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

        internal string archivo_txt="";
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

        private void pic_producto_Click(object sender, EventArgs e)
        {
            // StreamWriter Escribir = new StreamWriter(@"C:\Users\Public\Documents\" + archivo_txt, true);
            StreamWriter Escribir = new StreamWriter(@archivo_txt, true);
            try
            {
                Escribir.WriteLine(Descripcion_pr);
                Escribir.WriteLine(Precio_pr);
                Escribir.WriteLine(Codigo_pr);
                Escribir.WriteLine(Impresora);
                Escribir.WriteLine("\n");
                Escribir.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}
