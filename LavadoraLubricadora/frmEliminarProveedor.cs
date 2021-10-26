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
    public partial class frmEliminarProveedor : Form
    {
        LavadoraService.LavadoraServiceClient cliente;
        public frmEliminarProveedor()
        {
            InitializeComponent();
        }

        private static string busqueda;
        private static string valor;
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            cliente.EliminarProveedor(Convert.ToInt32(dgvProveedores.SelectedCells[0].Value));
            ActualizarDgvProveedor();
        }

        private void frmEliminarProveedor_Load(object sender, EventArgs e)
        {
            cliente = new LavadoraService.LavadoraServiceClient();
        }


        public void ActualizarDgvProveedor()
        {
            

            if (busqueda.Equals("Nombre"))
            {
                DataTable proveedores = cliente.BuscarProveedorNombre(valor);
                dgvProveedores.DataSource = proveedores;

            }
            else if (busqueda.Equals("Apellido"))
            {
                DataTable proveedores = cliente.BuscarProveedorApellido(valor);
                dgvProveedores.DataSource = proveedores;

            }
            else if (busqueda.Equals("RUC"))
            {
                DataTable proveedores = cliente.BuscarProveedorRuc(valor);
                dgvProveedores.DataSource = proveedores;
            }
            else if (busqueda.Equals("Empresa"))
            {
                DataTable proveedores = cliente.BuscarProveedorEmpresa(valor);
                dgvProveedores.DataSource = proveedores;
            }
            else if (busqueda.Equals("Mostrar Todos"))
            {
                DataTable proveedores = cliente.ObtenerProveedor();
                dgvProveedores.DataSource = proveedores;
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Seguro que desea Salir?", "Aviso", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cbxCriBusqueda.SelectedItem.ToString().Equals("Nombre"))
            {
                DataTable proveedores = cliente.BuscarProveedorNombre(txtBusqueda.Text);
                dgvProveedores.DataSource = proveedores;
                
            }
            else if (cbxCriBusqueda.SelectedItem.ToString().Equals("Apellido"))
            {
                DataTable proveedores = cliente.BuscarProveedorApellido(txtBusqueda.Text);
                dgvProveedores.DataSource = proveedores;
                
            }
            else if (cbxCriBusqueda.SelectedItem.ToString().Equals("RUC"))
            {
                DataTable proveedores = cliente.BuscarProveedorRuc(txtBusqueda.Text);
                dgvProveedores.DataSource = proveedores;
            }
            else if (cbxCriBusqueda.SelectedItem.ToString().Equals("Empresa"))
            {
                DataTable proveedores = cliente.BuscarProveedorEmpresa(txtBusqueda.Text);
                dgvProveedores.DataSource = proveedores;
            }
            else if (cbxCriBusqueda.SelectedItem.ToString().Equals("Mostrar Todos"))
            {
                DataTable proveedores = cliente.ObtenerProveedor();
                dgvProveedores.DataSource = proveedores;
            }

            busqueda = cbxCriBusqueda.SelectedItem.ToString();
            valor = txtBusqueda.Text;


        }
    }
}
