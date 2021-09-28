namespace LavadoraLubricadora
{
    partial class frmBusquedaProductos
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxTipoProducto = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCriterioBusqueda = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbxViscocidad = new System.Windows.Forms.ComboBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(391, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "FORMULARIO DE BUSQUEDA";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalir.Location = new System.Drawing.Point(759, 552);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(86, 36);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Seleccione el Tipo de Producto:";
            // 
            // cbxTipoProducto
            // 
            this.cbxTipoProducto.FormattingEnabled = true;
            this.cbxTipoProducto.Location = new System.Drawing.Point(177, 68);
            this.cbxTipoProducto.Name = "cbxTipoProducto";
            this.cbxTipoProducto.Size = new System.Drawing.Size(158, 21);
            this.cbxTipoProducto.TabIndex = 4;
            this.cbxTipoProducto.SelectedValueChanged += new System.EventHandler(this.cbxTipoProducto_SelectedValueChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(15, 95);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(830, 1);
            this.panel3.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 11;
            // 
            // lblCriterioBusqueda
            // 
            this.lblCriterioBusqueda.AutoSize = true;
            this.lblCriterioBusqueda.Location = new System.Drawing.Point(12, 113);
            this.lblCriterioBusqueda.Name = "lblCriterioBusqueda";
            this.lblCriterioBusqueda.Size = new System.Drawing.Size(90, 13);
            this.lblCriterioBusqueda.TabIndex = 12;
            this.lblCriterioBusqueda.Text = "Criterio Busqueda";
            this.lblCriterioBusqueda.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 261);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(825, 219);
            this.dataGridView1.TabIndex = 14;
            // 
            // cbxViscocidad
            // 
            this.cbxViscocidad.FormattingEnabled = true;
            this.cbxViscocidad.Location = new System.Drawing.Point(177, 110);
            this.cbxViscocidad.Name = "cbxViscocidad";
            this.cbxViscocidad.Size = new System.Drawing.Size(158, 21);
            this.cbxViscocidad.TabIndex = 16;
            this.cbxViscocidad.Visible = false;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(177, 110);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(158, 20);
            this.txtBusqueda.TabIndex = 19;
            this.txtBusqueda.Visible = false;
            // 
            // frmBusquedaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 611);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.cbxViscocidad);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblCriterioBusqueda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.cbxTipoProducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label1);
            this.Name = "frmBusquedaProductos";
            this.Text = "frmBusquedaProductos";
            this.Load += new System.EventHandler(this.frmBusquedaProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxTipoProducto;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCriterioBusqueda;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbxViscocidad;
        private System.Windows.Forms.TextBox txtBusqueda;
    }
}