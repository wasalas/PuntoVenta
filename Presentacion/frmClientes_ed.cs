using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocio;

namespace Presentacion
{
    public partial class frmClientes_ed : Form
    {
        #region "Mis Variables"
        private int Estado_guarda;
        private EClientes oDatos;
        public bool GraboDatos = false;
        #endregion

        #region "Metodos del Form"
        public frmClientes_ed(int Opcion, EClientes Datos)
        {
            InitializeComponent();
            this.Estado_guarda = Opcion;
            this.oDatos = Datos;
        }
        private void frmClientes_ed_Load(object sender, EventArgs e)
        {
            this.cbo_tipdoc.DataSource =NTipo_Doc_Ide.Listado(1, "");
            this.cbo_tipdoc.ValueMember = "codigo_tdi";
            this.cbo_tipdoc.DisplayMember = "descripcion_tdi";
            this.cbo_tipdoc.SelectedIndex = -1;
            if (this.Estado_guarda == 1)
            {
                this.txt_codigo.Text = "0";                
                this.chk_estado.Checked = true;
                this.chk_estado.Enabled = false;
                this.Text = "Nuevo ";
            }
            else
            {
                this.txt_codigo.Text = oDatos.Codigo_cl.ToString();
                this.cbo_tipdoc.SelectedValue = oDatos.Codigo_tdi;
                this.txt_nrodoc.Text = oDatos.Nrodoc_cl;
                this.txt_nombres.Text = oDatos.Nombre_cl;
                this.txt_telefono.Text = oDatos.Telefono_cl;
                this.txt_celular.Text = oDatos.Celular_cl;
                this.txt_correo.Text = oDatos.Correo_cl;
                this.txt_direccion.Text = oDatos.Direccion_cl;
                this.chk_estado.Checked = oDatos.Estado == 1 ? true : false;
                this.Text = "Modificar ";
            }
            this.Text += "Cliente";
        }
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string Rpta = "";

            oDatos.Codigo_cl = Convert.ToInt32(this.txt_codigo.Text);
            oDatos.Codigo_tdi = Convert.ToInt32(this.cbo_tipdoc.SelectedValue ) ;
            oDatos.Nrodoc_cl = this.txt_nrodoc.Text.Trim().ToUpper();
            oDatos.Nombre_cl = this.txt_nombres.Text.Trim().ToUpper();
            oDatos.Telefono_cl = this.txt_telefono.Text.Trim().ToUpper();
            oDatos.Celular_cl = this.txt_celular.Text.Trim().ToUpper();
            oDatos.Correo_cl = this.txt_correo.Text.Trim().ToUpper();
            oDatos.Direccion_cl = this.txt_direccion.Text.Trim().ToUpper();
            oDatos.Estado = Convert.ToByte(this.chk_estado.Checked ? 1 : 0);

            if (oDatos.Nombre_cl== String.Empty)
            {
                this.txt_nombres.Focus();
                MessageBox.Show("Ingrese la Descripcion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (DialogResult.Yes == MessageBox.Show("¿Esta seguro de guardar los datos.", "Confirmacion.", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Rpta = NClientes.Guardar(this.Estado_guarda, this.oDatos);
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
        private void txt_descrip_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());
        }
        #endregion
    }
}
