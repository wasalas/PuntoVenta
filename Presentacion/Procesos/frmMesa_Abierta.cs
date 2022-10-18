using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using Negocio;
using Entidades;

namespace Presentacion.Procesos
{
    public partial class frmMesa_Abierta : Form
    {
        // *********************************************************************************
        #region "Mis Variables"
        private DataTable dt_DetalleProd;
        private int nLenMaxCant = 4;
        internal string Archivo_txt;

        internal int codigo_pv;     // se llena desde UserObject MiMesa
        internal int codigo_me;
        internal int codigo_tu;
        internal string fecha_trabajo;
        private int codigo_sf;
        private int codigo_cl = 0;

        // generacion de COMANDA
        string sImpresora = "";
        int nCodigo_ti = 0;
        string sDescripcion_pv = "";
        DateTime dFecha_trabajo;
        string sDescripcion_tu = "";
        string sNombre_us = "";
        string sDescripcion_ca = "";
        string sDescripcion_me = "";
        string sNombre_cl = "";
        string sNrodoc_cl = "";
        #endregion

        // *********************************************************************************
        #region "Metodos del Form"
        public frmMesa_Abierta()
        {
            InitializeComponent();
        }
        private void frmMesa_Abierta_Load(object sender, EventArgs e)
        {
            Carga_Datos();
        }
        #endregion

        // *********************************************************************************
        #region "Controles del Form"
        private void btn_1_Click(object sender, EventArgs e)
        {
            if (lbl_cantidad.Text.Trim().Length <= nLenMaxCant - 1)
                lbl_cantidad.Text = lbl_cantidad.Text.Trim() + "1";
        }
        private void btn_2_Click(object sender, EventArgs e)
        {
            if (lbl_cantidad.Text.Trim().Length <= nLenMaxCant - 1)
                lbl_cantidad.Text = lbl_cantidad.Text.Trim() + "2";
        }
        private void btn_3_Click(object sender, EventArgs e)
        {
            if (lbl_cantidad.Text.Trim().Length <= nLenMaxCant - 1)
                lbl_cantidad.Text = lbl_cantidad.Text.Trim() + "3";
        }
        private void btn_4_Click(object sender, EventArgs e)
        {
            if (lbl_cantidad.Text.Trim().Length <= nLenMaxCant - 1)
                lbl_cantidad.Text = lbl_cantidad.Text.Trim() + "4";
        }
        private void btn_5_Click(object sender, EventArgs e)
        {
            if (lbl_cantidad.Text.Trim().Length <= nLenMaxCant - 1)
                lbl_cantidad.Text = lbl_cantidad.Text.Trim() + "5";
        }
        private void btn_6_Click(object sender, EventArgs e)
        {
            if (lbl_cantidad.Text.Trim().Length <= nLenMaxCant - 1)
                lbl_cantidad.Text = lbl_cantidad.Text.Trim() + "6";
        }
        private void btn_7_Click(object sender, EventArgs e)
        {
            if (lbl_cantidad.Text.Trim().Length <= nLenMaxCant - 1)
                lbl_cantidad.Text = lbl_cantidad.Text.Trim() + "7";
        }
        private void btn_8_Click(object sender, EventArgs e)
        {
            if (lbl_cantidad.Text.Trim().Length <= nLenMaxCant - 1)
                lbl_cantidad.Text = lbl_cantidad.Text.Trim() + "8";
        }
        private void btn_9_Click(object sender, EventArgs e)
        {
            if (lbl_cantidad.Text.Trim().Length <= nLenMaxCant - 1)
                lbl_cantidad.Text = lbl_cantidad.Text.Trim() + "9";
        }
        private void btn_0_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lbl_cantidad.Text))
            {
                if (lbl_cantidad.Text.Trim().Length <= nLenMaxCant - 1)
                    lbl_cantidad.Text = lbl_cantidad.Text.Trim() + "0";
            }
        }
        private void btn_c_Click(object sender, EventArgs e)
        {
            lbl_cantidad.Text = "";
        }
        private void dg_subfamilias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Carga_Productos(flp_listado_productos);
        }
        private void btn_nuevo_pedido_Click(object sender, EventArgs e)
        {
            this.tab_pedidos.Controls["pag_nuevo"].Enabled = true;
            this.tab_pedidos.Controls["pag_ver"].Enabled = false;
            this.tab_pedidos.SelectedIndex = 0;
            timer1.Enabled = true; 
        }
        private void btn_ver_pedido_Click(object sender, EventArgs e)
        {
            Mostrar_Tickets();
            this.tab_pedidos.Controls["pag_nuevo"].Enabled = false;
            this.tab_pedidos.Controls["pag_ver"].Enabled = true;
            this.tab_pedidos.SelectedIndex = 1;
        }
        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (File.Exists(Archivo_txt))
            {
                DataRow Fila = dt_DetalleProd.NewRow();
                StreamReader Leer = new StreamReader(@Archivo_txt);

                Fila["Descripcion_pr"] = Leer.ReadLine();
                Fila["Precio"] = Leer.ReadLine();
                Fila["Codigo_pr"] = Convert.ToInt32(Leer.ReadLine());
                Fila["Impresora"] = Leer.ReadLine();

                Fila["Cantidad"] = "1";
                Fila["Total"] = Fila["Precio"];
                Fila["Obs"] = "";

                Leer.Close();
                File.Delete(Archivo_txt);
                dt_DetalleProd.Rows.Add(Fila);
                dt_DetalleProd.AcceptChanges();

                Calcula_TImporte_otal();
            }
        }
        private void btn_actualizar_cantidad_Click(object sender, EventArgs e)
        {
            if (dg_DetalleProd.SelectedRows.Count > 0 && lbl_cantidad.Text.Length > 0)
            {
                DataGridViewRow nFila = dg_DetalleProd.CurrentRow;
                if (nFila == null)
                    return;

                decimal nPrecio = Convert.ToDecimal(nFila.Cells["Precio"].Value);
                decimal nCantidad = Convert.ToDecimal(lbl_cantidad.Text);

                nFila.Cells["Cantidad"].Value = Convert.ToString(nCantidad);
                nFila.Cells["Total"].Value = Convert.ToString(nPrecio * nCantidad);

                dt_DetalleProd.AcceptChanges();
                Calcula_TImporte_otal();
                lbl_cantidad.Text = "";
            }
        }
        private void btn_quitar_producto_Click(object sender, EventArgs e)
        {
            if (dg_DetalleProd.SelectedRows.Count > 0)
            {
                dg_DetalleProd.Rows.Remove(dg_DetalleProd.CurrentRow);
                dt_DetalleProd.AcceptChanges();
                Calcula_TImporte_otal();
            }
        }
        private void dg_DetalleProd_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dg_DetalleProd.SelectedRows.Count > 0)
            {
                DataGridViewRow nFila = dg_DetalleProd.CurrentRow;
                if (nFila == null) return;

                txt_obs.Text = Convert.ToString(nFila.Cells["Obs"].Value);
                pnl_obs.Visible = true;
                txt_obs.Focus();
            }
        }
        private void btn_buscar_producto_Click(object sender, EventArgs e)
        {
            frmProductos_buscar frm = new frmProductos_buscar();
            frm.ShowDialog();
            if (frm.GraboDatos)
            {
                DataRow Fila = dt_DetalleProd.NewRow();

                Fila["Descripcion_pr"] = frm.oDatos.Descripcion_pr;
                Fila["Precio"] = frm.oDatos.Precio_unitario;
                Fila["Codigo_pr"] = frm.oDatos.Codigo_pr;
                Fila["Impresora"] = frm.oDatos.Impresora;

                Fila["Cantidad"] = "1";
                Fila["Total"] = Fila["Precio"];
                Fila["Obs"] = "";

                dt_DetalleProd.Rows.Add(Fila);
                dt_DetalleProd.AcceptChanges();

                Calcula_TImporte_otal();
            }
        }
        private void btn_retornar_obs_Click(object sender, EventArgs e)
        {
            if (dg_DetalleProd.SelectedRows.Count > 0)
            {
                DataGridViewRow nFila = dg_DetalleProd.CurrentRow;
                if (nFila == null) return;

                nFila.Cells["Obs"].Value = txt_obs.Text;
                dt_DetalleProd.AcceptChanges();
                pnl_obs.Visible = false;
            }
        }
        private void btn_buscar_cliente_Click(object sender, EventArgs e)
        {
            frmClientes_buscar frm = new frmClientes_buscar();
            frm.ShowDialog();
            if (frm.GraboDatos)
            {
                string cNombre = frm.oDatos.Nombre_cl;
                string nNrodoc = frm.oDatos.Nrodoc_cl;
                codigo_cl = frm.oDatos.Codigo_cl;
                txt_cliente.Text = cNombre;
                txt_nrodocumento.Text = nNrodoc;
            }
            else
            {
                txt_cliente.Text = "";
                txt_nrodocumento.Text = "";
                codigo_cl = 0;
            }
        }
        private void btn_generar_comanda_Click(object sender, EventArgs e)
        {
            EEncabezado_Tickets oDatos = new EEncabezado_Tickets();
            DataTable dtImpresora = new DataTable();

            if (txt_cliente.Text.Trim() == "")
            {
                MessageBox.Show("Ingres un Cliente.", "Ingreso de Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (lbl_total.Text.Trim() == "")
            {
                MessageBox.Show("Ingres un Producto.", "Ingreso de Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                oDatos.Fecha_trabajo = this.fecha_trabajo;
                oDatos.Codigo_cl = this.codigo_cl;
                oDatos.Nrodoc_cl = this.txt_nrodocumento.Text; 
                oDatos.Nombre_cl = this.txt_cliente.Text;
                oDatos.Codigo_me = this.codigo_me;
                oDatos.Total_ti = Convert.ToDecimal(lbl_total.Text);
                oDatos.Codigo_tu = this.codigo_tu;
                oDatos.Codigo_us = 1;
                oDatos.Codigo_tdp = 0;
                oDatos.Serie_tdp = "";
                oDatos.Corr_tdp = "";

                dt_DetalleProd.AcceptChanges();
                dtImpresora = NEncabezado_Tickets.Guardar(oDatos, dt_DetalleProd);
                int nCount = dtImpresora.Rows.Count;
                if (nCount > 0)
                {
                    for (int i = 0; i <= nCount - 1; i++)
                    {
                        sImpresora = Convert.ToString(dtImpresora.Rows[i][0]);
                        nCodigo_ti = Convert.ToInt32(dtImpresora.Rows[i][1]);
                        sDescripcion_pv = Convert.ToString(dtImpresora.Rows[i][2]);
                        dFecha_trabajo = Convert.ToDateTime(dtImpresora.Rows[i][3]);
                        sDescripcion_tu = Convert.ToString(dtImpresora.Rows[i][04]);
                        sNombre_us = Convert.ToString(dtImpresora.Rows[i][5]);
                        sDescripcion_ca = Convert.ToString(dtImpresora.Rows[i][6]);
                        sDescripcion_me = Convert.ToString(dtImpresora.Rows[i][7]);
                        sNombre_cl = Convert.ToString(dtImpresora.Rows[i][8]);
                        sNrodoc_cl = Convert.ToString(dtImpresora.Rows[i][9]);

                        printDocument1 = new PrintDocument();
                        printDocument1.PrinterSettings.PrinterName = sImpresora.Trim();
                        printDocument1.PrintPage += Imprimir;
                        printDocument1.Print();
                    }
                    MessageBox.Show("Pedido generado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar_Datos();
                }
                else
                {
                    MessageBox.Show("Comanda no generada, verifique el detalle del pedido.", "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        #endregion

        // *********************************************************************************
        #region "Mis Metodos"
        private void Carga_Datos()
        {
            Carga_SubFamilias();
            Detalle_Productos();
            timer1.Interval = 1000;
            timer1.Enabled = true;
        }
        private void Carga_SubFamilias()
        {
            try
            {
                dg_subfamilias.DataSource = NMesa_Abierta.Listado_SubFamilias_RP(this.codigo_pv);

                dg_subfamilias.Columns[0].HeaderText = "SUB FAMILIA";
                dg_subfamilias.Columns[0].Width = 220;

                dg_subfamilias.Columns[1].Visible = false;

                Metodos.Formato_dgv(dg_subfamilias, 10);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo leer las Suibfamilias." + "\n" + ex.Message + "\n" + ex.StackTrace, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Carga_Productos(FlowLayoutPanel Contenedor)
        {
            DataTable dt_Productos = new DataTable();
            int codigo;
            string descripcion, precio, impresora;
            byte[] bImagen = new byte[0];
            Image iImagen;

            Contenedor.Controls.Clear();
            if (dg_subfamilias.Rows.Count == 0)
                return;

            try
            {
                this.codigo_sf = Convert.ToInt32(dg_subfamilias.CurrentRow.Cells["codigo_sf"].Value);
                dt_Productos = NMesa_Abierta.Listado_Productos_SubFamilia_RP(this.codigo_pv, this.codigo_sf);
                int nFilas = dt_Productos.Rows.Count;
                if (nFilas == 0)
                    return;

                for (int i = 0; i < nFilas; i++)
                {
                    codigo = Convert.ToInt32(dt_Productos.Rows[i][0]);
                    descripcion = Convert.ToString(dt_Productos.Rows[i][1]);
                    precio = Convert.ToString(dt_Productos.Rows[i][2]);

                    bImagen = (byte[])dt_Productos.Rows[i][3];
                    MemoryStream ms = new MemoryStream(bImagen);
                    iImagen = Image.FromStream(ms);

                    impresora = Convert.ToString(dt_Productos.Rows[i][4]);

                    Controles.MiProducto oProducto = new Controles.MiProducto();
                    oProducto = new Controles.MiProducto();
                    oProducto.Codigo_pr = codigo;
                    oProducto.Descripcion_pr = descripcion;
                    oProducto.Precio_pr = precio;
                    oProducto.Imagen_pr = iImagen;
                    oProducto.Impresora = impresora;
                    oProducto.archivo_txt = Archivo_txt;
                    Contenedor.Controls.Add(oProducto);
                    oProducto = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo leer las Suibfamilias." + "\n" + ex.Message + "\n" + ex.StackTrace, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Detalle_Productos()
        {
            dt_DetalleProd = new DataTable();
            dt_DetalleProd.Columns.Add("Descripcion_pr", System.Type.GetType("System.String"));
            dt_DetalleProd.Columns.Add("Precio", System.Type.GetType("System.String"));
            dt_DetalleProd.Columns.Add("Cantidad", System.Type.GetType("System.String"));
            dt_DetalleProd.Columns.Add("Total", System.Type.GetType("System.String"));
            dt_DetalleProd.Columns.Add("Obs", System.Type.GetType("System.String"));
            dt_DetalleProd.Columns.Add("Codigo_pr", System.Type.GetType("System.Int32"));
            dt_DetalleProd.Columns.Add("Impresora", System.Type.GetType("System.String"));
            dg_DetalleProd.DataSource = this.dt_DetalleProd;

            dg_DetalleProd.Columns[0].HeaderText = "PRODUCTO";
            dg_DetalleProd.Columns[0].Width = 190;

            dg_DetalleProd.Columns[1].HeaderText = "P. UNIT.";
            dg_DetalleProd.Columns[1].Width = 75;
            dg_DetalleProd.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg_DetalleProd.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dg_DetalleProd.Columns[2].HeaderText = "CANT.";
            dg_DetalleProd.Columns[2].Width = 75;
            dg_DetalleProd.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg_DetalleProd.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dg_DetalleProd.Columns[3].HeaderText = "TOTAL S/.";
            dg_DetalleProd.Columns[3].Width = 90;
            dg_DetalleProd.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg_DetalleProd.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dg_DetalleProd.Columns[4].HeaderText = "OBS";
            dg_DetalleProd.Columns[4].Width = 100;

            dg_DetalleProd.Columns[5].Visible = false;
            dg_DetalleProd.Columns[6].Visible = false;

            Metodos.Formato_dgv(dg_DetalleProd, 10);
        }
        private void Calcula_TImporte_otal()
        {
            const int nCol = 3; // 
            decimal nSuma = 0;
            foreach (DataGridViewRow nRow in dg_DetalleProd.Rows)
            {
                nSuma += Convert.ToDecimal(nRow.Cells[nCol].Value);
            }
            lbl_total.Text = Convert.ToString(nSuma);
        }
        private void Limpiar_Datos()
        {
            txt_cliente.Text = "";
            txt_nrodocumento.Text = "";
            lbl_cantidad.Text = "";
            lbl_total.Text = "";
            dt_DetalleProd.Clear();
            timer1.Enabled = false;
        }
        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            DataTable dtImprimir = new DataTable();

            Font font1 = new Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Point);
            Font font2 = new Font("Arial", 8, FontStyle.Regular, GraphicsUnit.Point);
            Font font3 = new Font("Arial", 7, FontStyle.Regular, GraphicsUnit.Point);

            int ancho = 250;
            int y = 20;

            // CABECERA
            e.Graphics.DrawString("Comanda Ticket # " + nCodigo_ti, font1, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("Punto de Venta: " + sDescripcion_pv, font2, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("Fecha Trabjo: " + dFecha_trabajo, font2, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("Turno: " + sDescripcion_tu, font2, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("Usuario: " + sNombre_us, font2, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("Cargo: " + sDescripcion_ca, font2, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("Mesa #: " + sDescripcion_me, font2, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("Cliente: " + sNombre_cl, font2, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("Nro. Doc.: " + sNrodoc_cl, font2, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("----- PRODUCTOS -----", font2, Brushes.Black, new RectangleF(0, y += 30, ancho, 20));

            // DETALLE
            dtImprimir = NDetalle_Tickets.Listado_Detalle_Tickets(sImpresora, nCodigo_ti);
            int nCountD = dtImprimir.Rows.Count;
            if (nCountD > 0)
            {
                string sCant, sDesc, sObs;
                for (int j = 0; j <= nCountD - 1; j++)
                {
                    sCant = Convert.ToString(dtImprimir.Rows[j][0]);
                    sDesc = Convert.ToString(dtImprimir.Rows[j][1]);
                    sObs = Convert.ToString(dtImprimir.Rows[j][2]);
                    e.Graphics.DrawString(sCant + " " + sDesc, font3, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
                    if (sObs != "")
                        e.Graphics.DrawString("Observ. ---> " + sObs, font3, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
                }
            }
        }
        private void Formato_Tickets()
        {
            dg_Tickets.Columns[0].Width = 100;
            dg_Tickets.Columns[0].Visible = false;
            dg_Tickets.Columns[0].ReadOnly = true;

            dg_Tickets.Columns[1].HeaderText = "Nº TICKET";
            dg_Tickets.Columns[1].Width = 75;

            dg_Tickets.Columns[2].HeaderText = "CLIENTE";
            dg_Tickets.Columns[2].Width = 240;

            dg_Tickets.Columns[3].HeaderText = "EMISION";
            dg_Tickets.Columns[3].Width = 120;

            dg_Tickets.Columns[4].HeaderText = "TOTAL S/.";
            dg_Tickets.Columns[4].Width = 120;

            dg_Tickets.Columns[5].Visible = false;
            dg_Tickets.Columns[6].Visible = false;

            Metodos.Formato_dgv(dg_Tickets, 10);
        }
        private void Mostrar_Tickets()
        {
            try
            {
                dg_Tickets.DataSource = NEncabezado_Tickets.Mostrar_Tickets_Mesa(this.codigo_me);
                lbl_total_tickets.Text ="Total Tickets : " + Convert.ToString( dg_Tickets.Rows.Count);
                Formato_Tickets();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        #endregion
    }
}
