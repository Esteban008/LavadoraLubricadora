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
    public partial class frmIngresarUsuario : Form
    {
        LavadoraService.LavadoraServiceClient cliente;
        public frmIngresarUsuario()
        {
            InitializeComponent();
        }

        private void frmIngresarUsuario_Load(object sender, EventArgs e)
        {
            cliente = new LavadoraService.LavadoraServiceClient();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            cliente.IngresarUsuario(txtNombre.Text, txtApellido.Text, txtTelefono.Text, txtCorreo.Text, txtRol.Text, txtCnueva.Text);
            DialogResult dialogResult = MessageBox.Show("Proveedor guardado con éxito", "Aviso", MessageBoxButtons.OK);
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtRol.Clear();
            txtCnueva.Clear();
            txtCrepetir.Clear();
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
