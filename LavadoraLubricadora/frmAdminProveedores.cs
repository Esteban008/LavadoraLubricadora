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
    public partial class frmAdminProveedores : Form
    {
        LavadoraService.LavadoraServiceClient cliente;
        private static string busqueda;
        private static string valor;

        public frmAdminProveedores()
        {
            InitializeComponent();
        }

        private void frmAdminProveedores_Load(object sender, EventArgs e)
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

                if (cliente.ValidarProveedor(txtRuc.Text))
                {
                    MessageBox.Show("\t      Este Proveedor ya existe. \nSi desea actualizar los datos seleccione el boton Editar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cliente.IngresarProveedor(txtRuc.Text,txtNombre.Text, txtApellido.Text, txtTelefono.Text, txtCorreo.Text, txtDireccion.Text, txtEmpresa.Text);
                    DialogResult dialogResult = MessageBox.Show("Proveedor ingresado con éxito", "Aviso", MessageBoxButtons.OK);
                    LimpiarCampos();
                }
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
            txtRuc.Clear();
            txtDireccion.Clear();
            txtEmpresa.Clear();
        }

        private void txtRuc_KeyPress(object sender, KeyPressEventArgs e)
        {
            //defenimos el rango de codigos ASCII que admite solo numeros a la entrada
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 44 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo está permitido números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
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

        #endregion

        #region Editar

        private void btnBuscarE_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxCriBusquedaE.SelectedItem != null)
                {
                        LimpiarCamposE();
                    if (cbxCriBusquedaE.SelectedItem.ToString().Equals("Ruc"))
                    {
                        DataTable proveedores = cliente.BuscarProveedorRuc(txtBusquedaE.Text);
                        dgvProveedoresE.DataSource = proveedores;

                    }
                    else if (cbxCriBusquedaE.SelectedItem.ToString().Equals("Apellido"))
                    {
                        DataTable proveedores = cliente.BuscarProveedorApellido(txtBusquedaE.Text);
                        dgvProveedoresE.DataSource = proveedores;

                    }
                    else if (cbxCriBusquedaE.SelectedItem.ToString().Equals("Empresa"))
                    {
                        DataTable proveedores = cliente.BuscarProveedorEmpresa(txtBusquedaE.Text);
                        dgvProveedoresE.DataSource = proveedores;

                    }
                    else if (cbxCriBusquedaE.SelectedItem.ToString().Equals("Mostrar Todos"))
                    {
                        DataTable proveedores = cliente.ObtenerProveedor();
                        dgvProveedoresE.DataSource = proveedores;
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
                cliente.EditarProveedor(Convert.ToInt32(dgvProveedoresE.SelectedCells[0].Value), txtRucE.Text, txtNombreE.Text, txtApellidoE.Text, txtTelefonoE.Text, txtCorreoE.Text, txtDireccionE.Text, txtEmpresaE.Text);
                DialogResult dialogResult = MessageBox.Show("Proveedor actualizado con éxito", "Aviso", MessageBoxButtons.OK);
                LimpiarCamposE();
                ActualizarDgvProveedorE();
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

        public void ActualizarDgvProveedorE()
        {
            try
            {
                if (busqueda.Equals("Ruc"))
                {
                    DataTable clientes = cliente.BuscarProveedorRuc(valor);
                    dgvProveedoresE.DataSource = clientes;

                }
                else if (busqueda.Equals("Apellido"))
                {
                    DataTable clientes = cliente.BuscarUsuarioApellido(valor);
                    dgvProveedoresE.DataSource = clientes;

                }
                else if (busqueda.Equals("Empresa"))
                {
                    DataTable clientes = cliente.BuscarProveedorEmpresa(valor);
                    dgvProveedoresE.DataSource = clientes;

                }
                else if (busqueda.Equals("Mostrar Todos"))
                {
                    DataTable clientes = cliente.ObtenerProveedor();
                    dgvProveedoresE.DataSource = clientes;
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
            txtRucE.Clear();
            txtDireccionE.Clear();
            txtEmpresaE.Clear();
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

        

        private void dgvProveedoresE_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtNombreE.Text = dgvProveedoresE.SelectedCells[1].Value.ToString();
                txtApellidoE.Text = dgvProveedoresE.SelectedCells[2].Value.ToString();
                txtRucE.Text = dgvProveedoresE.SelectedCells[3].Value.ToString();
                txtTelefonoE.Text = dgvProveedoresE.SelectedCells[4].Value.ToString();
                txtCorreoE.Text = dgvProveedoresE.SelectedCells[5].Value.ToString();
                txtDireccionE.Text = dgvProveedoresE.SelectedCells[6].Value.ToString();
                txtEmpresaE.Text = dgvProveedoresE.SelectedCells[7].Value.ToString();
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
                        if (cbxCriBusquedaD.SelectedItem.ToString().Equals("Ruc"))
                    {
                        DataTable proveedores = cliente.BuscarProveedorRuc(txtBusquedaD.Text);
                        dgvProveedoresE.DataSource = proveedores;

                    }
                    else if (cbxCriBusquedaD.SelectedItem.ToString().Equals("Apellido"))
                    {
                        DataTable proveedores = cliente.BuscarProveedorApellido(txtBusquedaD.Text);
                        dgvProveedoresE.DataSource = proveedores;

                    }
                    else if (cbxCriBusquedaD.SelectedItem.ToString().Equals("Empresa"))
                    {
                        DataTable proveedores = cliente.BuscarProveedorEmpresa(txtBusquedaD.Text);
                        dgvProveedoresE.DataSource = proveedores;

                    }
                    else if (cbxCriBusquedaD.SelectedItem.ToString().Equals("Mostrar Todos"))
                    {
                        DataTable proveedores = cliente.ObtenerProveedor();
                        dgvProveedoresD.DataSource = proveedores;
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
                cliente.EliminarProveedor(Convert.ToInt32(dgvProveedoresD.SelectedCells[0].Value));
                DialogResult dialogResult = MessageBox.Show("Proveedor eliminado con éxito", "Aviso", MessageBoxButtons.OK);
                ActualizarDgvProveedorD();
            }
            catch (Exception)
            {
                DialogResult dialogResult = MessageBox.Show("Ha ocurrido un error de conexión", "Aviso", MessageBoxButtons.OK);
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

        public void ActualizarDgvProveedorD()
        {
            try
            {
                if (busqueda.Equals("Ruc"))
                {
                    DataTable clientes = cliente.BuscarProveedorRuc(valor);
                    dgvProveedoresD.DataSource = clientes;

                }
                else if (busqueda.Equals("Apellido"))
                {
                    DataTable clientes = cliente.BuscarProveedorApellido(valor);
                    dgvProveedoresD.DataSource = clientes;

                }
                else if (busqueda.Equals("Empresa"))
                {
                    DataTable clientes = cliente.BuscarProveedorEmpresa(valor);
                    dgvProveedoresD.DataSource = clientes;

                }
                else if (busqueda.Equals("Mostrar Todos"))
                {
                    DataTable clientes = cliente.ObtenerProveedor();
                    dgvProveedoresD.DataSource = clientes;
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
