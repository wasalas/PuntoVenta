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
    public partial class frmProductos_buscar : Form
    {
        #region "Mis Variables"
        internal EProductos oDatos = new EProductos();
        internal bool GraboDatos = false;
        private int Cantidad_registros = 0;
        bool estado;
        string texto_buscar;
        #endregion

        #region "Metodos del Form"
        public frmProductos_buscar()
        {
            InitializeComponent();
        }
        private void frmProductos_buscar_Load(object sender, EventArgs e)
        {
            CargaDatos();
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
            btn_aceptar_Click(sender, e);
        }
        private void chkEsatdo_CheckedChanged(object sender, EventArgs e)
        {
            CargaDatos();
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
                dgDatos.DataSource = NProductos.Listado(p_estado, this.texto_buscar);
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


        private void ObtenerDatosForm()
        {
            dgDatos.Focus();

            this.Cantidad_registros = dgDatos.Rows.Count;

            estado = this.chkEsatdo.Checked;
            texto_buscar = this.txt_buscar.Text.ToUpper().Trim();
            if (this.Cantidad_registros == 0)
            {
                oDatos.Codigo_pr = 0;
                oDatos.Descripcion_pr = "";
                oDatos.Codigo_ma = 0;
                oDatos.Codigo_um = 0;
                oDatos.Codigo_fa = 0;
                oDatos.Codigo_sf = 0;
                oDatos.Precio_unitario = (decimal)0.0;
                oDatos.Codigo_ad = 0;
                oDatos.Observaciones = "";
                oDatos.Estado = 0;
                oDatos.Impresora = "";
            }
            else
            {
                oDatos.Codigo_pr = Convert.ToInt32(dgDatos.CurrentRow.Cells["codigo_pr"].Value);
                oDatos.Descripcion_pr = Convert.ToString(dgDatos.CurrentRow.Cells["descripcion_pr"].Value);
                oDatos.Codigo_ma = Convert.ToInt32(dgDatos.CurrentRow.Cells["codigo_ma"].Value);
                oDatos.Codigo_um = Convert.ToInt32(dgDatos.CurrentRow.Cells["codigo_um"].Value);
                oDatos.Codigo_fa = Convert.ToInt32(dgDatos.CurrentRow.Cells["codigo_fa"].Value);
                oDatos.Codigo_sf = Convert.ToInt32(dgDatos.CurrentRow.Cells["codigo_sf"].Value);
                oDatos.Precio_unitario = Convert.ToDecimal(dgDatos.CurrentRow.Cells["precio_unitario"].Value);
                oDatos.Codigo_ad = Convert.ToInt32(dgDatos.CurrentRow.Cells["codigo_ad"].Value);
                oDatos.Observaciones = Convert.ToString(dgDatos.CurrentRow.Cells["observaciones"].Value);
                oDatos.Estado = Convert.ToByte(dgDatos.CurrentRow.Cells["estado"].Value);
                oDatos.Impresora= Convert.ToString(dgDatos.CurrentRow.Cells["Impresora"].Value);
            }
        }
        private void FormatoGrid()
        {
            dgDatos.Columns[0].HeaderText = "CODIGO";
            dgDatos.Columns[0].Width = 70;
            dgDatos.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgDatos.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgDatos.Columns[1].HeaderText = "DESCRIPCION";
            dgDatos.Columns[1].Width = 250;

            dgDatos.Columns[2].HeaderText = "MARCA";
            dgDatos.Columns[2].Width = 150;

            dgDatos.Columns[3].HeaderText = "UNIDAD";
            dgDatos.Columns[3].Width = 90;

            dgDatos.Columns[4].HeaderText = "FAMILIA";
            dgDatos.Columns[4].Width = 120;

            dgDatos.Columns[5].HeaderText = "SUB-FAMILIA";
            dgDatos.Columns[5].Width = 120;

            dgDatos.Columns[6].HeaderText = "DESPACHO";
            dgDatos.Columns[6].Width = 120;

            dgDatos.Columns[7].HeaderText = "PRECIO";
            dgDatos.Columns[7].Width = 90;

            dgDatos.Columns[8].Visible = false;
            dgDatos.Columns[9].Visible = false;
            dgDatos.Columns[10].Visible = false;
            dgDatos.Columns[11].Visible = false;
            dgDatos.Columns[12].Visible = false;
            dgDatos.Columns[13].Visible = false;
            dgDatos.Columns[14].Visible = false;
            dgDatos.Columns[15].Visible = false;
            dgDatos.Columns[16].Visible = false;
            dgDatos.Columns[17].Visible = false;

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

        #endregion

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (dgDatos.SelectedRows.Count > 0)
            {
                this.GraboDatos = true;
                ObtenerDatosForm();
                this.Close();
            }            
        }
    }
}
