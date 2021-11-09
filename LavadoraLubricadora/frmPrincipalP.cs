using System;
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
    public partial class frmPrincipalP : Form
    {
        public frmPrincipalP()
        {
            InitializeComponent();
            DiseñoSubmenus();
        }

        private void DiseñoSubmenus()
        {
            pnlSubmenuAdmProductos.Visible = false;
            pnlSubmenuBuscar.Visible = false;
        }
         private void OcultarSubmenu()
        {
            if (pnlSubmenuAdmProductos.Visible == true)
            {
                pnlSubmenuAdmProductos.Visible = false;
            }

            if (pnlSubmenuBuscar.Visible == true)
            {
                pnlSubmenuBuscar.Visible = false;
            }
        }

        private void MostrarSubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                OcultarSubmenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
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
            if (Application.OpenForms["frmBuscarAceite"] == null)
                btnBuscarAceite.BackColor = Color.FromArgb(255, 255, 255);
            if (Application.OpenForms["frmBuscarFiltro"] == null)
                btnBuscarFiltro.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void btnBuscarProductos_Click(object sender, EventArgs e)
        {
            if (pnlSubmenuBuscar.Visible == false)
            {
                OcultarSubmenu();
                MostrarSubmenu(pnlSubmenuBuscar);
            }
            else
            {
                OcultarSubmenu();
            }                   
        }

        private void btnBuscarAceite_Click(object sender, EventArgs e)
        {         
            AbrirFormulario<frmBuscarAceite>();
            btnBuscarAceite.BackColor = Color.FromArgb(199, 207, 225);
        }

        private void btnBuscarFiltro_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmBuscarFiltro>();
            btnBuscarFiltro.BackColor = Color.FromArgb(199, 207, 225);
        }

        private void btnBuscarOtros_Click(object sender, EventArgs e)
        {
            btnBuscarOtros.BackColor = Color.FromArgb(199, 207, 225);
        }

        private void btnBusquedaxVehiculo_Click(object sender, EventArgs e)
        {
            btnBusquedaxVehiculo.BackColor = Color.FromArgb(199, 207, 225);
            AbrirFormulario<frmBusquedaVehiculo>();
        }


        private void btnAdmProductos_Click(object sender, EventArgs e)
        {
            if(pnlSubmenuAdmProductos.Visible == false)
            {
                OcultarSubmenu();
                MostrarSubmenu(pnlSubmenuAdmProductos);
            }
            else
            {
                OcultarSubmenu();
            }
                   
        }

        private void btnAdmAceite_Click(object sender, EventArgs e)
        {
            btnAdmAceite.BackColor = Color.FromArgb(199, 207, 225);
            AbrirFormulario<frmAdminAceites>();
        }

        private void btnAdmFiltro_Click(object sender, EventArgs e)
        {
            btnAdmFiltro.BackColor = Color.FromArgb(199, 207, 225);
        }

        private void btnAdmOtro_Click(object sender, EventArgs e)
        {
            btnAdmOtro.BackColor = Color.FromArgb(199, 207, 225);
        }

        private void btnAdmVehiculo_Click(object sender, EventArgs e)
        {
            btnAdmVehiculo.BackColor = Color.FromArgb(199, 207, 225);
        }
    }
}
