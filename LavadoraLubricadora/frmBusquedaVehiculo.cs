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
    public partial class frmBusquedaVehiculo : Form
    {
        LavadoraService.LavadoraServiceClient cliente;

        private void frmBusquedaVehiculo_Load(object sender, EventArgs e)
        {
            try
            {
                cliente = new LavadoraService.LavadoraServiceClient();
                BloquearEdicionCombos();
                //Llenado de combo
                cbxMarcaVehiculo.Items.AddRange(cliente.ObtenerMarcaVehiculo());
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

        public frmBusquedaVehiculo()
        {
            InitializeComponent();
        }

        //Evita edición de Combobox
        public void BloquearEdicionCombos()
        {
            cbxMarcaVehiculo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxModeloVehiculo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxAnioVehiculo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxMotorVehiculo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Seguro que desea Salir?", "Aviso", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void cbxMarcaVehiculo_SelectedValueChanged(object sender, EventArgs e)
        {
            cbxModeloVehiculo.Items.Clear();
            cbxAnioVehiculo.Items.Clear();
            cbxMotorVehiculo.Items.Clear();

            //Obtiene todos los modelos de la marca seleccionada
            cbxModeloVehiculo.Items.AddRange(cliente.ObtenerModeloVehiculo(cbxMarcaVehiculo.SelectedItem.ToString()));
        }

        private void cbxModeloVehiculo_SelectedValueChanged(object sender, EventArgs e)
        {
            cbxAnioVehiculo.Items.Clear();
            cbxMotorVehiculo.Items.Clear();

            //Obtiene todos los años y motorizaciones de la marca y modelo selecionada
            cbxAnioVehiculo.Items.AddRange(cliente.ObtenerAnioVehiculo(cbxMarcaVehiculo.SelectedItem.ToString(), cbxModeloVehiculo.SelectedItem.ToString()));
            cbxMotorVehiculo.Items.AddRange(cliente.ObtenerMotorVehiculo(cbxMarcaVehiculo.SelectedItem.ToString(), cbxModeloVehiculo.SelectedItem.ToString()));


        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxMarcaVehiculo.SelectedItem != null && cbxModeloVehiculo.SelectedItem != null && cbxAnioVehiculo.SelectedItem != null && cbxMotorVehiculo.SelectedItem != null)
                {
                    //Consulta los filtros correspondientes al vehiculo seleccionado
                    DataTable filtros = cliente.ObtenerFiltrosVehiculo(cliente.BuscarVehiculo(cbxMarcaVehiculo.SelectedItem.ToString(),
                                                                 cbxModeloVehiculo.SelectedItem.ToString(), cbxAnioVehiculo.SelectedItem.ToString(), cbxMotorVehiculo.SelectedItem.ToString()));
                    dgvFiltrosE.DataSource = filtros;
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Uno o más parámetros de búsqueda se encuantran vacíos", "Aviso", MessageBoxButtons.OK);
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
    }
}
