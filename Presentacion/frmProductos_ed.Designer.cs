namespace Presentacion
{
    partial class frmProductos_ed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductos_ed));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_buscar_imagen = new System.Windows.Forms.Button();
            this.dgPuntoVenta = new System.Windows.Forms.DataGridView();
            this.txt_obs = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbo_adespacho = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbo_sfamilias = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbo_familias = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbo_unidades = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbo_marcas = new System.Windows.Forms.ComboBox();
            this.txt_descrip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.chk_estado = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.img_imagen = new System.Windows.Forms.PictureBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPuntoVenta)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_buscar_imagen);
            this.groupBox1.Controls.Add(this.dgPuntoVenta);
            this.groupBox1.Controls.Add(this.txt_obs);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_precio);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cbo_adespacho);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbo_sfamilias);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbo_familias);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbo_unidades);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbo_marcas);
            this.groupBox1.Controls.Add(this.txt_descrip);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_codigo);
            this.groupBox1.Controls.Add(this.chk_estado);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(932, 366);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS GENERALES";
            // 
            // btn_buscar_imagen
            // 
            this.btn_buscar_imagen.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar_imagen.Image")));
            this.btn_buscar_imagen.Location = new System.Drawing.Point(581, 304);
            this.btn_buscar_imagen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_buscar_imagen.Name = "btn_buscar_imagen";
            this.btn_buscar_imagen.Size = new System.Drawing.Size(172, 32);
            this.btn_buscar_imagen.TabIndex = 26;
            this.btn_buscar_imagen.Text = "Buscar imagen";
            this.btn_buscar_imagen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_buscar_imagen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_buscar_imagen.UseVisualStyleBackColor = true;
            this.btn_buscar_imagen.Click += new System.EventHandler(this.btn_buscar_imagen_Click);
            // 
            // dgPuntoVenta
            // 
            this.dgPuntoVenta.AllowUserToAddRows = false;
            this.dgPuntoVenta.AllowUserToDeleteRows = false;
            this.dgPuntoVenta.AllowUserToOrderColumns = true;
            this.dgPuntoVenta.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(163)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgPuntoVenta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgPuntoVenta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.dgPuntoVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgPuntoVenta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(111)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPuntoVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgPuntoVenta.ColumnHeadersHeight = 30;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgPuntoVenta.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgPuntoVenta.EnableHeadersVisualStyles = false;
            this.dgPuntoVenta.Location = new System.Drawing.Point(574, 12);
            this.dgPuntoVenta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgPuntoVenta.Name = "dgPuntoVenta";
            this.dgPuntoVenta.RowHeadersVisible = false;
            this.dgPuntoVenta.RowTemplate.Height = 25;
            this.dgPuntoVenta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgPuntoVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPuntoVenta.Size = new System.Drawing.Size(341, 150);
            this.dgPuntoVenta.TabIndex = 22;
            // 
            // txt_obs
            // 
            this.txt_obs.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_obs.Location = new System.Drawing.Point(127, 247);
            this.txt_obs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_obs.MaxLength = 30;
            this.txt_obs.Multiline = true;
            this.txt_obs.Name = "txt_obs";
            this.txt_obs.Size = new System.Drawing.Size(431, 86);
            this.txt_obs.TabIndex = 18;
            this.txt_obs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Key_Mayusculas);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(5, 250);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 14);
            this.label10.TabIndex = 42;
            this.label10.Text = "Observaciones :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(62, 222);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 14);
            this.label9.TabIndex = 38;
            this.label9.Text = "Precio :";
            // 
            // txt_precio
            // 
            this.txt_precio.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precio.Location = new System.Drawing.Point(127, 219);
            this.txt_precio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(122, 22);
            this.txt_precio.TabIndex = 16;
            this.txt_precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_precio_KeyPress);
            this.txt_precio.Leave += new System.EventHandler(this.txt_precio_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(40, 194);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 14);
            this.label8.TabIndex = 34;
            this.label8.Text = "Despacho :";
            // 
            // cbo_adespacho
            // 
            this.cbo_adespacho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_adespacho.DropDownWidth = 350;
            this.cbo_adespacho.FormattingEnabled = true;
            this.cbo_adespacho.Location = new System.Drawing.Point(127, 191);
            this.cbo_adespacho.Name = "cbo_adespacho";
            this.cbo_adespacho.Size = new System.Drawing.Size(204, 22);
            this.cbo_adespacho.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 166);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 14);
            this.label7.TabIndex = 30;
            this.label7.Text = "Sub Familia :";
            // 
            // cbo_sfamilias
            // 
            this.cbo_sfamilias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_sfamilias.DropDownWidth = 350;
            this.cbo_sfamilias.FormattingEnabled = true;
            this.cbo_sfamilias.Location = new System.Drawing.Point(127, 163);
            this.cbo_sfamilias.Name = "cbo_sfamilias";
            this.cbo_sfamilias.Size = new System.Drawing.Size(204, 22);
            this.cbo_sfamilias.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(56, 138);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 14);
            this.label6.TabIndex = 26;
            this.label6.Text = "Familia :";
            // 
            // cbo_familias
            // 
            this.cbo_familias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_familias.DropDownWidth = 350;
            this.cbo_familias.FormattingEnabled = true;
            this.cbo_familias.Location = new System.Drawing.Point(127, 135);
            this.cbo_familias.Name = "cbo_familias";
            this.cbo_familias.Size = new System.Drawing.Size(204, 22);
            this.cbo_familias.TabIndex = 10;
            this.cbo_familias.SelectionChangeCommitted += new System.EventHandler(this.cbo_familias_SelectionChangeCommitted);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 110);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 14);
            this.label5.TabIndex = 22;
            this.label5.Text = "Unidades :";
            // 
            // cbo_unidades
            // 
            this.cbo_unidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_unidades.DropDownWidth = 350;
            this.cbo_unidades.FormattingEnabled = true;
            this.cbo_unidades.Location = new System.Drawing.Point(127, 107);
            this.cbo_unidades.Name = "cbo_unidades";
            this.cbo_unidades.Size = new System.Drawing.Size(204, 22);
            this.cbo_unidades.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 82);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 14);
            this.label4.TabIndex = 18;
            this.label4.Text = "Marca :";
            // 
            // cbo_marcas
            // 
            this.cbo_marcas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_marcas.DropDownWidth = 350;
            this.cbo_marcas.FormattingEnabled = true;
            this.cbo_marcas.Location = new System.Drawing.Point(127, 79);
            this.cbo_marcas.Name = "cbo_marcas";
            this.cbo_marcas.Size = new System.Drawing.Size(204, 22);
            this.cbo_marcas.TabIndex = 6;
            // 
            // txt_descrip
            // 
            this.txt_descrip.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descrip.Location = new System.Drawing.Point(127, 51);
            this.txt_descrip.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_descrip.MaxLength = 50;
            this.txt_descrip.Name = "txt_descrip";
            this.txt_descrip.Size = new System.Drawing.Size(431, 22);
            this.txt_descrip.TabIndex = 4;
            this.txt_descrip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Key_Mayusculas);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 14);
            this.label1.TabIndex = 10;
            this.label1.Text = "Codigo :";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Enabled = false;
            this.txt_codigo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo.Location = new System.Drawing.Point(127, 23);
            this.txt_codigo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(57, 22);
            this.txt_codigo.TabIndex = 2;
            // 
            // chk_estado
            // 
            this.chk_estado.AutoSize = true;
            this.chk_estado.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_estado.Location = new System.Drawing.Point(127, 339);
            this.chk_estado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chk_estado.Name = "chk_estado";
            this.chk_estado.Size = new System.Drawing.Size(63, 18);
            this.chk_estado.TabIndex = 20;
            this.chk_estado.Text = "Activo";
            this.chk_estado.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 14);
            this.label2.TabIndex = 14;
            this.label2.Text = "Descripcion :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 340);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 14);
            this.label3.TabIndex = 52;
            this.label3.Text = "Estado :";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.img_imagen);
            this.panel1.Location = new System.Drawing.Point(574, 163);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 139);
            this.panel1.TabIndex = 48;
            // 
            // img_imagen
            // 
            this.img_imagen.Location = new System.Drawing.Point(3, 3);
            this.img_imagen.Name = "img_imagen";
            this.img_imagen.Size = new System.Drawing.Size(174, 130);
            this.img_imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_imagen.TabIndex = 24;
            this.img_imagen.TabStop = false;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cancelar.Image")));
            this.btn_cancelar.Location = new System.Drawing.Point(478, 382);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(110, 32);
            this.btn_cancelar.TabIndex = 62;
            this.btn_cancelar.Text = "&Cancelar";
            this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.Location = new System.Drawing.Point(363, 382);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(110, 32);
            this.btn_guardar.TabIndex = 60;
            this.btn_guardar.Text = "&Guardar";
            this.btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // frmProductos_ed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(950, 417);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_guardar);
            this.Font = new System.Drawing.Font("Verdana", 9F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProductos_ed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProductos_ed";
            this.Load += new System.EventHandler(this.frmProductos_ed_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPuntoVenta)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_imagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_descrip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.CheckBox chk_estado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbo_marcas;
        private System.Windows.Forms.Button btn_buscar_imagen;
        private System.Windows.Forms.PictureBox img_imagen;
        private System.Windows.Forms.TextBox txt_obs;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbo_adespacho;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbo_sfamilias;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbo_familias;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbo_unidades;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgPuntoVenta;
    }
}