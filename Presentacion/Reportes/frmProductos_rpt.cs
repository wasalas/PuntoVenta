using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Reportes
{
    public partial class frmProductos_rpt : Form
    {
        public frmProductos_rpt()
        {
            InitializeComponent();
        }

        private void frmProductos_rpt_Load(object sender, EventArgs e)
        {
            bool miEstado = chk_estado.Checked;
            string miBusqueda = txt_texto.Text;

            this.spListado_ProductosTableAdapter.Fill(this.dS_Reportes.spListado_Productos, estado: miEstado, texto: miBusqueda);
            this.reportViewer1.RefreshReport();
        }
    }
}
