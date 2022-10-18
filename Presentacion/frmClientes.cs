using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Entidades;

namespace Presentacion
{
    public partial class frmClientes : Form
    {
        #region "Mis Variables"
        private static frmClientes _instancia;
        private EClientes oDatos = new EClientes();
        private int Cantidad_registros = 0;
        private int Estado_guarda;
        bool estado;
        string texto_buscar;
        #endregion

        #region "Metodos del Form"
        public frmClientes()
        {
            InitializeComponent();
        }
        private void frmClientes_Load(object sender, EventArgs e)
        {
            CargaDatos();
        }
        private void frmClientes_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instancia = null;
        }
        private void txt_buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());
        }
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            CargaDatos();
        }
        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            this.txt_buscar.Text = "";
            CargaDatos();
        }
        private void dgDatos_DoubleClick(object sender, EventArgs e)
        {
            btn_modificar_Click(sender, e);
        }
        private void btn_modificar_Click(object sender, EventArgs e)
        {
            ObtenerDatosForm();
            if (this.Cantidad_registros == 0)
            {
                MessageBox.Show("Seleccione un item a modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.Estado_guarda = 2;
            Editar();
        }
        private void chkEsatdo_CheckedChanged(object sender, EventArgs e)
        {
            CargaDatos();
        }
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            this.Estado_guarda = 1;
            Editar();
        }
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            ObtenerDatosForm();
            if (this.Cantidad_registros == 0)
            {
                MessageBox.Show("Seleccione un item a desactivar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (oDatos.Estado != 1)
            {
                MessageBox.Show("Registro ya desactivado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Eliminar();
        }
        private void btn_reporte_Click(object sender, EventArgs e)
        {
            ObtenerDatosForm();
            if (this.Cantidad_registros == 0)
            {
                MessageBox.Show("No existen datos para el reporte.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            /*
            Reportes.frmClientes_rpt frm = new Reportes.frmClientes_rpt();
            frm.chk_estado.Checked = this.estado;
            frm.txt_texto.Text = this.texto_buscar;
            frm.ShowDialog();   */
        }
        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region "Mis Metodos"
        private void CargaDatos()
        {
            ObtenerDatosForm();

            byte p_estado = Convert.ToByte(estado ? 1 : 0);
            this.Cantidad_registros = 0;

            try
            {
                dgDatos.DataSource = NClientes.Listado(p_estado, this.texto_buscar);
                this.Cantidad_registros = dgDatos.Rows.Count;
                FormatoGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace, "Error del S istema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ts_estado.Items[0].Text = "Estado : " + (estado ? "Activos" : "Inactivos");
            ts_estado.Items[1].Text = "   ";
            ts_estado.Items[2].Text = "Total registros : " + this.Cantidad_registros;
        }
        private void Editar()
        {

            frmClientes_ed frm = new frmClientes_ed(this.Estado_guarda, oDatos);
            frm.ShowDialog();

            if (frm.GraboDatos == true)
            {
                CargaDatos();
                BuscarEnGrid(oDatos.Codigo_cl);
            }

        }
        private void Eliminar()
        {
            ObtenerDatosForm();

            string mensaje = "¿Está seguro de desactivar.? \n" + this.oDatos.Nombre_cl;
            DialogResult Rpta = MessageBox.Show(mensaje, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Rpta != DialogResult.Yes)
                return;

            string msg_elimino;
            msg_elimino = NClientes.Eliminar(oDatos.Codigo_cl);
            if (msg_elimino == "OK")
            {
                MessageBox.Show("Se desactivó satisfactoriamente el registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargaDatos();
            }
            else
                MessageBox.Show(msg_elimino, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void ObtenerDatosForm()
        {
            dgDatos.Focus();

            this.Cantidad_registros = dgDatos.Rows.Count;

            estado = this.chkEsatdo.Checked;
            texto_buscar = this.txt_buscar.Text.ToUpper().Trim();

            if (this.Cantidad_registros == 0)
            {
                oDatos.Codigo_cl = 0;
                oDatos.Codigo_tdi = 0;
                oDatos.Nrodoc_cl = "";
                oDatos.Nombre_cl = "";
                oDatos.Telefono_cl = "";
                oDatos.Celular_cl = "";
                oDatos.Correo_cl = "";
                oDatos.Direccion_cl = "";
                oDatos.Estado = 0;
            }
            else
            {
                oDatos.Codigo_cl = Convert.ToInt32(dgDatos.CurrentRow.Cells["codigo_cl"].Value);
                oDatos.Codigo_tdi = Convert.ToInt32(dgDatos.CurrentRow.Cells["codigo_tdi"].Value);
                oDatos.Nrodoc_cl = Convert.ToString(dgDatos.CurrentRow.Cells["nrodoc_cl"].Value);
                oDatos.Nombre_cl = Convert.ToString(dgDatos.CurrentRow.Cells["nombre_cl"].Value);
                oDatos.Telefono_cl = Convert.ToString(dgDatos.CurrentRow.Cells["telefono_cl"].Value);
                oDatos.Celular_cl = Convert.ToString(dgDatos.CurrentRow.Cells["celular_cl"].Value);
                oDatos.Correo_cl = Convert.ToString(dgDatos.CurrentRow.Cells["correo_cl"].Value);
                oDatos.Direccion_cl = Convert.ToString(dgDatos.CurrentRow.Cells["direccion_cl"].Value);
                oDatos.Estado = Convert.ToByte(dgDatos.CurrentRow.Cells["estado"].Value);
            }
        }
        private void FormatoGrid()
        {
            dgDatos.Columns[0].HeaderText = "CODIGO";
            dgDatos.Columns[0].Width = 80;
            dgDatos.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgDatos.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgDatos.Columns[1].HeaderText = "TIPO DOC";
            dgDatos.Columns[1].Width = 100;

            dgDatos.Columns[2].HeaderText = "NRO DOC";
            dgDatos.Columns[2].Width = 120;

            dgDatos.Columns[3].HeaderText = "NOMBRES";
            dgDatos.Columns[3].Width = 200;

            dgDatos.Columns[4].HeaderText = "TELEFONO";
            dgDatos.Columns[4].Width = 0;
            dgDatos.Columns[4].Visible = false;

            dgDatos.Columns[5].HeaderText = "CELULAR";
            dgDatos.Columns[5].Width = 120;

            dgDatos.Columns[6].HeaderText = "CORREO";
            dgDatos.Columns[6].Width = 0;
            dgDatos.Columns[6].Visible = false;

            dgDatos.Columns[7].HeaderText = "DIRECCION";
            dgDatos.Columns[7].Width = 300;

            dgDatos.Columns[8].HeaderText = "TIP DOC ID";
            dgDatos.Columns[8].Width = 0;
            dgDatos.Columns[8].Visible = false;

            dgDatos.Columns[9].HeaderText = "ESTADO";
            dgDatos.Columns[9].Width = 0;
            dgDatos.Columns[9].Visible = false;

            Metodos.Formato_dgv(dgDatos, 10);
        }
        private void BuscarEnGrid(int codigo_buscar)
        {
            // Modificar: se posiciona en la fila modificada
            // Nuevo    : <<...No implementado...>>

            int fil = 0;    // Row
            int col = 0;
            for (fil = 0; fil < dgDatos.RowCount; fil++)
            {
                if (Convert.ToInt32(dgDatos[col, fil].Value) == codigo_buscar)
                {
                    dgDatos.CurrentCell = dgDatos[col, fil];  //dgDatos.Rows[fil].Cells[0];
                    return;
                }
            }
        }
        public static frmClientes GetInstancia()
        {
            if (_instancia == null)
                _instancia = new frmClientes();
            else
                _instancia.Activate();

            return _instancia;
        }
        #endregion

    }
}
