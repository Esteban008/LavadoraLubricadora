namespace LavadoraLubricadora
{
    partial class frmEditarAceite
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAceites = new System.Windows.Forms.DataGridView();
            this.cbxPresentacion = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtCantidadMin = new System.Windows.Forms.TextBox();
            this.cbxSae = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtCodigoB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxTipoCombustible = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cbxApi = new System.Windows.Forms.ComboBox();
            this.cbxTipoAceite = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtMargenMenor = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMargenMayor = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPrecioVMenor = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPreCIva = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPreVMayor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtGananPorMayor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPreSIva = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.cbxCriBusqueda = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAceites)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBuscar.Location = new System.Drawing.Point(654, 18);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(86, 36);
            this.btnBuscar.TabIndex = 47;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(336, 34);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(135, 20);
            this.txtBusqueda.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Criterio de busqueda:";
            // 
            // dgvAceites
            // 
            this.dgvAceites.AllowUserToAddRows = false;
            this.dgvAceites.AllowUserToDeleteRows = false;
            this.dgvAceites.AllowUserToResizeColumns = false;
            this.dgvAceites.AllowUserToResizeRows = false;
            this.dgvAceites.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvAceites.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAceites.Location = new System.Drawing.Point(54, 75);
            this.dgvAceites.Name = "dgvAceites";
            this.dgvAceites.ReadOnly = true;
            this.dgvAceites.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAceites.Size = new System.Drawing.Size(686, 203);
            this.dgvAceites.TabIndex = 43;
            this.dgvAceites.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAceites_CellClick);
            // 
            // cbxPresentacion
            // 
            this.cbxPresentacion.FormattingEnabled = true;
            this.cbxPresentacion.Location = new System.Drawing.Point(164, 434);
            this.cbxPresentacion.Name = "cbxPresentacion";
            this.cbxPresentacion.Size = new System.Drawing.Size(121, 21);
            this.cbxPresentacion.TabIndex = 89;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(53, 441);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 13);
            this.label17.TabIndex = 88;
            this.label17.Text = "Presentacion:";
            // 
            // txtCantidadMin
            // 
            this.txtCantidadMin.Location = new System.Drawing.Point(163, 406);
            this.txtCantidadMin.Name = "txtCantidadMin";
            this.txtCantidadMin.Size = new System.Drawing.Size(121, 20);
            this.txtCantidadMin.TabIndex = 87;
            // 
            // cbxSae
            // 
            this.cbxSae.FormattingEnabled = true;
            this.cbxSae.Location = new System.Drawing.Point(164, 463);
            this.cbxSae.Name = "cbxSae";
            this.cbxSae.Size = new System.Drawing.Size(121, 21);
            this.cbxSae.TabIndex = 91;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(54, 413);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 13);
            this.label13.TabIndex = 86;
            this.label13.Text = "Cantidad Minima:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(163, 378);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(121, 20);
            this.txtCantidad.TabIndex = 85;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(54, 385);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 13);
            this.label14.TabIndex = 84;
            this.label14.Text = "Cantidad:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(53, 469);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(31, 13);
            this.label19.TabIndex = 90;
            this.label19.Text = "SAE:";
            // 
            // txtCodigoB
            // 
            this.txtCodigoB.Location = new System.Drawing.Point(163, 350);
            this.txtCodigoB.Name = "txtCodigoB";
            this.txtCodigoB.Size = new System.Drawing.Size(121, 20);
            this.txtCodigoB.TabIndex = 83;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 82;
            this.label5.Text = "Codigo de Barras:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(163, 322);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(121, 20);
            this.txtDescripcion.TabIndex = 81;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 80;
            this.label4.Text = "Descripcion:";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(163, 294);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(121, 20);
            this.txtMarca.TabIndex = 79;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 78;
            this.label3.Text = "Marca:";
            // 
            // cbxTipoCombustible
            // 
            this.cbxTipoCombustible.FormattingEnabled = true;
            this.cbxTipoCombustible.Location = new System.Drawing.Point(165, 498);
            this.cbxTipoCombustible.Name = "cbxTipoCombustible";
            this.cbxTipoCombustible.Size = new System.Drawing.Size(121, 21);
            this.cbxTipoCombustible.TabIndex = 96;
            this.cbxTipoCombustible.SelectedValueChanged += new System.EventHandler(this.cbxTipoCombustible_SelectedValueChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(54, 503);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(106, 13);
            this.label18.TabIndex = 95;
            this.label18.Text = "Tipo de Combustible:";
            // 
            // cbxApi
            // 
            this.cbxApi.FormattingEnabled = true;
            this.cbxApi.Location = new System.Drawing.Point(165, 527);
            this.cbxApi.Name = "cbxApi";
            this.cbxApi.Size = new System.Drawing.Size(121, 21);
            this.cbxApi.TabIndex = 97;
            // 
            // cbxTipoAceite
            // 
            this.cbxTipoAceite.FormattingEnabled = true;
            this.cbxTipoAceite.Location = new System.Drawing.Point(165, 556);
            this.cbxTipoAceite.Name = "cbxTipoAceite";
            this.cbxTipoAceite.Size = new System.Drawing.Size(121, 21);
            this.cbxTipoAceite.TabIndex = 94;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(54, 559);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 13);
            this.label15.TabIndex = 93;
            this.label15.Text = "Tipo de Aceite:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(54, 531);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(27, 13);
            this.label16.TabIndex = 92;
            this.label16.Text = "API:";
            // 
            // txtMargenMenor
            // 
            this.txtMargenMenor.Location = new System.Drawing.Point(556, 449);
            this.txtMargenMenor.Name = "txtMargenMenor";
            this.txtMargenMenor.Size = new System.Drawing.Size(100, 20);
            this.txtMargenMenor.TabIndex = 111;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(423, 453);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 13);
            this.label11.TabIndex = 110;
            this.label11.Text = "Margen Por Menor";
            // 
            // txtMargenMayor
            // 
            this.txtMargenMayor.Location = new System.Drawing.Point(556, 423);
            this.txtMargenMayor.Name = "txtMargenMayor";
            this.txtMargenMayor.Size = new System.Drawing.Size(100, 20);
            this.txtMargenMayor.TabIndex = 109;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(423, 427);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 13);
            this.label12.TabIndex = 108;
            this.label12.Text = "Margen Por Mayor:";
            // 
            // txtPrecioVMenor
            // 
            this.txtPrecioVMenor.Location = new System.Drawing.Point(556, 397);
            this.txtPrecioVMenor.Name = "txtPrecioVMenor";
            this.txtPrecioVMenor.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioVMenor.TabIndex = 107;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(423, 401);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 13);
            this.label10.TabIndex = 106;
            this.label10.Text = "Precio Por Menor";
            // 
            // txtPreCIva
            // 
            this.txtPreCIva.Location = new System.Drawing.Point(556, 319);
            this.txtPreCIva.Name = "txtPreCIva";
            this.txtPreCIva.Size = new System.Drawing.Size(100, 20);
            this.txtPreCIva.TabIndex = 105;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(423, 323);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 13);
            this.label9.TabIndex = 104;
            this.label9.Text = "Precio Compra con IVA:";
            // 
            // txtPreVMayor
            // 
            this.txtPreVMayor.Location = new System.Drawing.Point(556, 371);
            this.txtPreVMayor.Name = "txtPreVMayor";
            this.txtPreVMayor.Size = new System.Drawing.Size(100, 20);
            this.txtPreVMayor.TabIndex = 103;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(423, 375);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 102;
            this.label8.Text = "Precio Por Mayor:";
            // 
            // txtGananPorMayor
            // 
            this.txtGananPorMayor.Location = new System.Drawing.Point(556, 345);
            this.txtGananPorMayor.Name = "txtGananPorMayor";
            this.txtGananPorMayor.Size = new System.Drawing.Size(100, 20);
            this.txtGananPorMayor.TabIndex = 101;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(423, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 13);
            this.label7.TabIndex = 100;
            this.label7.Text = "Ganancia al Mayor en %:";
            // 
            // txtPreSIva
            // 
            this.txtPreSIva.Location = new System.Drawing.Point(556, 293);
            this.txtPreSIva.Name = "txtPreSIva";
            this.txtPreSIva.Size = new System.Drawing.Size(100, 20);
            this.txtPreSIva.TabIndex = 99;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(423, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 13);
            this.label6.TabIndex = 98;
            this.label6.Text = "Precio Compra sin IVA:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGuardar.Location = new System.Drawing.Point(413, 541);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(86, 36);
            this.btnGuardar.TabIndex = 113;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalir.Location = new System.Drawing.Point(591, 541);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(86, 36);
            this.btnSalir.TabIndex = 112;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // cbxCriBusqueda
            // 
            this.cbxCriBusqueda.FormattingEnabled = true;
            this.cbxCriBusqueda.Items.AddRange(new object[] {
            "Codigo de Barras",
            "Marca",
            "Mostrar Todos"});
            this.cbxCriBusqueda.Location = new System.Drawing.Point(167, 34);
            this.cbxCriBusqueda.Name = "cbxCriBusqueda";
            this.cbxCriBusqueda.Size = new System.Drawing.Size(121, 21);
            this.cbxCriBusqueda.TabIndex = 114;
            // 
            // frmEditarAceite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 604);
            this.Controls.Add(this.cbxCriBusqueda);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtMargenMenor);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtMargenMayor);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtPrecioVMenor);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPreCIva);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPreVMayor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtGananPorMayor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPreSIva);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbxTipoCombustible);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.cbxApi);
            this.Controls.Add(this.cbxTipoAceite);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cbxPresentacion);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtCantidadMin);
            this.Controls.Add(this.cbxSae);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtCodigoB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAceites);
            this.Name = "frmEditarAceite";
            this.Text = "frmEditarAceite";
            this.Load += new System.EventHandler(this.frmEditarAceite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAceites)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAceites;
        private System.Windows.Forms.ComboBox cbxPresentacion;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtCantidadMin;
        private System.Windows.Forms.ComboBox cbxSae;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtCodigoB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxTipoCombustible;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cbxApi;
        private System.Windows.Forms.ComboBox cbxTipoAceite;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtMargenMenor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMargenMayor;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPrecioVMenor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPreCIva;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPreVMayor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtGananPorMayor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPreSIva;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox cbxCriBusqueda;
    }
}