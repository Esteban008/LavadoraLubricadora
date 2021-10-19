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
    public partial class frmGestionEmpleados : Form
    {

        LavadoraService.LavadoraServiceClient cliente;
        int estado = 0;
        public frmGestionEmpleados()
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            HabilitarCampos();
            MostrarClaveNueva();
            estado = 1;
            btnGuardar.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            MostrarClave();
            estado = 2;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (estado == 1)
            {
                cliente.IngresarUsuario(txtNombre.Text, txtApellido.Text, txtTelefono.Text, txtCorreo.Text, txtRol.Text, txtCnueva.Text);
                ActualizarDgvUsuario();
                LimpiarCampos();
                DeshabilitarCampos();
            }
            else if (estado == 2)
            {
                
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void frmGestionEmpleados_Load(object sender, EventArgs e)
        {
            cliente = new LavadoraService.LavadoraServiceClient();
            //Necesitamos una clase que llame lista de aceites para importar aca
            ActualizarDgvUsuario();
            DeshabilitarCampos();
            OcultarClave();
            txtCactual.UseSystemPasswordChar = true;
            txtCnueva.UseSystemPasswordChar = true;
            txtCrepetir.UseSystemPasswordChar = true;
        }

        public void ActualizarDgvUsuario()
        {
            DataTable usuarios = cliente.ObtenerUsuarios();
            dgvUsuarios.DataSource = usuarios;
        }

        public void OcultarClave()
        {
            lblCactual.Visible = false;
            txtCactual.Visible = false;
            lblCnueva.Visible = false;
            txtCnueva.Visible = false;
            lblCrepetir.Visible = false;
            txtCrepetir.Visible = false;
        }

        public void MostrarClave()
        {
            lblCactual.Visible = true;
            txtCactual.Visible = true;
            lblCnueva.Visible = true;
            txtCnueva.Visible = true;
            lblCrepetir.Visible = true;
            txtCrepetir.Visible = true;
        }

        public void MostrarClaveNueva()
        {
            
            lblCnueva.Visible = true;
            txtCnueva.Visible = true;
            lblCrepetir.Visible = true;
            txtCrepetir.Visible = true;
        }

        private void DeshabilitarCampos()
        {
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtTelefono.Enabled = false;
            txtCorreo.Enabled = false;
            txtRol.Enabled = false;
            //txtEmpresa.Enabled = false;
        }

        private void HabilitarCampos()
        {
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtTelefono.Enabled = true;
            txtCorreo.Enabled = true;
            txtRol.Enabled = true;
            //txtEmpresa.Enabled = true;
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            //txtRuc.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtRol.Clear();
            //txtEmpresa.Clear();
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombre.Text = dgvUsuarios.SelectedCells[1].Value.ToString();
            txtApellido.Text = dgvUsuarios.SelectedCells[2].Value.ToString();
            txtTelefono.Text = dgvUsuarios.SelectedCells[3].Value.ToString();
            txtCorreo.Text = dgvUsuarios.SelectedCells[4].Value.ToString();
            txtRol.Text = dgvUsuarios.SelectedCells[5].Value.ToString();
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

        private void cbxCactual_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxCactual.Checked)
            {
                txtCactual.UseSystemPasswordChar = false;
            }
            else
            {
                txtCactual.UseSystemPasswordChar = true;
            }
            
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
    }
}
