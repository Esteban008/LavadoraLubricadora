﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LavadoraLubricadora
{
    public partial class frmGestionEmpleados : Form
    {
        public frmGestionEmpleados()
        {
            InitializeComponent();
        }

        //METODO PARA ABRIR FORMULARIOS DENTRO DEL PANEL
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            //Busca en la colecion el formulario
            formulario = pnlPrincipal.Controls.OfType<MiForm>().FirstOrDefault();
            //si el formulario instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                pnlPrincipal.Controls.Add(formulario);
                pnlPrincipal.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CloseForms);
            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }

        //Metodo que nos permite cerrar los Formularios del Panel
        private void CloseForms(object sender, FormClosedEventArgs e)
        {

            if (Application.OpenForms["frmIngresarUsuario"] == null)
                btnNuevo.BackColor = Color.FromArgb(0, 0, 0);
            if (Application.OpenForms["frmEditarUsuario"] == null)
                btnEditar.BackColor = Color.FromArgb(0, 0, 0);
            if (Application.OpenForms["frmEliminarUsuario"] == null)
                btnEliminar.BackColor = Color.FromArgb(0, 0, 0);

        }

        private void frmGestionEmpleados_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmIngresarUsuario>();
            btnNuevo.BackColor = Color.FromArgb(158, 158, 158);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmEditarUsuario>();
            btnEditar.BackColor = Color.FromArgb(158, 158, 158);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmEliminarUsuario>();
            btnEliminar.BackColor = Color.FromArgb(158, 158, 158);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Seguro que desea Salir?", "Aviso", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
