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
    public partial class frmAdminVehiculos : Form
    {
        LavadoraService.LavadoraServiceClient cliente;
        private static string busqueda;
        private static string valor;
        public frmAdminVehiculos()
        {
            InitializeComponent();
        }

        private void frmAdminVehiculos_Load(object sender, EventArgs e)
        {
            cliente = new LavadoraService.LavadoraServiceClient();
            LoadIngresar();
            LoadEditar();
            LoadEliminar();
        }

        #region Ingresar Vehiculo

        private void LoadIngresar()
        {         
            BloquearEdicionCombos();
            OcultartxtVehiculo();
            LlenarCombos();
        }

        public void BloquearEdicionCombos()
        {
            cbxMarcaVehiculo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxModeloVehiculo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxAnioVehiculo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxMotorVehiculo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void OcultartxtVehiculo()
        {
            //Ocultar labels y limpiar los text box y labels
            txtIngresarMarca.Clear();
            lblIngresarMarca.Visible = false;
            txtIngresarMarca.Visible = false;


            txtIngresarModelo.Clear();
            lblIngresarModelo.Visible = false;
            txtIngresarModelo.Visible = false;

            txtIngresarAnio.Clear();
            lblIngresarAnio.Visible = false;
            txtIngresarAnio.Visible = false;

            txtIngresarMotor.Clear();
            lblIngresarMotor.Visible = false;
            txtIngresarMotor.Visible = false;
        }

        public void LlenarCombos()
        {
            try
            {
                cbxMarcaVehiculo.Items.AddRange(cliente.ObtenerMarcaVehiculo());
                cbxMarcaVehiculo.Items.Add("Otra Marca");
                cbxModeloVehiculo.Items.Add("Otro Modelo");
                cbxAnioVehiculo.Items.Add("Otro Año");
                cbxMotorVehiculo.Items.Add("Otro Motor");
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

        public void HabilitarCamposMarca()
        {
            lblIngresarMarca.Visible = true;
            txtIngresarMarca.Visible = true;
            cbxMarcaVehiculo.Enabled = false;
        }

        public void HabilitarCamposModelo()
        {
            lblIngresarModelo.Visible = true;
            txtIngresarModelo.Visible = true;
            cbxModeloVehiculo.Enabled = false;
        }

        public void HabilitarCamposAnio()
        {
            lblIngresarAnio.Visible = true;
            txtIngresarAnio.Visible = true;
            cbxAnioVehiculo.Enabled = false;
        }

        public void HabilitarCamposMotor()
        {
            lblIngresarMotor.Visible = true;
            txtIngresarMotor.Visible = true;
            cbxMotorVehiculo.Enabled = false;
        }

        public void LimpiarCombos()
        {
            cbxMarcaVehiculo.Items.Clear();
            cbxModeloVehiculo.Items.Clear();
            cbxAnioVehiculo.Items.Clear();
            cbxMotorVehiculo.Items.Clear();
        }

        public void HabilitarCombos()
        {
            cbxMarcaVehiculo.Enabled = true;
            cbxModeloVehiculo.Enabled = true;
            cbxAnioVehiculo.Enabled = true;
            cbxMotorVehiculo.Enabled = true;
        }

        private void cbxMarcaVehiculo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbxMarcaVehiculo.SelectedItem != null)
            {
                if (cbxMarcaVehiculo.SelectedItem.Equals("Otra Marca"))
                {
                    HabilitarCamposMarca();

                    //Campos de Modelo
                    HabilitarCamposModelo();
                    cbxModeloVehiculo.SelectedItem = "Otro Modelo";

                    //Campos de Anio
                    HabilitarCamposAnio();
                    cbxAnioVehiculo.SelectedItem = "Otro Año";

                    //Campos de Motor
                    HabilitarCamposMotor();
                    cbxMotorVehiculo.Items.Add("Otro Motor");
                }
                else
                {
                    cbxModeloVehiculo.Items.Clear();
                    cbxAnioVehiculo.Items.Clear();
                    cbxMotorVehiculo.Items.Clear();
                    cbxModeloVehiculo.Items.AddRange(cliente.ObtenerModeloVehiculo(cbxMarcaVehiculo.SelectedItem.ToString()));
                    cbxModeloVehiculo.Items.Add("Otro Modelo");
                    cbxAnioVehiculo.Items.Add("Otro Año");
                    cbxMotorVehiculo.Items.Add("Otro Motor");

                }
            }
        }


        private void cbxModeloVehiculo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbxModeloVehiculo.SelectedItem != null)
            {
                if (cbxModeloVehiculo.SelectedItem.Equals("Otro Modelo"))
                {
                    //Campo Modelo 
                    HabilitarCamposModelo();


                    //Campos de Anio
                    HabilitarCamposAnio();
                    cbxAnioVehiculo.SelectedItem = "Otro Año";

                    //Campos de Motor
                    HabilitarCamposMotor();
                    cbxMotorVehiculo.SelectedItem = "Otro Motor";
                }
                else
                {
                    try
                    {
                        cbxAnioVehiculo.Items.Clear();
                        cbxAnioVehiculo.Items.AddRange(cliente.ObtenerAnioVehiculo(cbxMarcaVehiculo.SelectedItem.ToString(), cbxModeloVehiculo.SelectedItem.ToString()));
                        cbxAnioVehiculo.Items.Add("Otro Año");


                        cbxMotorVehiculo.Items.Clear();
                        cbxMotorVehiculo.Items.AddRange(cliente.ObtenerMotorVehiculo(cbxMarcaVehiculo.SelectedItem.ToString(), cbxModeloVehiculo.SelectedItem.ToString()));
                        cbxMotorVehiculo.Items.Add("Otro Motor");
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
            }
        }

        private void cbxAnioVehiculo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbxAnioVehiculo.SelectedItem != null)
            {
                if (cbxAnioVehiculo.SelectedItem.Equals("Otro Año"))
                {
                    HabilitarCamposAnio();
                }
            }
        }

        private void cbxMotorVehiculo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbxMotorVehiculo.SelectedItem != null)
            {
                if (cbxMotorVehiculo.SelectedItem.Equals("Otro Motor"))
                {
                    HabilitarCamposMotor();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            HabilitarCombos();
            LimpiarCombos();
            LlenarCombos();
            OcultartxtVehiculo();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                List<LavadoraService.Vehiculo> vehiculos = new List<LavadoraService.Vehiculo>(cliente.ObtenerVehiculo());
                bool validacionIngreso = true;

                if (cbxMarcaVehiculo.SelectedItem != null && cbxModeloVehiculo.SelectedItem != null && cbxAnioVehiculo.SelectedItem != null && cbxMotorVehiculo.SelectedItem != null)
                {
                    if (cbxMarcaVehiculo.SelectedItem.Equals("Otra Marca"))
                    {
                        //Se verifica que la marca no exista
                        foreach (LavadoraService.Vehiculo vehiculo in vehiculos)
                        {
                            if (vehiculo.Marca.Equals(txtIngresarMarca.Text))
                            {
                                validacionIngreso = false;
                            }

                        }
                        if (validacionIngreso)
                        {
                            if (txtIngresarMarca.Text != "" && txtIngresarModelo.Text != "" && txtIngresarAnio.Text != "" && txtIngresarMotor.Text != "")
                            {
                                //Se crea un NUEVO vehiculo
                                int resultado = cliente.IngresarVehiculo(txtIngresarMarca.Text, txtIngresarModelo.Text, txtIngresarAnio.Text, txtIngresarMotor.Text);

                                if (resultado >= 1)
                                {
                                    DialogResult dialogResult = MessageBox.Show("Vehiculo ingresado exitosamente", "Aviso", MessageBoxButtons.OK);
                                    HabilitarCombos();
                                    LimpiarCombos();
                                    LlenarCombos();
                                    OcultartxtVehiculo();
                                }
                                else
                                {
                                    DialogResult dialogResult = MessageBox.Show("Vehiculo no ingresado verifique los datos ingresados", "Aviso", MessageBoxButtons.OK);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Uno o más campos están vacíos", "Aviso", MessageBoxButtons.OK);
                            }


                        }
                        else
                        {
                            DialogResult dialogResult = MessageBox.Show("¡La marca ya existe!", "Aviso", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        //Si el usuario utiliza una marca existente se procede a verificar el modelo del vehiculo
                        if (cbxModeloVehiculo.SelectedItem.Equals("Otro Modelo"))
                        {

                            //Se verifica que el modelo no existe
                            foreach (LavadoraService.Vehiculo vehiculo in vehiculos)
                            {
                                if (vehiculo.Marca.Equals(cbxMarcaVehiculo.SelectedItem.ToString()))
                                {
                                    if (vehiculo.Modelo.Equals(txtIngresarModelo.Text))
                                    {

                                        validacionIngreso = false;
                                    }

                                }

                            }
                            //Si el usuario selecciono otro modelo se crea un NUEVO vehiculo de marca existente

                            if (validacionIngreso)
                            {
                                if (cbxMarcaVehiculo.SelectedItem != null && txtIngresarModelo.Text != "" && txtIngresarAnio.Text != "" && txtIngresarMotor.Text != "")
                                {
                                    //Se crea un NUEVO vehiculo 
                                    int resultado = cliente.IngresarVehiculo(cbxMarcaVehiculo.SelectedItem.ToString(), txtIngresarModelo.Text, txtIngresarAnio.Text, txtIngresarMotor.Text);

                                    if (resultado >= 1)
                                    {
                                        DialogResult dialogResult = MessageBox.Show("Vehiculo ingresado exitosamente", "Aviso", MessageBoxButtons.OK);
                                        HabilitarCombos();
                                        LimpiarCombos();
                                        LlenarCombos();
                                        OcultartxtVehiculo();
                                    }
                                    else
                                    {
                                        DialogResult dialogResult = MessageBox.Show("Vehiculo no ingresado verifique los datos ingresados", "Aviso", MessageBoxButtons.OK);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Uno o más campos están vacíos", "Aviso", MessageBoxButtons.OK);
                                }



                            }
                            else
                            {
                                DialogResult dialogResult = MessageBox.Show("¡El modelo ya existe!", "Aviso", MessageBoxButtons.OK);
                            }

                        }
                        else
                        {
                            //Si el usuario utiliza una marca y modelo existente se procede a verificar el anio del vehiculo
                            if (cbxAnioVehiculo.SelectedItem.Equals("Otro Año"))
                            {
                                //Si el usuario selecciono otro anio se crea un NUEVO vehiculo de marca y modelo existente
                                //Se verifica que el año del vehiculo no existe
                                foreach (LavadoraService.Vehiculo vehiculo in vehiculos)
                                {
                                    if ((vehiculo.Marca.Equals(cbxMarcaVehiculo.SelectedItem.ToString())) && (vehiculo.Modelo.Equals(cbxModeloVehiculo.SelectedItem.ToString())))
                                    {
                                        if (vehiculo.Anio == txtIngresarAnio.Text)
                                        {
                                            validacionIngreso = false;
                                        }

                                    }
                                }

                                if (validacionIngreso)
                                {

                                    if (cbxMotorVehiculo.SelectedItem.Equals("Otro Motor"))
                                    {
                                        if (cbxMarcaVehiculo.SelectedItem != null && cbxModeloVehiculo.SelectedItem != null && txtIngresarAnio.Text != "" && txtIngresarMotor.Text != "")
                                        {
                                            //Se crea un NUEVO vehiculo
                                            int resultado = cliente.IngresarVehiculo(cbxMarcaVehiculo.SelectedItem.ToString(), cbxModeloVehiculo.SelectedItem.ToString(), txtIngresarAnio.Text, txtIngresarMotor.Text);

                                            if (resultado >= 1)
                                            {
                                                DialogResult dialogResult = MessageBox.Show("Vehiculo ingresado exitosamente", "Aviso", MessageBoxButtons.OK);
                                                HabilitarCombos();
                                                LimpiarCombos();
                                                LlenarCombos();
                                                OcultartxtVehiculo();
                                            }
                                            else
                                            {
                                                DialogResult dialogResult = MessageBox.Show("Vehiculo no ingresado verifique los datos ingresados", "Aviso", MessageBoxButtons.OK);
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Uno o más campos están vacíos", "Aviso", MessageBoxButtons.OK);
                                        }
                                        
                                        
                                    }
                                    else
                                    {
                                        if (cbxMarcaVehiculo.SelectedItem != null && cbxModeloVehiculo.SelectedItem != null && txtIngresarAnio.Text != "" && cbxMotorVehiculo.SelectedItem != null)
                                        {
                                            //Se crea un NUEVO vehiculo
                                            int resultado = cliente.IngresarVehiculo(cbxMarcaVehiculo.SelectedItem.ToString(), cbxModeloVehiculo.SelectedItem.ToString(), txtIngresarAnio.Text, cbxMotorVehiculo.SelectedItem.ToString());

                                            if (resultado >= 1)
                                            {
                                                DialogResult dialogResult = MessageBox.Show("Vehiculo ingresado exitosamente", "Aviso", MessageBoxButtons.OK);
                                                HabilitarCombos();
                                                LimpiarCombos();
                                                LlenarCombos();
                                                OcultartxtVehiculo();
                                            }
                                            else
                                            {
                                                DialogResult dialogResult = MessageBox.Show("Vehiculo no ingresado verifique los datos ingresados", "Aviso", MessageBoxButtons.OK);
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Uno o más campos están vacíos", "Aviso", MessageBoxButtons.OK);
                                        }

                                    }


                                }
                                else
                                {
                                    DialogResult dialogResult = MessageBox.Show("¡El vehiculo con el mismo año ya existe!", "Aviso", MessageBoxButtons.OK);
                                }
                            }
                            else
                            {
                                //Si el usuario utiliza una marca, modelo y anio existente se procede a verificar el motor
                                if (cbxMotorVehiculo.SelectedItem.Equals("Otro Motor"))
                                {
                                    //Si el usuario selecciono otro motor se añade el NUEVO motor al vehiculo existente
                                    //Se verifica que el motor del vehiculo no existe
                                    foreach (LavadoraService.Vehiculo vehiculo in vehiculos)
                                    {
                                        if ((vehiculo.Marca.Equals(cbxMarcaVehiculo.SelectedItem.ToString())) && (vehiculo.Modelo.Equals(cbxModeloVehiculo.SelectedItem.ToString())) && (vehiculo.Anio == cbxAnioVehiculo.SelectedItem.ToString()))
                                        {
                                            foreach (string motor in vehiculo.TipoMotor)
                                            {
                                                if (motor.Equals(txtIngresarMotor.Text))
                                                {
                                                    validacionIngreso = false;
                                                }

                                            }
                                        }
                                    }

                                    if (validacionIngreso)
                                    {
                                        if (cbxAnioVehiculo.SelectedItem.Equals("Otro Año"))
                                        {
                                            if (cbxMarcaVehiculo.SelectedItem != null && cbxModeloVehiculo.SelectedItem != null && txtIngresarAnio.Text != "" && txtIngresarMotor.Text != "")
                                            {
                                                //Se crea un NUEVO vehiculo
                                                int resultado = cliente.IngresarMotorVehiculo(cbxMarcaVehiculo.SelectedItem.ToString(), cbxModeloVehiculo.SelectedItem.ToString(), txtIngresarAnio.Text, txtIngresarMotor.Text);

                                                if (resultado >= 1)
                                                {
                                                    DialogResult dialogResult = MessageBox.Show("Vehiculo ingresado exitosamente", "Aviso", MessageBoxButtons.OK);
                                                    HabilitarCombos();
                                                    LimpiarCombos();
                                                    LlenarCombos();
                                                    OcultartxtVehiculo();
                                                }
                                                else
                                                {
                                                    DialogResult dialogResult = MessageBox.Show("Vehiculo no ingresado verifique los datos ingresados", "Aviso", MessageBoxButtons.OK);
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Uno o más campos están vacíos", "Aviso", MessageBoxButtons.OK);
                                            }


                                        }
                                        else
                                        {
                                            if (cbxMarcaVehiculo.SelectedItem != null && cbxModeloVehiculo.SelectedItem != null && txtIngresarMotor.Text != "" && cbxAnioVehiculo.SelectedItem != null)
                                            {
                                                //Se crea un NUEVO vehiculo
                                                int resultado = cliente.IngresarMotorVehiculo(cbxMarcaVehiculo.SelectedItem.ToString(), cbxModeloVehiculo.SelectedItem.ToString(), cbxAnioVehiculo.SelectedItem.ToString(), txtIngresarMotor.Text);
                                                Console.WriteLine(resultado);
                                                if (resultado >= 1)
                                                {
                                                    DialogResult dialogResult = MessageBox.Show("Vehiculo ingresado exitosamente", "Aviso", MessageBoxButtons.OK);
                                                    HabilitarCombos();
                                                    LimpiarCombos();
                                                    LlenarCombos();
                                                    OcultartxtVehiculo();
                                                }
                                                else
                                                {
                                                    DialogResult dialogResult = MessageBox.Show("Vehiculo no ingresado verifique los datos ingresados", "Aviso", MessageBoxButtons.OK);
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Uno o más campos están vacíos", "Aviso", MessageBoxButtons.OK);
                                            }


                                        }


                                    }
                                    else
                                    {
                                        DialogResult dialogResult = MessageBox.Show("¡El vehiculo con el mismo motor ya existe!", "Aviso", MessageBoxButtons.OK);
                                    }
                                }
                                else
                                {
                                    //Caso contrario se procede a notificar que el vehiculo ya existe
                                    DialogResult dialogResult = MessageBox.Show("¡El vehiculo ya existe!", "Aviso", MessageBoxButtons.OK);
                                }
                            }
                        }
                    }
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Es necesario llenar todos los campos", "Aviso", MessageBoxButtons.OK);
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Seguro que desea Salir?", "Aviso", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        #endregion

        #region Tab Editar

        private void LoadEditar()
        {
            cbxCriBusquedaE.DropDownStyle = ComboBoxStyle.DropDownList;
            txtBusquedaE.Visible = false;
        }

        private void btnBuscarE_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxCriBusquedaE.SelectedItem != null)
                {
                    LimpiarCamposE();
                    if (cbxCriBusquedaE.SelectedItem.ToString().Equals("Marca"))
                    {
                        DataTable vehiculos = cliente.BuscarVehiculoMarca(txtBusquedaE.Text);
                        dgvVehiculosE.DataSource = vehiculos;

                    }
                    else if (cbxCriBusquedaE.SelectedItem.ToString().Equals("Modelo"))
                    {
                        DataTable vehiculos = cliente.BuscarVehiculoModelo(txtBusquedaE.Text);
                        dgvVehiculosE.DataSource = vehiculos;
                    }
                    else if (cbxCriBusquedaE.SelectedItem.ToString().Equals("Mostrar Todos"))
                    {
                        DataTable vehiculos = cliente.ObtenerVehiculos();
                        dgvVehiculosE.DataSource = vehiculos;
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

        private void LimpiarCamposE()
        {
            txtMarcaE.Clear();
            txtModeloE.Clear();
            txtAnioE.Clear();
            txtTipoMotorE.Clear();
        }

        private void btnGuardarE_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtMarcaE.Text != "" && txtModeloE.Text != "" && txtAnioE.Text != "" && txtTipoMotorE.Text != "")
                {
                    int resultado = cliente.EditarVehiculo(Convert.ToInt32(dgvVehiculosE.SelectedCells[0].Value.ToString()), txtMarcaE.Text, txtModeloE.Text, txtAnioE.Text, txtTipoMotorE.Text);

                    if (resultado >= 1)
                    {
                        DialogResult dialogResult = MessageBox.Show("Vehículo actualizado exitosamente", "Aviso", MessageBoxButtons.OK);
                        LimpiarCamposE();
                        ActualizarDgvVehiculosE();
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("Este vehículo no se ha podido actualizar verifique los datos ingresados", "Aviso", MessageBoxButtons.OK);
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

        public void ActualizarDgvVehiculosE()
        {
            try
            {
                if (busqueda.Equals("Marca"))
                {
                    DataTable vehiculos = cliente.BuscarVehiculoMarca(valor);
                    dgvVehiculosE.DataSource = vehiculos;

                }
                else if (busqueda.Equals("Modelo"))
                {
                    DataTable vehiculos = cliente.BuscarVehiculoModelo(valor);
                    dgvVehiculosE.DataSource = vehiculos;

                }
                else if (busqueda.Equals("Mostrar Todos"))
                {
                    DataTable vehiculos = cliente.ObtenerVehiculos();
                    dgvVehiculosE.DataSource = vehiculos;
                }
            }
            catch (Exception)
            {
                DialogResult dialogResult = MessageBox.Show("Ha ocurrido un error de conexión", "Aviso", MessageBoxButtons.OK);
            }

        }

        private void dgvVehiculosE_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMarcaE.Text = dgvVehiculosE.SelectedCells[1].Value.ToString();
                txtModeloE.Text = dgvVehiculosE.SelectedCells[2].Value.ToString();
                txtAnioE.Text = dgvVehiculosE.SelectedCells[3].Value.ToString();
                txtTipoMotorE.Text = dgvVehiculosE.SelectedCells[4].Value.ToString();
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

        #endregion

        #region Tab Eliminar

        private void LoadEliminar()
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
                    if (cbxCriBusquedaD.SelectedItem.ToString().Equals("Marca"))
                    {
                        DataTable vehiculos = cliente.BuscarVehiculoMarca(txtBusquedaE.Text);
                        dgvVehiculosD.DataSource = vehiculos;

                    }
                    else if (cbxCriBusquedaD.SelectedItem.ToString().Equals("Modelo"))
                    {
                        DataTable vehiculos = cliente.BuscarVehiculoModelo(txtBusquedaE.Text);
                        dgvVehiculosD.DataSource = vehiculos;
                    }
                    else if (cbxCriBusquedaD.SelectedItem.ToString().Equals("Mostrar Todos"))
                    {
                        DataTable vehiculos = cliente.ObtenerVehiculos();
                        dgvVehiculosD.DataSource = vehiculos;
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

        public void ActualizarDgvVehiculosD()
        {
            try
            {
                if (busqueda.Equals("Marca"))
                {
                    DataTable vehiculos = cliente.BuscarVehiculoMarca(valor);
                    dgvVehiculosD.DataSource = vehiculos;

                }
                else if (busqueda.Equals("Modelo"))
                {
                    DataTable vehiculos = cliente.BuscarVehiculoModelo(valor);
                    dgvVehiculosD.DataSource = vehiculos;

                }
                else if (busqueda.Equals("Mostrar Todos"))
                {
                    DataTable vehiculos = cliente.ObtenerVehiculos();
                    dgvVehiculosD.DataSource = vehiculos;
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
                int resultado = cliente.EliminarVehiculo(Convert.ToInt32(dgvVehiculosD.SelectedCells[0].Value));

                if (resultado>=1)
                {
                    DialogResult dialogResult = MessageBox.Show("Vehículo eliminado con éxito", "Aviso", MessageBoxButtons.OK);
                    ActualizarDgvVehiculosD();
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("No se puede eliminar este vehículo ya que pertenece a un proceso", "Aviso", MessageBoxButtons.OK);
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

        #endregion
    }
}
