namespace Presentacion
{
    partial class frmMDIPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Marcas = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Familia = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_PtoVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.unidadesDeMEdidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Unidades = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Menu_Productos = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Salir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.procesosToolStripMenuItem,
            this.tablasToolStripMenuItem,
            this.sistemaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // tablasToolStripMenuItem
            // 
            this.tablasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Productos,
            this.toolStripSeparator1,
            this.Menu_Marcas,
            this.Menu_Familia,
            this.Menu_PtoVenta,
            this.unidadesDeMEdidaToolStripMenuItem,
            this.Menu_Unidades});
            this.tablasToolStripMenuItem.Name = "tablasToolStripMenuItem";
            this.tablasToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.tablasToolStripMenuItem.Text = "Tablas";
            // 
            // Menu_Marcas
            // 
            this.Menu_Marcas.Name = "Menu_Marcas";
            this.Menu_Marcas.Size = new System.Drawing.Size(209, 22);
            this.Menu_Marcas.Text = "Marcas";
            this.Menu_Marcas.Click += new System.EventHandler(this.Menu_Marcas_Click);
            // 
            // Menu_Familia
            // 
            this.Menu_Familia.Name = "Menu_Familia";
            this.Menu_Familia.Size = new System.Drawing.Size(209, 22);
            this.Menu_Familia.Text = "Familias y Sub Familias";
            this.Menu_Familia.Click += new System.EventHandler(this.Menu_Familia_Click);
            // 
            // Menu_PtoVenta
            // 
            this.Menu_PtoVenta.Name = "Menu_PtoVenta";
            this.Menu_PtoVenta.Size = new System.Drawing.Size(209, 22);
            this.Menu_PtoVenta.Text = "Puntos de Ventas y Mesas";
            this.Menu_PtoVenta.Click += new System.EventHandler(this.Menu_PtoVenta_Click);
            // 
            // unidadesDeMEdidaToolStripMenuItem
            // 
            this.unidadesDeMEdidaToolStripMenuItem.Name = "unidadesDeMEdidaToolStripMenuItem";
            this.unidadesDeMEdidaToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.unidadesDeMEdidaToolStripMenuItem.Text = "Aread de Despacho";
            // 
            // Menu_Unidades
            // 
            this.Menu_Unidades.Name = "Menu_Unidades";
            this.Menu_Unidades.Size = new System.Drawing.Size(209, 22);
            this.Menu_Unidades.Text = "Unidades de Medida";
            this.Menu_Unidades.Click += new System.EventHandler(this.Menu_Unidades_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(206, 6);
            // 
            // Menu_Productos
            // 
            this.Menu_Productos.Name = "Menu_Productos";
            this.Menu_Productos.Size = new System.Drawing.Size(209, 22);
            this.Menu_Productos.Text = "Productos";
            this.Menu_Productos.Click += new System.EventHandler(this.Menu_Productos_Click);
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Salir});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // Menu_Salir
            // 
            this.Menu_Salir.Name = "Menu_Salir";
            this.Menu_Salir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.L)));
            this.Menu_Salir.Size = new System.Drawing.Size(132, 22);
            this.Menu_Salir.Text = "Salir";
            this.Menu_Salir.Click += new System.EventHandler(this.Menu_Salir_Click);
            // 
            // frmMDIPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMDIPrincipal";
            this.Text = "Sistema de Punto de Venta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tablasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Menu_PtoVenta;
        private System.Windows.Forms.ToolStripMenuItem Menu_Familia;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Menu_Salir;
        private System.Windows.Forms.ToolStripMenuItem Menu_Marcas;
        private System.Windows.Forms.ToolStripMenuItem Menu_Unidades;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem Menu_Productos;
        private System.Windows.Forms.ToolStripMenuItem unidadesDeMEdidaToolStripMenuItem;
    }
}