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
    public partial class frmGestionProveedores : Form
    {

        LavadoraService.LavadoraServiceClient cliente;
        public frmGestionProveedores()
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            cliente.IngresarProveedor(txtRuc.Text, txtNombre.Text, txtApellido.Text, txtTelefono.Text, txtCorreo.Text, txtDireccion.Text, txtEmpresa.Text);
            ActualizarDgvProveedor();
        }

        private void frmGestionProveedores_Load(object sender, EventArgs e)
        {
            cliente = new LavadoraService.LavadoraServiceClient();
            //Necesitamos una clase que llame lista de aceites para importar aca
            ActualizarDgvProveedor();
        }



        public void ActualizarDgvProveedor()
        {
            DataTable proveedores = cliente.ObtenerProveedor();
            dgvProveedores.DataSource = proveedores;
        }
    }
}
