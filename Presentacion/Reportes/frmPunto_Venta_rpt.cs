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
    public partial class frmPunto_Venta_rpt : Form
    {
        public frmPunto_Venta_rpt()
        {
            InitializeComponent();
        }

        private void frmPunto_Venta_rpt_Load(object sender, EventArgs e)
        {
            bool miEstado = chk_estado.Checked;
            string miBusqueda = txt_texto.Text;

            this.spListado_Punto_VentaTableAdapter.Fill(this.dS_Reportes.spListado_Punto_Venta, estado: miEstado, texto: miBusqueda);
            this.reportViewer1.RefreshReport();
        }
    }
}
