namespace Presentacion.Controles
{
    partial class MiProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MiProducto));
            this.pnl_producto = new System.Windows.Forms.Panel();
            this.lbl_precio_pr = new System.Windows.Forms.Label();
            this.lbl_descripcion_pr = new System.Windows.Forms.Label();
            this.pic_producto = new System.Windows.Forms.PictureBox();
            this.pnl_producto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_producto)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_producto
            // 
            this.pnl_producto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_producto.Controls.Add(this.lbl_precio_pr);
            this.pnl_producto.Controls.Add(this.lbl_descripcion_pr);
            this.pnl_producto.Controls.Add(this.pic_producto);
            this.pnl_producto.Location = new System.Drawing.Point(0, 1);
            this.pnl_producto.Name = "pnl_producto";
            this.pnl_producto.Size = new System.Drawing.Size(178, 191);
            this.pnl_producto.TabIndex = 0;
            // 
            // lbl_precio_pr
            // 
            this.lbl_precio_pr.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precio_pr.Location = new System.Drawing.Point(4, 154);
            this.lbl_precio_pr.Name = "lbl_precio_pr";
            this.lbl_precio_pr.Size = new System.Drawing.Size(165, 33);
            this.lbl_precio_pr.TabIndex = 5;
            this.lbl_precio_pr.Text = "0.00";
            this.lbl_precio_pr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_descripcion_pr
            // 
            this.lbl_descripcion_pr.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descripcion_pr.Location = new System.Drawing.Point(4, 115);
            this.lbl_descripcion_pr.Name = "lbl_descripcion_pr";
            this.lbl_descripcion_pr.Size = new System.Drawing.Size(168, 33);
            this.lbl_descripcion_pr.TabIndex = 4;
            this.lbl_descripcion_pr.Text = "Producto x";
            this.lbl_descripcion_pr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pic_producto
            // 
            this.pic_producto.Image = ((System.Drawing.Image)(resources.GetObject("pic_producto.Image")));
            this.pic_producto.Location = new System.Drawing.Point(32, 3);
            this.pic_producto.Name = "pic_producto";
            this.pic_producto.Size = new System.Drawing.Size(114, 97);
            this.pic_producto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_producto.TabIndex = 3;
            this.pic_producto.TabStop = false;
            // 
            // MiProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_producto);
            this.Name = "MiProducto";
            this.Size = new System.Drawing.Size(180, 195);
            this.Load += new System.EventHandler(this.MiProducto_Load);
            this.pnl_producto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_producto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_producto;
        private System.Windows.Forms.Label lbl_precio_pr;
        private System.Windows.Forms.Label lbl_descripcion_pr;
        private System.Windows.Forms.PictureBox pic_producto;
    }
}
