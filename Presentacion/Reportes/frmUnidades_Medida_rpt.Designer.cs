namespace Presentacion.Reportes
{
    partial class frmUnidades_Medida_rpt
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dS_Reportes = new Presentacion.Reportes.DS_Reportes();
            this.spListadoUnidades_MedidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spListado_Unidades_MedidaTableAdapter = new Presentacion.Reportes.DS_ReportesTableAdapters.spListado_Unidades_MedidaTableAdapter();
            this.txt_texto = new System.Windows.Forms.TextBox();
            this.chk_estado = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Reportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spListadoUnidades_MedidaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spListadoUnidades_MedidaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Presentacion.Reportes.rptUnidades_Medida.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 549);
            this.reportViewer1.TabIndex = 0;
            // 
            // dS_Reportes
            // 
            this.dS_Reportes.DataSetName = "DS_Reportes";
            this.dS_Reportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spListadoUnidades_MedidaBindingSource
            // 
            this.spListadoUnidades_MedidaBindingSource.DataMember = "spListado_Unidades_Medida";
            this.spListadoUnidades_MedidaBindingSource.DataSource = this.dS_Reportes;
            // 
            // spListado_Unidades_MedidaTableAdapter
            // 
            this.spListado_Unidades_MedidaTableAdapter.ClearBeforeFill = true;
            // 
            // txt_texto
            // 
            this.txt_texto.Location = new System.Drawing.Point(48, 71);
            this.txt_texto.Name = "txt_texto";
            this.txt_texto.Size = new System.Drawing.Size(100, 20);
            this.txt_texto.TabIndex = 1;
            this.txt_texto.Visible = false;
            // 
            // chk_estado
            // 
            this.chk_estado.AutoSize = true;
            this.chk_estado.Location = new System.Drawing.Point(48, 108);
            this.chk_estado.Name = "chk_estado";
            this.chk_estado.Size = new System.Drawing.Size(61, 17);
            this.chk_estado.TabIndex = 2;
            this.chk_estado.Text = "Activos";
            this.chk_estado.UseVisualStyleBackColor = true;
            this.chk_estado.Visible = false;
            // 
            // frmUnidades_Medida_rpt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 549);
            this.Controls.Add(this.chk_estado);
            this.Controls.Add(this.txt_texto);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmUnidades_Medida_rpt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUnidades_Medida_rpt";
            this.Load += new System.EventHandler(this.frmUnidades_Medida_rpt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS_Reportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spListadoUnidades_MedidaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spListadoUnidades_MedidaBindingSource;
        private DS_Reportes dS_Reportes;
        private DS_ReportesTableAdapters.spListado_Unidades_MedidaTableAdapter spListado_Unidades_MedidaTableAdapter;
        public System.Windows.Forms.TextBox txt_texto;
        public System.Windows.Forms.CheckBox chk_estado;
    }
}