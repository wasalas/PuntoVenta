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
using Entidades;

namespace Presentacion.Procesos
{
    public partial class frmRegistro_Pedidos : Form
    {
        // *********************************************************************************
        #region "Mis Variables"
        public int Codigo_pv { get; set; }
        public int Codigo_me { get; set; }        
        public int Codigo_us { get; set; }
        public int Codigo_tu { get; set; }
        public int Codigo_es { get; set; }
        public string Descripcion_me { get; set; }
        public string Descripcion_pv { get; set; }
        public Image Estado { get; set; }

        #endregion
        // *********************************************************************************
        #region "Metodos del Form"
        public frmRegistro_Pedidos()
        {
            InitializeComponent();
        }
        private void frmRegistro_Pedidos_Load(object sender, EventArgs e)
        {
            Carga_Datos();
            this.timer1.Enabled = true;
        }
        #endregion

        // *********************************************************************************
        #region "Controles del Form"
        private void cbo_PuntoVenta_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Codigo_pv = 0;
            if (cbo_PuntoVenta.Items.Count > 0)
            {
                Codigo_pv = Convert.ToInt32(cbo_PuntoVenta.SelectedValue);
                Estado_FechaTurno_PV(Codigo_pv);
                Llenar_Punto_Venta(flowLayoutPanel1);
            }
        }
        private void cbo_PuntoVenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cbo_PuntoVenta.SelectedIndex != -1)
            //cbo_PuntoVenta_SelectionChangeCommitted(sender, e);
        }
        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Codigo_pv = 0;
            if (cbo_PuntoVenta.Items.Count > 0)
            {
                Codigo_pv = Convert.ToInt32(cbo_PuntoVenta.SelectedValue);
                Estado_FechaTurno_PV(Codigo_pv);
                Llenar_Punto_Venta(flowLayoutPanel1);
            }
        }
        #endregion

        // *********************************************************************************
        #region "Mis Metodos"
        private void Carga_Datos()
        {
            Codigo_us = 1;
            this.cbo_PuntoVenta.DataSource = NPunto_Ventas.Listado(1, "");
            this.cbo_PuntoVenta.ValueMember = "codigo_pv";
            this.cbo_PuntoVenta.DisplayMember = "descripcion_pv";
            this.cbo_PuntoVenta.SelectedIndex = -1;
        }
        private void Estado_FechaTurno_PV(int codigo_pv)
        {
            Codigo_tu = 0;
            Codigo_es = 0;
            DataTable dt = new DataTable();
            string sFecha, sturno, sEstado;

            dt = NCierres_Turnos.Estado_Turno_PV(codigo_pv);
            if (dt.Rows.Count != 0)
            {
                sFecha = Convert.ToString(dt.Rows[0][0]);
                sFecha = sFecha.Substring(0, sFecha.Length - 8);
                
                Codigo_tu = Convert.ToInt32(dt.Rows[0][1]);
                sturno = Convert.ToString(dt.Rows[0][2]);

                Codigo_es = Convert.ToInt32(dt.Rows[0][3]); 
                sEstado = Convert.ToString(dt.Rows[0][4]).Trim().ToUpper();
            }
            else
            {
                sFecha = "SIN FECHA";
                sturno = "SIN TURNO";
                sEstado = "SIN ESTADO";
            }
            txt_fecha.Text = sFecha;
            txt_turno.Text = sturno;
            txt_estado.Text = sEstado;
        }
        private void Llenar_Punto_Venta(FlowLayoutPanel contenedor)
        {
            if (Codigo_es == 1)
            {
                contenedor.Controls.Clear();
                byte[] bImagen1 = new byte[0];
                byte[] bImagen2 = new byte[0];
                bImagen1 = NImagen_Predeterminada.Imagen_Estado_Mesa(1);
                bImagen2 = NImagen_Predeterminada.Imagen_Estado_Mesa(2);
                MemoryStream ms1 = new MemoryStream(bImagen1);
                MemoryStream ms2 = new MemoryStream(bImagen2);

                DataTable dt = new DataTable();
                dt = NMesas.Listado(this.Codigo_pv, 1, "");
                for (int i = 0; i < dt.Rows.Count ; i++)
                {
                    // 0 = codigo_me, 1 = descripcion_me, 2 = codigo_pv, 3 = descripcion_pv, 4 = disponible, 5 = estado
                    Codigo_me = Convert.ToInt32(dt.Rows[i][0]);
                    Descripcion_me = Convert.ToString(dt.Rows[i][1]);
                    
                    if (Convert.ToInt32(dt.Rows[i][4]) == 1)        // disponible
                        Estado = Image.FromStream(ms1);
                    else
                        Estado = Image.FromStream(ms2);

                    // Codigo_pv = Convert.ToInt32(dt.Rows[i][2]);
                    Descripcion_pv = Convert.ToString(dt.Rows[i][3]);

                    Controles.MiMesa oMesa  = new Controles.MiMesa();
                    
                    oMesa.Codigo_me = this.Codigo_me;                    
                    oMesa.Codigo_pv = this.Codigo_pv;
                    oMesa.Codigo_tu = this.Codigo_tu;
                    oMesa.Codigo_us = this.Codigo_us;
                    oMesa.Disponible = this.Estado;
                    oMesa.Descripcion_me = this.Descripcion_me; 
                    oMesa.Descripcion_pv = this.Descripcion_pv;

                    contenedor.Controls.Add(oMesa);
                }
            }
            else
                contenedor.Controls.Clear();
        }
        #endregion
    }
}
