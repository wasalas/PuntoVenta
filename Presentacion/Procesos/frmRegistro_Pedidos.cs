using Negocio;
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

namespace Presentacion.Procesos
{
    public partial class frmRegistro_Pedidos : Form
    {
        // *********************************************************************************
        #region "Mis Variables"

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
            this.cbo_PuntoVenta.DataSource = NPunto_Ventas.Listado(1, "");
            this.cbo_PuntoVenta.ValueMember = "codigo_pv";
            this.cbo_PuntoVenta.DisplayMember = "descripcion_pv";
            this.cbo_PuntoVenta.SelectedIndex = -1;
        }
        #endregion

        private void cbo_PuntoVenta_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int codigo_pv = 0;            
            if (cbo_PuntoVenta.Items.Count > 0)
            {
                codigo_pv = Convert.ToInt32(cbo_PuntoVenta.SelectedValue);
                Estado_FechaTurno_PV(codigo_pv);                
            }            
        }
        private void Estado_FechaTurno_PV(int codigo_pv)
        {
            DataTable dt = new DataTable();
            string sFecha, sturno, sEstado;

            dt = NCierres_Turnos.Estado_Turno_PV(codigo_pv);
            if (dt.Rows.Count != 0)
            {
                sFecha = Convert.ToString(dt.Rows[0][0]);
                sturno = Convert.ToString(dt.Rows[0][2]);
                sEstado = Convert.ToString(dt.Rows[0][4]).ToUpper();
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
    }
}
