namespace LavadoraLubricadora
{
    partial class frmAdminProductos
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
            this.btnAgregarVehiculo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxTipoProducto = new System.Windows.Forms.ComboBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCodigoB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPreSIva = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPorMayor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPreVMayor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPreCIva = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMargenMenor = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMargenMayor = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCantidadMin = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cbxPresentacion = new System.Windows.Forms.ComboBox();
            this.cbxTipoAceite = new System.Windows.Forms.ComboBox();
            this.cbxTipoCombustible = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cbxSae = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cbxApi = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(412, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "FORMULARIO DE ADMINISTRACION DE PRODUCTOS";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalir.Location = new System.Drawing.Point(1041, 611);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(86, 36);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAgregarVehiculo
            // 
            this.btnAgregarVehiculo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregarVehiculo.FlatAppearance.BorderSize = 0;
            this.btnAgregarVehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarVehiculo.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAgregarVehiculo.Location = new System.Drawing.Point(990, 579);
            this.btnAgregarVehiculo.Name = "btnAgregarVehiculo";
            this.btnAgregarVehiculo.Size = new System.Drawing.Size(137, 26);
            this.btnAgregarVehiculo.TabIndex = 3;
            this.btnAgregarVehiculo.Text = "Agregar Vehiculo";
            this.btnAgregarVehiculo.UseVisualStyleBackColor = false;
            this.btnAgregarVehiculo.Click += new System.EventHandler(this.btnAgregarVehiculo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Selecccion el tipo de producto:";
            // 
            // cbxTipoProducto
            // 
            this.cbxTipoProducto.FormattingEnabled = true;
            this.cbxTipoProducto.Items.AddRange(new object[] {
            "Aceite",
            "Filtro",
            "Otros"});
            this.cbxTipoProducto.Location = new System.Drawing.Point(186, 40);
            this.cbxTipoProducto.Name = "cbxTipoProducto";
            this.cbxTipoProducto.Size = new System.Drawing.Size(214, 21);
            this.cbxTipoProducto.TabIndex = 5;
            this.cbxTipoProducto.SelectedValueChanged += new System.EventHandler(this.cbxTipoProducto_SelectedValueChanged);
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(13, 91);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(1114, 285);
            this.dgvProductos.TabIndex = 6;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(632, 41);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(220, 20);
            this.txtBuscar.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 409);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Marca:";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(110, 402);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 20);
            this.txtMarca.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 433);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Descripcion:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(110, 428);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 11;
            // 
            // txtCodigoB
            // 
            this.txtCodigoB.Location = new System.Drawing.Point(110, 454);
            this.txtCodigoB.Name = "txtCodigoB";
            this.txtCodigoB.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoB.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 459);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Codigo de Barras:";
            // 
            // txtPreSIva
            // 
            this.txtPreSIva.Location = new System.Drawing.Point(334, 401);
            this.txtPreSIva.Name = "txtPreSIva";
            this.txtPreSIva.Size = new System.Drawing.Size(100, 20);
            this.txtPreSIva.TabIndex = 15;
            this.txtPreSIva.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(216, 406);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Precio Compra sin IVA:";
            // 
            // txtPorMayor
            // 
            this.txtPorMayor.Location = new System.Drawing.Point(345, 454);
            this.txtPorMayor.Name = "txtPorMayor";
            this.txtPorMayor.Size = new System.Drawing.Size(100, 20);
            this.txtPorMayor.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(216, 461);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "% de ganancia al Mayor:";
            // 
            // txtPreVMayor
            // 
            this.txtPreVMayor.Location = new System.Drawing.Point(574, 402);
            this.txtPreVMayor.Name = "txtPreVMayor";
            this.txtPreVMayor.Size = new System.Drawing.Size(100, 20);
            this.txtPreVMayor.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(479, 409);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Precio Por Mayor:";
            // 
            // txtPreCIva
            // 
            this.txtPreCIva.Location = new System.Drawing.Point(334, 427);
            this.txtPreCIva.Name = "txtPreCIva";
            this.txtPreCIva.Size = new System.Drawing.Size(100, 20);
            this.txtPreCIva.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(216, 432);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Precio Compra con IVA:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(574, 429);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(479, 436);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Precio Por Menor";
            // 
            // txtMargenMenor
            // 
            this.txtMargenMenor.Location = new System.Drawing.Point(794, 429);
            this.txtMargenMenor.Name = "txtMargenMenor";
            this.txtMargenMenor.Size = new System.Drawing.Size(100, 20);
            this.txtMargenMenor.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(693, 436);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Margen Por Menor";
            // 
            // txtMargenMayor
            // 
            this.txtMargenMayor.Location = new System.Drawing.Point(794, 402);
            this.txtMargenMayor.Name = "txtMargenMayor";
            this.txtMargenMayor.Size = new System.Drawing.Size(100, 20);
            this.txtMargenMayor.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(693, 409);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Margen Por Mayor:";
            // 
            // txtCantidadMin
            // 
            this.txtCantidadMin.Location = new System.Drawing.Point(1010, 428);
            this.txtCantidadMin.Name = "txtCantidadMin";
            this.txtCantidadMin.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadMin.TabIndex = 31;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(916, 435);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Cantidad Minima:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(1010, 401);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 29;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(916, 408);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Cantidad:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(651, 507);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 13);
            this.label15.TabIndex = 36;
            this.label15.Text = "Tipo de Aceite:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(457, 507);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(27, 13);
            this.label16.TabIndex = 34;
            this.label16.Text = "API:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(13, 507);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 13);
            this.label17.TabIndex = 32;
            this.label17.Text = "Presentacion:";
            // 
            // cbxPresentacion
            // 
            this.cbxPresentacion.FormattingEnabled = true;
            this.cbxPresentacion.Location = new System.Drawing.Point(110, 499);
            this.cbxPresentacion.Name = "cbxPresentacion";
            this.cbxPresentacion.Size = new System.Drawing.Size(121, 21);
            this.cbxPresentacion.TabIndex = 38;
            // 
            // cbxTipoAceite
            // 
            this.cbxTipoAceite.FormattingEnabled = true;
            this.cbxTipoAceite.Location = new System.Drawing.Point(736, 500);
            this.cbxTipoAceite.Name = "cbxTipoAceite";
            this.cbxTipoAceite.Size = new System.Drawing.Size(121, 21);
            this.cbxTipoAceite.TabIndex = 39;
            // 
            // cbxTipoCombustible
            // 
            this.cbxTipoCombustible.FormattingEnabled = true;
            this.cbxTipoCombustible.Location = new System.Drawing.Point(997, 500);
            this.cbxTipoCombustible.Name = "cbxTipoCombustible";
            this.cbxTipoCombustible.Size = new System.Drawing.Size(121, 21);
            this.cbxTipoCombustible.TabIndex = 41;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(885, 507);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(106, 13);
            this.label18.TabIndex = 40;
            this.label18.Text = "Tipo de Combustible:";
            // 
            // cbxSae
            // 
            this.cbxSae.FormattingEnabled = true;
            this.cbxSae.Location = new System.Drawing.Point(300, 500);
            this.cbxSae.Name = "cbxSae";
            this.cbxSae.Size = new System.Drawing.Size(121, 21);
            this.cbxSae.TabIndex = 43;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(248, 508);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(31, 13);
            this.label19.TabIndex = 42;
            this.label19.Text = "SAE:";
            // 
            // cbxApi
            // 
            this.cbxApi.FormattingEnabled = true;
            this.cbxApi.Location = new System.Drawing.Point(490, 500);
            this.cbxApi.Name = "cbxApi";
            this.cbxApi.Size = new System.Drawing.Size(121, 21);
            this.cbxApi.TabIndex = 44;
            // 
            // frmAdminProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 659);
            this.Controls.Add(this.cbxApi);
            this.Controls.Add(this.cbxSae);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.cbxTipoCombustible);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.cbxTipoAceite);
            this.Controls.Add(this.cbxPresentacion);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtCantidadMin);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtMargenMenor);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtMargenMayor);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPreCIva);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPreVMayor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPorMayor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPreSIva);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCodigoB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.cbxTipoProducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAgregarVehiculo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label1);
            this.Name = "frmAdminProductos";
            this.Text = "frmAdminProductos";
            this.Load += new System.EventHandler(this.frmAdminProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAgregarVehiculo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxTipoProducto;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCodigoB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPreSIva;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPorMayor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPreVMayor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPreCIva;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMargenMenor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMargenMayor;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCantidadMin;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbxPresentacion;
        private System.Windows.Forms.ComboBox cbxTipoAceite;
        private System.Windows.Forms.ComboBox cbxTipoCombustible;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cbxSae;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cbxApi;
    }
}