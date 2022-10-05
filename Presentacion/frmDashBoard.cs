using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace Presentacion
{
    public partial class frmDashBoard : Form
    {
        // DragForm
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr Hwnd, int wMsg, int wParam, int lParam);

        #region "Mis Variables"
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form ActiveForm = null;
        #endregion

        #region "Metodos del Form"
        public frmDashBoard()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 46);            
            pnl_menu.Controls.Add(leftBorderBtn);

            this.Text = String.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            grb_fecha.Text = "";
        }
        private void frmDashBoard_Load(object sender, EventArgs e)
        {
            Ocultar_Paneles();
            Disable_Titulo();
        }
        #endregion

        #region "Controlers del Form"
        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            if (ActiveForm != null)
                ActiveForm.Close();

            Enable_Boton(sender, RGBColors.color4);
            Ocultar_Paneles();
            Disable_Titulo();
        }
        private void pnl_cabecera_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void btn_procesos_Click(object sender, EventArgs e)
        {            
            if (pnl_procesos.Visible)
            {
                Disable_Boton();
                Disable_Titulo();
                pnl_procesos.Visible = false;
            }
            else
            {
                Enable_Boton(sender, RGBColors.color1);
                Enable_Titulo(sender, RGBColors.color1);
                pnl_procesos.Visible = true;
            }

            pnl_reportes.Visible = false;
            pnl_datosmaestros.Visible = false;
        }
        private void btn_reportes_Click(object sender, EventArgs e)
        {
            pnl_procesos.Visible = false;
            if (pnl_reportes.Visible)
            {
                Disable_Boton();
                Disable_Titulo();
                pnl_reportes.Visible = false;
            }
            else
            {
                Enable_Boton(sender, RGBColors.color2);
                Enable_Titulo(sender, RGBColors.color2); 
                pnl_reportes.Visible = true;
            }
            pnl_datosmaestros.Visible = false;
        }
        private void btn_datosmaestros_Click(object sender, EventArgs e)
        {
            pnl_procesos.Visible = false;
            pnl_reportes.Visible = false;
            if (pnl_datosmaestros.Visible)
            {
                Disable_Boton();
                Disable_Titulo();
                pnl_datosmaestros.Visible = false;
            }
            else
            {
                Enable_Boton(sender, RGBColors.color3);
                Enable_Titulo(sender, RGBColors.color3);
                pnl_datosmaestros.Visible = true;
            }
        }
        private void btn_marcas_Click(object sender, EventArgs e)
        {
            Open_Form(new frmMarcas());
        }
        private void btn_productos_Click(object sender, EventArgs e)
        {
            Open_Form(new frmProductos());
        }
        private void btn_umedida_Click(object sender, EventArgs e)
        {
            Open_Form(new frmUnidades_Medida());
        }
        private void btn_ptoventaMesas_Click(object sender, EventArgs e)
        {
            Open_Form(new frmPunto_Venta());
        }
        private void btn_famSsubFam_Click(object sender, EventArgs e)
        {
            Open_Form(new frmFamilias());
        }
        private void btn_areaDespacho_Click(object sender, EventArgs e)
        {
            Open_Form(new frmArea_Despacho());
        }
        private void btn_cessarsesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_min_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void btn_max_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
            else
                WindowState = FormWindowState.Maximized;
        }
        private void btn_cer_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_hora.Text = DateTime.Now.ToLongTimeString();
            lbl_fecha.Text = DateTime.Now.ToLongDateString();
        }
        #endregion

        #region "Mis Metodos"
        private void Open_Form(Form oForm)
        {
            if (ActiveForm != null)            
                ActiveForm.Close();

            ActiveForm = oForm;
            oForm.TopLevel = false;
            oForm.FormBorderStyle = FormBorderStyle.None;
            oForm.Dock = DockStyle.Fill;
            pnl_cuerpo.Controls.Add(oForm);
            pnl_cuerpo.Tag = oForm;
            oForm.BringToFront();
            oForm.Show();
            
        }
        private void Ocultar_Paneles()
        {
            pnl_procesos.Visible = false;
            pnl_reportes.Visible = false;
            pnl_datosmaestros.Visible = false;
        }        
        private void Disable_Boton()
        {            
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(44, 105, 141);
                currentBtn.ForeColor = Color.White;                
                //currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                //currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                //currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void Enable_Boton(object senderBtn, Color color)
        {
            if(senderBtn != null)
            {
                Disable_Boton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37,36,81);
                currentBtn.ForeColor = color;
                //currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                //currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                //currentBtn.ImageAlign = ContentAlignment.MiddleCenter;
            }
        }
        private void Disable_Titulo()
        {
            ico_seleccion.IconChar = IconChar.Home;
            ico_seleccion.IconColor = Color.Black;
            lbl_seleccion.Text = "Home";
            lbl_seleccion.ForeColor = Color.Black;            
        }
        private void Enable_Titulo(object senderBtn, Color color)
        {
            currentBtn = (IconButton)senderBtn;

            ico_seleccion.Visible = true;
            lbl_seleccion.Visible = true;

            ico_seleccion.IconChar = currentBtn.IconChar;
            ico_seleccion.IconColor = currentBtn.IconColor;

            lbl_seleccion.Text = currentBtn.Text;
            lbl_seleccion.ForeColor = currentBtn.ForeColor;
        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172,126,241);
            public static Color color2 = Color.FromArgb(249,118,176);
            public static Color color3 = Color.FromArgb(253,138,114);
            public static Color color4 = Color.FromArgb(24,161,251);
        }
        #endregion

        private void btn_registrar_pedido_Click(object sender, EventArgs e)
        {
            Open_Form(new Procesos.frmRegistro_Pedidos());
        }
    }
}
