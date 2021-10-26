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
    public partial class frmIngresarProveedores : Form
    {

        LavadoraService.LavadoraServiceClient cliente;
        public frmIngresarProveedores()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            cliente.IngresarProveedor(txtRuc.Text, txtNombre.Text, txtApellido.Text, txtTelefono.Text, txtCorreo.Text, txtDireccion.Text, txtEmpresa.Text);
            LimpiarCampos();

            DialogResult dialogResult = MessageBox.Show("Proveedor guardado con éxito", "Aviso", MessageBoxButtons.OK);
        }

        private void frmIngresarProveedores_Load(object sender, EventArgs e)
        {
            cliente = new LavadoraService.LavadoraServiceClient();
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtRuc.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtDireccion.Clear();
            txtEmpresa.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Seguro que desea Salir?", "Aviso", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
