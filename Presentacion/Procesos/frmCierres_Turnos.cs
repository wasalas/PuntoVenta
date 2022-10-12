using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocio;

namespace Presentacion.Procesos
{
    public partial class frmCierres_Turnos : Form
    {
        //***********************************************************************************
        #region "Mis Variables"
        private ECierres_Turnos oDatos = new ECierres_Turnos();
        DataTable dt_Cierres_Turnos = new DataTable();
        DataTable dt_Punto_Venta = new DataTable();
        private string sDescripcion_pv;
        #endregion

        //***********************************************************************************
        #region "Metos del Formr"
        public frmCierres_Turnos()
        {
            InitializeComponent();
        }
        private void frmCierres_Turnos_Load(object sender, EventArgs e)
        {
            Carga_Puntos_Venta();
        }
        #endregion

        //***********************************************************************************
        #region "Controles del Form"
        private void cbo_PuntoVenta_SelectionChangeCommitted(object sender, EventArgs e)
        {            
            int codigo_pv;
            string sFecha = "", sDes_turno = "", sDes_estado = "";
            bool bEnable;
            sDescripcion_pv = "";

            btn_abrir.Enabled = false;
            btn_cerrar.Enabled = false;
            oDatos.Estado_tu = 0;

            if (cbo_PuntoVenta.SelectedIndex != -1)
            {
                codigo_pv = Convert.ToInt32(cbo_PuntoVenta.SelectedValue);
                oDatos.Codigo_pv = Convert.ToInt32(dt_Punto_Venta.Rows[cbo_PuntoVenta.SelectedIndex][0]);
                sDescripcion_pv = Convert.ToString(dt_Punto_Venta.Rows[cbo_PuntoVenta.SelectedIndex][1]);

                dt_Cierres_Turnos = NCierres_Turnos.Estado_Turno_PV(codigo_pv);
                if (dt_Cierres_Turnos.Rows.Count > 0)
                {
                    oDatos.Fecha_ct = Convert.ToDateTime(dt_Cierres_Turnos.Rows[0][0]);
                    oDatos.Codigo_tu = Convert.ToInt32(dt_Cierres_Turnos.Rows[0][1]);
                    sDes_turno = Convert.ToString(dt_Cierres_Turnos.Rows[0][2]);
                    oDatos.Estado_tu = Convert.ToByte(dt_Cierres_Turnos.Rows[0][3]);
                    sDes_estado = Convert.ToString(dt_Cierres_Turnos.Rows[0][4]);
                
                    sFecha = Convert.ToString(oDatos.Fecha_ct);
                    sFecha = sFecha.Substring(0, sFecha.Length - 8);

                    if (string.IsNullOrEmpty(sFecha))
                        sFecha = DateTime.Now.ToString("dd-MM-yyy");
                }
            }
            bEnable = oDatos.Estado_tu == 1 ? true : false;
            btn_abrir.Enabled = !bEnable;
            btn_cerrar.Enabled = bEnable;

            txt_fecha.Text = sFecha;
            txt_turno.Text = sDes_turno;
            txt_estado.Text = sDes_estado;
        }
        private void btn_abrir_Click(object sender, EventArgs e)
        {
            Procesos.frmCierres_Turnos_ed frm = new frmCierres_Turnos_ed(oDatos);
            frm.txt_punto_venta.Text = sDescripcion_pv;
            frm.ShowDialog();
            if (frm.Grabo_Cambios)
            {
                cbo_PuntoVenta_SelectionChangeCommitted(sender, e);
            }
        }
        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cerrando turno...");
        }
        #endregion

        //***********************************************************************************
        #region "Mis Metodos"
        private void Carga_Puntos_Venta()
        {
            dt_Punto_Venta = NPunto_Ventas.Listado(1, "");
            this.cbo_PuntoVenta.DataSource = dt_Punto_Venta;
            this.cbo_PuntoVenta.ValueMember = "codigo_pv";
            this.cbo_PuntoVenta.DisplayMember = "descripcion_pv";
            this.cbo_PuntoVenta.SelectedIndex = -1;
        }
        #endregion

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
