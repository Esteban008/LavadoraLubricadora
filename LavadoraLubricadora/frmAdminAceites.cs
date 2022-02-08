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
    public partial class frmAdminAceites : Form
    {
        LavadoraService.LavadoraServiceClient cliente;
        private static string busqueda;
        private static string valor;

        public frmAdminAceites()
        {
            InitializeComponent();
        }

        private void frmAdminAceites_Load(object sender, EventArgs e)
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

        #region Tab Ingresar

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cliente.ValidarAceite(txtCodigoB.Text))
                {
                    MessageBox.Show("\t\tEste Aceite ya existe. \nSi desea actualizar los datos seleccione la pestaña Editar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //Validacion de Combobox vacios
                    if (cbxPresentacion.SelectedItem != null && cbxSae.SelectedItem != null && cbxTipoCombustible.SelectedItem != null &&
                        cbxApi.SelectedItem != null && cbxTipoAceite.SelectedItem != null )
                    {
                        
                        //Ingreso de Aceite a base de datos a través del servicio
                        int resultado = cliente.IngresarAceite(txtMarca.Text, txtDescripcion.Text, txtCodigoB.Text, Convert.ToInt32(txtCantidad.Text),
                        Convert.ToInt32(txtCantidadMin.Text), cbxPresentacion.SelectedItem.ToString(), cbxSae.SelectedItem.ToString(),
                        cbxTipoCombustible.SelectedItem.ToString(), cbxApi.SelectedItem.ToString(), cbxTipoAceite.SelectedItem.ToString(),
                        Convert.ToDouble(txtPreSIva.Text), Convert.ToDouble(txtPreCIva.Text), Convert.ToDouble(txtPreVMayor.Text),
                        Convert.ToDouble(txtPrecioVMenor.Text), Convert.ToDouble(txtMargenMayor.Text), Convert.ToDouble(txtMargenMenor.Text));
                        if (resultado==1)
                        {
                            DialogResult dialogResult = MessageBox.Show("Aceite ingresado con éxito", "Aviso", MessageBoxButtons.OK);
                            LimpiarCampos();
                            cbxTipoCombustible.Items.AddRange(cliente.ObtenerTipoCombustible());
                        }
                        else
                        {
                            DialogResult dialogResult = MessageBox.Show("Aceite no ingresado a la base de datos verifique los datos ingresados", "Aviso", MessageBoxButtons.OK);
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
            cbxApi.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxPresentacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxSae.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxTipoAceite.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxTipoCombustible.DropDownStyle = ComboBoxStyle.DropDownList;
            llenarCbxs();
            DeshabilitarCampos();
        }

        public void llenarCbxs()
        {
            try
            {
                cbxPresentacion.Items.AddRange(cliente.ObtenerPresentacion());
                cbxSae.Items.AddRange(cliente.ObtenerSAE());
                cbxTipoCombustible.Items.AddRange(cliente.ObtenerTipoCombustible());
                cbxTipoAceite.Items.AddRange(cliente.ObtenerTipoAceite());
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
            cbxPresentacion.SelectedIndex = -1;
            cbxSae.SelectedIndex = -1;
            cbxTipoCombustible.Items.Clear();
            cbxApi.SelectedIndex = -1;
            cbxTipoAceite.SelectedIndex = -1;
            txtPreSIva.Clear();
            txtPreCIva.Clear();
            txtGananPorMayor.Clear();
            txtPrecioVMenor.Clear();
            txtPreVMayor.Clear();
            txtMargenMayor.Clear();
            txtMargenMenor.Clear();
        }

        //Calcula el precio de venta al por mayor
        //y los margenes de ganancia
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

        //Obtiene valores de API correspondiente al tipo de combustible
        private void cbxTipoCombustible_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbxTipoCombustible.SelectedItem.ToString().Equals("Gasolina"))
                {
                    cbxApi.Items.Clear();
                    cbxApi.Items.AddRange(cliente.ObtenerApi(1));
                }
                else if (cbxTipoCombustible.SelectedItem.ToString().Equals("Diesel"))
                {
                    cbxApi.Items.Clear();
                    cbxApi.Items.AddRange(cliente.ObtenerApi(2));
                }
                else if (cbxTipoCombustible.SelectedItem.ToString().Equals("N/A"))
                {
                    cbxApi.Items.Clear();
                    cbxApi.Items.AddRange(cliente.ObtenerApi(3));
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

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            //defenimos el rango de codigos ASCII que admite solo numeros a la entrada
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 44 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo está permitido números y la coma", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }

        private void txtCantidadMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            //defenimos el rango de codigos ASCII que admite solo numeros a la entrada
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 44 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo está permitido números y la coma", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
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

        #endregion

        #region Tab Editar

        private void btnBuscarE_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxCriBusquedaE.SelectedItem != null)
                {
                    LimpiarCamposE();
                    cbxTipoCombustibleE.Items.AddRange(cliente.ObtenerTipoCombustible());

                    if (cbxCriBusquedaE.SelectedItem.ToString().Equals("Codigo de Barras"))
                    {
                        DataTable aceites = cliente.BuscarAceiteCodigo(txtBusquedaE.Text);
                        dgvAceitesE.DataSource = aceites;

                    }
                    else if (cbxCriBusquedaE.SelectedItem.ToString().Equals("Marca"))
                    {
                        DataTable aceites = cliente.BuscarAceiteMarca(txtBusquedaE.Text);
                        dgvAceitesE.DataSource = aceites;

                    }
                    else if (cbxCriBusquedaE.SelectedItem.ToString().Equals("Mostrar Todos"))
                    {
                        DataTable aceites = cliente.ObtenerAceite();
                        dgvAceitesE.DataSource = aceites;
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

                if (cbxPresentacionE.SelectedItem != null && cbxSaeE.SelectedItem != null && cbxTipoCombustibleE.SelectedItem != null &&
                        cbxApiE.SelectedItem != null && cbxTipoAceiteE.SelectedItem != null)
                {
                    int resultado = cliente.EditarAceite(Convert.ToInt32(dgvAceitesE.SelectedCells[0].Value), txtMarcaE.Text, txtDescripcionE.Text, txtCodigoBE.Text, Convert.ToInt32(txtCantidadE.Text),
                                                   Convert.ToInt32(txtCantidadMinE.Text), cbxPresentacionE.SelectedItem.ToString(), cbxSaeE.SelectedItem.ToString(),
                                                   cbxTipoCombustibleE.SelectedItem.ToString(), cbxApiE.SelectedItem.ToString(), cbxTipoAceiteE.SelectedItem.ToString(),
                                                   Convert.ToDouble(txtPreSIvaE.Text), Convert.ToDouble(txtPreCIvaE.Text), Convert.ToDouble(txtPreVMayorE.Text),
                                                   Convert.ToDouble(txtPreVMenorE.Text), Convert.ToDouble(txtMargenMayorE.Text), Convert.ToDouble(txtMargenMenorE.Text));

                    if (resultado==1)
                    {

                        DialogResult dialogResult = MessageBox.Show("Aceite actualizado con éxito", "Aviso", MessageBoxButtons.OK);
                        if (cliente.ValidarMinAceite(Convert.ToInt32(dgvAceitesE.SelectedCells[0].Value.ToString())))
                        {
                            MessageBox.Show("Este producto está próximo a agotarse", "Aviso", MessageBoxButtons.OK);
                        }

                        
                        ActualizarDgvAceiteE();
                        LimpiarCamposE();
                        cbxTipoCombustibleE.Items.AddRange(cliente.ObtenerTipoCombustible());
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("Este aceite no se ha podido actualizar verifique los datos ingresados", "Aviso", MessageBoxButtons.OK);
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

            catch (Exception)
            {
                DialogResult dialogResult = MessageBox.Show("Ha ocurrido un error", "Aviso", MessageBoxButtons.OK);
            }

        }

        private void btnCancelarE_Click(object sender, EventArgs e)
        {
            LimpiarCamposE();
        }

        public void ActualizarDgvAceiteE()
        {
            try
            {
                if (busqueda.Equals("Codigo de Barras"))
                {
                    DataTable aceites = cliente.BuscarAceiteCodigo(valor);
                    dgvAceitesE.DataSource = aceites;

                }
                else if (busqueda.Equals("Marca"))
                {
                    DataTable aceites = cliente.BuscarAceiteMarca(valor);
                    dgvAceitesE.DataSource = aceites;

                }
                else if (busqueda.Equals("Mostrar Todos"))
                {
                    DataTable aceites = cliente.ObtenerAceite();
                    dgvAceitesE.DataSource = aceites;
                }
            }
            catch (Exception)
            {
                DialogResult dialogResult = MessageBox.Show("Ha ocurrido un error", "Aviso", MessageBoxButtons.OK);
            }

        }

        public void LoadEditar()
        {
            cbxCriBusquedaE.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxApiE.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxPresentacionE.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxSaeE.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxTipoAceiteE.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxTipoCombustibleE.DropDownStyle = ComboBoxStyle.DropDownList;
            txtBusquedaE.Visible = false;
            llenarCbxsE();
            DeshabilitarCamposE();
        }
        public void llenarCbxsE()
        {
            cbxPresentacionE.Items.AddRange(cliente.ObtenerPresentacion());
            cbxSaeE.Items.AddRange(cliente.ObtenerSAE());
            cbxTipoCombustibleE.Items.AddRange(cliente.ObtenerTipoCombustible());
            cbxTipoAceiteE.Items.AddRange(cliente.ObtenerTipoAceite());
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
            cbxPresentacionE.SelectedIndex = -1;
            cbxSaeE.SelectedIndex = -1;
            cbxTipoCombustibleE.Items.Clear();
            cbxApiE.SelectedIndex = -1;
            cbxTipoAceiteE.SelectedIndex = -1;
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


        private void dgvAceitesE_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMarcaE.Text = dgvAceitesE.SelectedCells[1].Value.ToString();
                txtDescripcionE.Text = dgvAceitesE.SelectedCells[2].Value.ToString();
                cbxPresentacionE.SelectedItem = dgvAceitesE.SelectedCells[3].Value.ToString();
                cbxSaeE.SelectedItem = dgvAceitesE.SelectedCells[4].Value.ToString();
                cbxTipoAceiteE.SelectedItem = dgvAceitesE.SelectedCells[6].Value.ToString();
                txtCodigoBE.Text = dgvAceitesE.SelectedCells[8].Value.ToString();
                txtPreSIvaE.Text = Math.Round(Convert.ToDouble(dgvAceitesE.SelectedCells[9].Value.ToString()), 2).ToString();
                txtPreCIvaE.Text = Math.Round(Convert.ToDouble(dgvAceitesE.SelectedCells[10].Value.ToString()), 2).ToString();
                txtPreVMayorE.Text = Math.Round(Convert.ToDouble(dgvAceitesE.SelectedCells[11].Value.ToString()), 2).ToString();
                txtPreVMenorE.Text = Math.Round(Convert.ToDouble(dgvAceitesE.SelectedCells[12].Value.ToString()), 2).ToString();
                txtMargenMayorE.Text = Math.Round(Convert.ToDouble(dgvAceitesE.SelectedCells[13].Value.ToString()), 2).ToString();
                txtMargenMenorE.Text = Math.Round(Convert.ToDouble(dgvAceitesE.SelectedCells[14].Value.ToString()), 2).ToString();
                cbxTipoCombustibleE.SelectedItem = dgvAceitesE.SelectedCells[7].Value.ToString();
                txtCantidadE.Text = dgvAceitesE.SelectedCells[15].Value.ToString();
                txtCantidadMinE.Text = dgvAceitesE.SelectedCells[16].Value.ToString();
                txtGananPorMayorE.Text = Math.Round((((Convert.ToDouble(txtPreVMayorE.Text) - Convert.ToDouble(txtPreCIvaE.Text)) * 100) / (Convert.ToDouble(txtPreCIvaE.Text)))).ToString();
                cbxApiE.SelectedItem = dgvAceitesE.SelectedCells[5].Value.ToString();
            }
            catch (ArgumentOutOfRangeException)
            {
                DialogResult dialogResult = MessageBox.Show("Selección no válida", "Aviso", MessageBoxButtons.OK);
            }

        }

        private void cbxCriBusquedaE_SelectedValueChanged(object sender, EventArgs e)
        {
            try
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
            catch (EndpointNotFoundException)
            {
                DialogResult dialogResult = MessageBox.Show("Ha ocurrido un error de conexión", "Aviso", MessageBoxButtons.OK);
            }
            catch (Exception)
            {
                DialogResult dialogResult = MessageBox.Show("Ha ocurrido un error", "Aviso", MessageBoxButtons.OK);
            }
        }

        private void cbxTipoCombustibleE_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbxTipoCombustibleE.SelectedItem.ToString().Equals("Gasolina"))
                {
                    cbxApiE.Items.Clear();
                    cbxApiE.Items.AddRange(cliente.ObtenerApi(1));
                }
                else if (cbxTipoCombustibleE.SelectedItem.ToString().Equals("Diesel"))
                {
                    cbxApiE.Items.Clear();
                    cbxApiE.Items.AddRange(cliente.ObtenerApi(2));
                }
                else if (cbxTipoCombustibleE.SelectedItem.ToString().Equals("N/A"))
                {
                    cbxApiE.Items.Clear();
                    cbxApiE.Items.AddRange(cliente.ObtenerApi(3));
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

        private void txtCantidadE_KeyPress(object sender, KeyPressEventArgs e)
        {
            //defenimos el rango de codigos ASCII que admite solo numeros a la entrada
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 44 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo está permitido números y la coma", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }

        private void txtCantidadMinE_KeyPress(object sender, KeyPressEventArgs e)
        {
            //defenimos el rango de codigos ASCII que admite solo numeros a la entrada
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 44 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
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

        #region Tab Eliminar

        private void btnBuscarD_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxCriBusquedaD.SelectedItem != null)
                {

                    if (cbxCriBusquedaD.SelectedItem.ToString().Equals("Codigo de Barras"))
                    {
                        DataTable aceites = cliente.BuscarAceiteCodigo(txtBusquedaD.Text);
                        dgvAceitesD.DataSource = aceites;

                    }
                    else if (cbxCriBusquedaD.SelectedItem.ToString().Equals("Marca"))
                    {
                        DataTable aceites = cliente.BuscarAceiteMarca(txtBusquedaD.Text);
                        dgvAceitesD.DataSource = aceites;

                    }
                    else if (cbxCriBusquedaD.SelectedItem.ToString().Equals("Mostrar Todos"))
                    {
                        DataTable aceites = cliente.ObtenerAceite();
                        dgvAceitesD.DataSource = aceites;
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
                int resultado = cliente.EliminarAceite(Convert.ToInt32(dgvAceitesD.SelectedCells[0].Value));

                if (resultado==1)
                {
                    DialogResult dialogResult = MessageBox.Show("Aceite eliminado con éxito", "Aviso", MessageBoxButtons.OK);
                    ActualizarDgvAceiteD();
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("No se puede eliminar este aceite ya que pertenece a un proceso", "Aviso", MessageBoxButtons.OK);
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


        public void ActualizarDgvAceiteD()
        {
            try
            {
                if (busqueda.Equals("Codigo de Barras"))
                {
                    DataTable aceites = cliente.BuscarAceiteCodigo(valor);
                    dgvAceitesD.DataSource = aceites;

                }
                else if (busqueda.Equals("Marca"))
                {
                    DataTable aceites = cliente.BuscarAceiteMarca(valor);
                    dgvAceitesD.DataSource = aceites;

                }
                else if (busqueda.Equals("Mostrar Todos"))
                {
                    DataTable aceites = cliente.ObtenerAceite();
                    dgvAceitesD.DataSource = aceites;
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
