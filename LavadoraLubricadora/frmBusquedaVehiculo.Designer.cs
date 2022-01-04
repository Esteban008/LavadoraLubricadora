namespace LavadoraLubricadora
{
    partial class frmBusquedaVehiculo
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxMarcaVehiculo = new System.Windows.Forms.ComboBox();
            this.cbxModeloVehiculo = new System.Windows.Forms.ComboBox();
            this.cbxAnioVehiculo = new System.Windows.Forms.ComboBox();
            this.cbxMotorVehiculo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvFiltrosE = new System.Windows.Forms.DataGridView();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rosca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoFiltro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoFiltro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarcaVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModeloVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnioVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MotorVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PporMayor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PporMenor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiltrosE)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.45791F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.38826F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.27778F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.722222F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbxMarcaVehiculo, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbxModeloVehiculo, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbxAnioVehiculo, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbxMotorVehiculo, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnBuscar, 2, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(48, 23);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.45087F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.38728F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.38728F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.38728F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.38728F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(670, 166);
            this.tableLayoutPanel1.TabIndex = 128;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 127;
            this.label6.Text = "Motor:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 124;
            this.label4.Text = "Modelo:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 126;
            this.label5.Text = "Año:";
            // 
            // cbxMarcaVehiculo
            // 
            this.cbxMarcaVehiculo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbxMarcaVehiculo.FormattingEnabled = true;
            this.cbxMarcaVehiculo.Location = new System.Drawing.Point(123, 30);
            this.cbxMarcaVehiculo.Name = "cbxMarcaVehiculo";
            this.cbxMarcaVehiculo.Size = new System.Drawing.Size(220, 21);
            this.cbxMarcaVehiculo.TabIndex = 128;
            this.cbxMarcaVehiculo.SelectedValueChanged += new System.EventHandler(this.cbxMarcaVehiculo_SelectedValueChanged);
            // 
            // cbxModeloVehiculo
            // 
            this.cbxModeloVehiculo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbxModeloVehiculo.FormattingEnabled = true;
            this.cbxModeloVehiculo.Location = new System.Drawing.Point(123, 65);
            this.cbxModeloVehiculo.Name = "cbxModeloVehiculo";
            this.cbxModeloVehiculo.Size = new System.Drawing.Size(220, 21);
            this.cbxModeloVehiculo.TabIndex = 129;
            this.cbxModeloVehiculo.SelectedValueChanged += new System.EventHandler(this.cbxModeloVehiculo_SelectedValueChanged);
            // 
            // cbxAnioVehiculo
            // 
            this.cbxAnioVehiculo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbxAnioVehiculo.FormattingEnabled = true;
            this.cbxAnioVehiculo.Location = new System.Drawing.Point(123, 100);
            this.cbxAnioVehiculo.Name = "cbxAnioVehiculo";
            this.cbxAnioVehiculo.Size = new System.Drawing.Size(220, 21);
            this.cbxAnioVehiculo.TabIndex = 130;
            // 
            // cbxMotorVehiculo
            // 
            this.cbxMotorVehiculo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbxMotorVehiculo.FormattingEnabled = true;
            this.cbxMotorVehiculo.Location = new System.Drawing.Point(123, 136);
            this.cbxMotorVehiculo.Name = "cbxMotorVehiculo";
            this.cbxMotorVehiculo.Size = new System.Drawing.Size(220, 21);
            this.cbxMotorVehiculo.TabIndex = 131;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 132;
            this.label3.Text = "Marca:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label2, 6);
            this.label2.Location = new System.Drawing.Point(260, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 13);
            this.label2.TabIndex = 122;
            this.label2.Text = "BÚSQUEDA POR VEHÍCULO";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(243)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(62)))), ((int)(((byte)(110)))));
            this.btnBuscar.Location = new System.Drawing.Point(404, 131);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(76, 32);
            this.btnBuscar.TabIndex = 118;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(243)))));
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(62)))), ((int)(((byte)(110)))));
            this.btnSalir.Location = new System.Drawing.Point(632, 466);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(86, 36);
            this.btnSalir.TabIndex = 129;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvFiltrosE
            // 
            this.dgvFiltrosE.AllowUserToAddRows = false;
            this.dgvFiltrosE.AllowUserToDeleteRows = false;
            this.dgvFiltrosE.AllowUserToResizeColumns = false;
            this.dgvFiltrosE.AllowUserToResizeRows = false;
            this.dgvFiltrosE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFiltrosE.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvFiltrosE.BackgroundColor = System.Drawing.Color.White;
            this.dgvFiltrosE.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvFiltrosE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiltrosE.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Marca,
            this.ADescripcion,
            this.Rosca,
            this.TipoFiltro,
            this.CodigoFiltro,
            this.MarcaVehiculo,
            this.ModeloVehiculo,
            this.AnioVehiculo,
            this.MotorVehiculo,
            this.PporMayor,
            this.PporMenor,
            this.Cantidad});
            this.dgvFiltrosE.Location = new System.Drawing.Point(48, 231);
            this.dgvFiltrosE.Name = "dgvFiltrosE";
            this.dgvFiltrosE.ReadOnly = true;
            this.dgvFiltrosE.RowHeadersVisible = false;
            this.dgvFiltrosE.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFiltrosE.Size = new System.Drawing.Size(670, 229);
            this.dgvFiltrosE.TabIndex = 130;
            // 
            // Marca
            // 
            this.Marca.DataPropertyName = "Marca";
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            this.Marca.Width = 62;
            // 
            // ADescripcion
            // 
            this.ADescripcion.DataPropertyName = "Descripcion";
            this.ADescripcion.HeaderText = "Descripcion";
            this.ADescripcion.Name = "ADescripcion";
            this.ADescripcion.ReadOnly = true;
            this.ADescripcion.Width = 88;
            // 
            // Rosca
            // 
            this.Rosca.DataPropertyName = "Rosca";
            this.Rosca.HeaderText = "Rosca";
            this.Rosca.Name = "Rosca";
            this.Rosca.ReadOnly = true;
            this.Rosca.Width = 63;
            // 
            // TipoFiltro
            // 
            this.TipoFiltro.DataPropertyName = "Tipo_Filtro";
            this.TipoFiltro.HeaderText = "Tipo de Filtro";
            this.TipoFiltro.Name = "TipoFiltro";
            this.TipoFiltro.ReadOnly = true;
            this.TipoFiltro.Width = 93;
            // 
            // CodigoFiltro
            // 
            this.CodigoFiltro.DataPropertyName = "Codigo_Filtro";
            this.CodigoFiltro.HeaderText = "Codigo de Filtro";
            this.CodigoFiltro.Name = "CodigoFiltro";
            this.CodigoFiltro.ReadOnly = true;
            this.CodigoFiltro.Width = 77;
            // 
            // MarcaVehiculo
            // 
            this.MarcaVehiculo.DataPropertyName = "Marca_Vehiculo";
            this.MarcaVehiculo.HeaderText = "Marca Vehículo";
            this.MarcaVehiculo.Name = "MarcaVehiculo";
            this.MarcaVehiculo.ReadOnly = true;
            this.MarcaVehiculo.Width = 99;
            // 
            // ModeloVehiculo
            // 
            this.ModeloVehiculo.DataPropertyName = "Modelo_Vehiculo";
            this.ModeloVehiculo.HeaderText = "ModeloVehiculo";
            this.ModeloVehiculo.Name = "ModeloVehiculo";
            this.ModeloVehiculo.ReadOnly = true;
            this.ModeloVehiculo.Width = 108;
            // 
            // AnioVehiculo
            // 
            this.AnioVehiculo.DataPropertyName = "Anio_Vehiculo";
            this.AnioVehiculo.HeaderText = "Año Vehículo";
            this.AnioVehiculo.Name = "AnioVehiculo";
            this.AnioVehiculo.ReadOnly = true;
            this.AnioVehiculo.Width = 89;
            // 
            // MotorVehiculo
            // 
            this.MotorVehiculo.DataPropertyName = "Motor_Vehiculo";
            this.MotorVehiculo.HeaderText = "MotorVehiculo";
            this.MotorVehiculo.Name = "MotorVehiculo";
            this.MotorVehiculo.ReadOnly = true;
            // 
            // PporMayor
            // 
            this.PporMayor.DataPropertyName = "Precio_por_mayor";
            this.PporMayor.HeaderText = "Precio por Mayor";
            this.PporMayor.Name = "PporMayor";
            this.PporMayor.ReadOnly = true;
            this.PporMayor.Width = 103;
            // 
            // PporMenor
            // 
            this.PporMenor.DataPropertyName = "Precio_por_menor";
            this.PporMenor.HeaderText = "Precio por Menor";
            this.PporMenor.Name = "PporMenor";
            this.PporMenor.ReadOnly = true;
            this.PporMenor.Width = 104;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 74;
            // 
            // frmBusquedaVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 531);
            this.Controls.Add(this.dgvFiltrosE);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmBusquedaVehiculo";
            this.Text = "frmBusquedaVehiculo";
            this.Load += new System.EventHandler(this.frmBusquedaVehiculo_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiltrosE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvFiltrosE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxMarcaVehiculo;
        private System.Windows.Forms.ComboBox cbxModeloVehiculo;
        private System.Windows.Forms.ComboBox cbxAnioVehiculo;
        private System.Windows.Forms.ComboBox cbxMotorVehiculo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rosca;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoFiltro;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoFiltro;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarcaVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModeloVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnioVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MotorVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PporMayor;
        private System.Windows.Forms.DataGridViewTextBoxColumn PporMenor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
    }
}