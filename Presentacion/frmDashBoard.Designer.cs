namespace Presentacion
{
    partial class frmDashBoard
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
            this.components = new System.ComponentModel.Container();
            this.pnl_menu = new System.Windows.Forms.Panel();
            this.btn_cessarsesion = new FontAwesome.Sharp.IconButton();
            this.pnl_datosmaestros = new System.Windows.Forms.Panel();
            this.btn_areaDespacho = new FontAwesome.Sharp.IconButton();
            this.btn_ptoventaMesas = new FontAwesome.Sharp.IconButton();
            this.btn_famSsubFam = new FontAwesome.Sharp.IconButton();
            this.btn_umedida = new FontAwesome.Sharp.IconButton();
            this.btn_marcas = new FontAwesome.Sharp.IconButton();
            this.btn_productos = new FontAwesome.Sharp.IconButton();
            this.btn_datosmaestros = new FontAwesome.Sharp.IconButton();
            this.pnl_reportes = new System.Windows.Forms.Panel();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.iconButton6 = new FontAwesome.Sharp.IconButton();
            this.btn_reportes = new FontAwesome.Sharp.IconButton();
            this.pnl_procesos = new System.Windows.Forms.Panel();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.btn_registrar_pedido = new FontAwesome.Sharp.IconButton();
            this.btn_procesos = new FontAwesome.Sharp.IconButton();
            this.btn_dashboard = new FontAwesome.Sharp.IconButton();
            this.pnl_logo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_cabecera = new System.Windows.Forms.Panel();
            this.btn_cer = new FontAwesome.Sharp.IconButton();
            this.btn_max = new FontAwesome.Sharp.IconButton();
            this.btn_min = new FontAwesome.Sharp.IconButton();
            this.lbl_seleccion = new System.Windows.Forms.Label();
            this.ico_seleccion = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_pie = new System.Windows.Forms.Panel();
            this.grb_fecha = new System.Windows.Forms.GroupBox();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.lbl_hora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnl_cuerpo = new System.Windows.Forms.Panel();
            this.pnl_menu.SuspendLayout();
            this.pnl_datosmaestros.SuspendLayout();
            this.pnl_reportes.SuspendLayout();
            this.pnl_procesos.SuspendLayout();
            this.pnl_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_cabecera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ico_seleccion)).BeginInit();
            this.pnl_pie.SuspendLayout();
            this.grb_fecha.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_menu
            // 
            this.pnl_menu.AutoScroll = true;
            this.pnl_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(105)))), ((int)(((byte)(141)))));
            this.pnl_menu.Controls.Add(this.btn_cessarsesion);
            this.pnl_menu.Controls.Add(this.pnl_datosmaestros);
            this.pnl_menu.Controls.Add(this.btn_datosmaestros);
            this.pnl_menu.Controls.Add(this.pnl_reportes);
            this.pnl_menu.Controls.Add(this.btn_reportes);
            this.pnl_menu.Controls.Add(this.pnl_procesos);
            this.pnl_menu.Controls.Add(this.btn_procesos);
            this.pnl_menu.Controls.Add(this.btn_dashboard);
            this.pnl_menu.Controls.Add(this.pnl_logo);
            this.pnl_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_menu.Location = new System.Drawing.Point(0, 0);
            this.pnl_menu.Name = "pnl_menu";
            this.pnl_menu.Size = new System.Drawing.Size(200, 731);
            this.pnl_menu.TabIndex = 0;
            // 
            // btn_cessarsesion
            // 
            this.btn_cessarsesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cessarsesion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_cessarsesion.FlatAppearance.BorderSize = 0;
            this.btn_cessarsesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cessarsesion.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cessarsesion.ForeColor = System.Drawing.Color.White;
            this.btn_cessarsesion.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            this.btn_cessarsesion.IconColor = System.Drawing.Color.White;
            this.btn_cessarsesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_cessarsesion.IconSize = 32;
            this.btn_cessarsesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cessarsesion.Location = new System.Drawing.Point(0, 794);
            this.btn_cessarsesion.Name = "btn_cessarsesion";
            this.btn_cessarsesion.Size = new System.Drawing.Size(183, 40);
            this.btn_cessarsesion.TabIndex = 8;
            this.btn_cessarsesion.Text = "Cerrar Sesión";
            this.btn_cessarsesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cessarsesion.UseVisualStyleBackColor = true;
            this.btn_cessarsesion.Click += new System.EventHandler(this.btn_cessarsesion_Click);
            // 
            // pnl_datosmaestros
            // 
            this.pnl_datosmaestros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(193)))), ((int)(((byte)(211)))));
            this.pnl_datosmaestros.Controls.Add(this.btn_areaDespacho);
            this.pnl_datosmaestros.Controls.Add(this.btn_ptoventaMesas);
            this.pnl_datosmaestros.Controls.Add(this.btn_famSsubFam);
            this.pnl_datosmaestros.Controls.Add(this.btn_umedida);
            this.pnl_datosmaestros.Controls.Add(this.btn_marcas);
            this.pnl_datosmaestros.Controls.Add(this.btn_productos);
            this.pnl_datosmaestros.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_datosmaestros.Location = new System.Drawing.Point(0, 550);
            this.pnl_datosmaestros.Name = "pnl_datosmaestros";
            this.pnl_datosmaestros.Size = new System.Drawing.Size(183, 244);
            this.pnl_datosmaestros.TabIndex = 7;
            // 
            // btn_areaDespacho
            // 
            this.btn_areaDespacho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_areaDespacho.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_areaDespacho.FlatAppearance.BorderSize = 0;
            this.btn_areaDespacho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_areaDespacho.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_areaDespacho.ForeColor = System.Drawing.Color.White;
            this.btn_areaDespacho.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.btn_areaDespacho.IconColor = System.Drawing.Color.White;
            this.btn_areaDespacho.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_areaDespacho.IconSize = 32;
            this.btn_areaDespacho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_areaDespacho.Location = new System.Drawing.Point(0, 200);
            this.btn_areaDespacho.Name = "btn_areaDespacho";
            this.btn_areaDespacho.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btn_areaDespacho.Size = new System.Drawing.Size(183, 40);
            this.btn_areaDespacho.TabIndex = 7;
            this.btn_areaDespacho.Text = "Areas de Despacho";
            this.btn_areaDespacho.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_areaDespacho.UseVisualStyleBackColor = true;
            this.btn_areaDespacho.Click += new System.EventHandler(this.btn_areaDespacho_Click);
            // 
            // btn_ptoventaMesas
            // 
            this.btn_ptoventaMesas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ptoventaMesas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_ptoventaMesas.FlatAppearance.BorderSize = 0;
            this.btn_ptoventaMesas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ptoventaMesas.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ptoventaMesas.ForeColor = System.Drawing.Color.White;
            this.btn_ptoventaMesas.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.btn_ptoventaMesas.IconColor = System.Drawing.Color.White;
            this.btn_ptoventaMesas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_ptoventaMesas.IconSize = 32;
            this.btn_ptoventaMesas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ptoventaMesas.Location = new System.Drawing.Point(0, 160);
            this.btn_ptoventaMesas.Name = "btn_ptoventaMesas";
            this.btn_ptoventaMesas.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btn_ptoventaMesas.Size = new System.Drawing.Size(183, 40);
            this.btn_ptoventaMesas.TabIndex = 6;
            this.btn_ptoventaMesas.Text = "Puntos de Venta y Mesas";
            this.btn_ptoventaMesas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ptoventaMesas.UseVisualStyleBackColor = true;
            this.btn_ptoventaMesas.Click += new System.EventHandler(this.btn_ptoventaMesas_Click);
            // 
            // btn_famSsubFam
            // 
            this.btn_famSsubFam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_famSsubFam.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_famSsubFam.FlatAppearance.BorderSize = 0;
            this.btn_famSsubFam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_famSsubFam.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_famSsubFam.ForeColor = System.Drawing.Color.White;
            this.btn_famSsubFam.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.btn_famSsubFam.IconColor = System.Drawing.Color.White;
            this.btn_famSsubFam.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_famSsubFam.IconSize = 32;
            this.btn_famSsubFam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_famSsubFam.Location = new System.Drawing.Point(0, 120);
            this.btn_famSsubFam.Name = "btn_famSsubFam";
            this.btn_famSsubFam.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btn_famSsubFam.Size = new System.Drawing.Size(183, 40);
            this.btn_famSsubFam.TabIndex = 5;
            this.btn_famSsubFam.Text = "Familias y SubFamilias";
            this.btn_famSsubFam.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_famSsubFam.UseVisualStyleBackColor = true;
            this.btn_famSsubFam.Click += new System.EventHandler(this.btn_famSsubFam_Click);
            // 
            // btn_umedida
            // 
            this.btn_umedida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_umedida.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_umedida.FlatAppearance.BorderSize = 0;
            this.btn_umedida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_umedida.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_umedida.ForeColor = System.Drawing.Color.White;
            this.btn_umedida.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.btn_umedida.IconColor = System.Drawing.Color.White;
            this.btn_umedida.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_umedida.IconSize = 32;
            this.btn_umedida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_umedida.Location = new System.Drawing.Point(0, 80);
            this.btn_umedida.Name = "btn_umedida";
            this.btn_umedida.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btn_umedida.Size = new System.Drawing.Size(183, 40);
            this.btn_umedida.TabIndex = 4;
            this.btn_umedida.Text = "Unidades de Medida";
            this.btn_umedida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_umedida.UseVisualStyleBackColor = true;
            this.btn_umedida.Click += new System.EventHandler(this.btn_umedida_Click);
            // 
            // btn_marcas
            // 
            this.btn_marcas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_marcas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_marcas.FlatAppearance.BorderSize = 0;
            this.btn_marcas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_marcas.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_marcas.ForeColor = System.Drawing.Color.White;
            this.btn_marcas.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.btn_marcas.IconColor = System.Drawing.Color.White;
            this.btn_marcas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_marcas.IconSize = 32;
            this.btn_marcas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_marcas.Location = new System.Drawing.Point(0, 40);
            this.btn_marcas.Name = "btn_marcas";
            this.btn_marcas.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btn_marcas.Size = new System.Drawing.Size(183, 40);
            this.btn_marcas.TabIndex = 3;
            this.btn_marcas.Text = "Marcas";
            this.btn_marcas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_marcas.UseVisualStyleBackColor = true;
            this.btn_marcas.Click += new System.EventHandler(this.btn_marcas_Click);
            // 
            // btn_productos
            // 
            this.btn_productos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_productos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_productos.FlatAppearance.BorderSize = 0;
            this.btn_productos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_productos.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_productos.ForeColor = System.Drawing.Color.White;
            this.btn_productos.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.btn_productos.IconColor = System.Drawing.Color.White;
            this.btn_productos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_productos.IconSize = 32;
            this.btn_productos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_productos.Location = new System.Drawing.Point(0, 0);
            this.btn_productos.Name = "btn_productos";
            this.btn_productos.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btn_productos.Size = new System.Drawing.Size(183, 40);
            this.btn_productos.TabIndex = 2;
            this.btn_productos.Text = "Productos";
            this.btn_productos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_productos.UseVisualStyleBackColor = true;
            this.btn_productos.Click += new System.EventHandler(this.btn_productos_Click);
            // 
            // btn_datosmaestros
            // 
            this.btn_datosmaestros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_datosmaestros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_datosmaestros.FlatAppearance.BorderSize = 0;
            this.btn_datosmaestros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_datosmaestros.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_datosmaestros.ForeColor = System.Drawing.Color.White;
            this.btn_datosmaestros.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.btn_datosmaestros.IconColor = System.Drawing.Color.White;
            this.btn_datosmaestros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_datosmaestros.IconSize = 32;
            this.btn_datosmaestros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_datosmaestros.Location = new System.Drawing.Point(0, 510);
            this.btn_datosmaestros.Name = "btn_datosmaestros";
            this.btn_datosmaestros.Size = new System.Drawing.Size(183, 40);
            this.btn_datosmaestros.TabIndex = 6;
            this.btn_datosmaestros.Text = "Datos Maestros";
            this.btn_datosmaestros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_datosmaestros.UseVisualStyleBackColor = true;
            this.btn_datosmaestros.Click += new System.EventHandler(this.btn_datosmaestros_Click);
            // 
            // pnl_reportes
            // 
            this.pnl_reportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(193)))), ((int)(((byte)(211)))));
            this.pnl_reportes.Controls.Add(this.iconButton4);
            this.pnl_reportes.Controls.Add(this.iconButton5);
            this.pnl_reportes.Controls.Add(this.iconButton6);
            this.pnl_reportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_reportes.Location = new System.Drawing.Point(0, 380);
            this.pnl_reportes.Name = "pnl_reportes";
            this.pnl_reportes.Size = new System.Drawing.Size(183, 130);
            this.pnl_reportes.TabIndex = 5;
            // 
            // iconButton4
            // 
            this.iconButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton4.ForeColor = System.Drawing.Color.White;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.iconButton4.IconColor = System.Drawing.Color.White;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 32;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.Location = new System.Drawing.Point(0, 80);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.iconButton4.Size = new System.Drawing.Size(183, 40);
            this.iconButton4.TabIndex = 4;
            this.iconButton4.Text = "Opcion 3";
            this.iconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton4.UseVisualStyleBackColor = true;
            // 
            // iconButton5
            // 
            this.iconButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton5.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton5.FlatAppearance.BorderSize = 0;
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton5.ForeColor = System.Drawing.Color.White;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.iconButton5.IconColor = System.Drawing.Color.White;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.IconSize = 32;
            this.iconButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.Location = new System.Drawing.Point(0, 40);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.iconButton5.Size = new System.Drawing.Size(183, 40);
            this.iconButton5.TabIndex = 3;
            this.iconButton5.Text = "Opcion 2";
            this.iconButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton5.UseVisualStyleBackColor = true;
            // 
            // iconButton6
            // 
            this.iconButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton6.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton6.FlatAppearance.BorderSize = 0;
            this.iconButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton6.ForeColor = System.Drawing.Color.White;
            this.iconButton6.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.iconButton6.IconColor = System.Drawing.Color.White;
            this.iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton6.IconSize = 32;
            this.iconButton6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton6.Location = new System.Drawing.Point(0, 0);
            this.iconButton6.Name = "iconButton6";
            this.iconButton6.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.iconButton6.Size = new System.Drawing.Size(183, 40);
            this.iconButton6.TabIndex = 2;
            this.iconButton6.Text = "Opcion 1";
            this.iconButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton6.UseVisualStyleBackColor = true;
            // 
            // btn_reportes
            // 
            this.btn_reportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_reportes.FlatAppearance.BorderSize = 0;
            this.btn_reportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reportes.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reportes.ForeColor = System.Drawing.Color.White;
            this.btn_reportes.IconChar = FontAwesome.Sharp.IconChar.FileContract;
            this.btn_reportes.IconColor = System.Drawing.Color.White;
            this.btn_reportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_reportes.IconSize = 32;
            this.btn_reportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reportes.Location = new System.Drawing.Point(0, 340);
            this.btn_reportes.Name = "btn_reportes";
            this.btn_reportes.Size = new System.Drawing.Size(183, 40);
            this.btn_reportes.TabIndex = 3;
            this.btn_reportes.Text = "Reportes";
            this.btn_reportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_reportes.UseVisualStyleBackColor = true;
            this.btn_reportes.Click += new System.EventHandler(this.btn_reportes_Click);
            // 
            // pnl_procesos
            // 
            this.pnl_procesos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(193)))), ((int)(((byte)(211)))));
            this.pnl_procesos.Controls.Add(this.iconButton3);
            this.pnl_procesos.Controls.Add(this.iconButton2);
            this.pnl_procesos.Controls.Add(this.btn_registrar_pedido);
            this.pnl_procesos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_procesos.Location = new System.Drawing.Point(0, 210);
            this.pnl_procesos.Name = "pnl_procesos";
            this.pnl_procesos.Size = new System.Drawing.Size(183, 130);
            this.pnl_procesos.TabIndex = 2;
            // 
            // iconButton3
            // 
            this.iconButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.ForeColor = System.Drawing.Color.White;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.SquareUpRight;
            this.iconButton3.IconColor = System.Drawing.Color.White;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 32;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(0, 80);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.iconButton3.Size = new System.Drawing.Size(183, 40);
            this.iconButton3.TabIndex = 4;
            this.iconButton3.Text = "Opcion 3";
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            this.iconButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.SquareUpRight;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 32;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(0, 40);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.iconButton2.Size = new System.Drawing.Size(183, 40);
            this.iconButton2.TabIndex = 3;
            this.iconButton2.Text = "Opcion 2";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // btn_registrar_pedido
            // 
            this.btn_registrar_pedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_registrar_pedido.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_registrar_pedido.FlatAppearance.BorderSize = 0;
            this.btn_registrar_pedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registrar_pedido.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrar_pedido.ForeColor = System.Drawing.Color.White;
            this.btn_registrar_pedido.IconChar = FontAwesome.Sharp.IconChar.SquareUpRight;
            this.btn_registrar_pedido.IconColor = System.Drawing.Color.White;
            this.btn_registrar_pedido.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_registrar_pedido.IconSize = 32;
            this.btn_registrar_pedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_registrar_pedido.Location = new System.Drawing.Point(0, 0);
            this.btn_registrar_pedido.Name = "btn_registrar_pedido";
            this.btn_registrar_pedido.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btn_registrar_pedido.Size = new System.Drawing.Size(183, 40);
            this.btn_registrar_pedido.TabIndex = 2;
            this.btn_registrar_pedido.Text = "Registrar Pedido";
            this.btn_registrar_pedido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_registrar_pedido.UseVisualStyleBackColor = true;
            this.btn_registrar_pedido.Click += new System.EventHandler(this.btn_registrar_pedido_Click);
            // 
            // btn_procesos
            // 
            this.btn_procesos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_procesos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_procesos.FlatAppearance.BorderSize = 0;
            this.btn_procesos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_procesos.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_procesos.ForeColor = System.Drawing.Color.White;
            this.btn_procesos.IconChar = FontAwesome.Sharp.IconChar.ThList;
            this.btn_procesos.IconColor = System.Drawing.Color.White;
            this.btn_procesos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_procesos.IconSize = 32;
            this.btn_procesos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_procesos.Location = new System.Drawing.Point(0, 170);
            this.btn_procesos.Name = "btn_procesos";
            this.btn_procesos.Size = new System.Drawing.Size(183, 40);
            this.btn_procesos.TabIndex = 1;
            this.btn_procesos.Text = "Procesos";
            this.btn_procesos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_procesos.UseVisualStyleBackColor = true;
            this.btn_procesos.Click += new System.EventHandler(this.btn_procesos_Click);
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_dashboard.FlatAppearance.BorderSize = 0;
            this.btn_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dashboard.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dashboard.ForeColor = System.Drawing.Color.White;
            this.btn_dashboard.IconChar = FontAwesome.Sharp.IconChar.Dochub;
            this.btn_dashboard.IconColor = System.Drawing.Color.White;
            this.btn_dashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_dashboard.IconSize = 32;
            this.btn_dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dashboard.Location = new System.Drawing.Point(0, 130);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Size = new System.Drawing.Size(183, 40);
            this.btn_dashboard.TabIndex = 0;
            this.btn_dashboard.Text = "DashBoard";
            this.btn_dashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_dashboard.UseVisualStyleBackColor = true;
            this.btn_dashboard.Click += new System.EventHandler(this.btn_dashboard_Click);
            // 
            // pnl_logo
            // 
            this.pnl_logo.Controls.Add(this.pictureBox1);
            this.pnl_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_logo.Location = new System.Drawing.Point(0, 0);
            this.pnl_logo.Name = "pnl_logo";
            this.pnl_logo.Size = new System.Drawing.Size(183, 130);
            this.pnl_logo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(30, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnl_cabecera
            // 
            this.pnl_cabecera.BackColor = System.Drawing.Color.White;
            this.pnl_cabecera.Controls.Add(this.btn_cer);
            this.pnl_cabecera.Controls.Add(this.btn_max);
            this.pnl_cabecera.Controls.Add(this.btn_min);
            this.pnl_cabecera.Controls.Add(this.lbl_seleccion);
            this.pnl_cabecera.Controls.Add(this.ico_seleccion);
            this.pnl_cabecera.Controls.Add(this.label1);
            this.pnl_cabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_cabecera.Location = new System.Drawing.Point(200, 0);
            this.pnl_cabecera.Name = "pnl_cabecera";
            this.pnl_cabecera.Size = new System.Drawing.Size(1174, 70);
            this.pnl_cabecera.TabIndex = 1;
            this.pnl_cabecera.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_cabecera_MouseDown);
            // 
            // btn_cer
            // 
            this.btn_cer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(74)))), ((int)(((byte)(130)))));
            this.btn_cer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cer.FlatAppearance.BorderSize = 0;
            this.btn_cer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cer.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btn_cer.IconColor = System.Drawing.Color.White;
            this.btn_cer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_cer.IconSize = 20;
            this.btn_cer.Location = new System.Drawing.Point(1121, 0);
            this.btn_cer.Name = "btn_cer";
            this.btn_cer.Size = new System.Drawing.Size(45, 25);
            this.btn_cer.TabIndex = 5;
            this.btn_cer.UseVisualStyleBackColor = false;
            this.btn_cer.Click += new System.EventHandler(this.btn_cer_Click);
            // 
            // btn_max
            // 
            this.btn_max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_max.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.btn_max.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_max.FlatAppearance.BorderSize = 0;
            this.btn_max.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_max.IconChar = FontAwesome.Sharp.IconChar.ExternalLinkAlt;
            this.btn_max.IconColor = System.Drawing.Color.White;
            this.btn_max.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_max.IconSize = 20;
            this.btn_max.Location = new System.Drawing.Point(1075, 0);
            this.btn_max.Name = "btn_max";
            this.btn_max.Size = new System.Drawing.Size(45, 25);
            this.btn_max.TabIndex = 4;
            this.btn_max.UseVisualStyleBackColor = false;
            this.btn_max.Click += new System.EventHandler(this.btn_max_Click);
            // 
            // btn_min
            // 
            this.btn_min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(185)))), ((int)(((byte)(214)))));
            this.btn_min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_min.FlatAppearance.BorderSize = 0;
            this.btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_min.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btn_min.IconColor = System.Drawing.Color.White;
            this.btn_min.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_min.IconSize = 20;
            this.btn_min.Location = new System.Drawing.Point(1029, 0);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(45, 25);
            this.btn_min.TabIndex = 3;
            this.btn_min.UseVisualStyleBackColor = false;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            // 
            // lbl_seleccion
            // 
            this.lbl_seleccion.AutoSize = true;
            this.lbl_seleccion.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_seleccion.Location = new System.Drawing.Point(45, 30);
            this.lbl_seleccion.Name = "lbl_seleccion";
            this.lbl_seleccion.Size = new System.Drawing.Size(23, 18);
            this.lbl_seleccion.TabIndex = 2;
            this.lbl_seleccion.Text = "...";
            // 
            // ico_seleccion
            // 
            this.ico_seleccion.BackColor = System.Drawing.Color.White;
            this.ico_seleccion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ico_seleccion.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ico_seleccion.IconColor = System.Drawing.SystemColors.ControlText;
            this.ico_seleccion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ico_seleccion.IconSize = 34;
            this.ico_seleccion.Location = new System.Drawing.Point(6, 24);
            this.ico_seleccion.Name = "ico_seleccion";
            this.ico_seleccion.Size = new System.Drawing.Size(32, 32);
            this.ico_seleccion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ico_seleccion.TabIndex = 1;
            this.ico_seleccion.TabStop = false;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(105)))), ((int)(((byte)(141)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1174, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "SISTEMA DE PUNTO DE VENTA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_pie
            // 
            this.pnl_pie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.pnl_pie.Controls.Add(this.grb_fecha);
            this.pnl_pie.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_pie.Location = new System.Drawing.Point(200, 654);
            this.pnl_pie.Name = "pnl_pie";
            this.pnl_pie.Size = new System.Drawing.Size(1174, 77);
            this.pnl_pie.TabIndex = 2;
            // 
            // grb_fecha
            // 
            this.grb_fecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grb_fecha.Controls.Add(this.lbl_fecha);
            this.grb_fecha.Controls.Add(this.lbl_hora);
            this.grb_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_fecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grb_fecha.Location = new System.Drawing.Point(903, 6);
            this.grb_fecha.Name = "grb_fecha";
            this.grb_fecha.Size = new System.Drawing.Size(259, 67);
            this.grb_fecha.TabIndex = 0;
            this.grb_fecha.TabStop = false;
            this.grb_fecha.Text = "Fecha y Hora :";
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_fecha.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_fecha.Location = new System.Drawing.Point(3, 38);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(253, 22);
            this.lbl_fecha.TabIndex = 1;
            this.lbl_fecha.Text = "label2";
            this.lbl_fecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_hora
            // 
            this.lbl_hora.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_hora.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_hora.Location = new System.Drawing.Point(3, 16);
            this.lbl_hora.Name = "lbl_hora";
            this.lbl_hora.Size = new System.Drawing.Size(253, 22);
            this.lbl_hora.TabIndex = 0;
            this.lbl_hora.Text = "label2";
            this.lbl_hora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnl_cuerpo
            // 
            this.pnl_cuerpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_cuerpo.Location = new System.Drawing.Point(200, 70);
            this.pnl_cuerpo.Name = "pnl_cuerpo";
            this.pnl_cuerpo.Size = new System.Drawing.Size(1174, 584);
            this.pnl_cuerpo.TabIndex = 3;
            // 
            // frmDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 731);
            this.Controls.Add(this.pnl_cuerpo);
            this.Controls.Add(this.pnl_cabecera);
            this.Controls.Add(this.pnl_pie);
            this.Controls.Add(this.pnl_menu);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard - Punto de Venta";
            this.Load += new System.EventHandler(this.frmDashBoard_Load);
            this.pnl_menu.ResumeLayout(false);
            this.pnl_datosmaestros.ResumeLayout(false);
            this.pnl_reportes.ResumeLayout(false);
            this.pnl_procesos.ResumeLayout(false);
            this.pnl_logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_cabecera.ResumeLayout(false);
            this.pnl_cabecera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ico_seleccion)).EndInit();
            this.pnl_pie.ResumeLayout(false);
            this.grb_fecha.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_menu;
        private System.Windows.Forms.Panel pnl_cabecera;
        private System.Windows.Forms.Panel pnl_pie;
        private System.Windows.Forms.Panel pnl_logo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btn_dashboard;
        private System.Windows.Forms.Panel pnl_procesos;
        private FontAwesome.Sharp.IconButton btn_procesos;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton btn_registrar_pedido;
        private FontAwesome.Sharp.IconButton btn_cessarsesion;
        private System.Windows.Forms.Panel pnl_datosmaestros;
        private FontAwesome.Sharp.IconButton btn_umedida;
        private FontAwesome.Sharp.IconButton btn_marcas;
        private FontAwesome.Sharp.IconButton btn_productos;
        private FontAwesome.Sharp.IconButton btn_datosmaestros;
        private System.Windows.Forms.Panel pnl_reportes;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton6;
        private FontAwesome.Sharp.IconButton btn_reportes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grb_fecha;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Label lbl_hora;
        private System.Windows.Forms.Timer timer1;
        private FontAwesome.Sharp.IconButton btn_cer;
        private FontAwesome.Sharp.IconButton btn_max;
        private FontAwesome.Sharp.IconButton btn_min;
        private System.Windows.Forms.Label lbl_seleccion;
        private FontAwesome.Sharp.IconPictureBox ico_seleccion;
        private System.Windows.Forms.Panel pnl_cuerpo;
        private FontAwesome.Sharp.IconButton btn_areaDespacho;
        private FontAwesome.Sharp.IconButton btn_ptoventaMesas;
        private FontAwesome.Sharp.IconButton btn_famSsubFam;
    }
}