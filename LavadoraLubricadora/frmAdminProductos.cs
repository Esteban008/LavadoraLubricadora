using System;
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
    public partial class frmAdminProductos : Form
    {
        LavadoraService.LavadoraServiceClient cliente;
        private static string busqueda;
        private static string valor;

        public frmAdminProductos()
        {
            InitializeComponent();
        }

        private void frmAdminProductos_Load(object sender, EventArgs e)
        {
            cliente = new LavadoraService.LavadoraServiceClient();

            //PESTAÑA DE INGRESAR
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
                if (cliente.ValidarProducto(txtCodigoB.Text))
                {
                    MessageBox.Show("\t\tEste Producto ya existe. \nSi desea actualizar los datos seleccione el boton editar Editar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (txtMarca.Text != "" && txtDescripcion.Text != "" && txtCodigoB.Text != "" && txtCantidad.Text != "" && txtCantidadMin.Text != "" && 
                        txtPreSIva.Text != "" && txtGananPorMayor.Text != "" && txtPrecioVMenor.Text != "")
                    {
                        int resultado = cliente.IngresarProducto(txtMarca.Text, txtDescripcion.Text, txtCodigoB.Text, Convert.ToInt32(txtCantidad.Text),
                    Convert.ToInt32(txtCantidadMin.Text), Convert.ToDouble(txtPreSIva.Text), Convert.ToDouble(txtPreCIva.Text), Convert.ToDouble(txtPreVMayor.Text),
                    Convert.ToDouble(txtPrecioVMenor.Text), Convert.ToDouble(txtMargenMayor.Text), Convert.ToDouble(txtMargenMenor.Text));

                        if (resultado == 1)
                        {
                            DialogResult dialogResult = MessageBox.Show("Producto ingresado con éxito", "Aviso", MessageBoxButtons.OK);

                            LimpiarCampos();
                        }
                        else
                        {
                            DialogResult dialogResult = MessageBox.Show("Producto no ingresado a la base de datos verifique los datos ingresados", "Aviso", MessageBoxButtons.OK);
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
            catch (OverflowException)
            {
                DialogResult dialogResult = MessageBox.Show("Valor numerico fuera de rango", "Aviso", MessageBoxButtons.OK);
            }
            catch (FormatException)
            {
                DialogResult dialogResult = MessageBox.Show("Uno o más campos están vacíos", "Aviso", MessageBoxButtons.OK);
            }
            catch (Exception)
            {
                DialogResult dialogResult = MessageBox.Show("Ha ocurrido un error", "Aviso", MessageBoxButtons.OK);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        public void LoadIngresar()
        {
            DeshabilitarCampos();
        }

        public void DeshabilitarCampos()
        {
            txtPreCIva.Enabled = false;
            txtMargenMayor.Enabled = false;
            txtMargenMenor.Enabled = false;
            txtPreVMayor.Enabled = false;
        }

        public void LimpiarCampos()
        {
            txtMarca.Clear();
            txtDescripcion.Clear();
            txtCodigoB.Clear();
            txtCantidad.Clear();
            txtCantidadMin.Clear();
            txtPreSIva.Clear();
            txtPreCIva.Clear();
            txtGananPorMayor.Clear();
            txtPrecioVMenor.Clear();
            txtPreVMayor.Clear();
            txtMargenMayor.Clear();
            txtMargenMenor.Clear();
        }

        public void Recalcular()
        {
            double precioVMenor = 0;
            double precioCompraConIva = 0;

            //Conversion del valor en txtBaseImponible
            Double.TryParse(txtPrecioVMenor.Text, out precioVMenor);
            Double.TryParse(txtPreCIva.Text, out precioCompraConIva);

            //Calculo del IVA
            double magenxmenor = Math.Round((precioVMenor - precioCompraConIva), 2);



            //Actualizacion de los campos correspondientes

            txtMargenMenor.Text = magenxmenor.ToString();


            double porcenGanancia = 0;



            //Conversion del valor en txtBaseImponible
            Double.TryParse(txtGananPorMayor.Text, out porcenGanancia);


            //Calculo del IVA
            double margenxMayor = Math.Round(((porcenGanancia / 100) * precioCompraConIva), 2);

            //Calculo del total
            double precioVentaMayor = Math.Round((precioCompraConIva + margenxMayor), 2);

            //Actualizacion de los campos correspondientes

            txtPreVMayor.Text = precioVentaMayor.ToString();
            txtMargenMayor.Text = margenxMayor.ToString();
        }

        private void txtPreSIva_KeyPress(object sender, KeyPressEventArgs e)
        {
            //defenimos el rango de codigos ASCII que admite solo numeros a la entrada
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 45 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo está permitido números y la coma", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }

        private void txtPreSIva_KeyUp(object sender, KeyEventArgs e)
        {
            double baseImpo = 0;

            //Conversion del valor en txtBaseImponible
            Double.TryParse(txtPreSIva.Text, out baseImpo);

            //Calculo del IVA
            double iva = baseImpo * 0.12;

            //Calculo del total
            double total = Math.Round((baseImpo + iva), 2);

            //Actualizacion de los campos correspondientes

            txtPreCIva.Text = total.ToString();

            Recalcular();
        }

        private void txtGananPorMayor_KeyPress(object sender, KeyPressEventArgs e)
        {
            //defenimos el rango de codigos ASCII que admite solo numeros a la entrada
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 45 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo está permitido números y la coma", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }

        private void txtGananPorMayor_KeyUp(object sender, KeyEventArgs e)
        {
            double porcenGanancia = 0;
            double precioCompraConIva = 0;


            //Conversion del valor en txtBaseImponible
            Double.TryParse(txtGananPorMayor.Text, out porcenGanancia);
            Double.TryParse(txtPreCIva.Text, out precioCompraConIva);

            //Calculo del IVA
            double margenxMayor = Math.Round(((porcenGanancia / 100) * precioCompraConIva), 2);

            //Calculo del total
            double precioVentaMayor = Math.Round((precioCompraConIva + margenxMayor), 2);

            //Actualizacion de los campos correspondientes

            txtPreVMayor.Text = precioVentaMayor.ToString();
            txtMargenMayor.Text = margenxMayor.ToString();
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            //defenimos el rango de codigos ASCII que admite solo numeros a la entrada
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 44 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo está permitido números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }

        private void txtCantidadMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            //defenimos el rango de codigos ASCII que admite solo numeros a la entrada
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 44 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo está permitido números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }
        private void txtPrecioVMenor_KeyPress(object sender, KeyPressEventArgs e)
        {
            //defenimos el rango de codigos ASCII que admite solo numeros a la entrada
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 45 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo está permitido números y la coma", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }

        private void txtPrecioVMenor_KeyUp(object sender, KeyEventArgs e)
        {
            double precioVMenor = 0;
            double precioCompraConIva = 0;

            //Conversion del valor en txtBaseImponible
            Double.TryParse(txtPrecioVMenor.Text, out precioVMenor);
            Double.TryParse(txtPreCIva.Text, out precioCompraConIva);

            //Calculo del IVA
            double magenxmenor = Math.Round((precioVMenor - precioCompraConIva), 2);



            //Actualizacion de los campos correspondientes

            txtMargenMenor.Text = magenxmenor.ToString();

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
                    if (cbxCriBusquedaE.SelectedItem.ToString().Equals("Codigo de Barras"))
                    {
                        DataTable productos = cliente.BuscarProductoCodigo(txtBusquedaE.Text);
                        dgvProductoE.DataSource = productos;

                    }
                    else if (cbxCriBusquedaE.SelectedItem.ToString().Equals("Marca"))
                    {
                        DataTable productos = cliente.BuscarProductoMarca(txtBusquedaE.Text);
                        dgvProductoE.DataSource = productos;

                    }
                    else if (cbxCriBusquedaE.SelectedItem.ToString().Equals("Mostrar Todos"))
                    {
                        DataTable productos = cliente.ObtenerProducto();
                        dgvProductoE.DataSource = productos;
                    }
                    busqueda = cbxCriBusquedaE.SelectedItem.ToString();
                    valor = txtBusquedaE.Text;
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

        private void btnGuardarE_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMarcaE.Text != "" && txtDescripcionE.Text != "" && txtCodigoBE.Text != "" && txtCantidadE.Text != "" && txtCantidadMinE.Text != "" &&
                        txtPreSIvaE.Text != "" && txtGananPorMayorE.Text != "" && txtPreVMenorE.Text != "")
                {
                    int resultado = cliente.EditarProducto(Convert.ToInt32(dgvProductoE.SelectedCells[0].Value), txtMarcaE.Text, txtDescripcionE.Text, txtCodigoBE.Text, Convert.ToInt32(txtCantidadE.Text),
                        Convert.ToInt32(txtCantidadMinE.Text), Convert.ToDouble(txtPreSIvaE.Text), Convert.ToDouble(txtPreCIvaE.Text), Convert.ToDouble(txtPreVMayorE.Text),
                        Convert.ToDouble(txtPreVMenorE.Text), Convert.ToDouble(txtMargenMayorE.Text), Convert.ToDouble(txtMargenMenorE.Text));

                    if (resultado == 1)
                    {
                        if (cliente.ValidarMinProducto(Convert.ToInt32(dgvProductoE.SelectedCells[0].Value.ToString())))
                        {
                            MessageBox.Show("Este producto está próximo a agotarse", "Aviso", MessageBoxButtons.OK);
                        }

                        DialogResult dialogResult = MessageBox.Show("Producto actualizado con éxito", "Aviso", MessageBoxButtons.OK);
                        ActualizarDgvProductoE();
                        LimpiarCamposE();
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("Este producto no se ha podido actualizar verifique los datos ingresados", "Aviso", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Uno o más campos están vacíos", "Aviso", MessageBoxButtons.OK);
                }


            }
            catch (EndpointNotFoundException)
            {
                DialogResult dialogResult = MessageBox.Show("Ha ocurrido un error de conexión", "Aviso", MessageBoxButtons.OK);
            }
            catch (OverflowException)
            {
                DialogResult dialogResult = MessageBox.Show("Valor numerico fuera de rango", "Aviso", MessageBoxButtons.OK);
            }
            catch (FormatException)
            {
                DialogResult dialogResult = MessageBox.Show("Uno o más campos están vacíos", "Aviso", MessageBoxButtons.OK);
            }
            catch (Exception)
            {
                DialogResult dialogResult = MessageBox.Show("Ha ocurrido un error", "Aviso", MessageBoxButtons.OK);
            }

        }

        private void btnCancelarE_Click(object sender, EventArgs e)
        {
            LimpiarCamposE();
        }

        public void ActualizarDgvProductoE()
        {
            try
            {
                if (busqueda.Equals("Codigo de Barras"))
                {
                    DataTable productos = cliente.BuscarProductoCodigo(valor);
                    dgvProductoE.DataSource = productos;

                }
                else if (busqueda.Equals("Marca"))
                {
                    DataTable productos = cliente.BuscarProductoMarca(valor);
                    dgvProductoE.DataSource = productos;

                }
                else if (busqueda.Equals("Mostrar Todos"))
                {
                    DataTable productos = cliente.ObtenerProducto();
                    dgvProductoE.DataSource = productos;
                }
            }
            catch (EndpointNotFoundException)
            {
                DialogResult dialogResult = MessageBox.Show("Ha ocurrido un error de conexión", "Aviso", MessageBoxButtons.OK);
            }
            catch (Exception)
            {
                DialogResult dialogResult = MessageBox.Show("Ha ocurrido un error", "Aviso", MessageBoxButtons.OK);
            }

        }

        public void LoadEditar()
        {
            cbxCriBusquedaE.DropDownStyle = ComboBoxStyle.DropDownList;
            txtBusquedaE.Visible = false;
            DeshabilitarCamposE();
        }

        public void DeshabilitarCamposE()
        {
            txtPreCIvaE.Enabled = false;
            txtMargenMayorE.Enabled = false;
            txtMargenMenorE.Enabled = false;
            txtPreVMayorE.Enabled = false;
        }

        public void LimpiarCamposE()
        {
            txtMarcaE.Clear();
            txtDescripcionE.Clear();
            txtCodigoBE.Clear();
            txtCantidadE.Clear();
            txtCantidadMinE.Clear();
            txtPreSIvaE.Clear();
            txtPreCIvaE.Clear();
            txtGananPorMayorE.Clear();
            txtPreVMenorE.Clear();
            txtPreVMayorE.Clear();
            txtMargenMayorE.Clear();
            txtMargenMenorE.Clear();
        }

        public void RecalcularEE()
        {
            double precioVMenorE = 0;
            double precioCompraConIvaE = 0;

            //Conversion del valor en txtBaseImponible
            Double.TryParse(txtPreVMenorE.Text, out precioVMenorE);
            Double.TryParse(txtPreCIvaE.Text, out precioCompraConIvaE);

            //Calculo del IVA
            double magenxmenorE = Math.Round((precioVMenorE - precioCompraConIvaE), 2);



            //Actualizacion de los campos correspondientes

            txtMargenMenorE.Text = magenxmenorE.ToString();


            double porcenGananciaE = 0;



            //Conversion del valor en txtBaseImponible
            Double.TryParse(txtGananPorMayor.Text, out porcenGananciaE);


            //Calculo del IVA
            double margenxMayorE = Math.Round(((porcenGananciaE / 100) * precioCompraConIvaE), 2);

            //Calculo del total
            double precioVentaMayorE = Math.Round((precioCompraConIvaE + margenxMayorE), 2);

            //Actualizacion de los campos correspondientes

            txtPreVMayorE.Text = precioVentaMayorE.ToString();
            txtMargenMayorE.Text = margenxMayorE.ToString();
        }

        public void RecalcularE()
        {
            double precioVMenorE = 0;
            double precioCompraConIvaE = 0;

            //Conversion del valor en txtBaseImponible
            Double.TryParse(txtPreVMenorE.Text, out precioVMenorE);
            Double.TryParse(txtPreCIvaE.Text, out precioCompraConIvaE);

            //Calculo del IVA
            double magenxmenorE = Math.Round((precioVMenorE - precioCompraConIvaE), 2);



            //Actualizacion de los campos correspondientes

            txtMargenMenorE.Text = magenxmenorE.ToString();


            double porcenGananciaE = 0;



            //Conversion del valor en txtBaseImponible
            Double.TryParse(txtGananPorMayorE.Text, out porcenGananciaE);


            //Calculo del IVA
            double margenxMayorE = Math.Round(((porcenGananciaE / 100) * precioCompraConIvaE), 2);

            //Calculo del total
            double precioVentaMayorE = Math.Round((precioCompraConIvaE + margenxMayorE), 2);

            //Actualizacion de los campos correspondientes

            txtPreVMayorE.Text = precioVentaMayorE.ToString();
            txtMargenMayorE.Text = margenxMayorE.ToString();
        }

        private void dgvProductoE_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMarcaE.Text = dgvProductoE.SelectedCells[1].Value.ToString();
                txtDescripcionE.Text = dgvProductoE.SelectedCells[2].Value.ToString();
                txtCodigoBE.Text = dgvProductoE.SelectedCells[3].Value.ToString();
                txtPreSIvaE.Text = Math.Round(Convert.ToDouble(dgvProductoE.SelectedCells[4].Value.ToString()), 2).ToString();
                txtPreCIvaE.Text = Math.Round(Convert.ToDouble(dgvProductoE.SelectedCells[5].Value.ToString()), 2).ToString();
                txtPreVMayorE.Text = Math.Round(Convert.ToDouble(dgvProductoE.SelectedCells[6].Value.ToString()), 2).ToString();
                txtPreVMenorE.Text = Math.Round(Convert.ToDouble(dgvProductoE.SelectedCells[7].Value.ToString()), 2).ToString();
                txtMargenMayorE.Text = Math.Round(Convert.ToDouble(dgvProductoE.SelectedCells[8].Value.ToString()), 2).ToString();
                txtMargenMenorE.Text = Math.Round(Convert.ToDouble(dgvProductoE.SelectedCells[9].Value.ToString()), 2).ToString();
                txtCantidadE.Text = dgvProductoE.SelectedCells[10].Value.ToString();
                txtCantidadMinE.Text = dgvProductoE.SelectedCells[11].Value.ToString();
                txtGananPorMayorE.Text = Math.Round((((Convert.ToDouble(txtPreVMayorE.Text) - Convert.ToDouble(txtPreCIvaE.Text)) * 100) / (Convert.ToDouble(txtPreCIvaE.Text)))).ToString();
            }
            catch (ArgumentOutOfRangeException)
            {
                DialogResult dialogResult = MessageBox.Show("Selección no válida", "Aviso", MessageBoxButtons.OK);
            }
            

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

        private void txtPreSIvaE_KeyPress(object sender, KeyPressEventArgs e)
        {
            //defenimos el rango de codigos ASCII que admite solo numeros a la entrada
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 45 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo está permitido números y la coma", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }

        private void txtPreSIvaE_KeyUp(object sender, KeyEventArgs e)
        {
            double baseImpoE = 0;

            //Conversion del valor en txtBaseImponible
            Double.TryParse(txtPreSIvaE.Text, out baseImpoE);

            //Calculo del IVA
            double ivaE = baseImpoE * 0.12;

            //Calculo del total
            double totalE = Math.Round((baseImpoE + ivaE), 2);

            //Actualizacion de los campos correspondientes

            txtPreCIvaE.Text = totalE.ToString();

            RecalcularEE();
        }

        private void txtGananPorMayorE_KeyPress(object sender, KeyPressEventArgs e)
        {
            //defenimos el rango de codigos ASCII que admite solo numeros a la entrada
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 45 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo está permitido números y la coma", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }

        private void txtGananPorMayorE_KeyUp(object sender, KeyEventArgs e)
        {
            double porcenGananciaE = 0;
            double precioCompraConIvaE = 0;


            //Conversion del valor en txtBaseImponible
            Double.TryParse(txtGananPorMayorE.Text, out porcenGananciaE);
            Double.TryParse(txtPreCIvaE.Text, out precioCompraConIvaE);

            //Calculo del IVA
            double margenxMayorE = Math.Round(((porcenGananciaE / 100) * precioCompraConIvaE), 2);

            //Calculo del total
            double precioVentaMayorE = Math.Round((precioCompraConIvaE + margenxMayorE), 2);

            //Actualizacion de los campos correspondientes

            txtPreVMayorE.Text = precioVentaMayorE.ToString();
            txtMargenMayorE.Text = margenxMayorE.ToString();
        }

        private void txtPreVMenorE_KeyPress(object sender, KeyPressEventArgs e)
        {
            //defenimos el rango de codigos ASCII que admite solo numeros a la entrada
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 45 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo está permitido números y la coma", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }

        private void txtCantidadE_KeyPress(object sender, KeyPressEventArgs e)
        {
            //defenimos el rango de codigos ASCII que admite solo numeros a la entrada
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 44 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo está permitido números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }

        private void txtCantidadMinE_KeyPress(object sender, KeyPressEventArgs e)
        {
            //defenimos el rango de codigos ASCII que admite solo numeros a la entrada
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 44 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo está permitido números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }

        private void txtPreVMenorE_KeyUp(object sender, KeyEventArgs e)
        {
            double precioVMenorE = 0;
            double precioCompraConIvaE = 0;

            //Conversion del valor en txtBaseImponible
            Double.TryParse(txtPreVMenorE.Text, out precioVMenorE);
            Double.TryParse(txtPreCIvaE.Text, out precioCompraConIvaE);

            //Calculo del IVA
            double magenxmenorE = Math.Round((precioVMenorE - precioCompraConIvaE), 2);



            //Actualizacion de los campos correspondientes

            txtMargenMenorE.Text = magenxmenorE.ToString();
        }

        #endregion

        #region Eliminar

        private void btnBuscarD_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxCriBusquedaD.SelectedItem != null)
                {
                    if (cbxCriBusquedaD.SelectedItem.ToString().Equals("Codigo de Barras"))
                    {
                        DataTable productos = cliente.BuscarProductoCodigo(txtBusquedaD.Text);
                        dgvProductosD.DataSource = productos;

                    }
                    else if (cbxCriBusquedaD.SelectedItem.ToString().Equals("Marca"))
                    {
                        DataTable productos = cliente.BuscarProductoMarca(txtBusquedaD.Text);
                        dgvProductosD.DataSource = productos;

                    }
                    else if (cbxCriBusquedaD.SelectedItem.ToString().Equals("Mostrar Todos"))
                    {
                        DataTable productos = cliente.ObtenerProducto();
                        dgvProductosD.DataSource = productos;
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
                int resultado = cliente.EliminarProducto(Convert.ToInt32(dgvProductosD.SelectedCells[0].Value));
                if (resultado == 1)
                {
                    DialogResult dialogResult = MessageBox.Show("Producto eliminado con éxito", "Aviso", MessageBoxButtons.OK);
                    ActualizarDgvProductoD();
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("No se puede eliminar este producto ya que pertenece a un proceso", "Aviso", MessageBoxButtons.OK);
                }
            }
            catch (EndpointNotFoundException)
            {
                DialogResult dialogResult = MessageBox.Show("Ha ocurrido un error de conexión", "Aviso", MessageBoxButtons.OK);
            }
            catch (ArgumentOutOfRangeException)
            {
                DialogResult dialogResult = MessageBox.Show("Selección no válida", "Aviso", MessageBoxButtons.OK);
            }

            catch (Exception)
            {
                DialogResult dialogResult = MessageBox.Show("Ha ocurrido un error", "Aviso", MessageBoxButtons.OK);
            }


        }
        public void LoadEliminar()
        {
            cbxCriBusquedaD.DropDownStyle = ComboBoxStyle.DropDownList;
            txtBusquedaD.Visible = false;
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

        public void ActualizarDgvProductoD()
        {
            try
            {
                if (busqueda.Equals("Codigo de Barras"))
                {
                    DataTable productos = cliente.BuscarProductoCodigo(valor);
                    dgvProductosD.DataSource = productos;

                }
                else if (busqueda.Equals("Marca"))
                {
                    DataTable productos = cliente.BuscarProductoMarca(valor);
                    dgvProductosD.DataSource = productos;

                }
                else if (busqueda.Equals("Mostrar Todos"))
                {
                    DataTable productos = cliente.ObtenerProducto();
                    dgvProductosD.DataSource = productos;
                }
            }
            catch (Exception)
            {
                DialogResult dialogResult = MessageBox.Show("Ha ocurrido un error", "Aviso", MessageBoxButtons.OK);
            }

        }

        #endregion

        
    }
}
