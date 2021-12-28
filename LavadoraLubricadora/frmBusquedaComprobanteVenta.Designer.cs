namespace LavadoraLubricadora
{
    partial class frmBusquedaComprobanteVenta
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
            this.dgvProductoE = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PCsinIva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PCconIVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PporMayor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PporMenor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MporMayor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Margenxmenor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantMinima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductoE)).BeginInit();
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
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.Controls.Add(this.txtBusquedaE, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.cbxCriBusquedaE, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnBuscarE, 4, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(49, 38);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(702, 47);
            this.tableLayoutPanel3.TabIndex = 124;
            // 
            // txtBusquedaE
            // 
            this.txtBusquedaE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBusquedaE.Location = new System.Drawing.Point(374, 13);
            this.txtBusquedaE.Name = "txtBusquedaE";
            this.txtBusquedaE.Size = new System.Drawing.Size(193, 20);
            this.txtBusquedaE.TabIndex = 117;
            // 
            // cbxCriBusquedaE
            // 
            this.cbxCriBusquedaE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxCriBusquedaE.FormattingEnabled = true;
            this.cbxCriBusquedaE.Items.AddRange(new object[] {
            "Cédula de Cliente",
            "Fecha de Compra"});
            this.cbxCriBusquedaE.Location = new System.Drawing.Point(131, 13);
            this.cbxCriBusquedaE.Name = "cbxCriBusquedaE";
            this.cbxCriBusquedaE.Size = new System.Drawing.Size(178, 21);
            this.cbxCriBusquedaE.TabIndex = 120;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 17);
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
            this.btnBuscarE.Location = new System.Drawing.Point(577, 6);
            this.btnBuscarE.Name = "btnBuscarE";
            this.btnBuscarE.Size = new System.Drawing.Size(80, 35);
            this.btnBuscarE.TabIndex = 118;
            this.btnBuscarE.Text = "Buscar";
            this.btnBuscarE.UseVisualStyleBackColor = false;
            // 
            // dgvProductoE
            // 
            this.dgvProductoE.AllowUserToAddRows = false;
            this.dgvProductoE.AllowUserToDeleteRows = false;
            this.dgvProductoE.AllowUserToResizeColumns = false;
            this.dgvProductoE.AllowUserToResizeRows = false;
            this.dgvProductoE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductoE.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvProductoE.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductoE.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvProductoE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductoE.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Marca,
            this.ADescripcion,
            this.CodigoB,
            this.PCsinIva,
            this.PCconIVA,
            this.PporMayor,
            this.PporMenor,
            this.MporMayor,
            this.Margenxmenor,
            this.Cantidad,
            this.CantMinima});
            this.dgvProductoE.Location = new System.Drawing.Point(49, 134);
            this.dgvProductoE.Name = "dgvProductoE";
            this.dgvProductoE.ReadOnly = true;
            this.dgvProductoE.RowHeadersVisible = false;
            this.dgvProductoE.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductoE.Size = new System.Drawing.Size(702, 312);
            this.dgvProductoE.TabIndex = 125;
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
            // frmBusquedaComprobanteVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(810, 626);
            this.Controls.Add(this.dgvProductoE);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Name = "frmBusquedaComprobanteVenta";
            this.Text = "frmBusquedaComprobanteVenta";
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductoE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox txtBusquedaE;
        private System.Windows.Forms.ComboBox cbxCriBusquedaE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarE;
        private System.Windows.Forms.DataGridView dgvProductoE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADescripcion;
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