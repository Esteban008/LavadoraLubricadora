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
            this.ComprobanteVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ComprobanteVentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProveedorBindingSource)).BeginInit();
            this.SuspendLayout();
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
    }
}