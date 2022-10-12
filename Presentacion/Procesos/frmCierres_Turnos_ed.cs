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
    public partial class frmCierres_Turnos_ed : Form
    {
        ECierres_Turnos oDatos;
        public bool Grabo_Cambios;
        public frmCierres_Turnos_ed(ECierres_Turnos oDatos)
        {
            InitializeComponent();
            this.oDatos = oDatos;
        }
        private void frmCierres_Turnos_ed_Load(object sender, EventArgs e)
        {
            Carga_Turnos();
        }
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            this.Grabo_Cambios = false;
            DialogResult Confirma;
            Confirma = MessageBox.Show("Está seguro de Abrir un turno.", "Confinmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Confirma != DialogResult.Yes)
                return;
            oDatos.Fecha_ct = dtp_fecha.Value;
            oDatos.Codigo_tu = Convert.ToInt32(cbo_Turnos.SelectedValue);

            string Rpta;
            try
            {
                Rpta = NCierres_Turnos.Abrir(oDatos);
                if (Rpta == "OK")
                {
                    MessageBox.Show("Turno abierto satisfactoriamente.", "Informnación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Grabo_Cambios = true;
                }
                else
                    MessageBox.Show("No se pudo abrir el Turno." + "\n" + Rpta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            this.Close();
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Grabo_Cambios = false;
            this.Close();
        }
        private void Carga_Turnos()
        {
            this.cbo_Turnos.DataSource = NTurnos.Listado(1, "");
            this.cbo_Turnos.ValueMember = "codigo_tu";
            this.cbo_Turnos.DisplayMember = "descripcion_tu";
            this.cbo_Turnos.SelectedIndex = -1;
        }

    }
}
