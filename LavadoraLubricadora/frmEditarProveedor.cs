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
    public partial class frmEditarProveedor : Form
    {
        LavadoraService.LavadoraServiceClient cliente;
        public frmEditarProveedor()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            cliente.EditarProveedor(Convert.ToInt32(dgvProveedores.SelectedCells[0].Value), txtRuc.Text, txtNombre.Text, txtApellido.Text, txtTelefono.Text, txtCorreo.Text, txtDireccion.Text, txtEmpresa.Text);
            ActualizarDgvProveedor();
            LimpiarCampos();
            DialogResult dialogResult = MessageBox.Show("Proveedor guardado con éxito", "Aviso", MessageBoxButtons.OK);
        }

        private void frmEditarProveedor_Load(object sender, EventArgs e)
        {
            cliente = new LavadoraService.LavadoraServiceClient();
        }


        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtRuc.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtDireccion.Clear();
            txtEmpresa.Clear();
        }


        public void ActualizarDgvProveedor()
        {
            DataTable proveedores = cliente.ObtenerProveedor();
            dgvProveedores.DataSource = proveedores;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Seguro que desea Salir?", "Aviso", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dgvProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombre.Text = dgvProveedores.SelectedCells[1].Value.ToString();
            txtApellido.Text = dgvProveedores.SelectedCells[2].Value.ToString();
            txtRuc.Text = dgvProveedores.SelectedCells[3].Value.ToString();
            txtTelefono.Text = dgvProveedores.SelectedCells[4].Value.ToString();
            txtCorreo.Text = dgvProveedores.SelectedCells[5].Value.ToString();
            txtDireccion.Text = dgvProveedores.SelectedCells[6].Value.ToString();
            txtEmpresa.Text = dgvProveedores.SelectedCells[7].Value.ToString();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
