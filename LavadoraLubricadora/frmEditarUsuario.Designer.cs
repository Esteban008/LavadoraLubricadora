namespace LavadoraLubricadora
{
    partial class frmEditarUsuario
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
            this.cbxCriBusqueda = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRol = new System.Windows.Forms.TextBox();
            this.cbxCrepetir = new System.Windows.Forms.CheckBox();
            this.cbxCnueva = new System.Windows.Forms.CheckBox();
            this.txtCrepetir = new System.Windows.Forms.TextBox();
            this.lblCrepetir = new System.Windows.Forms.Label();
            this.txtCnueva = new System.Windows.Forms.TextBox();
            this.lblCnueva = new System.Windows.Forms.Label();
            this.cbxRol = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBuscar.Location = new System.Drawing.Point(644, 18);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(86, 36);
            this.btnBuscar.TabIndex = 63;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(381, 33);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(135, 20);
            this.txtBusqueda.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "Criterio de busqueda:";
            // 
            // cbxCriBusqueda
            // 
            this.cbxCriBusqueda.FormattingEnabled = true;
            this.cbxCriBusqueda.Items.AddRange(new object[] {
            "Nombre",
            "Apellido",
            "Rol",
            "Mostrar Todos"});
            this.cbxCriBusqueda.Location = new System.Drawing.Point(157, 33);
            this.cbxCriBusqueda.Name = "cbxCriBusqueda";
            this.cbxCriBusqueda.Size = new System.Drawing.Size(121, 21);
            this.cbxCriBusqueda.TabIndex = 60;
            this.cbxCriBusqueda.SelectedValueChanged += new System.EventHandler(this.cbxCriBusqueda_SelectedValueChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGuardar.Location = new System.Drawing.Point(262, 495);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(86, 36);
            this.btnGuardar.TabIndex = 59;
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
            this.btnSalir.Location = new System.Drawing.Point(440, 495);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(86, 36);
            this.btnSalir.TabIndex = 58;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AllowUserToResizeColumns = false;
            this.dgvUsuarios.AllowUserToResizeRows = false;
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(44, 78);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(686, 203);
            this.dgvUsuarios.TabIndex = 57;
            this.dgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(122, 390);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(226, 20);
            this.txtCorreo.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 393);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "Correo:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(122, 357);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(226, 20);
            this.txtTelefono.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "Telefono:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(122, 324);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(226, 20);
            this.txtApellido.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Apellido:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(122, 291);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(226, 20);
            this.txtNombre.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 426);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Rol:";
            // 
            // txtRol
            // 
            this.txtRol.Location = new System.Drawing.Point(122, 423);
            this.txtRol.Name = "txtRol";
            this.txtRol.Size = new System.Drawing.Size(226, 20);
            this.txtRol.TabIndex = 48;
            // 
            // cbxCrepetir
            // 
            this.cbxCrepetir.AutoSize = true;
            this.cbxCrepetir.Location = new System.Drawing.Point(713, 422);
            this.cbxCrepetir.Name = "cbxCrepetir";
            this.cbxCrepetir.Size = new System.Drawing.Size(61, 17);
            this.cbxCrepetir.TabIndex = 72;
            this.cbxCrepetir.Text = "Mostrar";
            this.cbxCrepetir.UseVisualStyleBackColor = true;
            this.cbxCrepetir.CheckedChanged += new System.EventHandler(this.cbxCrepetir_CheckedChanged);
            // 
            // cbxCnueva
            // 
            this.cbxCnueva.AutoSize = true;
            this.cbxCnueva.Location = new System.Drawing.Point(713, 395);
            this.cbxCnueva.Name = "cbxCnueva";
            this.cbxCnueva.Size = new System.Drawing.Size(61, 17);
            this.cbxCnueva.TabIndex = 71;
            this.cbxCnueva.Text = "Mostrar";
            this.cbxCnueva.UseVisualStyleBackColor = true;
            this.cbxCnueva.CheckedChanged += new System.EventHandler(this.cbxCnueva_CheckedChanged);
            // 
            // txtCrepetir
            // 
            this.txtCrepetir.Location = new System.Drawing.Point(480, 419);
            this.txtCrepetir.Name = "txtCrepetir";
            this.txtCrepetir.Size = new System.Drawing.Size(226, 20);
            this.txtCrepetir.TabIndex = 69;
            this.txtCrepetir.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCrepetir_KeyUp);
            // 
            // lblCrepetir
            // 
            this.lblCrepetir.AutoSize = true;
            this.lblCrepetir.Location = new System.Drawing.Point(365, 422);
            this.lblCrepetir.Name = "lblCrepetir";
            this.lblCrepetir.Size = new System.Drawing.Size(101, 13);
            this.lblCrepetir.TabIndex = 68;
            this.lblCrepetir.Text = "Repetir Contraseña:";
            // 
            // txtCnueva
            // 
            this.txtCnueva.Location = new System.Drawing.Point(480, 393);
            this.txtCnueva.Name = "txtCnueva";
            this.txtCnueva.Size = new System.Drawing.Size(226, 20);
            this.txtCnueva.TabIndex = 67;
            // 
            // lblCnueva
            // 
            this.lblCnueva.AutoSize = true;
            this.lblCnueva.Location = new System.Drawing.Point(365, 396);
            this.lblCnueva.Name = "lblCnueva";
            this.lblCnueva.Size = new System.Drawing.Size(97, 13);
            this.lblCnueva.TabIndex = 66;
            this.lblCnueva.Text = "Contraseña nueva:";
            // 
            // cbxRol
            // 
            this.cbxRol.FormattingEnabled = true;
            this.cbxRol.Items.AddRange(new object[] {
            "Administrador",
            "Empleado"});
            this.cbxRol.Location = new System.Drawing.Point(381, 32);
            this.cbxRol.Name = "cbxRol";
            this.cbxRol.Size = new System.Drawing.Size(135, 21);
            this.cbxRol.TabIndex = 73;
            // 
            // frmEditarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 548);
            this.Controls.Add(this.cbxRol);
            this.Controls.Add(this.cbxCrepetir);
            this.Controls.Add(this.cbxCnueva);
            this.Controls.Add(this.txtCrepetir);
            this.Controls.Add(this.lblCrepetir);
            this.Controls.Add(this.txtCnueva);
            this.Controls.Add(this.lblCnueva);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxCriBusqueda);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRol);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Name = "frmEditarUsuario";
            this.Text = "frmEditarUsuario";
            this.Load += new System.EventHandler(this.frmEditarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxCriBusqueda;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRol;
        private System.Windows.Forms.CheckBox cbxCrepetir;
        private System.Windows.Forms.CheckBox cbxCnueva;
        private System.Windows.Forms.TextBox txtCrepetir;
        private System.Windows.Forms.Label lblCrepetir;
        private System.Windows.Forms.TextBox txtCnueva;
        private System.Windows.Forms.Label lblCnueva;
        private System.Windows.Forms.ComboBox cbxRol;
    }
}