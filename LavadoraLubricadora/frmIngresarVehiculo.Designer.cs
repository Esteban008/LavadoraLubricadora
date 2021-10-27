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
            this.txtIngresarMarca = new System.Windows.Forms.TextBox();
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
            this.btnCancelarIngreso = new System.Windows.Forms.Button();
            this.lblIngresarMotor = new System.Windows.Forms.Label();
            this.cbxMotorVehiculo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIngresarMotor = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgvVehiculos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIngresarMarca
            // 
            this.txtIngresarMarca.Location = new System.Drawing.Point(431, 329);
            this.txtIngresarMarca.Name = "txtIngresarMarca";
            this.txtIngresarMarca.Size = new System.Drawing.Size(204, 20);
            this.txtIngresarMarca.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Marca:";
            // 
            // cbxMarcasVehiculos
            // 
            this.cbxMarcasVehiculos.FormattingEnabled = true;
            this.cbxMarcasVehiculos.Location = new System.Drawing.Point(102, 330);
            this.cbxMarcasVehiculos.Name = "cbxMarcasVehiculos";
            this.cbxMarcasVehiculos.Size = new System.Drawing.Size(217, 21);
            this.cbxMarcasVehiculos.TabIndex = 2;
            this.cbxMarcasVehiculos.SelectedValueChanged += new System.EventHandler(this.cbxMarcasVehiculos_SelectedValueChanged);
            // 
            // lblIngresarMarca
            // 
            this.lblIngresarMarca.AutoSize = true;
            this.lblIngresarMarca.Location = new System.Drawing.Point(339, 336);
            this.lblIngresarMarca.Name = "lblIngresarMarca";
            this.lblIngresarMarca.Size = new System.Drawing.Size(81, 13);
            this.lblIngresarMarca.TabIndex = 3;
            this.lblIngresarMarca.Text = "Ingresar Marca:";
            // 
            // lblIngresarModelo
            // 
            this.lblIngresarModelo.AutoSize = true;
            this.lblIngresarModelo.Location = new System.Drawing.Point(339, 386);
            this.lblIngresarModelo.Name = "lblIngresarModelo";
            this.lblIngresarModelo.Size = new System.Drawing.Size(86, 13);
            this.lblIngresarModelo.TabIndex = 7;
            this.lblIngresarModelo.Text = "Ingresar Modelo:";
            // 
            // cbxModeloVehiculo
            // 
            this.cbxModeloVehiculo.FormattingEnabled = true;
            this.cbxModeloVehiculo.Location = new System.Drawing.Point(102, 384);
            this.cbxModeloVehiculo.Name = "cbxModeloVehiculo";
            this.cbxModeloVehiculo.Size = new System.Drawing.Size(217, 21);
            this.cbxModeloVehiculo.TabIndex = 6;
            this.cbxModeloVehiculo.SelectedValueChanged += new System.EventHandler(this.cbxModeloVehiculo_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 387);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Modelo:";
            // 
            // txtIngresarModelo
            // 
            this.txtIngresarModelo.Location = new System.Drawing.Point(431, 383);
            this.txtIngresarModelo.Name = "txtIngresarModelo";
            this.txtIngresarModelo.Size = new System.Drawing.Size(204, 20);
            this.txtIngresarModelo.TabIndex = 4;
            // 
            // lblIngresarAnio
            // 
            this.lblIngresarAnio.AutoSize = true;
            this.lblIngresarAnio.Location = new System.Drawing.Point(339, 434);
            this.lblIngresarAnio.Name = "lblIngresarAnio";
            this.lblIngresarAnio.Size = new System.Drawing.Size(70, 13);
            this.lblIngresarAnio.TabIndex = 11;
            this.lblIngresarAnio.Text = "Ingresar Año:";
            // 
            // cbxAnioVehiculo
            // 
            this.cbxAnioVehiculo.FormattingEnabled = true;
            this.cbxAnioVehiculo.Location = new System.Drawing.Point(102, 431);
            this.cbxAnioVehiculo.Name = "cbxAnioVehiculo";
            this.cbxAnioVehiculo.Size = new System.Drawing.Size(217, 21);
            this.cbxAnioVehiculo.TabIndex = 10;
            this.cbxAnioVehiculo.SelectedValueChanged += new System.EventHandler(this.cbxAnioVehiculo_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 434);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Año:";
            // 
            // txtIngresarAnio
            // 
            this.txtIngresarAnio.Location = new System.Drawing.Point(431, 430);
            this.txtIngresarAnio.Name = "txtIngresarAnio";
            this.txtIngresarAnio.Size = new System.Drawing.Size(204, 20);
            this.txtIngresarAnio.TabIndex = 8;
            // 
            // btnCancelarIngreso
            // 
            this.btnCancelarIngreso.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelarIngreso.FlatAppearance.BorderSize = 0;
            this.btnCancelarIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarIngreso.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancelarIngreso.Location = new System.Drawing.Point(549, 522);
            this.btnCancelarIngreso.Name = "btnCancelarIngreso";
            this.btnCancelarIngreso.Size = new System.Drawing.Size(86, 32);
            this.btnCancelarIngreso.TabIndex = 12;
            this.btnCancelarIngreso.Text = "Cancelar";
            this.btnCancelarIngreso.UseVisualStyleBackColor = false;
            this.btnCancelarIngreso.Click += new System.EventHandler(this.btnCancelarIngreso_Click);
            // 
            // lblIngresarMotor
            // 
            this.lblIngresarMotor.AutoSize = true;
            this.lblIngresarMotor.Location = new System.Drawing.Point(339, 479);
            this.lblIngresarMotor.Name = "lblIngresarMotor";
            this.lblIngresarMotor.Size = new System.Drawing.Size(78, 13);
            this.lblIngresarMotor.TabIndex = 18;
            this.lblIngresarMotor.Text = "Ingresar Motor:";
            // 
            // cbxMotorVehiculo
            // 
            this.cbxMotorVehiculo.FormattingEnabled = true;
            this.cbxMotorVehiculo.Location = new System.Drawing.Point(102, 476);
            this.cbxMotorVehiculo.Name = "cbxMotorVehiculo";
            this.cbxMotorVehiculo.Size = new System.Drawing.Size(217, 21);
            this.cbxMotorVehiculo.TabIndex = 17;
            this.cbxMotorVehiculo.SelectedValueChanged += new System.EventHandler(this.cbxMotorVehiculo_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 479);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Motor:";
            // 
            // txtIngresarMotor
            // 
            this.txtIngresarMotor.Location = new System.Drawing.Point(431, 475);
            this.txtIngresarMotor.Name = "txtIngresarMotor";
            this.txtIngresarMotor.Size = new System.Drawing.Size(204, 20);
            this.txtIngresarMotor.TabIndex = 15;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.Location = new System.Drawing.Point(898, 555);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(137, 26);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEliminar.Location = new System.Drawing.Point(830, 457);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(86, 36);
            this.btnEliminar.TabIndex = 48;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEditar.Location = new System.Drawing.Point(830, 373);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(86, 36);
            this.btnEditar.TabIndex = 47;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNuevo.Location = new System.Drawing.Point(830, 320);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(86, 36);
            this.btnNuevo.TabIndex = 46;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGuardar.Location = new System.Drawing.Point(830, 415);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(86, 36);
            this.btnGuardar.TabIndex = 45;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dgvVehiculos
            // 
            this.dgvVehiculos.AllowUserToAddRows = false;
            this.dgvVehiculos.AllowUserToDeleteRows = false;
            this.dgvVehiculos.AllowUserToOrderColumns = true;
            this.dgvVehiculos.AllowUserToResizeColumns = false;
            this.dgvVehiculos.AllowUserToResizeRows = false;
            this.dgvVehiculos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehiculos.Location = new System.Drawing.Point(12, 67);
            this.dgvVehiculos.Name = "dgvVehiculos";
            this.dgvVehiculos.ReadOnly = true;
            this.dgvVehiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVehiculos.Size = new System.Drawing.Size(1079, 219);
            this.dgvVehiculos.TabIndex = 49;
            this.dgvVehiculos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVehiculos_CellClick);
            // 
            // frmIngresarVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 607);
            this.Controls.Add(this.dgvVehiculos);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblIngresarMotor);
            this.Controls.Add(this.cbxMotorVehiculo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIngresarMotor);
            this.Controls.Add(this.btnCancelarIngreso);
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
            this.Controls.Add(this.txtIngresarMarca);
            this.Name = "frmIngresarVehiculo";
            this.Text = "frmIngresarVehiculo";
            this.Load += new System.EventHandler(this.frmIngresarVehiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIngresarMarca;
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
        private System.Windows.Forms.Button btnCancelarIngreso;
        private System.Windows.Forms.Label lblIngresarMotor;
        private System.Windows.Forms.ComboBox cbxMotorVehiculo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIngresarMotor;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvVehiculos;
    }
}