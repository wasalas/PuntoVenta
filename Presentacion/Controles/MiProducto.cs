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

namespace Presentacion.Controles
{
    public partial class MiProducto : UserControl
    {
        // ******************************************************************
        #region "Mis Variables"
        public int Codigo_pr { get; set; }

        public string Descripcion_pr
        {
            get { return lbl_descripcion_pr.Text; }
            set { lbl_descripcion_pr.Text = value; }
        }
        public string Precio_pr
        {
            get { return lbl_precio_pr.Text; }
            set { lbl_precio_pr.Text = value; }
        }
        public Image Imagen_pr
        {
            get { return pic_producto.Image; }
            set { pic_producto.Image = value; }
        }
        public string Impresora { get; set; }
        #endregion

        // ******************************************************************
        #region "Metodos del Form"
        public MiProducto()
        {
            InitializeComponent();
        }
        private void MiProducto_Load(object sender, EventArgs e)
        {

        }
        #endregion
        // ******************************************************************
        #region "Controles del Form"
        #endregion

        // ******************************************************************
        #region "Mis Metodos"
        #endregion

    }
}
