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
    public partial class frmPrincipalU : Form
    {
        public frmPrincipalU()
        {
            InitializeComponent();
            DiseñoSubmenus();
        }
        private void DiseñoSubmenus()
        {
            pnlSubmenuBuscar.Visible = false;
            pnlSubmenuVentas.Visible = false;
            pnlSubmenuAdmin.Visible = false;
            pnlSubMenuNotificaciones.Visible = false;
        }

        private void OcultarSubmenu()
        {

            if (pnlSubmenuBuscar.Visible == true)
            {
                pnlSubmenuBuscar.Visible = false;
            }

            if (pnlSubmenuVentas.Visible == true)
            {
                pnlSubmenuVentas.Visible = false;
            }


            if (pnlSubmenuAdmin.Visible == true)
            {
                pnlSubmenuAdmin.Visible = false;
            }

            if (pnlSubMenuNotificaciones.Visible == true)
            {
                pnlSubMenuNotificaciones.Visible = false;
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
            formulario = pnlAdmin.Controls.OfType<MiForm>().FirstOrDefault();
            //si el formulario instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                pnlAdmin.Controls.Add(formulario);
                pnlAdmin.Tag = formulario;
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
            if (Application.OpenForms["frmBuscarProducto"] == null)
                btnBuscarOtros.BackColor = Color.FromArgb(255, 255, 255);
            if (Application.OpenForms["frmBusquedaVehiculo"] == null)
                btnBusquedaxVehiculo.BackColor = Color.FromArgb(255, 255, 255);


            if (Application.OpenForms["frmComprabanteVenta"] == null)
                btnComprobanteVenta.BackColor = Color.FromArgb(255, 255, 255);
            if (Application.OpenForms["frmAdminClientes"] == null)
                btnAdminClientes.BackColor = Color.FromArgb(255, 255, 255);


            if (Application.OpenForms["frmGenerarReportes"] == null)
                btnGReportesVentas.BackColor = Color.FromArgb(255, 255, 255);

            if (Application.OpenForms["frmNotificaciones"] == null)
                btnVNotificacion.BackColor = Color.FromArgb(255, 255, 255);

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
            AbrirFormulario<frmBuscarProducto>();
            btnBuscarOtros.BackColor = Color.FromArgb(199, 207, 225);
        }

        private void btnBusquedaxVehiculo_Click(object sender, EventArgs e)
        {
            btnBusquedaxVehiculo.BackColor = Color.FromArgb(199, 207, 225);
            AbrirFormulario<frmBusquedaVehiculo>();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            if (pnlSubmenuVentas.Visible == false)
            {
                OcultarSubmenu();
                MostrarSubmenu(pnlSubmenuVentas);
            }
            else
            {
                OcultarSubmenu();
            }
        }

        private void btnComprobanteVenta_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmComprabanteVenta>();
            btnComprobanteVenta.BackColor = Color.FromArgb(199, 207, 225);
        }

        private void btnAdminClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmAdminClientes>();
            btnAdminClientes.BackColor = Color.FromArgb(199, 207, 225);
        }

        private void btnAdministracion_Click(object sender, EventArgs e)
        {
            if (pnlSubmenuAdmin.Visible == false)
            {
                OcultarSubmenu();
                MostrarSubmenu(pnlSubmenuAdmin);
            }
            else
            {
                OcultarSubmenu();
            }
        }

        private void btnGReportesVentas_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmGenerarReportes>();
            btnGReportesVentas.BackColor = Color.FromArgb(199, 207, 225);
        }

        private void btnNotificacion_Click(object sender, EventArgs e)
        {
            if (pnlSubMenuNotificaciones.Visible == false)
            {
                OcultarSubmenu();
                MostrarSubmenu(pnlSubMenuNotificaciones);
            }
            else
            {
                OcultarSubmenu();
            }
        }

        private void btnVNotificacion_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmNotificaciones>();
            btnVNotificacion.BackColor = Color.FromArgb(199, 207, 225);
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPrincipalU_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.UserClosing)
            {
                return;
            }

            DialogResult dialog = MessageBox.Show("¿Esta seguro de salir?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
    }
}
