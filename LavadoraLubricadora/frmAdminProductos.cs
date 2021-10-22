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
    public partial class frmAdminProductos : Form
    {

        LavadoraService.LavadoraServiceClient cliente;
        public frmAdminProductos()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Seguro que desea Salir?", "Aviso", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnAgregarVehiculo_Click(object sender, EventArgs e)
        {
            frmIngresarVehiculo ingresarVehiculo = new frmIngresarVehiculo();
            ingresarVehiculo.ShowDialog();
        }

        private void frmAdminProductos_Load(object sender, EventArgs e)
        {
            cbxTipoProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cliente = new LavadoraService.LavadoraServiceClient();
        }

        private void cbxTipoProducto_SelectedValueChanged(object sender, EventArgs e)
        {
            //Si el usuario selecciona
            if (cbxTipoProducto.SelectedItem.Equals("Aceite"))
            {
                dgvProductos.Columns.Clear();
                //cbxViscocidad.SelectedIndex = 0;            
                //Necesitamos una clase que llame lista de aceites para importar aca
                DataTable aceites = cliente.ObtenerAceite();
                dgvProductos.DataSource = aceites;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
