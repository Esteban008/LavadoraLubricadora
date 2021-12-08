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
       
        private static bool estadoIngresar = false;
        private static DataTable dtProductos;

        public frmComprabanteVenta()
        {
            InitializeComponent();
        }

        private void frmComprabanteVenta_Load(object sender, EventArgs e)
        {
            cliente = new LavadoraService.LavadoraServiceClient();

            //PESTAÑA DE EDITAR
            LoadIngresar();

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
                    }
                }
            }
            catch (Exception)
            {
                DialogResult dialogResult = MessageBox.Show("Ha ocurrido un error de connección", "Aviso", MessageBoxButtons.OK);
            }          
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                LavadoraService.ProductoComprobante productoObj = cliente.BuscarProductosCBarras(txtCodigoBarras.Text);

                if (productoObj.Id != 0)
                {


                    if (txtCantidad.Text != String.Empty)
                    {
                        productoObj.Cantidad = Convert.ToInt32(txtCantidad.Text);
                        productoObj.PrecioTotal = (Convert.ToInt32(txtCantidad.Text) * productoObj.PrecioVenta);

                        object[] v =
                        {
                        productoObj.Id,
                        productoObj.Descripcion,
                        productoObj.CodigoBarras,
                        productoObj.Cantidad,
                        productoObj.PrecioVenta,
                        productoObj.PrecioTotal,
                        };

                        dtProductos.Rows.Add(v);

                        ActualizarDgv();

                        Calcular();
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("La cantidad es incorrecta", "Aviso", MessageBoxButtons.OK);
                    }


                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Producto no Encontrado", "Aviso", MessageBoxButtons.OK);
                }

            }
            catch (Exception)
            {
                DialogResult dialogResult = MessageBox.Show("Ha ocurrido un error de connección", "Aviso", MessageBoxButtons.OK);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnVender_Click(object sender, EventArgs e)
        {

        }

        private void LoadIngresar()
        {
            BloquearCampos();

            dtProductos = new DataTable();
            dtProductos.Clear();
            dtProductos.Columns.Add("ID");
            dtProductos.Columns.Add("Descripcion");
            dtProductos.Columns.Add("codigoBarras");
            dtProductos.Columns.Add("Cantidad");
            dtProductos.Columns.Add("precioVenta");
            dtProductos.Columns.Add("precioTotal");

            txtSubtotal.Enabled = false;
            txtIva.Enabled = false;
            txtTotal.Enabled = false;
            
        }

        private void BloquearCampos()
        {
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtTelefono.Enabled = false;
            txtCorreo.Enabled = false;
            txtCedula.Enabled = false;
            txtDireccion.Enabled = false;
        }
        private void DesbloquearCampos()
        {
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtTelefono.Enabled = true;
            txtCorreo.Enabled = true;
            txtCedula.Enabled = true;
            txtDireccion.Enabled = true;
        }       

        private void ActualizarDgv()
        {
            dgvProductosI.DataSource = dtProductos;
        }

        private void Calcular()
        {
            List<double> subtotal = new List<double>();

            foreach (DataGridViewRow row in dgvProductosI.Rows)
            {
                subtotal.Add(Convert.ToDouble(row.Cells[5].Value.ToString()));
            }

            txtSubtotal.Text = subtotal.Sum().ToString();
            txtIva.Text = Convert.ToString( Math.Round((Convert.ToDouble(txtSubtotal.Text) * 0.12),2) );
            txtTotal.Text = Convert.ToString( Math.Round((Convert.ToDouble(txtSubtotal.Text) + Convert.ToDouble(txtIva.Text)),2));
        }

        private void txtDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            //defenimos el rango de codigos ASCII que admite solo numeros a la entrada
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 45 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo está permitido números y la coma", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }

        private void txtDescuento_KeyUp(object sender, KeyEventArgs e)
        {
            double descuento = 0;

            //Conversion del valor en txtBaseImponible
            Double.TryParse(txtDescuento.Text, out descuento);


            txtTotal.Text = Convert.ToString(Math.Round((Convert.ToDouble(txtSubtotal.Text) + Convert.ToDouble(txtIva.Text))*(1-(descuento/100)), 2));
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            //defenimos el rango de codigos ASCII que admite solo numeros a la entrada
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 44 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo está permitido números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }

        #endregion


    }
}
