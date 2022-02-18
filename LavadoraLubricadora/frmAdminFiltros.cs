using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.ServiceModel;

namespace LavadoraLubricadora
{
    public partial class frmAdminFiltros : Form
    {
        LavadoraService.LavadoraServiceClient cliente;
        private static string busqueda;
        private static string valor;

        public static List<int> idVehiculos;
        public static List<int> idCodigos;
        public static List<string> codigos;

        public frmAdminFiltros()
        {
            InitializeComponent();
        }

        private void frmAdminFiltros_Load(object sender, EventArgs e)
        {
            cliente = new LavadoraService.LavadoraServiceClient();
            idVehiculos = new List<int>();
            LimpiarCacheListaVehiculos();
            this.toolTipMsj.SetToolTip(this.rtxtCodigos, "Ingrese un código por linea");

            LoadIngresar();

            LoadEditar();

            LoadEliminar();
        }

        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            //Busca en la colecion el formulario
            formulario = pnlContenedor.Controls.OfType<MiForm>().FirstOrDefault();
            //si el formulario instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                pnlContenedor.Controls.Add(formulario);
                pnlContenedor.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }

        private void AbrirFormularioE<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            //Busca en la colecion el formulario
            formulario = pnlContenedor.Controls.OfType<MiForm>().FirstOrDefault();
            //si el formulario instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                pnlContenedorE.Controls.Add(formulario);
                pnlContenedorE.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Seguro que desea Salir?", "Aviso", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        public void LimpiarCacheListaVehiculos()
        {
            try
            {
                idVehiculos.Clear();
                cliente.GuardarIDsVehiculos(idVehiculos.ToArray());
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


        #region Tab Ingresar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                List<int> idVehiculos = cliente.ObtenerIDsVehiculos().ToList();
                List<string> codigos = recuperarRtxt();

                if (cliente.ValidarFiltro(txtCodigoB.Text))
                {
                    MessageBox.Show("\t\tEste Filtro ya existe. \nSi desea actualizar los datos seleccione el boton editar Editar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //Validacion de Combobox vacios
                    if (cbxTipoFiltro.SelectedItem != null && txtRosca.Text != "" && txtMarca.Text != "" && txtDescripcion.Text != "" && txtCodigoB.Text != "" && 
                        txtCantidad.Text != "" && txtCantidadMin.Text != "" && txtPreSIva.Text != "" && txtGananPorMayor.Text != "" && txtPrecioVMenor.Text != "" 
                        && rtxtCodigos.Text != "")
                    {
                        //Ingreso de Aceite a base de datos a través del servicio
                        int resultado = cliente.IngresarFiltro(cbxTipoFiltro.SelectedItem.ToString(), txtRosca.Text, txtMarca.Text, txtDescripcion.Text, txtCodigoB.Text, 
                           Convert.ToInt32(txtCantidad.Text), Convert.ToInt32(txtCantidadMin.Text), Convert.ToDouble(txtPreSIva.Text), Convert.ToDouble(txtPreCIva.Text), 
                           Convert.ToDouble(txtPreVMayor.Text), Convert.ToDouble(txtPrecioVMenor.Text), Convert.ToDouble(txtMargenMayor.Text), 
                           Convert.ToDouble(txtMargenMenor.Text));

                        if (resultado==1)
                        {
                            foreach (var idVehiculo in idVehiculos)
                            {
                                cliente.IngresarVehiculoFiltro(txtCodigoB.Text, idVehiculo);
                            }

                            foreach (var codigo in codigos)
                            {
                                cliente.IngresarCodigoFiltro(txtCodigoB.Text, codigo);
                            }

                            DialogResult dialogResult = MessageBox.Show("Filtro ingresado con éxito", "Aviso", MessageBoxButtons.OK);

                            LimpiarCampos();
                            LimpiarCacheListaVehiculos();
                        }
                        else
                        {
                            MessageBox.Show("Uno o más campos están vacíos", "Aviso", MessageBoxButtons.OK);
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

        private void btnAgregarVehiculos_Click(object sender, EventArgs e)
        {
            try
            {
                cliente.GuardarEstadoListaVehiculos(false);
                AbrirFormulario<frmAgregarVehiculo>();
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

        private void LoadIngresar()
        {

            try
            {
                cbxTipoFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
                cbxTipoFiltro.Items.AddRange(cliente.ObtenerTipoFiltro());

                DeshabilitarCampos();
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
            txtRosca.Clear();
            rtxtCodigos.Clear();
            cbxTipoFiltro.SelectedIndex = -1;
            txtPreSIva.Clear();
            txtPreCIva.Clear();
            txtGananPorMayor.Clear();
            txtPrecioVMenor.Clear();
            txtPreVMayor.Clear();
            txtMargenMayor.Clear();
            txtMargenMenor.Clear();

        }

        public List<string> recuperarRtxt()
        {
            string[] list = rtxtCodigos.Lines;
            List<string> codigos = new List<string>(list);

            return codigos;
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

        private void txtPreSIva_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            //defenimos el rango de codigos ASCII que admite solo numeros a la entrada
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 45 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo está permitido números y la coma", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }

        private void txtGananPorMayor_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            //defenimos el rango de codigos ASCII que admite solo numeros a la entrada
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 45 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo está permitido números y la coma", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }

        private void txtPrecioVMenor_KeyPress_1(object sender, KeyPressEventArgs e)
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

        #region Tab Editar

        private void btnBuscarE_Click(object sender, EventArgs e)
        {
            try
            {

                if (cbxCriBusquedaE.SelectedItem != null)
                {
                    LimpiarCamposE();
                    if (cbxCriBusquedaE.SelectedItem.ToString().Equals("Codigo de Barras"))
                    {
                        DataTable filtros = cliente.BuscarFiltroCodigo(txtBusquedaE.Text);
                        dgvFiltrosE.DataSource = filtros;

                    }
                    else if (cbxCriBusquedaE.SelectedItem.ToString().Equals("Marca"))
                    {
                        DataTable filtros = cliente.BuscarFiltroMarca(txtBusquedaE.Text);
                        dgvFiltrosE.DataSource = filtros;

                    }
                    else if (cbxCriBusquedaE.SelectedItem.ToString().Equals("Mostrar Todos"))
                    {
                        DataTable filtros = cliente.ObtenerFiltros();
                        dgvFiltrosE.DataSource = filtros;
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

                if (cbxTipoFiltroE.SelectedItem != null && txtRoscaE.Text != "" && txtMarcaE.Text != "" && txtDescripcionE.Text != "" && txtCodigoBE.Text != "" &&
                        txtCantidadE.Text != "" && txtCantidadMinE.Text != "" && txtPreSIvaE.Text != "" && txtGananPorMayorE.Text != "" && txtPreVMenorE.Text != ""
                        && rtxtCodigosE.Text != "")
                {
                    idCodigos = cliente.ObtenerIdCodigosFiltro(Convert.ToInt32(dgvFiltrosE.SelectedCells[0].Value.ToString())).ToList();

                    cliente.LimpiarRelacionCodigosBase(Convert.ToInt32(dgvFiltrosE.SelectedCells[0].Value.ToString()));

                    foreach (var item in idCodigos)
                    {
                        cliente.LimpiarCodigosBase(Convert.ToInt32(item));
                    }

                    int resultado = cliente.EditarFiltro(Convert.ToInt32(dgvFiltrosE.SelectedCells[0].Value.ToString()), cbxTipoFiltroE.SelectedItem.ToString(), txtRoscaE.Text, txtMarcaE.Text, txtDescripcionE.Text, txtCodigoBE.Text, Convert.ToInt32(txtCantidadE.Text),
                               Convert.ToInt32(txtCantidadMinE.Text), Convert.ToDouble(txtPreSIvaE.Text), Convert.ToDouble(txtPreCIvaE.Text), Convert.ToDouble(txtPreVMayorE.Text),
                               Convert.ToDouble(txtPreVMenorE.Text), Convert.ToDouble(txtMargenMayorE.Text), Convert.ToDouble(txtMargenMenorE.Text));

                    if (resultado == 1)
                    {
                        //Sila lista de vehiculos esta llena se limpia la referencia de los vehiculos y se agrega la nueva lista
                        if (cliente.ObtenerIDsVehiculos().Length != 0)
                        {
                            cliente.LimpiarVehiculosBase(Convert.ToInt32(dgvFiltrosE.SelectedCells[0].Value.ToString()));

                            List<int> idVehiculos = cliente.ObtenerIDsVehiculos().ToList();

                            foreach (var idVehiculo in idVehiculos)
                            {
                                cliente.IngresarVehiculoFiltro(txtCodigoBE.Text, idVehiculo);
                            }
                        }

                        List<string> codigosE = recuperarRtxtE();

                        foreach (var codigo in codigosE)
                        {
                            cliente.IngresarCodigoFiltro(txtCodigoBE.Text, codigo);
                        }

                        if (cliente.ValidarMinFiltro(Convert.ToInt32(dgvFiltrosE.SelectedCells[0].Value.ToString())))
                        {
                            MessageBox.Show("Este producto está próximo a agotarse", "Aviso", MessageBoxButtons.OK);
                        }
                        DialogResult dialogResult = MessageBox.Show("Filtro actualizado con éxito", "Aviso", MessageBoxButtons.OK);

                        LimpiarCamposE();
                        ActualizarDgvFiltrosE();
                        LimpiarCacheListaVehiculos();
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("Filtro no se ha podido actualizar verifique los datos ingresados", "Aviso", MessageBoxButtons.OK);
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

        private void btnEditarVehiculos_Click(object sender, EventArgs e)
        {
            try
            {
                cliente.GuardarEstadoListaVehiculos(true);
                cliente.GuardarIDListaVehiculos(Convert.ToInt32(dgvFiltrosE.SelectedCells[0].Value.ToString()));
                AbrirFormularioE<frmAgregarVehiculo>();
            }
            catch (Exception)
            {
                DialogResult dialogResult = MessageBox.Show("Debe seleccionar un filtro para editar", "Aviso", MessageBoxButtons.OK);
            }

        }


        public void ActualizarDgvFiltrosE()
        {

            try
            {
                if (busqueda.Equals("Codigo de Barras"))
                {
                    DataTable filtros = cliente.BuscarFiltroCodigo(valor);
                    dgvFiltrosE.DataSource = filtros;

                }
                else if (busqueda.Equals("Marca"))
                {
                    DataTable filtros = cliente.BuscarFiltroMarca(valor);
                    dgvFiltrosE.DataSource = filtros;

                }
                else if (busqueda.Equals("Mostrar Todos"))
                {
                    DataTable filtros = cliente.ObtenerFiltros();
                    dgvFiltrosE.DataSource = filtros;
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

        private void LoadEditar()
        {
            try
            {
                cbxCriBusquedaE.DropDownStyle = ComboBoxStyle.DropDownList;
                cbxTipoFiltroE.DropDownStyle = ComboBoxStyle.DropDownList;
                cbxTipoFiltroE.Items.AddRange(cliente.ObtenerTipoFiltro());

                txtBusquedaE.Visible = false;
                btnEditarVehiculos.Enabled = false;

                DeshabilitarCamposE();
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
            txtRoscaE.Clear();
            rtxtCodigosE.Clear();
            cbxTipoFiltroE.SelectedIndex = -1;
            txtPreSIvaE.Clear();
            txtPreCIvaE.Clear();
            txtGananPorMayorE.Clear();
            txtPreVMenorE.Clear();
            txtPreVMayorE.Clear();
            txtMargenMayorE.Clear();
            txtMargenMenorE.Clear();

            btnAgregarVehiculos.Enabled = false;
        }

        public List<string> recuperarRtxtE()
        {
            string[] list = rtxtCodigosE.Lines;
            List<string> codigos = new List<string>(list);
            return codigos;
        }

        public void llenarRtxtE(int id)
        {

            List<string> codigos = new List<string>();

            foreach (DataGridViewRow row in dgvFiltrosE.Rows)
            {
                if (Convert.ToInt32(row.Cells[0].Value.ToString()) == id)
                {
                    codigos.Add(row.Cells[5].Value.ToString());
                }    
            }

            rtxtCodigosE.Lines = codigos.ToArray();
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

        private void dgvFiltrosE_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                txtMarcaE.Text = dgvFiltrosE.SelectedCells[1].Value.ToString();
                txtDescripcionE.Text = dgvFiltrosE.SelectedCells[2].Value.ToString();
                txtRoscaE.Text = dgvFiltrosE.SelectedCells[3].Value.ToString();
                cbxTipoFiltroE.SelectedItem = dgvFiltrosE.SelectedCells[4].Value.ToString();
                llenarRtxtE(Convert.ToInt32(dgvFiltrosE.SelectedCells[0].Value.ToString()));
                txtCodigoBE.Text = dgvFiltrosE.SelectedCells[6].Value.ToString();
                txtPreSIvaE.Text = Math.Round(Convert.ToDouble(dgvFiltrosE.SelectedCells[7].Value.ToString()), 2).ToString();
                txtPreCIvaE.Text = Math.Round(Convert.ToDouble(dgvFiltrosE.SelectedCells[8].Value.ToString()), 2).ToString();
                txtPreVMayorE.Text = Math.Round(Convert.ToDouble(dgvFiltrosE.SelectedCells[9].Value.ToString()), 2).ToString();
                txtPreVMenorE.Text = Math.Round(Convert.ToDouble(dgvFiltrosE.SelectedCells[10].Value.ToString()), 2).ToString();
                txtMargenMayorE.Text = Math.Round(Convert.ToDouble(dgvFiltrosE.SelectedCells[11].Value.ToString()), 2).ToString();
                txtMargenMenorE.Text = Math.Round(Convert.ToDouble(dgvFiltrosE.SelectedCells[12].Value.ToString()), 2).ToString();
                txtCantidadE.Text = dgvFiltrosE.SelectedCells[13].Value.ToString();
                txtCantidadMinE.Text = dgvFiltrosE.SelectedCells[14].Value.ToString();
                txtGananPorMayorE.Text = Math.Round((((Convert.ToDouble(txtPreVMayorE.Text) - Convert.ToDouble(txtPreCIvaE.Text)) * 100) / (Convert.ToDouble(txtPreCIvaE.Text)))).ToString();

                codigos = recuperarRtxtE();

                btnEditarVehiculos.Enabled = true;
            }
            catch (ArgumentOutOfRangeException)
            {
                DialogResult dialogResult = MessageBox.Show("Selección no válida", "Aviso", MessageBoxButtons.OK);
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
                        DataTable filtros = cliente.BuscarFiltroCodigo(txtBusquedaD.Text);
                        dgvFiltrosD.DataSource = filtros;

                    }
                    else if (cbxCriBusquedaD.SelectedItem.ToString().Equals("Marca"))
                    {
                        DataTable filtros = cliente.BuscarFiltroMarca(txtBusquedaD.Text);
                        dgvFiltrosD.DataSource = filtros;
                    }
                    else if (cbxCriBusquedaD.SelectedItem.ToString().Equals("Mostrar Todos"))
                    {
                        DataTable filtros = cliente.ObtenerFiltros();
                        dgvFiltrosD.DataSource = filtros;
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
                idCodigos = cliente.ObtenerIdCodigosFiltro(Convert.ToInt32(dgvFiltrosD.SelectedCells[0].Value.ToString())).ToList();

                cliente.LimpiarRelacionCodigosBase(Convert.ToInt32(dgvFiltrosD.SelectedCells[0].Value.ToString()));



                foreach (var item in idCodigos)
                {
                    cliente.LimpiarCodigosBase(Convert.ToInt32(item));
                }

                int resultado = cliente.EliminarFiltro(Convert.ToInt32(dgvFiltrosD.SelectedCells[0].Value));

                if (resultado==1)
                {
                    DialogResult dialogResult = MessageBox.Show("Filtro eliminado con éxito", "Aviso", MessageBoxButtons.OK);
                    ActualizarDgvFiltroD();
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Ocurrió un error al eliminar el filtro", "Aviso", MessageBoxButtons.OK);
                }
                
            }
            catch (ArgumentOutOfRangeException)
            {
                DialogResult dialogResult = MessageBox.Show("Selección no válida", "Aviso", MessageBoxButtons.OK);
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

        private void LoadEliminar()
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

        public void ActualizarDgvFiltroD()
        {
            try
            {
                if (busqueda.Equals("Codigo de Barras"))
                {
                    DataTable filtros = cliente.BuscarFiltroCodigo(valor);
                    dgvFiltrosD.DataSource = filtros;

                }
                else if (busqueda.Equals("Marca"))
                {
                    DataTable filtros = cliente.BuscarFiltroMarca(valor);
                    dgvFiltrosD.DataSource = filtros;

                }
                else if (busqueda.Equals("Mostrar Todos"))
                {
                    DataTable filtros = cliente.ObtenerFiltros();
                    dgvFiltrosD.DataSource = filtros;
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
