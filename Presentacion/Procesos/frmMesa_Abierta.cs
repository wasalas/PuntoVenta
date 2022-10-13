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
using Negocio;

namespace Presentacion.Procesos
{
    public partial class frmMesa_Abierta : Form
    {
        // *********************************************************************************
        #region "Mis Variables"
        internal int codigo_pv;     // se llena desde UserObject MiMesa
        private int codigo_sf;

        #endregion

        // *********************************************************************************
        #region "Metodos del Form"
        public frmMesa_Abierta()
        {
            InitializeComponent();
        }
        private void frmMesa_Abierta_Load(object sender, EventArgs e)
        {
            Carga_Datos();
        }
        #endregion

        // *********************************************************************************
        #region "Controles del Form"
        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        // *********************************************************************************
        #region "Mis Metodos"
        private void Carga_Datos()
        {
            Carga_SubFamilias();
        }
        private void Carga_SubFamilias()
        {
            dg_subfamilias.DataSource = NMesa_Abierta.Listado_SubFamilias_RP(this.codigo_pv);

            dg_subfamilias.Columns[0].HeaderText = "SUB FAMILIA";
            dg_subfamilias.Columns[0].Width = 220;

            dg_subfamilias.Columns[1].Visible = false;

            Metodos.Formato_dgv(dg_subfamilias, 10);
        }
        private void Carga_Productos(FlowLayoutPanel Contenedor)
        {
            DataTable dt_Productos = new DataTable();
            int codigo;
            string descripcion, precio, impresora;
            byte[] bImagen = new byte[0];
            Image iImagen;

            Contenedor.Controls.Clear();
            if (dg_subfamilias.Rows.Count == 0)
                return;

            this.codigo_sf = Convert.ToInt32(dg_subfamilias.CurrentRow.Cells["codigo_sf"].Value);

            dt_Productos = NMesa_Abierta.Listado_Productos_SubFamilia_RP(this.codigo_pv, this.codigo_sf);
            int nFilas = dt_Productos.Rows.Count;
            if (dt_Productos.Rows.Count == 0)
                return;
            for (int i = 0; i <= nFilas-1; i++)
            {
                codigo = Convert.ToInt32(dt_Productos.Rows[i][0]);
                descripcion = Convert.ToString(dt_Productos.Rows[i][1]);
                precio = Convert.ToString(dt_Productos.Rows[i][2]);

                bImagen = (byte[])dt_Productos.Rows[i][3];
                MemoryStream ms = new MemoryStream(bImagen);
                iImagen = Image.FromStream(ms);

                impresora = Convert.ToString(dt_Productos.Rows[i][4]);

                Controles.MiProducto oProducto = new Controles.MiProducto();

                oProducto.Codigo_pr = codigo;
                oProducto.Descripcion_pr = descripcion;
                oProducto.Precio_pr = precio;
                oProducto.Imagen_pr = iImagen;
                oProducto.Impresora = impresora;
                Contenedor.Controls.Add(oProducto);
            }
        }
        #endregion

        private void dg_subfamilias_CurrentCellChanged(object sender, EventArgs e)
        {
            //Carga_Productos(flp_listado_productos);
        }

        private void dg_subfamilias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Carga_Productos(flp_listado_productos);
        }

        private void dg_subfamilias_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            //Carga_Productos(flp_listado_productos);
        }

        private void dg_subfamilias_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //Carga_Productos(flp_listado_productos);
        }
    }
}
