using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmMDIPrincipal : Form
    {
        public frmMDIPrincipal()
        {
            InitializeComponent();
        }
        #region "Metodos del Menu"

        private void Menu_PtoVenta_Click(object sender, EventArgs e)
        {
            frmPunto_Venta frm = frmPunto_Venta.GetInstancia();
            frm.MdiParent = this;
            frm.Show();
        }
        private void Menu_Familia_Click(object sender, EventArgs e)
        {
            frmFamilias frm = frmFamilias.GetInstancia();
            frm.MdiParent = this;
            frm.Show();
        }
        private void Menu_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        private void Menu_Marcas_Click(object sender, EventArgs e)
        {
            frmMarcas frm = frmMarcas.GetInstancia();
            frm.MdiParent = this;
            frm.Show();
        }

        private void Menu_Unidades_Click(object sender, EventArgs e)
        {
            frmUnidades_Medida frm = frmUnidades_Medida.GetInstancia();
            frm.MdiParent = this;
            frm.Show();
        }

        private void Menu_Productos_Click(object sender, EventArgs e)
        {
            frmProductos frm = frmProductos.GetInstancia();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
