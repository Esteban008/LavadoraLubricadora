namespace LavadoraLubricadora
{
    partial class frmBuscarAceite
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
            this.cbxCriBusqueda = new System.Windows.Forms.ComboBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAceites = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APresentacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SAE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.API = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoAceite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoCombustible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PCsinIva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PCconIVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PporMayor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PporMenor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MporMayor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Margenxmenor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantMinima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAceites)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxCriBusqueda
            // 
            this.cbxCriBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxCriBusqueda.FormattingEnabled = true;
            this.cbxCriBusqueda.Items.AddRange(new object[] {
            "Codigo de Barras",
            "Marca",
            "Mostrar Todos"});
            this.cbxCriBusqueda.Location = new System.Drawing.Point(127, 57);
            this.cbxCriBusqueda.Name = "cbxCriBusqueda";
            this.cbxCriBusqueda.Size = new System.Drawing.Size(173, 21);
            this.cbxCriBusqueda.TabIndex = 120;
            this.cbxCriBusqueda.SelectedValueChanged += new System.EventHandler(this.cbxCriBusqueda_SelectedValueChanged);
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
            this.btnSalir.Size = new System.Drawing.Size(80, 35);
            this.btnSalir.TabIndex = 119;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(243)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(62)))), ((int)(((byte)(110)))));
            this.btnBuscar.Location = new System.Drawing.Point(561, 50);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(80, 35);
            this.btnBuscar.TabIndex = 118;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBusqueda.Location = new System.Drawing.Point(364, 57);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(187, 20);
            this.txtBusqueda.TabIndex = 117;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 116;
            this.label1.Text = "Criterio de busqueda:";
            // 
            // dgvAceites
            // 
            this.dgvAceites.AllowUserToAddRows = false;
            this.dgvAceites.AllowUserToDeleteRows = false;
            this.dgvAceites.AllowUserToResizeColumns = false;
            this.dgvAceites.AllowUserToResizeRows = false;
            this.dgvAceites.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAceites.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvAceites.BackgroundColor = System.Drawing.Color.White;
            this.dgvAceites.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvAceites.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAceites.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Marca,
            this.ADescripcion,
            this.APresentacion,
            this.SAE,
            this.API,
            this.TipoAceite,
            this.TipoCombustible,
            this.CodigoB,
            this.PCsinIva,
            this.PCconIVA,
            this.PporMayor,
            this.PporMenor,
            this.MporMayor,
            this.Margenxmenor,
            this.Cantidad,
            this.CantMinima});
            this.dgvAceites.Location = new System.Drawing.Point(48, 167);
            this.dgvAceites.Name = "dgvAceites";
            this.dgvAceites.ReadOnly = true;
            this.dgvAceites.RowHeadersVisible = false;
            this.dgvAceites.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAceites.Size = new System.Drawing.Size(670, 281);
            this.dgvAceites.TabIndex = 115;
            this.dgvAceites.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAceites_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 43;
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
            // APresentacion
            // 
            this.APresentacion.DataPropertyName = "Presentacion";
            this.APresentacion.HeaderText = "Presentación";
            this.APresentacion.Name = "APresentacion";
            this.APresentacion.ReadOnly = true;
            this.APresentacion.Width = 94;
            // 
            // SAE
            // 
            this.SAE.DataPropertyName = "SAE";
            this.SAE.HeaderText = "SAE";
            this.SAE.Name = "SAE";
            this.SAE.ReadOnly = true;
            this.SAE.Width = 53;
            // 
            // API
            // 
            this.API.DataPropertyName = "API";
            this.API.HeaderText = "API";
            this.API.Name = "API";
            this.API.ReadOnly = true;
            this.API.Width = 49;
            // 
            // TipoAceite
            // 
            this.TipoAceite.DataPropertyName = "Tipo_Aceite";
            this.TipoAceite.HeaderText = "Tipo de Aceite";
            this.TipoAceite.Name = "TipoAceite";
            this.TipoAceite.ReadOnly = true;
            this.TipoAceite.Width = 93;
            // 
            // TipoCombustible
            // 
            this.TipoCombustible.DataPropertyName = "Tipo_Combustible";
            this.TipoCombustible.HeaderText = "Tipo de Combustible";
            this.TipoCombustible.Name = "TipoCombustible";
            this.TipoCombustible.ReadOnly = true;
            this.TipoCombustible.Width = 117;
            // 
            // CodigoB
            // 
            this.CodigoB.DataPropertyName = "Codigo";
            this.CodigoB.HeaderText = "Código de Barras";
            this.CodigoB.Name = "CodigoB";
            this.CodigoB.ReadOnly = true;
            this.CodigoB.Width = 77;
            // 
            // PCsinIva
            // 
            this.PCsinIva.DataPropertyName = "Precio_Compra_SIVA";
            this.PCsinIva.HeaderText = "Precio de Compra sin IVA";
            this.PCsinIva.Name = "PCsinIva";
            this.PCsinIva.ReadOnly = true;
            this.PCsinIva.Width = 109;
            // 
            // PCconIVA
            // 
            this.PCconIVA.DataPropertyName = "Precio_Compra_IVA";
            this.PCconIVA.HeaderText = "Precio de Compra con IVA";
            this.PCconIVA.Name = "PCconIVA";
            this.PCconIVA.ReadOnly = true;
            this.PCconIVA.Width = 109;
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
            // MporMayor
            // 
            this.MporMayor.DataPropertyName = "Margen_por_mayor";
            this.MporMayor.HeaderText = "Margen por Mayor";
            this.MporMayor.Name = "MporMayor";
            this.MporMayor.ReadOnly = true;
            this.MporMayor.Width = 82;
            // 
            // Margenxmenor
            // 
            this.Margenxmenor.DataPropertyName = "Margen_por_menor";
            this.Margenxmenor.HeaderText = "Margen por menor";
            this.Margenxmenor.Name = "Margenxmenor";
            this.Margenxmenor.ReadOnly = true;
            this.Margenxmenor.Width = 82;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 74;
            // 
            // CantMinima
            // 
            this.CantMinima.DataPropertyName = "Cantidad_Minima";
            this.CantMinima.HeaderText = "Cantidad Mínima";
            this.CantMinima.Name = "CantMinima";
            this.CantMinima.ReadOnly = true;
            this.CantMinima.Width = 103;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.47846F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.25842F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.47132F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.79181F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnBuscar, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtBusqueda, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbxCriBusqueda, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(48, 23);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.625F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.375F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(670, 96);
            this.tableLayoutPanel1.TabIndex = 121;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label2, 3);
            this.label2.Location = new System.Drawing.Point(272, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 122;
            this.label2.Text = "BÚSQUEDA DE ACEITES";
            // 
            // frmBuscarAceite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 531);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvAceites);
            this.Name = "frmBuscarAceite";
            this.Text = "frmBuscarAceite";
            this.Load += new System.EventHandler(this.frmBuscarAceite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAceites)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxCriBusqueda;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAceites;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn APresentacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn SAE;
        private System.Windows.Forms.DataGridViewTextBoxColumn API;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoAceite;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoCombustible;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoB;
        private System.Windows.Forms.DataGridViewTextBoxColumn PCsinIva;
        private System.Windows.Forms.DataGridViewTextBoxColumn PCconIVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PporMayor;
        private System.Windows.Forms.DataGridViewTextBoxColumn PporMenor;
        private System.Windows.Forms.DataGridViewTextBoxColumn MporMayor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Margenxmenor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantMinima;
        private System.Windows.Forms.Label label2;
    }
}