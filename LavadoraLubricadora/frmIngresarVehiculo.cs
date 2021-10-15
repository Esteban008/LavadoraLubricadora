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
        public frmIngresarVehiculo()
        {
            InitializeComponent();
        }

        private void frmIngresarVehiculo_Load(object sender, EventArgs e)
        {
            lblIngresarMarca.Visible = false;
            txtIgresarMarca.Visible = false;
            cbxMarcasVehiculos.DropDownStyle = ComboBoxStyle.DropDownList;
            btnCancelarMarca.Visible = false;

            lblIngresarModelo.Visible = false;
            txtIngresarModelo.Visible = false;
            cbxModeloVehiculo.DropDownStyle = ComboBoxStyle.DropDownList;
            btnCancelarModelo.Visible = false;


            lblIngresarAnio.Visible = false;
            txtIngresarAnio.Visible = false;
            cbxAnioVehiculo.DropDownStyle = ComboBoxStyle.DropDownList;
            btnCancelarAnio.Visible = false;

            lblIngresarMotor.Visible = false;
            txtIngresarMotor.Visible = false;
            cbxMotorVehiculo.DropDownStyle = ComboBoxStyle.DropDownList;
            btnCancelarMotor.Visible = false;

            cliente = new LavadoraService.LavadoraServiceClient();

            cbxMarcasVehiculos.Items.AddRange(cliente.ObtenerMarcaVehiculo());
            cbxMarcasVehiculos.Items.Add("Otra Marca");
        }

        #region btnCancelar
        // Acciones del Boton Cancelar de todos los parametros
        private void btnCancelarMarca_Click(object sender, EventArgs e)
        {          
            btnCancelarMarca.Visible = false;

            //Activacion de los combobox
            cbxMarcasVehiculos.Enabled = true;
            cbxModeloVehiculo.Enabled = true;
            cbxAnioVehiculo.Enabled = true;
            cbxMotorVehiculo.Enabled = true;

            //Limpieza de los text box y labels
            txtIgresarMarca.Text = "";
            lblIngresarMarca.Visible = false;
            txtIgresarMarca.Visible = false;

            txtIngresarModelo.Text = "";
            lblIngresarModelo.Visible = false;
            txtIngresarModelo.Visible = false;

            txtIngresarAnio.Text = "";
            lblIngresarAnio.Visible = false;
            txtIngresarAnio.Visible = false;

            txtIngresarMotor.Text = "";
            lblIngresarMotor.Visible = false;
            txtIngresarMotor.Visible = false;

        }

        private void btnCancelarModelo_Click(object sender, EventArgs e)
        {            
            btnCancelarModelo.Visible = false;

            //Activacion de los combobox
            cbxModeloVehiculo.Enabled = true;
            cbxAnioVehiculo.Enabled = true;
            cbxMotorVehiculo.Enabled = true;

            //Limpieza de los text box y labels
            txtIngresarModelo.Text = "";
            lblIngresarModelo.Visible = false;
            txtIngresarModelo.Visible = false;

            txtIngresarAnio.Text = "";
            lblIngresarAnio.Visible = false;
            txtIngresarAnio.Visible = false;

            txtIngresarMotor.Text = "";
            lblIngresarMotor.Visible = false;
            txtIngresarMotor.Visible = false;
        }

        private void btnCancelarAnio_Click(object sender, EventArgs e)
        {
            txtIngresarAnio.Text = "";
            lblIngresarAnio.Visible = false;
            txtIngresarAnio.Visible = false;
            btnCancelarAnio.Visible = false;
            cbxAnioVehiculo.Enabled = true;

            cbxAnioVehiculo.Items.Clear();
            cbxAnioVehiculo.Items.AddRange(cliente.ObtenerAnioVehiculo(cbxMarcasVehiculos.SelectedItem.ToString(), cbxModeloVehiculo.SelectedItem.ToString()));
            cbxAnioVehiculo.Items.Add("Otro Año");
        }

        private void btnCancelarMotor_Click(object sender, EventArgs e)
        {
            txtIngresarMotor.Text = "";
            lblIngresarMotor.Visible = false;
            txtIngresarMotor.Visible = false;
            btnCancelarMotor.Visible = false;
            cbxMotorVehiculo.Enabled = true;

            cbxMotorVehiculo.Items.Clear();
            cbxMotorVehiculo.Items.AddRange(cliente.ObtenerMotorVehiculo(cbxMarcasVehiculos.SelectedItem.ToString(), cbxModeloVehiculo.SelectedItem.ToString()));
            cbxMotorVehiculo.Items.Add("Otro Motor");
        }
        #endregion

        #region ComboSelectedValuerChanged
        private void cbxMarcasVehiculos_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbxMarcasVehiculos.SelectedItem.Equals("Otra Marca"))
            {
                //Campos de Marca
                lblIngresarMarca.Visible = true;
                txtIgresarMarca.Visible = true;
                cbxMarcasVehiculos.Enabled = false;
                btnCancelarMarca.Visible = true;
                cbxModeloVehiculo.Items.Clear();
                cbxAnioVehiculo.Items.Clear();
                cbxMotorVehiculo.Items.Clear();

                //Campos de Modelo
                lblIngresarModelo.Visible = true;
                txtIngresarModelo.Visible = true;
                cbxModeloVehiculo.Enabled = false;

                //Campos de Anio
                lblIngresarAnio.Visible = true;
                txtIngresarAnio.Visible = true;
                cbxAnioVehiculo.Enabled = false;

                //Campos de Motor
                lblIngresarMotor.Visible = true;
                txtIngresarMotor.Visible = true;
                cbxMotorVehiculo.Enabled = false;
                cbxMotorVehiculo.Items.Clear();
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
                lblIngresarModelo.Visible = true;
                txtIngresarModelo.Visible = true;
                cbxModeloVehiculo.Enabled = false;
                btnCancelarModelo.Visible = true;
                cbxAnioVehiculo.Items.Clear();
                cbxMotorVehiculo.Items.Clear();

                //Campos de Anio
                lblIngresarAnio.Visible = true;
                txtIngresarAnio.Visible = true;
                cbxAnioVehiculo.Enabled = false;

                //Campos de Motor
                lblIngresarMotor.Visible = true;
                txtIngresarMotor.Visible = true;
                cbxMotorVehiculo.Enabled = false;
                cbxMotorVehiculo.Items.Clear();
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
                lblIngresarAnio.Visible = true;
                txtIngresarAnio.Visible = true;
                cbxAnioVehiculo.Enabled = false;
                btnCancelarAnio.Visible = true;         
            }
        }

        private void cbxMotorVehiculo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbxMotorVehiculo.SelectedItem.Equals("Otro Motor"))
            {
                lblIngresarMotor.Visible = true;
                txtIngresarMotor.Visible = true;
                cbxMotorVehiculo.Enabled = false;
                btnCancelarMotor.Visible = true;
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            List<LavadoraService.Vehiculo> vehiculos = new List<LavadoraService.Vehiculo>(cliente.ObtenerVehiculo());
            bool validacionIngreso=true;

            if (cbxMarcasVehiculos.SelectedItem.Equals("Otra Marca"))
            {
                //Se verifica que la marca no exista
                foreach (LavadoraService.Vehiculo vehiculo in vehiculos)
                {
                    if (vehiculo.Marca.Equals(txtIgresarMarca.Text))
                    {
                        validacionIngreso = false;
                    }
                    
                }
                if (validacionIngreso)
                {
                    //Se crea un NUEVO vehiculo
                    cliente.IngresarVehiculo(txtIgresarMarca.Text, txtIngresarModelo.Text, Convert.ToInt32(txtIngresarAnio.Text), txtIngresarMotor.Text);
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
    }
}
