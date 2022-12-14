using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace Presentacion.Controles
{
    public partial class MiMesa : UserControl
    {
        //****************************************************************
        #region "Mis Variables y Propiedades"

        public int Codigo_me { get; set; }
        public int Codigo_pv { get; set; }
        public int Codigo_us { get; set; }
        public int Codigo_tu { get; set; }
        public string Descripcion_me
        {
            get { return lbl_descripcion_me.Text; }
            set { lbl_descripcion_me.Text = value; }
        }
        public string Descripcion_pv { get; set; }
        public Image Disponible
        {
            get { return pic_estado.Image; }
            set { pic_estado.Image = value; }
        }
        public string Fecha_trabajo { get; set; }
        #endregion

        //****************************************************************
        #region "Metodos del Control"
        public MiMesa()
        {
            InitializeComponent();
        }

        private void MiMesa_Load(object sender, EventArgs e)
        {
            //
        }

        #endregion


        //****************************************************************
        #region "Mis Metodos"

        #endregion

        private void pic_ImagenMesa_Click(object sender, EventArgs e)
        {
            Procesos.frmMesa_Abierta frm = new Procesos.frmMesa_Abierta();
            
            frm.txt_mesa_seleccionada.Text = this.Descripcion_me;
            frm.txt_punto_venta.Text = this.Descripcion_pv;
            frm.codigo_pv = this.Codigo_pv;
            frm.codigo_me = this.Codigo_me;
            frm.codigo_tu = this.Codigo_tu;
            frm.fecha_trabajo = this.Fecha_trabajo;
            frm.Archivo_txt = @"C:\Users\Public\Documents\" + Convert.ToString(DateTime.Now.Ticks) + ".txt";

            frm.ShowDialog();
        }
    }
}
