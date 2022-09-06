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
    public partial class frmMarcas_rpt : Form
    {
        public frmMarcas_rpt()
        {
            InitializeComponent();
        }

        private void frmMarcas_rpt_Load(object sender, EventArgs e)
        {
            bool miEstado = chk_estado.Checked;
            string miBusqueda = txt_texto.Text;

            this.spListado_MarcasTableAdapter.Fill(this.dS_Reportes.spListado_Marcas, estado: miEstado, texto: miBusqueda);
            this.reportViewer1.RefreshReport();
        }
    }
}
