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
    public partial class frmAdminClientes : Form
    {
        LavadoraService.LavadoraServiceClient cliente;
        private static string busqueda;
        private static string valor;


        public frmAdminClientes()
        {
            InitializeComponent();
        }

        private void frmAdminClientes_Load(object sender, EventArgs e)
        {
            cliente = new LavadoraService.LavadoraServiceClient();

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
                if (cliente.ValidarCliente(txtCedula.Text))
                {
                    MessageBox.Show("\t      Este Cliente ya existe. \nSi desea actualizar los datos seleccione el boton Editar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cliente.IngresarCliente(txtNombre.Text, txtApellido.Text, txtTelefono.Text, txtCorreo.Text, txtCedula.Text, txtDireccion.Text);
                    DialogResult dialogResult = MessageBox.Show("Cliente ingresado con éxito", "Aviso", MessageBoxButtons.OK);
                    LimpiarCampos();
                }
            }
            catch (Exception)
            {
                DialogResult dialogResult = MessageBox.Show("Ha ocurrido un error de connección", "Aviso", MessageBoxButtons.OK);
            }          
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        public void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtCedula.Clear();
            txtDireccion.Clear();
        }

        #endregion

        #region Editar

        private void btnBuscarE_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxCriBusquedaE.SelectedItem.ToString().Equals("Cédula"))
                {
                    DataTable clientes = cliente.BuscarClienteCedula(txtBusquedaE.Text);
                    dgvClientesE.DataSource = clientes;

                }
                else if (cbxCriBusquedaE.SelectedItem.ToString().Equals("Apellido"))
                {
                    DataTable clientes = cliente.BuscarClienteApellido(txtBusquedaE.Text);
                    dgvClientesE.DataSource = clientes;

                }
                else if (cbxCriBusquedaE.SelectedItem.ToString().Equals("Mostrar Todos"))
                {
                    DataTable clientes = cliente.ObtenerClientes();
                    dgvClientesE.DataSource = clientes;
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
                    cliente.EditarCliente(Convert.ToInt32(dgvClientesE.SelectedCells[0].Value), txtNombreE.Text, txtApellidoE.Text, txtTelefonoE.Text, txtCorreoE.Text, txtCedulaE.Text, txtDireccionE.Text);
                    DialogResult dialogResult = MessageBox.Show("Cliente actualizado con éxito", "Aviso", MessageBoxButtons.OK);
                    LimpiarCamposE();
                    ActualizarDgvClienteE();         
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
        }

        public void ActualizarDgvClienteE()
        {
            if (busqueda.Equals("Cédula"))
            {
                DataTable clientes = cliente.BuscarClienteCedula(valor);
                dgvClientesE.DataSource = clientes;

            }
            else if (busqueda.Equals("Apellido"))
            {
                DataTable clientes = cliente.BuscarClienteApellido(valor);
                dgvClientesE.DataSource = clientes;

            }
            else if (busqueda.Equals("Mostrar Todos"))
            {
                DataTable clientes = cliente.ObtenerClientes();
                dgvClientesE.DataSource = clientes;
            }
        }

        public void LimpiarCamposE()
        {
            txtNombreE.Clear();
            txtApellidoE.Clear();
            txtTelefonoE.Clear();
            txtCorreoE.Clear();
            txtCedulaE.Clear();
            txtDireccionE.Clear();
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

        private void dgvClientesE_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombreE.Text = dgvClientesE.SelectedCells[1].Value.ToString();
            txtApellidoE.Text = dgvClientesE.SelectedCells[2].Value.ToString();
            txtTelefonoE.Text = dgvClientesE.SelectedCells[3].Value.ToString();
            txtCorreoE.Text = dgvClientesE.SelectedCells[4].Value.ToString();
            txtCedulaE.Text = dgvClientesE.SelectedCells[5].Value.ToString();
            txtDireccionE.Text = dgvClientesE.SelectedCells[6].Value.ToString();
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
                if (cbxCriBusquedaD.SelectedItem.ToString().Equals("Cédula"))
                {
                    DataTable clientes = cliente.BuscarClienteCedula(txtBusquedaD.Text);
                    dgvClientesD.DataSource = clientes;

                }
                else if (cbxCriBusquedaD.SelectedItem.ToString().Equals("Apellido"))
                {
                    DataTable clientes = cliente.BuscarClienteApellido(txtBusquedaD.Text);
                    dgvClientesD.DataSource = clientes;

                }
                else if (cbxCriBusquedaD.SelectedItem.ToString().Equals("Mostrar Todos"))
                {
                    DataTable clientes = cliente.ObtenerClientes();
                    dgvClientesD.DataSource = clientes;
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
                cliente.EliminarCliente(Convert.ToInt32(dgvClientesD.SelectedCells[0].Value));
                DialogResult dialogResult = MessageBox.Show("Cliente eliminado con éxito", "Aviso", MessageBoxButtons.OK);
                ActualizarDgvClienteD();
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

        public void ActualizarDgvClienteD()
        {
            if (busqueda.Equals("Cédula"))
            {
                DataTable clientes = cliente.BuscarClienteCedula(valor);
                dgvClientesD.DataSource = clientes;

            }
            else if (busqueda.Equals("Apellido"))
            {
                DataTable clientes = cliente.BuscarClienteApellido(valor);
                dgvClientesD.DataSource = clientes;

            }
            else if (busqueda.Equals("Mostrar Todos"))
            {
                DataTable clientes = cliente.ObtenerClientes();
                dgvClientesD.DataSource = clientes;
            }
        }
        #endregion
    }
}
