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
    public partial class frmEditarUsuario : Form
    {
        LavadoraService.LavadoraServiceClient cliente;
        private static string busqueda;
        private static string valor;

        public frmEditarUsuario()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
                cliente.EditarUsuario(Convert.ToInt32(dgvUsuarios.SelectedCells[0].Value), txtNombre.Text, txtApellido.Text, txtTelefono.Text, txtCorreo.Text, txtRol.Text, txtCnueva.Text);
        }

        private void frmEditarUsuario_Load(object sender, EventArgs e)
        {
            cliente = new LavadoraService.LavadoraServiceClient();
            cbxCriBusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxRol.DropDownStyle = ComboBoxStyle.DropDownList;
            txtCnueva.UseSystemPasswordChar = true;
            txtCrepetir.UseSystemPasswordChar = true;
            btnGuardar.Enabled = false; 
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
                DataTable proveedores = cliente.ObtenerUsuarios();
                dgvUsuarios.DataSource = proveedores;
            }

            busqueda = cbxCriBusqueda.SelectedItem.ToString();
            valor = txtBusqueda.Text;
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtRol.Clear();
            txtCnueva.Clear();
            txtCrepetir.Clear();
        }

        private void cbxCnueva_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxCnueva.Checked)
            {
                txtCnueva.UseSystemPasswordChar = false;
            }
            else
            {
                txtCnueva.UseSystemPasswordChar = true;
            }
        }

        private void cbxCrepetir_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxCrepetir.Checked)
            {
                txtCrepetir.UseSystemPasswordChar = false;
            }
            else
            {
                txtCrepetir.UseSystemPasswordChar = true;
            }
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombre.Text = dgvUsuarios.SelectedCells[1].Value.ToString();
            txtApellido.Text = dgvUsuarios.SelectedCells[2].Value.ToString();
            txtTelefono.Text = dgvUsuarios.SelectedCells[3].Value.ToString();
            txtCorreo.Text = dgvUsuarios.SelectedCells[4].Value.ToString();
            txtRol.Text = dgvUsuarios.SelectedCells[5].Value.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Seguro que desea Salir?", "Aviso", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtCrepetir_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtCrepetir.Text.Equals(txtCnueva.Text))
            {
                btnGuardar.Enabled = true;
            }
            else
            {
                btnGuardar.Enabled = false;
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
