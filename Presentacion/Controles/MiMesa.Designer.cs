namespace Presentacion.Controles
{
    partial class MiMesa
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MiMesa));
            this.pnl_mesa = new System.Windows.Forms.Panel();
            this.lbl_descripcion_me = new System.Windows.Forms.Label();
            this.pic_estado = new System.Windows.Forms.PictureBox();
            this.pic_ImagenMesa = new System.Windows.Forms.PictureBox();
            this.pnl_mesa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_estado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ImagenMesa)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_mesa
            // 
            this.pnl_mesa.BackColor = System.Drawing.Color.Lavender;
            this.pnl_mesa.Controls.Add(this.lbl_descripcion_me);
            this.pnl_mesa.Controls.Add(this.pic_estado);
            this.pnl_mesa.Controls.Add(this.pic_ImagenMesa);
            this.pnl_mesa.Location = new System.Drawing.Point(2, 3);
            this.pnl_mesa.Name = "pnl_mesa";
            this.pnl_mesa.Size = new System.Drawing.Size(126, 131);
            this.pnl_mesa.TabIndex = 0;
            // 
            // lbl_descripcion_me
            // 
            this.lbl_descripcion_me.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descripcion_me.Location = new System.Drawing.Point(6, 111);
            this.lbl_descripcion_me.Name = "lbl_descripcion_me";
            this.lbl_descripcion_me.Size = new System.Drawing.Size(115, 16);
            this.lbl_descripcion_me.TabIndex = 2;
            this.lbl_descripcion_me.Text = "Mesa X";
            this.lbl_descripcion_me.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pic_estado
            // 
            this.pic_estado.Image = ((System.Drawing.Image)(resources.GetObject("pic_estado.Image")));
            this.pic_estado.Location = new System.Drawing.Point(51, 2);
            this.pic_estado.Name = "pic_estado";
            this.pic_estado.Size = new System.Drawing.Size(24, 22);
            this.pic_estado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_estado.TabIndex = 1;
            this.pic_estado.TabStop = false;
            // 
            // pic_ImagenMesa
            // 
            this.pic_ImagenMesa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_ImagenMesa.Image = ((System.Drawing.Image)(resources.GetObject("pic_ImagenMesa.Image")));
            this.pic_ImagenMesa.Location = new System.Drawing.Point(19, 26);
            this.pic_ImagenMesa.Name = "pic_ImagenMesa";
            this.pic_ImagenMesa.Size = new System.Drawing.Size(88, 84);
            this.pic_ImagenMesa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_ImagenMesa.TabIndex = 0;
            this.pic_ImagenMesa.TabStop = false;
            this.pic_ImagenMesa.Click += new System.EventHandler(this.pic_ImagenMesa_Click);
            // 
            // MiMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_mesa);
            this.Name = "MiMesa";
            this.Size = new System.Drawing.Size(131, 137);
            this.Load += new System.EventHandler(this.MiMesa_Load);
            this.pnl_mesa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_estado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ImagenMesa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_mesa;
        private System.Windows.Forms.PictureBox pic_ImagenMesa;
        private System.Windows.Forms.Label lbl_descripcion_me;
        private System.Windows.Forms.PictureBox pic_estado;
    }
}
