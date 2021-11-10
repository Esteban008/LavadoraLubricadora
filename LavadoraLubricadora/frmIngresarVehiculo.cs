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
    public partial class frmIngresarVehiculo : Form
    {
        LavadoraService.LavadoraServiceClient cliente;
        int estado = 0;
        public frmIngresarVehiculo()
        {
            InitializeComponent();
        }

        private void frmIngresarVehiculo_Load(object sender, EventArgs e)
        {

            cliente = new LavadoraService.LavadoraServiceClient();

            BloquearEdicionCombos();
            OcultartxtVehiculo();
            LlenarCombos();
            ActualizarDgvVehiculos();
            btnCancelarIngreso.Visible = false;
        }


        public void BloquearEdicionCombos()
        {
            cbxMarcasVehiculos.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxModeloVehiculo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxAnioVehiculo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxMotorVehiculo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void HabilitarCombos()
        {
            cbxMarcasVehiculos.Enabled = true;
            cbxModeloVehiculo.Enabled = true;
            cbxAnioVehiculo.Enabled = true;
            cbxMotorVehiculo.Enabled = true;
        }

        public void DeshabilitarCombos()
        {
            cbxMarcasVehiculos.Enabled = false;
            cbxModeloVehiculo.Enabled = false;
            cbxAnioVehiculo.Enabled = false;
            cbxMotorVehiculo.Enabled = false;
        }

        public void LlenarCombos()
        {
            cbxMarcasVehiculos.Items.AddRange(cliente.ObtenerMarcaVehiculo());
            cbxMarcasVehiculos.Items.Add("Otra Marca");
        }

        public void ActualizarDgvVehiculos()
        {
            DataTable vehiculos = cliente.ObtenerVehiculos();
            dgvVehiculos.DataSource = vehiculos;
        }

        public void HabilitarCamposMarca()
        {
            lblIngresarMarca.Visible = true;
            txtIngresarMarca.Visible = true;
            cbxMarcasVehiculos.Enabled = false;
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

        // Acciones del Boton Cancelar de todos los parametros


        #region ComboSelectedValuerChanged
        private void cbxMarcasVehiculos_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbxMarcasVehiculos.SelectedItem.Equals("Otra Marca"))
            {

                HabilitarCamposMarca();

                //Campos de Modelo
                HabilitarCamposModelo();
                cbxModeloVehiculo.Items.Clear();

                //Campos de Anio
                HabilitarCamposAnio();
                cbxAnioVehiculo.Items.Clear();

                //Campos de Motor
                HabilitarCamposMotor();
                cbxMotorVehiculo.Items.Clear();

                btnCancelarIngreso.Visible = true;

            }
            else
            {
                cbxModeloVehiculo.Items.Clear();
                cbxModeloVehiculo.Items.AddRange(cliente.ObtenerModeloVehiculo(cbxMarcasVehiculos.SelectedItem.ToString()));
                cbxModeloVehiculo.Items.Add("Otro Modelo");
            }
        }

        private void cbxModeloVehiculo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbxModeloVehiculo.SelectedItem.Equals("Otro Modelo"))
            {
                //Campo Modelo 
                HabilitarCamposModelo();


                //Campos de Anio
                HabilitarCamposAnio();
                cbxAnioVehiculo.Items.Clear();

                //Campos de Motor
                HabilitarCamposMotor();
                cbxMotorVehiculo.Items.Clear();

                btnCancelarIngreso.Visible = true;
            }
            else
            {
                cbxAnioVehiculo.Items.Clear();
                cbxAnioVehiculo.Items.AddRange(cliente.ObtenerAnioVehiculo(cbxMarcasVehiculos.SelectedItem.ToString(),cbxModeloVehiculo.SelectedItem.ToString()));
                cbxAnioVehiculo.Items.Add("Otro Año");

                cbxMotorVehiculo.Items.Clear();
                cbxMotorVehiculo.Items.AddRange(cliente.ObtenerMotorVehiculo(cbxMarcasVehiculos.SelectedItem.ToString(), cbxModeloVehiculo.SelectedItem.ToString()));
                cbxMotorVehiculo.Items.Add("Otro Motor");
            }
        }
        

        private void cbxAnioVehiculo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbxAnioVehiculo.SelectedItem.Equals("Otro Año"))
            {
                HabilitarCamposAnio();
                btnCancelarIngreso.Visible = true;
            }
        }

        private void cbxMotorVehiculo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbxMotorVehiculo.SelectedItem.Equals("Otro Motor"))
            {
                HabilitarCamposMotor();
                btnCancelarIngreso.Visible = true;
            }
        }

        #endregion

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Seguro que desea CANCELAR y SALIR?", "Aviso", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        

        private void dgvVehiculos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MostrartxtVehiculo();
            txtIngresarMarca.Text = dgvVehiculos.SelectedCells[1].Value.ToString();
            txtIngresarModelo.Text = dgvVehiculos.SelectedCells[2].Value.ToString();
            txtIngresarAnio.Text = dgvVehiculos.SelectedCells[3].Value.ToString();
            txtIngresarMotor.Text = dgvVehiculos.SelectedCells[4].Value.ToString();
            
        }


        public void MostrartxtVehiculo()
        {
            //Mostrar textbox
            txtIngresarMarca.Visible = true;
            txtIngresarModelo.Visible = true; 
            txtIngresarAnio.Visible = true;
            txtIngresarMotor.Visible = true;
            //Mostrar labels
            lblIngresarMarca.Visible = true;
            lblIngresarModelo.Visible = true;
            lblIngresarAnio.Visible = true;
            lblIngresarMotor.Visible = true;
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

        public void LimpiarCombos()
        {
            cbxMarcasVehiculos.Items.Clear();
            cbxModeloVehiculo.Items.Clear();
            cbxAnioVehiculo.Items.Clear();
            cbxMotorVehiculo.Items.Clear();
        }
        

        private void btnCancelarIngreso_Click(object sender, EventArgs e)
        {
            HabilitarCombos();
            LimpiarCombos();
            LlenarCombos();
            OcultartxtVehiculo();

            btnCancelarIngreso.Visible = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            MostrartxtVehiculo();
            estado = 2;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            
            MostrartxtVehiculo();
            LimpiarCombos();
            estado = 1;
            dgvVehiculos.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            List<LavadoraService.Vehiculo> vehiculos = new List<LavadoraService.Vehiculo>(cliente.ObtenerVehiculo());
            bool validacionIngreso = true;

            if (estado == 1)
            {
                if (cbxMarcasVehiculos.SelectedItem.Equals("Otra Marca"))
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
                        //Se crea un NUEVO vehiculo
                        cliente.IngresarVehiculo(txtIngresarMarca.Text, txtIngresarModelo.Text, Convert.ToInt32(txtIngresarAnio.Text), txtIngresarMotor.Text);
                        DialogResult dialogResult = MessageBox.Show("Vehiculo ingresado exitosamente", "Aviso", MessageBoxButtons.OK);
                        this.Close();
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
                            if (vehiculo.Marca.Equals(cbxMarcasVehiculos.SelectedItem.ToString()))
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
                            //Se crea un NUEVO vehiculo 
                            cliente.IngresarVehiculo(cbxMarcasVehiculos.SelectedItem.ToString(), txtIngresarModelo.Text, Convert.ToInt32(txtIngresarAnio.Text), txtIngresarMotor.Text);
                            DialogResult dialogResult = MessageBox.Show("Vehiculo ingresado exitosamente", "Aviso", MessageBoxButtons.OK);
                            this.Close();
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
                                if ((vehiculo.Marca.Equals(cbxMarcasVehiculos.SelectedItem.ToString())) && (vehiculo.Modelo.Equals(cbxModeloVehiculo.SelectedItem.ToString())))
                                {
                                    if (vehiculo.Anio == Convert.ToInt32(txtIngresarAnio.Text))
                                    {
                                        validacionIngreso = false;
                                    }

                                }
                            }

                            if (validacionIngreso)
                            {

                                if (cbxMotorVehiculo.SelectedItem.Equals("Otro Motor"))
                                {
                                    //Se crea un NUEVO vehiculo
                                    cliente.IngresarVehiculo(cbxMarcasVehiculos.SelectedItem.ToString(), cbxModeloVehiculo.SelectedItem.ToString(), Convert.ToInt32(txtIngresarAnio.Text), txtIngresarMotor.Text);
                                    DialogResult dialogResult = MessageBox.Show("Vehiculo ingresado exitosamente", "Aviso", MessageBoxButtons.OK);
                                    this.Close();
                                }
                                else
                                {
                                    //Se crea un NUEVO vehiculo
                                    cliente.IngresarVehiculo(cbxMarcasVehiculos.SelectedItem.ToString(), cbxModeloVehiculo.SelectedItem.ToString(), Convert.ToInt32(txtIngresarAnio.Text), cbxMotorVehiculo.SelectedItem.ToString());
                                    DialogResult dialogResult = MessageBox.Show("Vehiculo ingresado exitosamente", "Aviso", MessageBoxButtons.OK);
                                    this.Close();
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
                                    if ((vehiculo.Marca.Equals(cbxMarcasVehiculos.SelectedItem.ToString())) && (vehiculo.Modelo.Equals(cbxModeloVehiculo.SelectedItem.ToString())) && (vehiculo.Anio == Convert.ToInt32(cbxAnioVehiculo.SelectedItem.ToString())))
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
                                        //Se crea un NUEVO vehiculo
                                        cliente.IngresarMotorVehiculo(cbxMarcasVehiculos.SelectedItem.ToString(), cbxModeloVehiculo.SelectedItem.ToString(), Convert.ToInt32(txtIngresarAnio.Text), txtIngresarMotor.Text);
                                        DialogResult dialogResult = MessageBox.Show("Vehiculo ingresado exitosamente", "Aviso", MessageBoxButtons.OK);
                                        this.Close();
                                    }
                                    else
                                    {
                                        //Se crea un NUEVO vehiculo
                                        cliente.IngresarMotorVehiculo(cbxMarcasVehiculos.SelectedItem.ToString(), cbxModeloVehiculo.SelectedItem.ToString(), Convert.ToInt32(cbxAnioVehiculo.SelectedItem.ToString()), txtIngresarMotor.Text);
                                        DialogResult dialogResult = MessageBox.Show("Vehiculo ingresado exitosamente", "Aviso", MessageBoxButtons.OK);
                                        this.Close();
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
            else if (estado == 2)
            {
                cliente.EditarVehiculo(Convert.ToInt32(dgvVehiculos.SelectedCells[0].Value.ToString()), txtIngresarMarca.Text, txtIngresarModelo.Text, Convert.ToInt32(txtIngresarAnio.Text), txtIngresarMotor.Text);
            }
            else
            {
                Console.WriteLine("que putas");
            }



            ActualizarDgvVehiculos();
        }
    }
}
