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
            pnlSubmenuVentas.Visible = false;
            pnlSubmenuCompras.Visible = false;
            pnlSubmenuAdmin.Visible = false;
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

            if (pnlSubmenuVentas.Visible == true)
            {
                pnlSubmenuVentas.Visible = false;
            }

            if (pnlSubmenuCompras.Visible == true)
            {
                pnlSubmenuCompras.Visible = false;
            }

            if (pnlSubmenuAdmin.Visible == true)
            {
                pnlSubmenuAdmin.Visible = false;
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


            if (Application.OpenForms["frmAdminAceites"] == null)
                btnAdmAceite.BackColor = Color.FromArgb(255, 255, 255);
            if (Application.OpenForms["frmAdminVehiculos"] == null)
                btnAdmVehiculo.BackColor = Color.FromArgb(255, 255, 255);
            if (Application.OpenForms["frmAdminFiltros"] == null)
                btnAdmFiltro.BackColor = Color.FromArgb(255, 255, 255);
            if (Application.OpenForms["frmAdminProductos"] == null)
                btnAdmOtro.BackColor = Color.FromArgb(255, 255, 255);


            if (Application.OpenForms["frmComprabanteVenta"] == null)
                btnComprobanteVenta.BackColor = Color.FromArgb(255, 255, 255);
            if (Application.OpenForms["frmAdminClientes"] == null)
                btnAdminClientes.BackColor = Color.FromArgb(255, 255, 255);


            if (Application.OpenForms["frmComprobanteCompra"] == null)
                btnComprobanteCompra.BackColor = Color.FromArgb(255, 255, 255);
            if (Application.OpenForms["frmAdminProveedores"] == null)
                btnAdminProveedores.BackColor = Color.FromArgb(255, 255, 255);


            if (Application.OpenForms["frmGenerarReportes"] == null)
                btnGReportesVentas.BackColor = Color.FromArgb(255, 255, 255);
            if (Application.OpenForms["frmAdminUsuarios"] == null)
                btnGReporteCompras.BackColor = Color.FromArgb(255, 255, 255);      
                
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
            AbrirFormulario<frmAdminAceites>();
            btnAdmAceite.BackColor = Color.FromArgb(199, 207, 225);           
        }

        private void btnAdmFiltro_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmAdminFiltros>();
            btnAdmFiltro.BackColor = Color.FromArgb(199, 207, 225);
         
        }

        private void btnAdmOtro_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmAdminProductos>();
            btnAdmOtro.BackColor = Color.FromArgb(199, 207, 225);
        }

        private void btnAdmVehiculo_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmAdminVehiculos>();
            btnAdmVehiculo.BackColor = Color.FromArgb(199, 207, 225);         
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

        private void btnCompras_Click(object sender, EventArgs e)
        {
            if (pnlSubmenuCompras.Visible == false)
            {
                OcultarSubmenu();
                MostrarSubmenu(pnlSubmenuCompras);
            }
            else
            {
                OcultarSubmenu();
            }
        }

        private void btnComprobanteCompra_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmComprobanteCompra>();
            btnComprobanteCompra.BackColor = Color.FromArgb(199, 207, 225);
        }

        private void btnAdminProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmAdminProveedores>();
            btnAdminProveedores.BackColor = Color.FromArgb(199, 207, 225);
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

        private void btnAdminUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmAdminUsuarios>();
            btnAdminUsuario.BackColor = Color.FromArgb(199, 207, 225);
        }

        private void btnGReportesVentas_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmGenerarReportes>();
            btnGReportesVentas.BackColor = Color.FromArgb(199, 207, 225);
        }

        private void btnGReporteCompras_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmGenerarReporteCompras>();
            btnGReporteCompras.BackColor = Color.FromArgb(199, 207, 225);
        }
    }
}
