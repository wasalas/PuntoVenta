using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Entidades;
using Negocio;
using System.Runtime.InteropServices;

namespace Presentacion
{
    public partial class frmProductos_ed : Form
    {
        #region "Mis Variables"
        private int Estado_guarda;
        private EProductos oDatos;
        public bool GraboDatos = false;
        private DataTable dtPV = new DataTable();
        #endregion

        #region "Metodos del Form"
        public frmProductos_ed(int Opcion, EProductos Datos)
        {
            InitializeComponent();
            this.Estado_guarda = Opcion;
            this.oDatos = Datos;
        }
        private void frmProductos_ed_Load(object sender, EventArgs e)
        {
            this.cbo_marcas.DataSource = NMarcas.Listado(1, "");
            this.cbo_marcas.ValueMember = "codigo_ma";
            this.cbo_marcas.DisplayMember = "descripcion_ma";
            this.cbo_marcas.SelectedIndex = -1;

            this.cbo_unidades.DataSource = NUnidades_Medida.Listado(1, "");
            this.cbo_unidades.ValueMember = "codigo_um";
            this.cbo_unidades.DisplayMember = "descripcion_um";
            this.cbo_unidades.SelectedIndex = -1;

            this.cbo_adespacho.DataSource = NArea_Despacho.Listado(1, "");
            this.cbo_adespacho.ValueMember = "codigo_ad";
            this.cbo_adespacho.DisplayMember = "descripcion_ad";
            this.cbo_adespacho.SelectedIndex = -1;

            if (this.Estado_guarda == 1)
            {
                Carga_Familias();
                Carga_Sub_Familias(0);

                this.txt_codigo.Text = "0";
                this.txt_descrip.Text = "";
                txt_precio.Text = "0.00";
                this.chk_estado.Checked = true;
                this.chk_estado.Enabled = false;
                this.Text = "Nuevo ";
            }
            else
            {
                Carga_Familias();
                Carga_Sub_Familias(oDatos.Codigo_fa);

                this.txt_codigo.Text = oDatos.Codigo_pr.ToString();
                this.txt_descrip.Text = oDatos.Descripcion_pr;
                this.cbo_marcas.SelectedValue = oDatos.Codigo_ma;
                this.cbo_unidades.SelectedValue = oDatos.Codigo_um;
                this.cbo_familias.SelectedValue = oDatos.Codigo_fa;
                this.cbo_sfamilias.SelectedValue = oDatos.Codigo_sf;
                this.cbo_adespacho.SelectedValue = oDatos.Codigo_ad;
                this.txt_precio.Text = Convert.ToString(oDatos.Precio_unitario);
                this.txt_obs.Text = oDatos.Observaciones;
                this.chk_estado.Checked = oDatos.Estado == 1 ? true : false;

                this.Text = "Modificar ";
            }
            this.Text += "Producto";
            Mostrar_Imagen(Estado_guarda, oDatos.Codigo_pr);
            Crear_PV();
            Mostrar_PV(this.Estado_guarda, oDatos.Codigo_pr);
        }
        private void cbo_familias_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int codigo_fa = 0;
            if (this.cbo_familias.Items.Count > 0)
                codigo_fa = Convert.ToInt32(this.cbo_familias.SelectedValue);

            Carga_Sub_Familias(codigo_fa);
            this.cbo_sfamilias.SelectedIndex = -1;
        }
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string Rpta = "";

            oDatos.Codigo_pr = Convert.ToInt32(this.txt_codigo.Text);
            oDatos.Descripcion_pr = Convert.ToString(this.txt_descrip.Text.Trim().ToUpper());
            oDatos.Codigo_ma = Convert.ToInt32(this.cbo_marcas.SelectedValue);
            oDatos.Codigo_um = Convert.ToInt32(this.cbo_unidades.SelectedValue);
            oDatos.Codigo_fa = Convert.ToInt32(this.cbo_familias.SelectedValue);
            oDatos.Codigo_sf = Convert.ToInt32(this.cbo_sfamilias.SelectedValue);
            oDatos.Codigo_ad = Convert.ToInt32(this.cbo_adespacho.SelectedValue);
            oDatos.Precio_unitario = Convert.ToDecimal(this.txt_precio.Text);
            oDatos.Observaciones = this.txt_obs.Text.Trim().ToUpper();
            oDatos.Estado = Convert.ToByte(this.chk_estado.Checked ? 1 : 0);

            MemoryStream ms = new MemoryStream();
            img_imagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            oDatos.Imagen = ms.GetBuffer();

            if (oDatos.Descripcion_pr == String.Empty)
            {
                this.txt_descrip.Focus();
                MessageBox.Show("Ingrese la Descripcion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (DialogResult.Yes == MessageBox.Show("¿Esta seguro de guardar los datos.", "Confirmacion.", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Rpta = NProductos.Guardar(this.Estado_guarda, this.oDatos, dtPV);
                if (Rpta == "OK")
                {
                    MessageBox.Show("Datos guardados correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.GraboDatos = true;
                    this.Close();
                }
                else
                    MessageBox.Show(Rpta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region "Mis Metodos"
        private void Carga_Familias()
        {
            this.cbo_familias.DataSource = NFamilias.Listado(1, "");
            this.cbo_familias.ValueMember = "codigo_fa";
            this.cbo_familias.DisplayMember = "descripcion_fa";
            this.cbo_familias.SelectedIndex = -1;
        }
        private void Carga_Sub_Familias(int codigo_fa)
        {
            this.cbo_sfamilias.DataSource = NSubFamilias.Listado(codigo_fa, 1, "");
            this.cbo_sfamilias.ValueMember = "codigo_sf";
            this.cbo_sfamilias.DisplayMember = "descripcion_sf";
            this.cbo_sfamilias.SelectedIndex = -1;
        }
        private void Key_Mayusculas(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());
        }
        private void Mostrar_Imagen(int estado_guarda, int codigo_pr)
        {
            byte[] bImagen = new byte[0];
            if (estado_guarda == 1)
                bImagen = NImagen_Predeterminada.Mostrar();
            else
                bImagen = NImagen_Productos.Mostrar(codigo_pr);

            MemoryStream ms = new MemoryStream(bImagen);
            img_imagen.Image = System.Drawing.Bitmap.FromStream(ms);
        }
        private void Crear_PV()
        {
            dtPV = new DataTable();
            dtPV.Columns.Add("Descripcion_pv", System.Type.GetType("System.String"));
            dtPV.Columns.Add("Ok", System.Type.GetType("System.Boolean"));
            dtPV.Columns.Add("Codigo_pv", System.Type.GetType("System.Int32"));

            dgPuntoVenta.DataSource = dtPV;
            Metodos.Formato_dgv(dgPuntoVenta, 10);

            dgPuntoVenta.Columns[0].HeaderText = "PUNTO DE VENTA";
            dgPuntoVenta.Columns[0].Width = 250;
            dgPuntoVenta.Columns[0].ReadOnly = true;
            ;
            dgPuntoVenta.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgPuntoVenta.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgPuntoVenta.Columns[1].HeaderText = "OK";
            dgPuntoVenta.Columns[1].Width = 70;
            dgPuntoVenta.Columns[1].ReadOnly = false;

            dgPuntoVenta.Columns[2].Visible = false;

        }
        private void Mostrar_PV(int opcion, int codigo_pr)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = NPunto_Ventas.OK(opcion, codigo_pr);
                dtPV.Clear();
                for (int iFila = 0; iFila <= dt.Rows.Count - 1; iFila++)
                {
                    string sNom = Convert.ToString(dt.Rows[iFila][0]);
                    bool bOk = Convert.ToBoolean(dt.Rows[iFila][1]);
                    int iCod = Convert.ToInt32(dt.Rows[iFila][2]);
                    Agragar_PV(sNom, bOk, iCod);
                }
                dgPuntoVenta.DataSource = dtPV;
                dgPuntoVenta.Columns["Ok"].ReadOnly = opcion >= 1 ? false : true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void Agragar_PV(string descripcion, bool ok, int codigo)
        {
            DataRow fila = dtPV.NewRow();
            fila["Descripcion_pv"] = descripcion;
            fila["Ok"] = ok;
            fila["Codigo_pv"] = codigo;
            dtPV.Rows.Add(fila);
        }
        private void btn_buscar_imagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog Foto = new OpenFileDialog();
            Foto.Filter = "Archivos de imagen (*.jpg, *.jpe, *.jpeg, *.jfif, *.png) | *.jpg;*.jpe;*.jpeg;*.jfif;*.png";
            if (Foto.ShowDialog() == DialogResult.OK)
                img_imagen.Image = Image.FromFile(Foto.FileName);
        }
        #endregion

        private void txt_precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.KeyChar = Validaciones.MakeNumeric(sender as TextBox,e as char );
        }

        private void txt_precio_Leave(object sender, EventArgs e)
        {
            // nada aun
        }
    }
}
