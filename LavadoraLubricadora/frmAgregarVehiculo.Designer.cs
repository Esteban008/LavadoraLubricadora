
namespace LavadoraLubricadora
{
    partial class frmAgregarVehiculo
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
            this.dgvVehiculos = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxCriBusqueda = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblIngresarMotor = new System.Windows.Forms.Label();
            this.cbxMotorVehiculo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIngresarMotor = new System.Windows.Forms.TextBox();
            this.btnCancelarIngreso = new System.Windows.Forms.Button();
            this.lblIngresarAnio = new System.Windows.Forms.Label();
            this.cbxAnioVehiculo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIngresarAnio = new System.Windows.Forms.TextBox();
            this.lblIngresarModelo = new System.Windows.Forms.Label();
            this.cbxModeloVehiculo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIngresarModelo = new System.Windows.Forms.TextBox();
            this.lblIngresarMarca = new System.Windows.Forms.Label();
            this.cbxMarcasVehiculos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIngresarMarca = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAgregarVehiculo = new System.Windows.Forms.Button();
            this.btnEliminarVehiculo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.dgvVehiculos.Location = new System.Drawing.Point(15, 105);
            this.dgvVehiculos.Name = "dgvVehiculos";
            this.dgvVehiculos.ReadOnly = true;
            this.dgvVehiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVehiculos.Size = new System.Drawing.Size(580, 180);
            this.dgvVehiculos.TabIndex = 50;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBuscar.Location = new System.Drawing.Point(500, 37);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(86, 36);
            this.btnBuscar.TabIndex = 54;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(298, 43);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(135, 20);
            this.txtBusqueda.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "Criterio de busqueda:";
            // 
            // cbxCriBusqueda
            // 
            this.cbxCriBusqueda.FormattingEnabled = true;
            this.cbxCriBusqueda.Items.AddRange(new object[] {
            "Marca",
            "Modelo",
            "Mostrar Todos"});
            this.cbxCriBusqueda.Location = new System.Drawing.Point(129, 43);
            this.cbxCriBusqueda.Name = "cbxCriBusqueda";
            this.cbxCriBusqueda.Size = new System.Drawing.Size(121, 21);
            this.cbxCriBusqueda.TabIndex = 51;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAgregar.Location = new System.Drawing.Point(546, 350);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(86, 36);
            this.btnAgregar.TabIndex = 55;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalir.Location = new System.Drawing.Point(684, 350);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(86, 36);
            this.btnSalir.TabIndex = 56;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1324, 559);
            this.tabControl1.TabIndex = 57;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnEliminarVehiculo);
            this.tabPage1.Controls.Add(this.btnAgregarVehiculo);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.dgvVehiculos);
            this.tabPage1.Controls.Add(this.btnSalir);
            this.tabPage1.Controls.Add(this.cbxCriBusqueda);
            this.tabPage1.Controls.Add(this.btnAgregar);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnBuscar);
            this.tabPage1.Controls.Add(this.txtBusqueda);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1316, 533);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Agregar Vehículos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnEliminar);
            this.tabPage2.Controls.Add(this.btnEditar);
            this.tabPage2.Controls.Add(this.btnNuevo);
            this.tabPage2.Controls.Add(this.btnGuardar);
            this.tabPage2.Controls.Add(this.btnCancelar);
            this.tabPage2.Controls.Add(this.lblIngresarMotor);
            this.tabPage2.Controls.Add(this.cbxMotorVehiculo);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtIngresarMotor);
            this.tabPage2.Controls.Add(this.btnCancelarIngreso);
            this.tabPage2.Controls.Add(this.lblIngresarAnio);
            this.tabPage2.Controls.Add(this.cbxAnioVehiculo);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtIngresarAnio);
            this.tabPage2.Controls.Add(this.lblIngresarModelo);
            this.tabPage2.Controls.Add(this.cbxModeloVehiculo);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtIngresarModelo);
            this.tabPage2.Controls.Add(this.lblIngresarMarca);
            this.tabPage2.Controls.Add(this.cbxMarcasVehiculos);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtIngresarMarca);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1316, 533);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ingresar Vehículo ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEliminar.Location = new System.Drawing.Point(244, 364);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(86, 36);
            this.btnEliminar.TabIndex = 70;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEditar.Location = new System.Drawing.Point(244, 280);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(86, 36);
            this.btnEditar.TabIndex = 69;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNuevo.Location = new System.Drawing.Point(244, 227);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(86, 36);
            this.btnNuevo.TabIndex = 68;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGuardar.Location = new System.Drawing.Point(244, 322);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(86, 36);
            this.btnGuardar.TabIndex = 67;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.Location = new System.Drawing.Point(312, 462);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(137, 26);
            this.btnCancelar.TabIndex = 66;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // lblIngresarMotor
            // 
            this.lblIngresarMotor.AutoSize = true;
            this.lblIngresarMotor.Location = new System.Drawing.Point(299, 175);
            this.lblIngresarMotor.Name = "lblIngresarMotor";
            this.lblIngresarMotor.Size = new System.Drawing.Size(78, 13);
            this.lblIngresarMotor.TabIndex = 65;
            this.lblIngresarMotor.Text = "Ingresar Motor:";
            // 
            // cbxMotorVehiculo
            // 
            this.cbxMotorVehiculo.FormattingEnabled = true;
            this.cbxMotorVehiculo.Location = new System.Drawing.Point(62, 172);
            this.cbxMotorVehiculo.Name = "cbxMotorVehiculo";
            this.cbxMotorVehiculo.Size = new System.Drawing.Size(217, 21);
            this.cbxMotorVehiculo.TabIndex = 64;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 63;
            this.label4.Text = "Motor:";
            // 
            // txtIngresarMotor
            // 
            this.txtIngresarMotor.Location = new System.Drawing.Point(391, 171);
            this.txtIngresarMotor.Name = "txtIngresarMotor";
            this.txtIngresarMotor.Size = new System.Drawing.Size(204, 20);
            this.txtIngresarMotor.TabIndex = 62;
            // 
            // btnCancelarIngreso
            // 
            this.btnCancelarIngreso.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelarIngreso.FlatAppearance.BorderSize = 0;
            this.btnCancelarIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarIngreso.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancelarIngreso.Location = new System.Drawing.Point(509, 218);
            this.btnCancelarIngreso.Name = "btnCancelarIngreso";
            this.btnCancelarIngreso.Size = new System.Drawing.Size(86, 32);
            this.btnCancelarIngreso.TabIndex = 61;
            this.btnCancelarIngreso.Text = "Cancelar";
            this.btnCancelarIngreso.UseVisualStyleBackColor = false;
            // 
            // lblIngresarAnio
            // 
            this.lblIngresarAnio.AutoSize = true;
            this.lblIngresarAnio.Location = new System.Drawing.Point(299, 130);
            this.lblIngresarAnio.Name = "lblIngresarAnio";
            this.lblIngresarAnio.Size = new System.Drawing.Size(70, 13);
            this.lblIngresarAnio.TabIndex = 60;
            this.lblIngresarAnio.Text = "Ingresar Año:";
            // 
            // cbxAnioVehiculo
            // 
            this.cbxAnioVehiculo.FormattingEnabled = true;
            this.cbxAnioVehiculo.Location = new System.Drawing.Point(62, 127);
            this.cbxAnioVehiculo.Name = "cbxAnioVehiculo";
            this.cbxAnioVehiculo.Size = new System.Drawing.Size(217, 21);
            this.cbxAnioVehiculo.TabIndex = 59;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 58;
            this.label5.Text = "Año:";
            // 
            // txtIngresarAnio
            // 
            this.txtIngresarAnio.Location = new System.Drawing.Point(391, 126);
            this.txtIngresarAnio.Name = "txtIngresarAnio";
            this.txtIngresarAnio.Size = new System.Drawing.Size(204, 20);
            this.txtIngresarAnio.TabIndex = 57;
            // 
            // lblIngresarModelo
            // 
            this.lblIngresarModelo.AutoSize = true;
            this.lblIngresarModelo.Location = new System.Drawing.Point(299, 82);
            this.lblIngresarModelo.Name = "lblIngresarModelo";
            this.lblIngresarModelo.Size = new System.Drawing.Size(86, 13);
            this.lblIngresarModelo.TabIndex = 56;
            this.lblIngresarModelo.Text = "Ingresar Modelo:";
            // 
            // cbxModeloVehiculo
            // 
            this.cbxModeloVehiculo.FormattingEnabled = true;
            this.cbxModeloVehiculo.Location = new System.Drawing.Point(62, 80);
            this.cbxModeloVehiculo.Name = "cbxModeloVehiculo";
            this.cbxModeloVehiculo.Size = new System.Drawing.Size(217, 21);
            this.cbxModeloVehiculo.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "Modelo:";
            // 
            // txtIngresarModelo
            // 
            this.txtIngresarModelo.Location = new System.Drawing.Point(391, 79);
            this.txtIngresarModelo.Name = "txtIngresarModelo";
            this.txtIngresarModelo.Size = new System.Drawing.Size(204, 20);
            this.txtIngresarModelo.TabIndex = 53;
            // 
            // lblIngresarMarca
            // 
            this.lblIngresarMarca.AutoSize = true;
            this.lblIngresarMarca.Location = new System.Drawing.Point(299, 32);
            this.lblIngresarMarca.Name = "lblIngresarMarca";
            this.lblIngresarMarca.Size = new System.Drawing.Size(81, 13);
            this.lblIngresarMarca.TabIndex = 52;
            this.lblIngresarMarca.Text = "Ingresar Marca:";
            // 
            // cbxMarcasVehiculos
            // 
            this.cbxMarcasVehiculos.FormattingEnabled = true;
            this.cbxMarcasVehiculos.Location = new System.Drawing.Point(62, 26);
            this.cbxMarcasVehiculos.Name = "cbxMarcasVehiculos";
            this.cbxMarcasVehiculos.Size = new System.Drawing.Size(217, 21);
            this.cbxMarcasVehiculos.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Marca:";
            // 
            // txtIngresarMarca
            // 
            this.txtIngresarMarca.Location = new System.Drawing.Point(391, 25);
            this.txtIngresarMarca.Name = "txtIngresarMarca";
            this.txtIngresarMarca.Size = new System.Drawing.Size(204, 20);
            this.txtIngresarMarca.TabIndex = 49;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(721, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(580, 180);
            this.dataGridView1.TabIndex = 57;
            // 
            // btnAgregarVehiculo
            // 
            this.btnAgregarVehiculo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregarVehiculo.FlatAppearance.BorderSize = 0;
            this.btnAgregarVehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarVehiculo.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAgregarVehiculo.Location = new System.Drawing.Point(615, 155);
            this.btnAgregarVehiculo.Name = "btnAgregarVehiculo";
            this.btnAgregarVehiculo.Size = new System.Drawing.Size(86, 36);
            this.btnAgregarVehiculo.TabIndex = 58;
            this.btnAgregarVehiculo.Text = ">";
            this.btnAgregarVehiculo.UseVisualStyleBackColor = false;
            // 
            // btnEliminarVehiculo
            // 
            this.btnEliminarVehiculo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEliminarVehiculo.FlatAppearance.BorderSize = 0;
            this.btnEliminarVehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarVehiculo.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEliminarVehiculo.Location = new System.Drawing.Point(615, 197);
            this.btnEliminarVehiculo.Name = "btnEliminarVehiculo";
            this.btnEliminarVehiculo.Size = new System.Drawing.Size(86, 36);
            this.btnEliminarVehiculo.TabIndex = 59;
            this.btnEliminarVehiculo.Text = "<";
            this.btnEliminarVehiculo.UseVisualStyleBackColor = false;
            // 
            // frmAgregarVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 588);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmAgregarVehiculo";
            this.Text = "frmAgregarVehiculo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVehiculos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxCriBusqueda;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblIngresarMotor;
        private System.Windows.Forms.ComboBox cbxMotorVehiculo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIngresarMotor;
        private System.Windows.Forms.Button btnCancelarIngreso;
        private System.Windows.Forms.Label lblIngresarAnio;
        private System.Windows.Forms.ComboBox cbxAnioVehiculo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIngresarAnio;
        private System.Windows.Forms.Label lblIngresarModelo;
        private System.Windows.Forms.ComboBox cbxModeloVehiculo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIngresarModelo;
        private System.Windows.Forms.Label lblIngresarMarca;
        private System.Windows.Forms.ComboBox cbxMarcasVehiculos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIngresarMarca;
        private System.Windows.Forms.Button btnEliminarVehiculo;
        private System.Windows.Forms.Button btnAgregarVehiculo;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}