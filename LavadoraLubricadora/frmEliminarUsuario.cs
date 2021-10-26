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
    public partial class frmEliminarUsuario : Form
    {
        LavadoraService.LavadoraServiceClient cliente;
        private static string busqueda;
        private static string valor;

        public frmEliminarUsuario()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            cliente.EliminarUsuario(Convert.ToInt32(dgvUsuarios.SelectedCells[0].Value));
            DialogResult dialogResult = MessageBox.Show("Usuario eliminado con éxito", "Aviso", MessageBoxButtons.OK);
            ActualizarDgvProveedor();
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
                DataTable proveedores = cliente.BuscarUsuarioNombre(txtBusqueda.Text);
                dgvUsuarios.DataSource = proveedores;

            }
            else if (cbxCriBusqueda.SelectedItem.ToString().Equals("Apellido"))
            {
                DataTable proveedores = cliente.BuscarUsuarioApellido(txtBusqueda.Text);
                dgvUsuarios.DataSource = proveedores;

            }
            else if (cbxCriBusqueda.SelectedItem.ToString().Equals("Rol"))
            {
                DataTable proveedores = cliente.BuscarUsuarioRol(cbxRol.SelectedItem.ToString());
                dgvUsuarios.DataSource = proveedores;
            }
            else if (cbxCriBusqueda.SelectedItem.ToString().Equals("Mostrar Todos"))
            {
                DataTable proveedores = cliente.ObtenerProveedor();
                dgvUsuarios.DataSource = proveedores;
            }
            busqueda = cbxCriBusqueda.SelectedItem.ToString();
            valor = txtBusqueda.Text;
        }

        private void frmEliminarUsuario_Load(object sender, EventArgs e)
        {
            cbxCriBusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cliente = new LavadoraService.LavadoraServiceClient();
        }

        public void ActualizarDgvProveedor()
        {
            if (busqueda.Equals("Nombre"))
            {
                DataTable proveedores = cliente.BuscarUsuarioNombre(valor);
                dgvUsuarios.DataSource = proveedores;

            }
            else if (busqueda.Equals("Apellido"))
            {
                DataTable proveedores = cliente.BuscarUsuarioApellido(valor);
                dgvUsuarios.DataSource = proveedores;

            }
            else if (busqueda.Equals("Rol"))
            {
                DataTable proveedores = cliente.BuscarUsuarioRol(valor);
                dgvUsuarios.DataSource = proveedores;
            }
            else if (busqueda.Equals("Mostrar Todos"))
            {
                DataTable proveedores = cliente.ObtenerProveedor();
                dgvUsuarios.DataSource = proveedores;
            }
        }

        private void cbxCriBusqueda_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbxCriBusqueda.SelectedItem.ToString().Equals("Rol"))
            {
                cbxRol.Visible = true;
                txtBusqueda.Visible = false;
            }
            else
            {
                cbxRol.Visible = false;
                txtBusqueda.Visible = true;
            }
        }
    }
}
