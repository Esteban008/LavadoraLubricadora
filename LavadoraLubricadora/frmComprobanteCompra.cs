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
    public partial class frmComprobanteCompra : Form
    {
        LavadoraService.LavadoraServiceClient cliente;
        private int idComprobante;



        private static bool estadoIngresar = false;
        private static DataTable dtProductos;
        private static DataTable productos;

        public frmComprobanteCompra()
        {
            InitializeComponent();
        }

        private void frmComprobanteCompra_Load(object sender, EventArgs e)
        {
            cliente = new LavadoraService.LavadoraServiceClient();

            //PESTAÑA DE EDITAR
            LoadIngresar();

            //PESTAÑA DE BUSQUEDA
            LoadBuscar();

            //PESTAÑA DE ANULAR
            LoadAnular();
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

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                LavadoraService.Cliente clienteObj = cliente.BuscarClienteCedulaObj(txtCedulaBuscar.Text);

                if (clienteObj.IdPersona != 0)
                {
                    txtNombre.Text = clienteObj.Nombre;
                    txtApellido.Text = clienteObj.Apellido;
                    txtTelefono.Text = clienteObj.Telefono;
                    txtCorreo.Text = clienteObj.Correo;
                    txtCedula.Text = clienteObj.Cedula;
                    txtDireccion.Text = clienteObj.Direccion;
                    estadoIngresar = false;
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Cliente no encontrado, Desea ingresar el cliente", "Aviso", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        DesbloquearCampos();
                        estadoIngresar = true;
                        txtCedula.Text = txtCedulaBuscar.Text;
                    }
                }
            }
            catch (Exception)
            {
                DialogResult dialogResult = MessageBox.Show("Ha ocurrido un error de connección", "Aviso", MessageBoxButtons.OK);
            }
        }

        #endregion
    }
}
