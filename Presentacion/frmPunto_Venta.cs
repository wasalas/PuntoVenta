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
    public partial class frmPunto_Venta : Form
    {
        #region "Mis Variables"
        private static frmPunto_Venta _instancia;
        private EPunto_Venta oDatos = new EPunto_Venta();
        private int Cantidad_registros = 0;
        private int Estado_guarda;
        bool estado;
        string texto_buscar;
        #endregion

        #region "Metodos del Form"
        public frmPunto_Venta()
        {
            InitializeComponent();
        }
        private void frmPunto_Venta_Load(object sender, EventArgs e)
        {
            CargaDatos();
        }
        private void frmPunto_Venta_FormClosed(object sender, FormClosedEventArgs e)
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
            btn_mesas_Click(sender, e);
        }        
        private void btn_mesas_Click(object sender, EventArgs e)
        {
            ObtenerDatosForm();
            if (this.Cantidad_registros == 0)
            {
                MessageBox.Show("Seleccione un item para ver su detalle.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            frmMesas frm = frmMesas.GetInstancia();
            //frm.MdiParent = this;
            frm.txt_codigo_pv.Text = Convert.ToString(oDatos.Codigo_pv);
            frm.txt_descripcion_pv.Text = oDatos.Descripcion_pv;
            frm.ShowDialog();
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
            
            Reportes.frmPunto_Venta_rpt frm = new Reportes.frmPunto_Venta_rpt();
            frm.chk_estado.Checked = this.estado;
            frm.txt_texto.Text = this.texto_buscar;
            frm.ShowDialog();
            
        }
        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
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
                dgDatos.DataSource = NPunto_Ventas.Listado(p_estado, this.texto_buscar);
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

            frmPunto_Venta_ed frm = new frmPunto_Venta_ed(this.Estado_guarda, oDatos);
            frm.ShowDialog();

            if (frm.GraboDatos == true)
            {
                CargaDatos();
                BuscarEnGrid(oDatos.Codigo_pv);
            }

        }
        private void Eliminar()
        {
            ObtenerDatosForm();

            string mensaje = "¿Está seguro de desactivar.? \n" + this.oDatos.Descripcion_pv;
            DialogResult Rpta = MessageBox.Show(mensaje, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Rpta != DialogResult.Yes)
                return;

            string msg_elimino;
            msg_elimino = NPunto_Ventas.Eliminar(oDatos.Codigo_pv);
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
                oDatos.Codigo_pv = 0;
                oDatos.Descripcion_pv = "";
                oDatos.Estado = 0;
            }
            else
            {
                oDatos.Codigo_pv = Convert.ToInt32(dgDatos.CurrentRow.Cells["codigo_pv"].Value);
                oDatos.Descripcion_pv = Convert.ToString(dgDatos.CurrentRow.Cells["descripcion_pv"].Value);
                oDatos.Estado = Convert.ToByte(dgDatos.CurrentRow.Cells["estado"].Value);
            }
        }
        private void FormatoGrid()
        {
            dgDatos.Columns[0].HeaderText = "CODIGO";
            dgDatos.Columns[0].Width = 100;
            dgDatos.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgDatos.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgDatos.Columns[1].HeaderText = "DESCRIPCION";
            dgDatos.Columns[1].Width = 500;

            dgDatos.Columns[2].Visible = false;

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
        public static frmPunto_Venta GetInstancia()
        {
            if (_instancia == null)
                _instancia = new frmPunto_Venta();
            else
                _instancia.Activate();

            return _instancia;
        }
        #endregion

    }
}
