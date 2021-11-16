
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
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtBusquedaE = new System.Windows.Forms.TextBox();
            this.cbxCriBusquedaE = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscarE = new System.Windows.Forms.Button();
            this.dgvVehiculosE = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VAnio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VTipoMotor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvVehiculos2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuardarVehiculos = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculosE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos2)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.47846F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.25842F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.47132F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.79181F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel3.Controls.Add(this.txtBusquedaE, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.cbxCriBusquedaE, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnBuscarE, 4, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(12, 25);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(780, 47);
            this.tableLayoutPanel3.TabIndex = 125;
            // 
            // txtBusquedaE
            // 
            this.txtBusquedaE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBusquedaE.Location = new System.Drawing.Point(404, 13);
            this.txtBusquedaE.Name = "txtBusquedaE";
            this.txtBusquedaE.Size = new System.Drawing.Size(209, 20);
            this.txtBusquedaE.TabIndex = 117;
            // 
            // cbxCriBusquedaE
            // 
            this.cbxCriBusquedaE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxCriBusquedaE.FormattingEnabled = true;
            this.cbxCriBusquedaE.Items.AddRange(new object[] {
            "Marca",
            "Modelo",
            "Mostrar Todos"});
            this.cbxCriBusquedaE.Location = new System.Drawing.Point(141, 13);
            this.cbxCriBusquedaE.Name = "cbxCriBusquedaE";
            this.cbxCriBusquedaE.Size = new System.Drawing.Size(193, 21);
            this.cbxCriBusquedaE.TabIndex = 120;
            this.cbxCriBusquedaE.SelectedValueChanged += new System.EventHandler(this.cbxCriBusquedaE_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 116;
            this.label1.Text = "Criterio de busqueda:";
            // 
            // btnBuscarE
            // 
            this.btnBuscarE.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnBuscarE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(243)))));
            this.btnBuscarE.FlatAppearance.BorderSize = 0;
            this.btnBuscarE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(62)))), ((int)(((byte)(110)))));
            this.btnBuscarE.Location = new System.Drawing.Point(653, 6);
            this.btnBuscarE.Name = "btnBuscarE";
            this.btnBuscarE.Size = new System.Drawing.Size(80, 35);
            this.btnBuscarE.TabIndex = 118;
            this.btnBuscarE.Text = "Buscar";
            this.btnBuscarE.UseVisualStyleBackColor = false;
            this.btnBuscarE.Click += new System.EventHandler(this.btnBuscarE_Click);
            // 
            // dgvVehiculosE
            // 
            this.dgvVehiculosE.AllowUserToAddRows = false;
            this.dgvVehiculosE.AllowUserToDeleteRows = false;
            this.dgvVehiculosE.AllowUserToResizeColumns = false;
            this.dgvVehiculosE.AllowUserToResizeRows = false;
            this.dgvVehiculosE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVehiculosE.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVehiculosE.BackgroundColor = System.Drawing.Color.White;
            this.dgvVehiculosE.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvVehiculosE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehiculosE.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Marca,
            this.VModelo,
            this.VAnio,
            this.VTipoMotor});
            this.dgvVehiculosE.Location = new System.Drawing.Point(12, 123);
            this.dgvVehiculosE.Name = "dgvVehiculosE";
            this.dgvVehiculosE.ReadOnly = true;
            this.dgvVehiculosE.RowHeadersVisible = false;
            this.dgvVehiculosE.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVehiculosE.Size = new System.Drawing.Size(629, 138);
            this.dgvVehiculosE.TabIndex = 124;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Marca
            // 
            this.Marca.DataPropertyName = "Marca";
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            // 
            // VModelo
            // 
            this.VModelo.DataPropertyName = "Modelo";
            this.VModelo.HeaderText = "Modelo";
            this.VModelo.Name = "VModelo";
            this.VModelo.ReadOnly = true;
            // 
            // VAnio
            // 
            this.VAnio.DataPropertyName = "Anio";
            this.VAnio.HeaderText = "Año";
            this.VAnio.Name = "VAnio";
            this.VAnio.ReadOnly = true;
            // 
            // VTipoMotor
            // 
            this.VTipoMotor.DataPropertyName = "Tipo_Motor";
            this.VTipoMotor.HeaderText = "Tipo de Motor";
            this.VTipoMotor.Name = "VTipoMotor";
            this.VTipoMotor.ReadOnly = true;
            // 
            // dgvVehiculos2
            // 
            this.dgvVehiculos2.AllowUserToAddRows = false;
            this.dgvVehiculos2.AllowUserToDeleteRows = false;
            this.dgvVehiculos2.AllowUserToResizeColumns = false;
            this.dgvVehiculos2.AllowUserToResizeRows = false;
            this.dgvVehiculos2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVehiculos2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVehiculos2.BackgroundColor = System.Drawing.Color.White;
            this.dgvVehiculos2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvVehiculos2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehiculos2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgvVehiculos2.Location = new System.Drawing.Point(12, 339);
            this.dgvVehiculos2.Name = "dgvVehiculos2";
            this.dgvVehiculos2.ReadOnly = true;
            this.dgvVehiculos2.RowHeadersVisible = false;
            this.dgvVehiculos2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVehiculos2.Size = new System.Drawing.Size(629, 138);
            this.dgvVehiculos2.TabIndex = 126;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Marca";
            this.dataGridViewTextBoxColumn2.HeaderText = "Marca";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Modelo";
            this.dataGridViewTextBoxColumn3.HeaderText = "Modelo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Anio";
            this.dataGridViewTextBoxColumn4.HeaderText = "Año";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Tipo_Motor";
            this.dataGridViewTextBoxColumn5.HeaderText = "Tipo de Motor";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(243)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(62)))), ((int)(((byte)(110)))));
            this.btnAgregar.Location = new System.Drawing.Point(672, 123);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(80, 35);
            this.btnAgregar.TabIndex = 121;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(243)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(62)))), ((int)(((byte)(110)))));
            this.btnEliminar.Location = new System.Drawing.Point(672, 339);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(80, 35);
            this.btnEliminar.TabIndex = 127;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(243)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(62)))), ((int)(((byte)(110)))));
            this.btnCancelar.Location = new System.Drawing.Point(175, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(81, 30);
            this.btnCancelar.TabIndex = 128;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(364, 13);
            this.label3.TabIndex = 129;
            this.label3.Text = "¿No encuentra el vehículo?    Dirigase al apartado de Administrar Vehículos: ";
            // 
            // btnGuardarVehiculos
            // 
            this.btnGuardarVehiculos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarVehiculos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(243)))));
            this.btnGuardarVehiculos.FlatAppearance.BorderSize = 0;
            this.btnGuardarVehiculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarVehiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarVehiculos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(62)))), ((int)(((byte)(110)))));
            this.btnGuardarVehiculos.Location = new System.Drawing.Point(3, 3);
            this.btnGuardarVehiculos.Name = "btnGuardarVehiculos";
            this.btnGuardarVehiculos.Size = new System.Drawing.Size(80, 30);
            this.btnGuardarVehiculos.TabIndex = 130;
            this.btnGuardarVehiculos.Text = "Guardar";
            this.btnGuardarVehiculos.UseVisualStyleBackColor = false;
            this.btnGuardarVehiculos.Click += new System.EventHandler(this.btnGuardarVehiculos_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 267);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(613, 49);
            this.tableLayoutPanel1.TabIndex = 131;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.btnGuardarVehiculos, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnCancelar, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(202, 497);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(259, 36);
            this.tableLayoutPanel2.TabIndex = 132;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 130;
            this.label2.Text = "Lista de Vehículos:";
            // 
            // frmAgregarVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(834, 561);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvVehiculos2);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.dgvVehiculosE);
            this.Name = "frmAgregarVehiculo";
            this.Text = "frmAgregarVehiculo";
            this.Load += new System.EventHandler(this.frmAgregarVehiculo_Load);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculosE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos2)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox txtBusquedaE;
        private System.Windows.Forms.ComboBox cbxCriBusquedaE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarE;
        private System.Windows.Forms.DataGridView dgvVehiculosE;
        private System.Windows.Forms.DataGridView dgvVehiculos2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGuardarVehiculos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn VModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn VAnio;
        private System.Windows.Forms.DataGridViewTextBoxColumn VTipoMotor;
        private System.Windows.Forms.Label label2;
    }
}