namespace Presentacion
{
    partial class frmMesas_ed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMesas_ed));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_descripcion_pv = new System.Windows.Forms.TextBox();
            this.txt_codigo_pv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_descrip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.chk_estado = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_descripcion_pv);
            this.groupBox1.Controls.Add(this.txt_codigo_pv);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_descrip);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_codigo);
            this.groupBox1.Controls.Add(this.chk_estado);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(564, 140);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS GENERALES";
            // 
            // txt_descripcion_pv
            // 
            this.txt_descripcion_pv.Enabled = false;
            this.txt_descripcion_pv.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descripcion_pv.Location = new System.Drawing.Point(181, 24);
            this.txt_descripcion_pv.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_descripcion_pv.Name = "txt_descripcion_pv";
            this.txt_descripcion_pv.Size = new System.Drawing.Size(378, 22);
            this.txt_descripcion_pv.TabIndex = 38;
            // 
            // txt_codigo_pv
            // 
            this.txt_codigo_pv.Enabled = false;
            this.txt_codigo_pv.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo_pv.Location = new System.Drawing.Point(128, 24);
            this.txt_codigo_pv.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_codigo_pv.Name = "txt_codigo_pv";
            this.txt_codigo_pv.Size = new System.Drawing.Size(48, 22);
            this.txt_codigo_pv.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 14);
            this.label4.TabIndex = 36;
            this.label4.Text = "Punto de Venta :";
            // 
            // txt_descrip
            // 
            this.txt_descrip.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descrip.Location = new System.Drawing.Point(128, 80);
            this.txt_descrip.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_descrip.MaxLength = 30;
            this.txt_descrip.Name = "txt_descrip";
            this.txt_descrip.Size = new System.Drawing.Size(431, 22);
            this.txt_descrip.TabIndex = 5;
            this.txt_descrip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_descrip_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Codigo :";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Enabled = false;
            this.txt_codigo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo.Location = new System.Drawing.Point(128, 52);
            this.txt_codigo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(57, 22);
            this.txt_codigo.TabIndex = 3;
            // 
            // chk_estado
            // 
            this.chk_estado.AutoSize = true;
            this.chk_estado.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_estado.Location = new System.Drawing.Point(127, 108);
            this.chk_estado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chk_estado.Name = "chk_estado";
            this.chk_estado.Size = new System.Drawing.Size(63, 18);
            this.chk_estado.TabIndex = 7;
            this.chk_estado.Text = "Activo";
            this.chk_estado.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "Descripcion :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "Estado :";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cancelar.Image")));
            this.btn_cancelar.Location = new System.Drawing.Point(294, 160);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(110, 32);
            this.btn_cancelar.TabIndex = 12;
            this.btn_cancelar.Text = "&Cancelar";
            this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.Location = new System.Drawing.Point(179, 160);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(110, 32);
            this.btn_guardar.TabIndex = 11;
            this.btn_guardar.Text = "&Guardar";
            this.btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // frmMesas_ed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(583, 201);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_guardar);
            this.Font = new System.Drawing.Font("Verdana", 9F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMesas_ed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMesas_ed";
            this.Load += new System.EventHandler(this.frmMesas_ed_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        public System.Windows.Forms.TextBox txt_descripcion_pv;
        public System.Windows.Forms.TextBox txt_codigo_pv;
        private System.Windows.Forms.Label label4;
    }
}