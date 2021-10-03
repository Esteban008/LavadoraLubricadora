namespace LavadoraLubricadora
{
    partial class frmIngresarVehiculo
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
            this.txtIgresarMarca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxMarcasVehiculos = new System.Windows.Forms.ComboBox();
            this.lblIngresarMarca = new System.Windows.Forms.Label();
            this.lblIngresarModelo = new System.Windows.Forms.Label();
            this.cbxModeloVehiculo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIngresarModelo = new System.Windows.Forms.TextBox();
            this.lblIngresarAnio = new System.Windows.Forms.Label();
            this.cbxAnioVehiculo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIngresarAnio = new System.Windows.Forms.TextBox();
            this.btnCancelarMarca = new System.Windows.Forms.Button();
            this.btnCancelarModelo = new System.Windows.Forms.Button();
            this.btnCancelarAnio = new System.Windows.Forms.Button();
            this.btnCancelarMotor = new System.Windows.Forms.Button();
            this.lblIngresarMotor = new System.Windows.Forms.Label();
            this.cbxMotorVehiculo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIngresarMotor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtIgresarMarca
            // 
            this.txtIgresarMarca.Location = new System.Drawing.Point(423, 46);
            this.txtIgresarMarca.Name = "txtIgresarMarca";
            this.txtIgresarMarca.Size = new System.Drawing.Size(204, 20);
            this.txtIgresarMarca.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Marca:";
            // 
            // cbxMarcasVehiculos
            // 
            this.cbxMarcasVehiculos.FormattingEnabled = true;
            this.cbxMarcasVehiculos.Location = new System.Drawing.Point(94, 47);
            this.cbxMarcasVehiculos.Name = "cbxMarcasVehiculos";
            this.cbxMarcasVehiculos.Size = new System.Drawing.Size(217, 21);
            this.cbxMarcasVehiculos.TabIndex = 2;
            this.cbxMarcasVehiculos.SelectedValueChanged += new System.EventHandler(this.cbxMarcasVehiculos_SelectedValueChanged);
            // 
            // lblIngresarMarca
            // 
            this.lblIngresarMarca.AutoSize = true;
            this.lblIngresarMarca.Location = new System.Drawing.Point(331, 53);
            this.lblIngresarMarca.Name = "lblIngresarMarca";
            this.lblIngresarMarca.Size = new System.Drawing.Size(81, 13);
            this.lblIngresarMarca.TabIndex = 3;
            this.lblIngresarMarca.Text = "Ingresar Marca:";
            // 
            // lblIngresarModelo
            // 
            this.lblIngresarModelo.AutoSize = true;
            this.lblIngresarModelo.Location = new System.Drawing.Point(331, 103);
            this.lblIngresarModelo.Name = "lblIngresarModelo";
            this.lblIngresarModelo.Size = new System.Drawing.Size(86, 13);
            this.lblIngresarModelo.TabIndex = 7;
            this.lblIngresarModelo.Text = "Ingresar Modelo:";
            // 
            // cbxModeloVehiculo
            // 
            this.cbxModeloVehiculo.FormattingEnabled = true;
            this.cbxModeloVehiculo.Location = new System.Drawing.Point(94, 101);
            this.cbxModeloVehiculo.Name = "cbxModeloVehiculo";
            this.cbxModeloVehiculo.Size = new System.Drawing.Size(217, 21);
            this.cbxModeloVehiculo.TabIndex = 6;
            this.cbxModeloVehiculo.SelectedValueChanged += new System.EventHandler(this.cbxModeloVehiculo_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Modelo:";
            // 
            // txtIngresarModelo
            // 
            this.txtIngresarModelo.Location = new System.Drawing.Point(423, 100);
            this.txtIngresarModelo.Name = "txtIngresarModelo";
            this.txtIngresarModelo.Size = new System.Drawing.Size(204, 20);
            this.txtIngresarModelo.TabIndex = 4;
            // 
            // lblIngresarAnio
            // 
            this.lblIngresarAnio.AutoSize = true;
            this.lblIngresarAnio.Location = new System.Drawing.Point(331, 207);
            this.lblIngresarAnio.Name = "lblIngresarAnio";
            this.lblIngresarAnio.Size = new System.Drawing.Size(70, 13);
            this.lblIngresarAnio.TabIndex = 11;
            this.lblIngresarAnio.Text = "Ingresar Año:";
            // 
            // cbxAnioVehiculo
            // 
            this.cbxAnioVehiculo.FormattingEnabled = true;
            this.cbxAnioVehiculo.Location = new System.Drawing.Point(94, 204);
            this.cbxAnioVehiculo.Name = "cbxAnioVehiculo";
            this.cbxAnioVehiculo.Size = new System.Drawing.Size(217, 21);
            this.cbxAnioVehiculo.TabIndex = 10;
            this.cbxAnioVehiculo.SelectedValueChanged += new System.EventHandler(this.cbxAnioVehiculo_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Año:";
            // 
            // txtIngresarAnio
            // 
            this.txtIngresarAnio.Location = new System.Drawing.Point(423, 203);
            this.txtIngresarAnio.Name = "txtIngresarAnio";
            this.txtIngresarAnio.Size = new System.Drawing.Size(204, 20);
            this.txtIngresarAnio.TabIndex = 8;
            // 
            // btnCancelarMarca
            // 
            this.btnCancelarMarca.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelarMarca.FlatAppearance.BorderSize = 0;
            this.btnCancelarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarMarca.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancelarMarca.Location = new System.Drawing.Point(651, 42);
            this.btnCancelarMarca.Name = "btnCancelarMarca";
            this.btnCancelarMarca.Size = new System.Drawing.Size(137, 26);
            this.btnCancelarMarca.TabIndex = 12;
            this.btnCancelarMarca.Text = "Cancelar";
            this.btnCancelarMarca.UseVisualStyleBackColor = false;
            this.btnCancelarMarca.Click += new System.EventHandler(this.btnCancelarMarca_Click);
            // 
            // btnCancelarModelo
            // 
            this.btnCancelarModelo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelarModelo.FlatAppearance.BorderSize = 0;
            this.btnCancelarModelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarModelo.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancelarModelo.Location = new System.Drawing.Point(651, 95);
            this.btnCancelarModelo.Name = "btnCancelarModelo";
            this.btnCancelarModelo.Size = new System.Drawing.Size(137, 26);
            this.btnCancelarModelo.TabIndex = 13;
            this.btnCancelarModelo.Text = "Cancelar";
            this.btnCancelarModelo.UseVisualStyleBackColor = false;
            this.btnCancelarModelo.Click += new System.EventHandler(this.btnCancelarModelo_Click);
            // 
            // btnCancelarAnio
            // 
            this.btnCancelarAnio.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelarAnio.FlatAppearance.BorderSize = 0;
            this.btnCancelarAnio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarAnio.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancelarAnio.Location = new System.Drawing.Point(651, 199);
            this.btnCancelarAnio.Name = "btnCancelarAnio";
            this.btnCancelarAnio.Size = new System.Drawing.Size(137, 26);
            this.btnCancelarAnio.TabIndex = 14;
            this.btnCancelarAnio.Text = "Cancelar";
            this.btnCancelarAnio.UseVisualStyleBackColor = false;
            this.btnCancelarAnio.Click += new System.EventHandler(this.btnCancelarAnio_Click);
            // 
            // btnCancelarMotor
            // 
            this.btnCancelarMotor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelarMotor.FlatAppearance.BorderSize = 0;
            this.btnCancelarMotor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarMotor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarMotor.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancelarMotor.Location = new System.Drawing.Point(651, 148);
            this.btnCancelarMotor.Name = "btnCancelarMotor";
            this.btnCancelarMotor.Size = new System.Drawing.Size(137, 26);
            this.btnCancelarMotor.TabIndex = 19;
            this.btnCancelarMotor.Text = "Cancelar";
            this.btnCancelarMotor.UseVisualStyleBackColor = false;
            this.btnCancelarMotor.Click += new System.EventHandler(this.btnCancelarMotor_Click);
            // 
            // lblIngresarMotor
            // 
            this.lblIngresarMotor.AutoSize = true;
            this.lblIngresarMotor.Location = new System.Drawing.Point(331, 156);
            this.lblIngresarMotor.Name = "lblIngresarMotor";
            this.lblIngresarMotor.Size = new System.Drawing.Size(78, 13);
            this.lblIngresarMotor.TabIndex = 18;
            this.lblIngresarMotor.Text = "Ingresar Motor:";
            // 
            // cbxMotorVehiculo
            // 
            this.cbxMotorVehiculo.FormattingEnabled = true;
            this.cbxMotorVehiculo.Location = new System.Drawing.Point(94, 153);
            this.cbxMotorVehiculo.Name = "cbxMotorVehiculo";
            this.cbxMotorVehiculo.Size = new System.Drawing.Size(217, 21);
            this.cbxMotorVehiculo.TabIndex = 17;
            this.cbxMotorVehiculo.SelectedValueChanged += new System.EventHandler(this.cbxMotorVehiculo_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Motor:";
            // 
            // txtIngresarMotor
            // 
            this.txtIngresarMotor.Location = new System.Drawing.Point(423, 152);
            this.txtIngresarMotor.Name = "txtIngresarMotor";
            this.txtIngresarMotor.Size = new System.Drawing.Size(204, 20);
            this.txtIngresarMotor.TabIndex = 15;
            // 
            // frmIngresarVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelarMotor);
            this.Controls.Add(this.lblIngresarMotor);
            this.Controls.Add(this.cbxMotorVehiculo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIngresarMotor);
            this.Controls.Add(this.btnCancelarAnio);
            this.Controls.Add(this.btnCancelarModelo);
            this.Controls.Add(this.btnCancelarMarca);
            this.Controls.Add(this.lblIngresarAnio);
            this.Controls.Add(this.cbxAnioVehiculo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIngresarAnio);
            this.Controls.Add(this.lblIngresarModelo);
            this.Controls.Add(this.cbxModeloVehiculo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIngresarModelo);
            this.Controls.Add(this.lblIngresarMarca);
            this.Controls.Add(this.cbxMarcasVehiculos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIgresarMarca);
            this.Name = "frmIngresarVehiculo";
            this.Text = "frmIngresarVehiculo";
            this.Load += new System.EventHandler(this.frmIngresarVehiculo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIgresarMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxMarcasVehiculos;
        private System.Windows.Forms.Label lblIngresarMarca;
        private System.Windows.Forms.Label lblIngresarModelo;
        private System.Windows.Forms.ComboBox cbxModeloVehiculo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIngresarModelo;
        private System.Windows.Forms.Label lblIngresarAnio;
        private System.Windows.Forms.ComboBox cbxAnioVehiculo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIngresarAnio;
        private System.Windows.Forms.Button btnCancelarMarca;
        private System.Windows.Forms.Button btnCancelarModelo;
        private System.Windows.Forms.Button btnCancelarAnio;
        private System.Windows.Forms.Button btnCancelarMotor;
        private System.Windows.Forms.Label lblIngresarMotor;
        private System.Windows.Forms.ComboBox cbxMotorVehiculo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIngresarMotor;
    }
}