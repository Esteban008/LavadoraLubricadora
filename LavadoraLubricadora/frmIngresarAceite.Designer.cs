
namespace LavadoraLubricadora
{
    partial class frmIngresarAceite
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
            this.cbxApi = new System.Windows.Forms.ComboBox();
            this.cbxSae = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cbxTipoCombustible = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cbxTipoAceite = new System.Windows.Forms.ComboBox();
            this.cbxPresentacion = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtCantidadMin = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
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
            this.txtCodigoB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxApi
            // 
            this.cbxApi.FormattingEnabled = true;
            this.cbxApi.Location = new System.Drawing.Point(122, 246);
            this.cbxApi.Name = "cbxApi";
            this.cbxApi.Size = new System.Drawing.Size(121, 21);
            this.cbxApi.TabIndex = 78;
            // 
            // cbxSae
            // 
            this.cbxSae.FormattingEnabled = true;
            this.cbxSae.Location = new System.Drawing.Point(122, 188);
            this.cbxSae.Name = "cbxSae";
            this.cbxSae.Size = new System.Drawing.Size(121, 21);
            this.cbxSae.TabIndex = 77;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(11, 194);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(31, 13);
            this.label19.TabIndex = 76;
            this.label19.Text = "SAE:";
            // 
            // cbxTipoCombustible
            // 
            this.cbxTipoCombustible.FormattingEnabled = true;
            this.cbxTipoCombustible.Location = new System.Drawing.Point(122, 217);
            this.cbxTipoCombustible.Name = "cbxTipoCombustible";
            this.cbxTipoCombustible.Size = new System.Drawing.Size(121, 21);
            this.cbxTipoCombustible.TabIndex = 75;
            this.cbxTipoCombustible.SelectedValueChanged += new System.EventHandler(this.cbxTipoCombustible_SelectedValueChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(11, 222);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(106, 13);
            this.label18.TabIndex = 74;
            this.label18.Text = "Tipo de Combustible:";
            // 
            // cbxTipoAceite
            // 
            this.cbxTipoAceite.FormattingEnabled = true;
            this.cbxTipoAceite.Location = new System.Drawing.Point(122, 275);
            this.cbxTipoAceite.Name = "cbxTipoAceite";
            this.cbxTipoAceite.Size = new System.Drawing.Size(121, 21);
            this.cbxTipoAceite.TabIndex = 73;
            // 
            // cbxPresentacion
            // 
            this.cbxPresentacion.FormattingEnabled = true;
            this.cbxPresentacion.Location = new System.Drawing.Point(122, 159);
            this.cbxPresentacion.Name = "cbxPresentacion";
            this.cbxPresentacion.Size = new System.Drawing.Size(121, 21);
            this.cbxPresentacion.TabIndex = 72;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 278);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 13);
            this.label15.TabIndex = 71;
            this.label15.Text = "Tipo de Aceite:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(11, 250);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(27, 13);
            this.label16.TabIndex = 70;
            this.label16.Text = "API:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(11, 166);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 13);
            this.label17.TabIndex = 69;
            this.label17.Text = "Presentacion:";
            // 
            // txtCantidadMin
            // 
            this.txtCantidadMin.Location = new System.Drawing.Point(121, 131);
            this.txtCantidadMin.Name = "txtCantidadMin";
            this.txtCantidadMin.Size = new System.Drawing.Size(121, 20);
            this.txtCantidadMin.TabIndex = 68;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 138);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 13);
            this.label13.TabIndex = 67;
            this.label13.Text = "Cantidad Minima:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(121, 103);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(121, 20);
            this.txtCantidad.TabIndex = 66;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 110);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 13);
            this.label14.TabIndex = 65;
            this.label14.Text = "Cantidad:";
            // 
            // txtMargenMenor
            // 
            this.txtMargenMenor.Location = new System.Drawing.Point(428, 171);
            this.txtMargenMenor.Name = "txtMargenMenor";
            this.txtMargenMenor.Size = new System.Drawing.Size(100, 20);
            this.txtMargenMenor.TabIndex = 64;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(295, 175);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 13);
            this.label11.TabIndex = 63;
            this.label11.Text = "Margen Por Menor";
            // 
            // txtMargenMayor
            // 
            this.txtMargenMayor.Location = new System.Drawing.Point(428, 145);
            this.txtMargenMayor.Name = "txtMargenMayor";
            this.txtMargenMayor.Size = new System.Drawing.Size(100, 20);
            this.txtMargenMayor.TabIndex = 62;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(295, 149);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 13);
            this.label12.TabIndex = 61;
            this.label12.Text = "Margen Por Mayor:";
            // 
            // txtPrecioVMenor
            // 
            this.txtPrecioVMenor.Location = new System.Drawing.Point(428, 119);
            this.txtPrecioVMenor.Name = "txtPrecioVMenor";
            this.txtPrecioVMenor.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioVMenor.TabIndex = 60;
            this.txtPrecioVMenor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioVMenor_KeyPress);
            this.txtPrecioVMenor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPrecioVMenor_KeyUp);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(295, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 13);
            this.label10.TabIndex = 59;
            this.label10.Text = "Precio Por Menor";
            // 
            // txtPreCIva
            // 
            this.txtPreCIva.Location = new System.Drawing.Point(428, 41);
            this.txtPreCIva.Name = "txtPreCIva";
            this.txtPreCIva.Size = new System.Drawing.Size(100, 20);
            this.txtPreCIva.TabIndex = 58;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(295, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 13);
            this.label9.TabIndex = 57;
            this.label9.Text = "Precio Compra con IVA:";
            // 
            // txtPreVMayor
            // 
            this.txtPreVMayor.Location = new System.Drawing.Point(428, 93);
            this.txtPreVMayor.Name = "txtPreVMayor";
            this.txtPreVMayor.Size = new System.Drawing.Size(100, 20);
            this.txtPreVMayor.TabIndex = 56;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(295, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 55;
            this.label8.Text = "Precio Por Mayor:";
            // 
            // txtGananPorMayor
            // 
            this.txtGananPorMayor.Location = new System.Drawing.Point(428, 67);
            this.txtGananPorMayor.Name = "txtGananPorMayor";
            this.txtGananPorMayor.Size = new System.Drawing.Size(100, 20);
            this.txtGananPorMayor.TabIndex = 54;
            this.txtGananPorMayor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGananPorMayor_KeyPress);
            this.txtGananPorMayor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtGananPorMayor_KeyUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(295, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 13);
            this.label7.TabIndex = 53;
            this.label7.Text = "Ganancia al Mayor en %:";
            // 
            // txtPreSIva
            // 
            this.txtPreSIva.Location = new System.Drawing.Point(428, 15);
            this.txtPreSIva.Name = "txtPreSIva";
            this.txtPreSIva.Size = new System.Drawing.Size(100, 20);
            this.txtPreSIva.TabIndex = 52;
            this.txtPreSIva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPreSIva_KeyPress);
            this.txtPreSIva.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPreSIva_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(295, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "Precio Compra sin IVA:";
            // 
            // txtCodigoB
            // 
            this.txtCodigoB.Location = new System.Drawing.Point(121, 75);
            this.txtCodigoB.Name = "txtCodigoB";
            this.txtCodigoB.Size = new System.Drawing.Size(121, 20);
            this.txtCodigoB.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "Codigo de Barras:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(121, 47);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(121, 20);
            this.txtDescripcion.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Descripcion:";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(121, 19);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(121, 20);
            this.txtMarca.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Marca:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGuardar.Location = new System.Drawing.Point(329, 250);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(86, 36);
            this.btnGuardar.TabIndex = 80;
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
            this.btnSalir.Location = new System.Drawing.Point(442, 250);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(86, 36);
            this.btnSalir.TabIndex = 79;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmIngresarAceite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 318);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.cbxPresentacion);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtCantidadMin);
            this.Controls.Add(this.cbxSae);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cbxTipoCombustible);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cbxApi);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtMargenMenor);
            this.Controls.Add(this.cbxTipoAceite);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtMargenMayor);
            this.Controls.Add(this.label16);
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
            this.Controls.Add(this.txtCodigoB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.label3);
            this.Name = "frmIngresarAceite";
            this.Text = "frmIngresarAceite";
            this.Load += new System.EventHandler(this.frmIngresarAceite_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxApi;
        private System.Windows.Forms.ComboBox cbxSae;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cbxTipoCombustible;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cbxTipoAceite;
        private System.Windows.Forms.ComboBox cbxPresentacion;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtCantidadMin;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label14;
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
        private System.Windows.Forms.TextBox txtCodigoB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSalir;
    }
}