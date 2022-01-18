namespace LavadoraLubricadora
{
    partial class frmGenerarReportes
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
            this.rpvComprobantes = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ComprobanteVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ComprobanteVentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProveedorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rpvComprobantes
            // 
            reportDataSource1.Name = "comprobantes";
            reportDataSource1.Value = this.ComprobanteVentaBindingSource;
            this.rpvComprobantes.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvComprobantes.LocalReport.ReportEmbeddedResource = "LavadoraLubricadora.Report.ComprobantesVenta.rdlc";
            this.rpvComprobantes.Location = new System.Drawing.Point(224, 12);
            this.rpvComprobantes.Name = "rpvComprobantes";
            this.rpvComprobantes.ServerReport.BearerToken = null;
            this.rpvComprobantes.Size = new System.Drawing.Size(396, 246);
            this.rpvComprobantes.TabIndex = 0;
            // 
            // ComprobanteVentaBindingSource
            // 
            this.ComprobanteVentaBindingSource.DataSource = typeof(LavadoraLubricadora.LavadoraService.ComprobanteVenta);
            // 
            // ProveedorBindingSource
            // 
            this.ProveedorBindingSource.DataSource = typeof(LavadoraLubricadora.LavadoraService.Proveedor);
            // 
            // frmGenerarReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpvComprobantes);
            this.Name = "frmGenerarReportes";
            this.Text = "frmGenerarReportes";
            this.Load += new System.EventHandler(this.frmGenerarReportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ComprobanteVentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProveedorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource ComprobanteVentaBindingSource;
        private System.Windows.Forms.BindingSource ProveedorBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer rpvComprobantes;
    }
}