﻿namespace LavadoraLubricadora
{
    partial class frmBuscarFiltro
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.cbxCriBusqueda = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvFiltrosE = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rosca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoFiltro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoFiltro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PCsinIva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PCconIVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PporMayor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PporMenor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MporMayor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Margenxmenor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantMinima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiltrosE)).BeginInit();
            this.SuspendLayout();
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
            this.btnSalir.TabIndex = 123;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
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
            this.tableLayoutPanel1.TabIndex = 124;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(243)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(62)))), ((int)(((byte)(110)))));
            this.btnBuscar.Location = new System.Drawing.Point(552, 49);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(79, 36);
            this.btnBuscar.TabIndex = 118;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBusqueda.Location = new System.Drawing.Point(358, 57);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(183, 20);
            this.txtBusqueda.TabIndex = 117;
            // 
            // cbxCriBusqueda
            // 
            this.cbxCriBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxCriBusqueda.FormattingEnabled = true;
            this.cbxCriBusqueda.Items.AddRange(new object[] {
            "Codigo de Barras",
            "Marca",
            "Mostrar Todos"});
            this.cbxCriBusqueda.Location = new System.Drawing.Point(125, 57);
            this.cbxCriBusqueda.Name = "cbxCriBusqueda";
            this.cbxCriBusqueda.Size = new System.Drawing.Size(170, 21);
            this.cbxCriBusqueda.TabIndex = 120;
            this.cbxCriBusqueda.SelectedValueChanged += new System.EventHandler(this.cbxCriBusqueda_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 116;
            this.label1.Text = "Criterio de busqueda:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label2, 3);
            this.label2.Location = new System.Drawing.Point(266, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 122;
            this.label2.Text = "BÚSQUEDA DE FILTROS";
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
            this.ID,
            this.Marca,
            this.ADescripcion,
            this.Rosca,
            this.TipoFiltro,
            this.CodigoFiltro,
            this.CodigoB,
            this.PCsinIva,
            this.PCconIVA,
            this.PporMayor,
            this.PporMenor,
            this.MporMayor,
            this.Margenxmenor,
            this.Cantidad,
            this.CantMinima});
            this.dgvFiltrosE.Location = new System.Drawing.Point(48, 167);
            this.dgvFiltrosE.Name = "dgvFiltrosE";
            this.dgvFiltrosE.ReadOnly = true;
            this.dgvFiltrosE.RowHeadersVisible = false;
            this.dgvFiltrosE.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFiltrosE.Size = new System.Drawing.Size(670, 281);
            this.dgvFiltrosE.TabIndex = 126;
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
            this.TipoFiltro.Width = 86;
            // 
            // CodigoFiltro
            // 
            this.CodigoFiltro.DataPropertyName = "Codigo_Filtro";
            this.CodigoFiltro.HeaderText = "Codigo de Filtro";
            this.CodigoFiltro.Name = "CodigoFiltro";
            this.CodigoFiltro.ReadOnly = true;
            this.CodigoFiltro.Width = 77;
            // 
            // CodigoB
            // 
            this.CodigoB.DataPropertyName = "Codigo_Barras";
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
            // frmBuscarFiltro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 531);
            this.Controls.Add(this.dgvFiltrosE);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnSalir);
            this.Name = "frmBuscarFiltro";
            this.Text = "frmBuscarFiltro";
            this.Load += new System.EventHandler(this.frmBuscarFiltro_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiltrosE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.ComboBox cbxCriBusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvFiltrosE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rosca;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoFiltro;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoFiltro;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoB;
        private System.Windows.Forms.DataGridViewTextBoxColumn PCsinIva;
        private System.Windows.Forms.DataGridViewTextBoxColumn PCconIVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PporMayor;
        private System.Windows.Forms.DataGridViewTextBoxColumn PporMenor;
        private System.Windows.Forms.DataGridViewTextBoxColumn MporMayor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Margenxmenor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantMinima;
    }
}