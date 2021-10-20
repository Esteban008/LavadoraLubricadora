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
    public partial class frmGestionProveedores : Form
    {

        LavadoraService.LavadoraServiceClient cliente;
        int estado = 0;
        public frmGestionProveedores()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Seguro que desea Salir?", "Aviso", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            if (estado == 1)
            {
                cliente.IngresarProveedor(txtRuc.Text, txtNombre.Text, txtApellido.Text, txtTelefono.Text, txtCorreo.Text, txtDireccion.Text, txtEmpresa.Text);
                ActualizarDgvProveedor();
                LimpiarCampos();
                DeshabilitarCampos();
                dgvProveedores.Enabled = true;
            }
            else if(estado == 2){
                cliente.EditarProveedor(Convert.ToInt32(dgvProveedores.SelectedCells[0].Value), txtRuc.Text, txtNombre.Text, txtApellido.Text, txtTelefono.Text, txtCorreo.Text, txtDireccion.Text, txtEmpresa.Text);
                ActualizarDgvProveedor();
                LimpiarCampos();
                DeshabilitarCampos();
            }
        }

        private void frmGestionProveedores_Load(object sender, EventArgs e)
        {
            cliente = new LavadoraService.LavadoraServiceClient();
            //Necesitamos una clase que llame lista de aceites para importar aca
            ActualizarDgvProveedor();
            DeshabilitarCampos();
        }



        public void ActualizarDgvProveedor()
        {
            DataTable proveedores = cliente.ObtenerProveedor();
            dgvProveedores.DataSource = proveedores;
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

        private void DeshabilitarCampos()
        {
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtRuc.Enabled = false;
            txtTelefono.Enabled = false;
            txtCorreo.Enabled = false;
            txtDireccion.Enabled = false;
            txtEmpresa.Enabled = false;
        }

        private void HabilitarCampos()
        {
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtRuc.Enabled = true;
            txtTelefono.Enabled = true;
            txtCorreo.Enabled = true;
            txtDireccion.Enabled = true;
            txtEmpresa.Enabled = true;
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
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            HabilitarCampos();
            estado = 1;
            dgvProveedores.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            estado = 2;
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            cliente.EliminarProveedor(Convert.ToInt32(dgvProveedores.SelectedCells[0].Value));
            LimpiarCampos();
            ActualizarDgvProveedor();
        }
    }
}
