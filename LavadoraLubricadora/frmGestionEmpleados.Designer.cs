namespace LavadoraLubricadora
{
    partial class frmGestionEmpleados
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtRol = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCactual = new System.Windows.Forms.TextBox();
            this.lblCactual = new System.Windows.Forms.Label();
            this.txtCnueva = new System.Windows.Forms.TextBox();
            this.lblCnueva = new System.Windows.Forms.Label();
            this.txtCrepetir = new System.Windows.Forms.TextBox();
            this.lblCrepetir = new System.Windows.Forms.Label();
            this.cbxCactual = new System.Windows.Forms.CheckBox();
            this.cbxCnueva = new System.Windows.Forms.CheckBox();
            this.cbxCrepetir = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(383, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "FORMULARIO DE GESTION EMPLEADOS";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalir.Location = new System.Drawing.Point(838, 447);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(86, 36);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEliminar.Location = new System.Drawing.Point(838, 405);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(86, 36);
            this.btnEliminar.TabIndex = 44;
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
            this.btnEditar.Location = new System.Drawing.Point(838, 321);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(86, 36);
            this.btnEditar.TabIndex = 43;
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
            this.btnNuevo.Location = new System.Drawing.Point(838, 279);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(86, 36);
            this.btnNuevo.TabIndex = 42;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AllowUserToResizeColumns = false;
            this.dgvUsuarios.AllowUserToResizeRows = false;
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(12, 44);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(941, 203);
            this.dgvUsuarios.TabIndex = 41;
            this.dgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGuardar.Location = new System.Drawing.Point(838, 363);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(86, 36);
            this.btnGuardar.TabIndex = 40;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtRol
            // 
            this.txtRol.Location = new System.Drawing.Point(120, 395);
            this.txtRol.Name = "txtRol";
            this.txtRol.Size = new System.Drawing.Size(226, 20);
            this.txtRol.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 402);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Rol:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(120, 369);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(226, 20);
            this.txtCorreo.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 376);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Correo:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(120, 343);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(226, 20);
            this.txtTelefono.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Telefono:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(120, 311);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(226, 20);
            this.txtApellido.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Apellido:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(120, 285);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(226, 20);
            this.txtNombre.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Nombre:";
            // 
            // txtCactual
            // 
            this.txtCactual.Location = new System.Drawing.Point(492, 311);
            this.txtCactual.Name = "txtCactual";
            this.txtCactual.Size = new System.Drawing.Size(226, 20);
            this.txtCactual.TabIndex = 46;
            // 
            // lblCactual
            // 
            this.lblCactual.AutoSize = true;
            this.lblCactual.Location = new System.Drawing.Point(377, 314);
            this.lblCactual.Name = "lblCactual";
            this.lblCactual.Size = new System.Drawing.Size(96, 13);
            this.lblCactual.TabIndex = 45;
            this.lblCactual.Text = "Contraseña actual:";
            // 
            // txtCnueva
            // 
            this.txtCnueva.Location = new System.Drawing.Point(492, 347);
            this.txtCnueva.Name = "txtCnueva";
            this.txtCnueva.Size = new System.Drawing.Size(226, 20);
            this.txtCnueva.TabIndex = 48;
            // 
            // lblCnueva
            // 
            this.lblCnueva.AutoSize = true;
            this.lblCnueva.Location = new System.Drawing.Point(377, 350);
            this.lblCnueva.Name = "lblCnueva";
            this.lblCnueva.Size = new System.Drawing.Size(97, 13);
            this.lblCnueva.TabIndex = 47;
            this.lblCnueva.Text = "Contraseña nueva:";
            // 
            // txtCrepetir
            // 
            this.txtCrepetir.Location = new System.Drawing.Point(492, 373);
            this.txtCrepetir.Name = "txtCrepetir";
            this.txtCrepetir.Size = new System.Drawing.Size(226, 20);
            this.txtCrepetir.TabIndex = 50;
            this.txtCrepetir.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCrepetir_KeyUp);
            // 
            // lblCrepetir
            // 
            this.lblCrepetir.AutoSize = true;
            this.lblCrepetir.Location = new System.Drawing.Point(377, 376);
            this.lblCrepetir.Name = "lblCrepetir";
            this.lblCrepetir.Size = new System.Drawing.Size(101, 13);
            this.lblCrepetir.TabIndex = 49;
            this.lblCrepetir.Text = "Repetir Contraseña:";
            // 
            // cbxCactual
            // 
            this.cbxCactual.AutoSize = true;
            this.cbxCactual.Location = new System.Drawing.Point(725, 314);
            this.cbxCactual.Name = "cbxCactual";
            this.cbxCactual.Size = new System.Drawing.Size(61, 17);
            this.cbxCactual.TabIndex = 51;
            this.cbxCactual.Text = "Mostrar";
            this.cbxCactual.UseVisualStyleBackColor = true;
            this.cbxCactual.CheckedChanged += new System.EventHandler(this.cbxCactual_CheckedChanged);
            // 
            // cbxCnueva
            // 
            this.cbxCnueva.AutoSize = true;
            this.cbxCnueva.Location = new System.Drawing.Point(725, 349);
            this.cbxCnueva.Name = "cbxCnueva";
            this.cbxCnueva.Size = new System.Drawing.Size(61, 17);
            this.cbxCnueva.TabIndex = 52;
            this.cbxCnueva.Text = "Mostrar";
            this.cbxCnueva.UseVisualStyleBackColor = true;
            this.cbxCnueva.CheckedChanged += new System.EventHandler(this.cbxCnueva_CheckedChanged);
            // 
            // cbxCrepetir
            // 
            this.cbxCrepetir.AutoSize = true;
            this.cbxCrepetir.Location = new System.Drawing.Point(725, 376);
            this.cbxCrepetir.Name = "cbxCrepetir";
            this.cbxCrepetir.Size = new System.Drawing.Size(61, 17);
            this.cbxCrepetir.TabIndex = 53;
            this.cbxCrepetir.Text = "Mostrar";
            this.cbxCrepetir.UseVisualStyleBackColor = true;
            this.cbxCrepetir.CheckedChanged += new System.EventHandler(this.cbxCrepetir_CheckedChanged);
            // 
            // frmGestionEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 564);
            this.Controls.Add(this.cbxCrepetir);
            this.Controls.Add(this.cbxCnueva);
            this.Controls.Add(this.cbxCactual);
            this.Controls.Add(this.txtCrepetir);
            this.Controls.Add(this.lblCrepetir);
            this.Controls.Add(this.txtCnueva);
            this.Controls.Add(this.lblCnueva);
            this.Controls.Add(this.txtCactual);
            this.Controls.Add(this.lblCactual);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtRol);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label1);
            this.Name = "frmGestionEmpleados";
            this.Text = "frmGestionEmpleados";
            this.Load += new System.EventHandler(this.frmGestionEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtRol;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCactual;
        private System.Windows.Forms.Label lblCactual;
        private System.Windows.Forms.TextBox txtCnueva;
        private System.Windows.Forms.Label lblCnueva;
        private System.Windows.Forms.TextBox txtCrepetir;
        private System.Windows.Forms.Label lblCrepetir;
        private System.Windows.Forms.CheckBox cbxCactual;
        private System.Windows.Forms.CheckBox cbxCnueva;
        private System.Windows.Forms.CheckBox cbxCrepetir;
    }
}