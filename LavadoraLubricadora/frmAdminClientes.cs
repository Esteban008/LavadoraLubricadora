﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
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
                    if (txtNombre.Text!="" && txtApellido.Text != "" && txtTelefono.Text != "" && txtCorreo.Text != "" && txtCedula.Text != "" && 
                        txtDireccion.Text != "")
                    {
                        int resuitado = cliente.IngresarCliente(txtNombre.Text, txtApellido.Text, txtTelefono.Text, txtCorreo.Text, txtCedula.Text, txtDireccion.Text);
                        if (resuitado==1)
                        {
                            DialogResult dialogResult = MessageBox.Show("Cliente ingresado con éxito", "Aviso", MessageBoxButtons.OK);
                            LimpiarCampos();
                        }
                        else
                        {
                            DialogResult dialogResult = MessageBox.Show("Cliente no ingresado! Revise los datos ingresados", "Aviso", MessageBoxButtons.OK);
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Uno o más campos están vacíos", "Aviso", MessageBoxButtons.OK);
                    }

                }
            }
            catch (EndpointNotFoundException)
            {
                DialogResult dialogResult = MessageBox.Show("Ha ocurrido un error de conexión", "Aviso", MessageBoxButtons.OK);
            }
            catch (Exception)
            {
                DialogResult dialogResult = MessageBox.Show("Ha ocurrido un error de conexión", "Aviso", MessageBoxButtons.OK);
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

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            //defenimos el rango de codigos ASCII que admite solo numeros a la entrada
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 44 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo está permitido números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            //defenimos el rango de codigos ASCII que admite solo numeros a la entrada
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 44 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo está permitido números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }

        #endregion

        #region Editar

        private void btnBuscarE_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxCriBusquedaE.SelectedItem != null)
                {
                    LimpiarCamposE();
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
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Selecione un criterio de búsqueda", "Aviso", MessageBoxButtons.OK);
                }
                
            }
            catch (Exception)
            {
                DialogResult dialogResult = MessageBox.Show("Ha ocurrido un error de conexión", "Aviso", MessageBoxButtons.OK);
            }                      
        }

        private void btnGuardarE_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombreE.Text != "" && txtApellidoE.Text != "" && txtTelefonoE.Text != "" && txtCorreoE.Text != "" && txtCedulaE.Text != "" &&
                        txtDireccionE.Text != "")
                {
                    int resultado = cliente.EditarCliente(Convert.ToInt32(dgvClientesE.SelectedCells[0].Value), txtNombreE.Text, txtApellidoE.Text, txtTelefonoE.Text, txtCorreoE.Text, txtCedulaE.Text, txtDireccionE.Text);
                    if (resultado==1)
                    {
                        DialogResult dialogResult = MessageBox.Show("Cliente actualizado con éxito", "Aviso", MessageBoxButtons.OK);
                        LimpiarCamposE();
                        ActualizarDgvClienteE();
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("Cliente no actualizado! Revise los datos ingresados", "Aviso", MessageBoxButtons.OK);
                    }
                    
                }
                else
                {
                    MessageBox.Show("Uno o más campos están vacíos", "Aviso", MessageBoxButtons.OK);
                }

            }
            catch (Exception)
            {
                DialogResult dialogResult = MessageBox.Show("Ha ocurrido un error de conexión", "Aviso", MessageBoxButtons.OK);
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
            try
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
            catch (Exception)
            {
                DialogResult dialogResult = MessageBox.Show("Ha ocurrido un error", "Aviso", MessageBoxButtons.OK);
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
            try
            {
                if (cbxCriBusquedaE.SelectedItem != null)
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
            }
            catch (NullReferenceException)
            {
                DialogResult dialogResult = MessageBox.Show("Seleccione un criterio de búsqueda", "Aviso", MessageBoxButtons.OK);
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Aviso", MessageBoxButtons.YesNo);
            }
        }

        private void dgvClientesE_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtNombreE.Text = dgvClientesE.SelectedCells[1].Value.ToString();
                txtApellidoE.Text = dgvClientesE.SelectedCells[2].Value.ToString();
                txtTelefonoE.Text = dgvClientesE.SelectedCells[3].Value.ToString();
                txtCorreoE.Text = dgvClientesE.SelectedCells[4].Value.ToString();
                txtCedulaE.Text = dgvClientesE.SelectedCells[5].Value.ToString();
                txtDireccionE.Text = dgvClientesE.SelectedCells[6].Value.ToString();
            }
            catch (ArgumentOutOfRangeException)
            {
                DialogResult dialogResult = MessageBox.Show("Selección no válida", "Aviso", MessageBoxButtons.OK);
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
                if (cbxCriBusquedaD.SelectedItem != null)
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
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Seleccione un criterio de búsqueda", "Aviso", MessageBoxButtons.OK);
                }

            }
            catch (Exception)
            {
                DialogResult dialogResult = MessageBox.Show("Ha ocurrido un error de conexión", "Aviso", MessageBoxButtons.OK);
            }
            
         
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int resultado = cliente.EliminarCliente(Convert.ToInt32(dgvClientesD.SelectedCells[0].Value));

                if (resultado == 1)
                {
                    DialogResult dialogResult = MessageBox.Show("Cliente eliminado con éxito", "Aviso", MessageBoxButtons.OK);
                    ActualizarDgvClienteD();
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("No se puede eliminar este cliente ya que pertenece a un proceso", "Aviso", MessageBoxButtons.OK);
                }
            }
            catch (Exception)
            {
                DialogResult dialogResult = MessageBox.Show("Ha ocurrido un error de conexión", "Aviso", MessageBoxButtons.OK);
            }
        }

        private void cbxCriBusquedaD_SelectedValueChanged(object sender, EventArgs e)
        {

            try
            {
                if (cbxCriBusquedaD.SelectedItem != null)
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
            }
            catch (NullReferenceException)
            {
                DialogResult dialogResult = MessageBox.Show("Seleccione un criterio de búsqueda", "Aviso", MessageBoxButtons.OK);
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Aviso", MessageBoxButtons.YesNo);
            }
        }

        public void ActualizarDgvClienteD()
        {
            try
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
            catch (Exception)
            {
                DialogResult dialogResult = MessageBox.Show("Ha ocurrido un error de conexión", "Aviso", MessageBoxButtons.OK);
            }

        }
        #endregion

       
    }
}
