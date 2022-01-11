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
    public partial class frmAdminUsuarios : Form
    {
        LavadoraService.LavadoraServiceClient cliente;
        private static string busqueda;
        private static string valor;

        public frmAdminUsuarios()
        {
            InitializeComponent();
        }

        private void frmAdminUsuarios_Load(object sender, EventArgs e)
        {
            cliente = new LavadoraService.LavadoraServiceClient();
            //PESTAÑA DE EDITAR
            LoadIngresar();

            //PESTAÑA DE EDITAR
            LoadEditar();

            //PESTAÑA ELIMINAR
           LoadEliminar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Seguro que desea Salir?", "Aviso", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        #region Ingresar

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cliente.ValidarUsuarioIngresar(txtCorreo.Text))
                {
                    MessageBox.Show("\t      Este Usuario ya existe. \nSi desea actualizar los datos seleccione el boton Editar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (txtCRepetir.Text.Equals(txtClaveNueva.Text))
                    {
                        cliente.IngresarUsuario(txtNombre.Text, txtApellido.Text, txtTelefono.Text, txtCorreo.Text, txtRol.Text, txtCRepetir.Text);
                        DialogResult dialogResult = MessageBox.Show("Usuario ingresado con éxito", "Aviso", MessageBoxButtons.OK);
                        LimpiarCampos();
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("Las contraseñas no coinciden", "Aviso", MessageBoxButtons.OK);
                        txtClaveNueva.Clear();
                        txtCRepetir.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                DialogResult dialogResult = MessageBox.Show("Ha ocurrido un error de connección" + ex, "Aviso", MessageBoxButtons.OK);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        public void LoadIngresar()
        {
            txtClaveNueva.UseSystemPasswordChar = true;
            txtCRepetir.UseSystemPasswordChar = true;
        }

        public void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtClaveNueva.Clear();
            txtCRepetir.Clear();
            txtRol.Clear();
        }

        private void checkboxCNueva_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxCNueva.Checked)
            {
                txtClaveNueva.UseSystemPasswordChar = false;
            }
            else
            {
                txtClaveNueva.UseSystemPasswordChar = true;
            }
        }

        private void checkboxCRepetir_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxCRepetir.Checked)
            {
                txtCRepetir.UseSystemPasswordChar = false;
            }
            else
            {
                txtCRepetir.UseSystemPasswordChar = true;
            }
        }

        #endregion

        #region Editar

        private void btnBuscarE_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarCamposE();

                if (cbxCriBusquedaE.SelectedItem.ToString().Equals("Rol"))
                {
                    DataTable usuarios = cliente.BuscarUsuarioRol(txtBusquedaE.Text);
                    dgvUsuariosE.DataSource = usuarios;

                }
                else if (cbxCriBusquedaE.SelectedItem.ToString().Equals("Nombre"))
                {
                    DataTable usuarios = cliente.BuscarUsuarioNombre(txtBusquedaE.Text);
                    dgvUsuariosE.DataSource = usuarios;

                }
                else if (cbxCriBusquedaE.SelectedItem.ToString().Equals("Apellido"))
                {
                    DataTable usuarios = cliente.BuscarUsuarioApellido(txtBusquedaE.Text);
                    dgvUsuariosE.DataSource = usuarios;

                }
                else if (cbxCriBusquedaE.SelectedItem.ToString().Equals("Mostrar Todos"))
                {
                    DataTable usuarios = cliente.ObtenerUsuarios();
                    dgvUsuariosE.DataSource = usuarios;
                }
                busqueda = cbxCriBusquedaE.SelectedItem.ToString();
                valor = txtBusquedaE.Text;
            }
            catch (Exception)
            {
                DialogResult dialogResult = MessageBox.Show("Ha ocurrido un error de connección", "Aviso", MessageBoxButtons.OK);
            }
        }

        private void btnGuardarE_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkCambioC.Checked)
                {
                    cliente.EditarUsuario(Convert.ToInt32(dgvUsuariosE.SelectedCells[0].Value), txtNombreE.Text, txtApellidoE.Text, txtTelefonoE.Text, txtCorreoE.Text, txtRolE.Text, txtCRepetir.Text);
                    DialogResult dialogResult = MessageBox.Show("Usuario actualizado con éxito", "Aviso", MessageBoxButtons.OK);
                    LimpiarCamposE();
                    ActualizarDgvUsuariosE();
                }
                else
                {
                    cliente.EditarUsuarioSinContrasenia(Convert.ToInt32(dgvUsuariosE.SelectedCells[0].Value), txtNombreE.Text, txtApellidoE.Text, txtTelefonoE.Text, txtCorreoE.Text, txtRolE.Text);
                    DialogResult dialogResult = MessageBox.Show("Usuario actualizado con éxito", "Aviso", MessageBoxButtons.OK);
                    LimpiarCamposE();
                    ActualizarDgvUsuariosE();                    
                }
                
            }
            catch (Exception)
            {
                DialogResult dialogResult = MessageBox.Show("Ha ocurrido un error de connección", "Aviso", MessageBoxButtons.OK);
            }
        }

        private void btnCancelarE_Click(object sender, EventArgs e)
        {
            LimpiarCamposE();
        }

        public void LoadEditar()
        {
            cbxCriBusquedaE.DropDownStyle = ComboBoxStyle.DropDownList;
            txtBusquedaE.Visible = false;
            txtClaveNuevaE.UseSystemPasswordChar = true;
            txtCRepetirE.UseSystemPasswordChar = true;
            lblCNueva.Visible = false;
            lblCRepetir.Visible = false;
            txtClaveNuevaE.Visible = false;
            txtCRepetirE.Visible = false;
            checkboxCNuevaE.Visible = false;
            checkboxCRepetirE.Visible = false;
        }

        public void ActualizarDgvUsuariosE()
        {
            if (busqueda.Equals("Rol"))
            {
                DataTable usuarios = cliente.BuscarUsuarioRol(valor);
                dgvUsuariosE.DataSource = usuarios;

            }
            else if (busqueda.Equals("Nombre"))
            {
                DataTable usuarios = cliente.BuscarUsuarioNombre(valor);
                dgvUsuariosE.DataSource = usuarios;

            }
            else if (busqueda.Equals("Apellido"))
            {
                DataTable usuarios = cliente.BuscarUsuarioApellido(valor);
                dgvUsuariosE.DataSource = usuarios;

            }
            else if (busqueda.Equals("Mostrar Todos"))
            {
                DataTable usuarios = cliente.ObtenerUsuarios();
                dgvUsuariosE.DataSource = usuarios;
            }
        }

        public void LimpiarCamposE()
        {
            txtNombreE.Clear();
            txtApellidoE.Clear();
            txtTelefonoE.Clear();
            txtCorreoE.Clear();
            txtCRepetirE.Clear();
            txtClaveNuevaE.Clear();
            txtRolE.Clear();
        }

        private void cbxCriBusquedaE_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbxCriBusquedaE.SelectedItem.ToString().Equals("Mostrar Todos"))
            {
                txtBusquedaE.Visible = false;
                txtBusquedaE.Clear();
            }
            else
            {
                txtBusquedaE.Visible = true;
                txtBusquedaE.Clear();
            }
        }

        private void dgvUsuariosE_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombreE.Text = dgvUsuariosE.SelectedCells[1].Value.ToString();
            txtApellidoE.Text = dgvUsuariosE.SelectedCells[2].Value.ToString();
            txtTelefonoE.Text = dgvUsuariosE.SelectedCells[3].Value.ToString();
            txtCorreoE.Text = dgvUsuariosE.SelectedCells[4].Value.ToString();
            txtRolE.Text = dgvUsuariosE.SelectedCells[5].Value.ToString();
        }

        private void checkboxCNuevaE_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxCNuevaE.Checked)
            {
                txtClaveNuevaE.UseSystemPasswordChar = false;
            }
            else
            {
                txtClaveNuevaE.UseSystemPasswordChar = true;
            }
        }

        private void checkboxCRepetirE_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxCRepetirE.Checked)
            {
                txtCRepetirE.UseSystemPasswordChar = false;
            }
            else
            {
                txtCRepetirE.UseSystemPasswordChar = true;
            }
        }

        private void checkCambioC_CheckedChanged(object sender, EventArgs e)
        {
            if (checkCambioC.Checked)
            {
                lblCNueva.Visible = true;
                lblCRepetir.Visible = true;
                txtClaveNuevaE.Visible = true;
                txtCRepetirE.Visible = true;
                checkboxCNuevaE.Visible = true;
                checkboxCRepetirE.Visible = true;
            }
            else
            {
                lblCNueva.Visible = false;
                lblCRepetir.Visible = false;
                txtClaveNuevaE.Visible = false;
                txtCRepetirE.Visible = false;
                checkboxCNuevaE.Visible = false;
                checkboxCRepetirE.Visible = false;
            }
        }

        #endregion

        #region Eliminar

        public void LoadEliminar()
        {
            cbxCriBusquedaD.DropDownStyle = ComboBoxStyle.DropDownList;
            txtBusquedaD.Visible = false;
        }

        private void btnBuscarD_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxCriBusquedaD.SelectedItem.ToString().Equals("Rol"))
                {
                    DataTable clientes = cliente.BuscarUsuarioRol(txtBusquedaD.Text);
                    dgvUsuariosD.DataSource = clientes;

                }
                else if (cbxCriBusquedaD.SelectedItem.ToString().Equals("Nombre"))
                {
                    DataTable clientes = cliente.BuscarUsuarioNombre(txtBusquedaD.Text);
                    dgvUsuariosD.DataSource = clientes;

                }
                else if (cbxCriBusquedaD.SelectedItem.ToString().Equals("Apellido"))
                {
                    DataTable clientes = cliente.BuscarUsuarioApellido(txtBusquedaD.Text);
                    dgvUsuariosD.DataSource = clientes;

                }
                else if (cbxCriBusquedaD.SelectedItem.ToString().Equals("Mostrar Todos"))
                {
                    DataTable clientes = cliente.ObtenerUsuarios();
                    dgvUsuariosD.DataSource = clientes;
                }
                busqueda = cbxCriBusquedaD.SelectedItem.ToString();
                valor = txtBusquedaD.Text;
            }
            catch (Exception)
            {
                DialogResult dialogResult = MessageBox.Show("Ha ocurrido un error de connección", "Aviso", MessageBoxButtons.OK);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cliente.EliminarUsuario(Convert.ToInt32(dgvUsuariosD.SelectedCells[0].Value)))
                {
                    DialogResult dialogResult = MessageBox.Show("Usuario eliminado con éxito", "Aviso", MessageBoxButtons.OK);
                    ActualizarDgvUsuarioD();
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("No es posible eliminar el administrador actual", "Aviso", MessageBoxButtons.OK);
                }
                
               
            }
            catch (Exception)
            {
                DialogResult dialogResult = MessageBox.Show("Ha ocurrido un error de connección", "Aviso", MessageBoxButtons.OK);
            }
        }

        private void cbxCriBusquedaD_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbxCriBusquedaD.SelectedItem.ToString().Equals("Mostrar Todos"))
            {
                txtBusquedaD.Visible = false;
                txtBusquedaD.Clear();
            }
            else
            {
                txtBusquedaD.Visible = true;
                txtBusquedaD.Clear();
            }
        }

        public void ActualizarDgvUsuarioD()
        {
            if (busqueda.Equals("Rol"))
            {
                DataTable usuarios = cliente.BuscarUsuarioRol(valor);
                dgvUsuariosD.DataSource = usuarios;

            }
            else if (busqueda.Equals("Nombre"))
            {
                DataTable usuarios = cliente.BuscarUsuarioNombre(valor);
                dgvUsuariosD.DataSource = usuarios;

            }
            else if (busqueda.Equals("Apellido"))
            {
                DataTable usuarios = cliente.BuscarUsuarioApellido(valor);
                dgvUsuariosD.DataSource = usuarios;

            }
            else if (busqueda.Equals("Mostrar Todos"))
            {
                DataTable usuarios = cliente.ObtenerUsuarios();
                dgvUsuariosD.DataSource = usuarios;
            }
        }


        #endregion


    }
}
