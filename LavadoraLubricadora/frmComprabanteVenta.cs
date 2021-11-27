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
    public partial class frmComprabanteVenta : Form
    {

        LavadoraService.LavadoraServiceClient cliente;
        private static string busqueda;
        private static string valor;

        public frmComprabanteVenta()
        {
            InitializeComponent();
        }

        private void frmComprabanteVenta_Load(object sender, EventArgs e)
        {
            cliente = new LavadoraService.LavadoraServiceClient();

            //PESTAÑA DE EDITAR
            //LoadEditar();

            //PESTAÑA ELIMINAR
            //LoadEliminar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Seguro que desea Salir?", "Aviso", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }



        #region Ingresar
        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            LavadoraService.Cliente clienteObj = cliente.BuscarClienteCedulaObj(txtCedulaBuscar.Text);

            txtNombre.Text = clienteObj.Nombre;
            txtApellido.Text = clienteObj.Apellido;
            txtTelefono.Text = clienteObj.Telefono;
            txtCorreo.Text = clienteObj.Correo;
            txtCedula.Text = clienteObj.Cedula;
            txtDireccion.Text = clienteObj.Direccion;

        }



        #endregion

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}
