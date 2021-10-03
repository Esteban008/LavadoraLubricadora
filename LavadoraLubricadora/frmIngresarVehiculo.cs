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
            txtIgresarMarca.Text = "";
            lblIngresarMarca.Visible = false;
            txtIgresarMarca.Visible = false;
            btnCancelarMarca.Visible = false;
            cbxMarcasVehiculos.Enabled = true;
        }

        private void btnCancelarModelo_Click(object sender, EventArgs e)
        {
            txtIngresarModelo.Text = "";
            lblIngresarModelo.Visible = false;
            txtIngresarModelo.Visible = false;
            btnCancelarModelo.Visible = false;
            cbxModeloVehiculo.Enabled = true;
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
                lblIngresarMarca.Visible = true;
                txtIgresarMarca.Visible = true;
                cbxMarcasVehiculos.Enabled = false;
                btnCancelarMarca.Visible = true;
                cbxModeloVehiculo.Items.Clear();
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
                lblIngresarModelo.Visible = true;
                txtIngresarModelo.Visible = true;
                cbxModeloVehiculo.Enabled = false;
                btnCancelarModelo.Visible = true;
                cbxAnioVehiculo.Items.Clear();
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
                cbxAnioVehiculo.Items.Clear();          
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
                cbxMotorVehiculo.Items.Clear();
            }
        }
        #endregion
    }
}
