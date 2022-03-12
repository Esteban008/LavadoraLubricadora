using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.ServiceModel;

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
                LavadoraService.Proveedor ProveedorObj = cliente.BuscarProveedorRucObj(txtRucBuscar.Text);

                if (ProveedorObj.IdPersona != 0)
                {
                    txtNombre.Text = ProveedorObj.Nombre;
                    txtApellido.Text = ProveedorObj.Apellido;
                    txtTelefono.Text = ProveedorObj.Telefono;
                    txtCorreo.Text = ProveedorObj.Correo;
                    txtEmpresa.Text = ProveedorObj.Empresa;
                    txtDireccion.Text = ProveedorObj.Direccion;
                    estadoIngresar = false;
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Proveedor no encontrado, ingrese los datos del proveedor", "Aviso", MessageBoxButtons.OK);

                    if (dialogResult == DialogResult.OK)
                    {
                        DesbloquearCampos();
                        estadoIngresar = true;

                    }
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                LavadoraService.ProductoComprobante productoObj;

                 productoObj = cliente.BuscarProductoCCompra(txtCodigoBarras.Text);


                if (txtCodigoBarras.Text != String.Empty && productoObj.Id != 0) 
                {
                    if (txtCantidad.Text != String.Empty)
                    {
                        productoObj.Cantidad = Convert.ToInt32(txtCantidad.Text);
                        productoObj.PrecioTotal = (Convert.ToInt32(txtCantidad.Text) * productoObj.Precio);

                        object[] v =
                        {
                        productoObj.Id,
                        productoObj.Descripcion,
                        productoObj.CodigoBarras,
                        productoObj.Cantidad,
                        productoObj.Precio,
                        productoObj.PrecioTotal,
                        };

                        if (ValidarProducto(productoObj.CodigoBarras))
                        {
                            DialogResult dialogResult = MessageBox.Show("Este producto ya existe", "Aviso", MessageBoxButtons.OK);
                        }
                        else
                        {
                            dtProductos.Rows.Add(v);
                        }
                        ActualizarDgv();

                        Calcular();
                        txtCodigoBarras.Clear();
                        txtCantidad.Clear();
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("Cantidad ingresada no válida", "Aviso", MessageBoxButtons.OK);
                    }

                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Producto no Encontrado", "Aviso", MessageBoxButtons.OK);
                    DialogResult dialogResult1 = MessageBox.Show("Si desea ingresar un producto nuevo, dirigase al apartado de Administración de Productos", "Aviso", MessageBoxButtons.OK);
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

        private void btnEliminarDgv_Click(object sender, EventArgs e)
        {
            try
            {
                dtProductos.Rows.RemoveAt(dgvProductosI.SelectedCells[2].RowIndex);

                dtProductos.AcceptChanges();

                dgvProductosI.DataSource = dtProductos;
            }
            catch (ArgumentOutOfRangeException)
            {

                DialogResult dialogResult = MessageBox.Show("Seleccione un producto", "Aviso", MessageBoxButtons.OK);
            }
            

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            idComprobante = 0;

            try
            {

                    if (estadoIngresar)
                    {
                        cliente.IngresarProveedor(txtRucBuscar.Text, txtNombre.Text, txtApellido.Text, txtTelefono.Text, txtCorreo.Text,  txtDireccion.Text, txtEmpresa.Text);

                        idComprobante = cliente.IngresarComprobanteCompra(txtRucBuscar.Text, txtNFactura.Text, Convert.ToDouble(txtSubtotal.Text), Convert.ToDouble(txtIva.Text), Convert.ToDouble(txtTotal.Text), 0, DateTime.Now);

                        foreach (DataGridViewRow row in dgvProductosI.Rows)
                        {
                            if ((row.Cells["dataGridViewTextBoxColumn26"].Value.ToString()).Contains("A-"))
                            {
                                cliente.IngresarAceiteComprobanteCompra(Convert.ToInt32(row.Cells[0].Value.ToString()), idComprobante, Convert.ToInt32(row.Cells[3].Value.ToString()));
                                if (cliente.ValidarMinAceite(Convert.ToInt32(row.Cells[0].Value.ToString())))
                                {
                                    MessageBox.Show("Producto: " + row.Cells[1].Value.ToString() + " está próximo a agotarse", "Aviso", MessageBoxButtons.OK);
                                }
                            }
                            if ((row.Cells["dataGridViewTextBoxColumn26"].Value.ToString()).Contains("F-"))
                            {
                                cliente.IngresarFiltroComprobanteCompra(Convert.ToInt32(row.Cells[0].Value.ToString()), idComprobante, Convert.ToInt32(row.Cells[3].Value.ToString()));
                                if (cliente.ValidarMinFiltro(Convert.ToInt32(row.Cells[0].Value.ToString())))
                                {
                                    MessageBox.Show("Producto: " + row.Cells[1].Value.ToString() + " está próximo a agotarse", "Aviso", MessageBoxButtons.OK);
                                }
                            }
                            if ((row.Cells["dataGridViewTextBoxColumn26"].Value.ToString()).Contains("P-"))
                            {
                                cliente.IngresarProductoComprobanteCompra(Convert.ToInt32(row.Cells[0].Value.ToString()), idComprobante, Convert.ToInt32(row.Cells[3].Value.ToString()));
                                if (cliente.ValidarMinProducto(Convert.ToInt32(row.Cells[0].Value.ToString())))
                                {
                                    MessageBox.Show("Producto: " + row.Cells[1].Value.ToString() + " está próximo a agotarse", "Aviso", MessageBoxButtons.OK);
                                }
                            }
                        }
                    }
                    else
                    {
                        idComprobante = cliente.IngresarComprobanteCompra(txtRucBuscar.Text, txtNFactura.Text, Convert.ToDouble(txtSubtotal.Text), Convert.ToDouble(txtIva.Text), Convert.ToDouble(txtTotal.Text), 0, DateTime.Now);

                        foreach (DataGridViewRow row in dgvProductosI.Rows)
                        {
                            if ((row.Cells["dataGridViewTextBoxColumn26"].Value.ToString()).Contains("A-"))
                            {
                                cliente.IngresarAceiteComprobanteCompra(Convert.ToInt32(row.Cells[0].Value.ToString()), idComprobante, Convert.ToInt32(row.Cells[3].Value.ToString()));
                                if (cliente.ValidarMinAceite(Convert.ToInt32(row.Cells[0].Value.ToString())))
                                {
                                    MessageBox.Show("Producto: " + row.Cells[1].Value.ToString() + " está próximo a agotarse", "Aviso", MessageBoxButtons.OK);
                                }
                            }
                            if ((row.Cells["dataGridViewTextBoxColumn26"].Value.ToString()).Contains("F-"))
                            {
                                cliente.IngresarFiltroComprobanteCompra(Convert.ToInt32(row.Cells[0].Value.ToString()), idComprobante, Convert.ToInt32(row.Cells[3].Value.ToString()));
                                if (cliente.ValidarMinFiltro(Convert.ToInt32(row.Cells[0].Value.ToString())))
                                {
                                    MessageBox.Show("Producto: " + row.Cells[1].Value.ToString() + " está próximo a agotarse", "Aviso", MessageBoxButtons.OK);
                                }
                            }
                            if ((row.Cells["dataGridViewTextBoxColumn26"].Value.ToString()).Contains("P-"))
                            {
                                cliente.IngresarProductoComprobanteCompra(Convert.ToInt32(row.Cells[0].Value.ToString()), idComprobante, Convert.ToInt32(row.Cells[3].Value.ToString()));
                                if (cliente.ValidarMinProducto(Convert.ToInt32(row.Cells[0].Value.ToString())))
                                {
                                    MessageBox.Show("Producto: " + row.Cells[1].Value.ToString() + " está próximo a agotarse", "Aviso", MessageBoxButtons.OK);
                                }
                            }
                        }
                    }


                    //Parte para imprimir comprobante
                    prtdComprobante = new PrintDocument();
                    PrinterSettings ps = new PrinterSettings();
                    prtdComprobante.PrinterSettings = ps;
                    prtdComprobante.PrintPage += Imprimir;
                    prtdComprobante.Print();



                    DialogResult dialogResult = MessageBox.Show("Comprobante generado con éxito", "Aviso", MessageBoxButtons.OK);

                    LimpiarCampos();

                    estadoIngresar = false;





            }
            catch (FormatException)
            {
                DialogResult dialogResult = MessageBox.Show("Uno o más campos estan vacios", "Aviso", MessageBoxButtons.OK);
            }
            catch (CommunicationException)
            {
                DialogResult dialogResult = MessageBox.Show("Se perdio la conexión. Cierre sesión e inicie nuevamente", "Aviso", MessageBoxButtons.OK);
            }
            catch (Exception)
            {
                DialogResult dialogResult = MessageBox.Show("Ha ocurrido un error de conexión", "Aviso", MessageBoxButtons.OK);
            }
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
            dtProductos.Columns.Add("precioCompraSinIva");
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
            txtEmpresa.Enabled = false;
            txtDireccion.Enabled = false;
        }

        private void DesbloquearCampos()
        {
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtTelefono.Enabled = true;
            txtCorreo.Enabled = true;
            txtEmpresa.Enabled = true;
            txtDireccion.Enabled = true;
        }

        public void LimpiarCampos()
        {
            txtNFactura.Clear();
            txtRucBuscar.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtEmpresa.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtCodigoBarras.Clear();
            txtCantidad.Clear();
            txtSubtotal.Clear();
            txtIva.Clear();
            txtTotal.Clear();

            dtProductos.Rows.Clear();
            ActualizarDgv();

        }

        private bool ValidarProducto(string codigoBarras)
        {
            bool estado = false;
            foreach (DataRow row in dtProductos.Rows)
            {
                if (row["codigoBarras"].ToString().Equals(codigoBarras))
                {
                    estado = true;
                }
            }
            return estado;
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            //defenimos el rango de codigos ASCII que admite solo numeros a la entrada
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 44 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo está permitido números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
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
            txtIva.Text = Convert.ToString(Math.Round((Convert.ToDouble(txtSubtotal.Text) * 0.12), 2));
            txtTotal.Text = Convert.ToString(Math.Round((Convert.ToDouble(txtSubtotal.Text) + Convert.ToDouble(txtIva.Text)), 2));
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

        private void txtRucBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            //defenimos el rango de codigos ASCII que admite solo numeros a la entrada
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 44 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo está permitido números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }

        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 14);
            int ancho = 450;
            int y = 20;

            StringFormat formatDerecha = new StringFormat();
            formatDerecha.Alignment = StringAlignment.Far;
            formatDerecha.LineAlignment = StringAlignment.Far;

            e.Graphics.DrawString("Lavadora y Lubricadora Negritos - Lubrigaman", font, Brushes.Black, new RectangleF(0, y += 0, ancho, 20));
            e.Graphics.DrawString("RUC: 0705760924001", font, Brushes.Black, new RectangleF(0, y += 30, ancho, 20));
            e.Graphics.DrawString("Av. Mariscal Sucre y Pedro Concha", font, Brushes.Black, new RectangleF(0, y += 30, ancho, 20));
            e.Graphics.DrawString("QUITO - ECUADOR", font, Brushes.Black, new RectangleF(0, y += 30, ancho, 20));
            e.Graphics.DrawString("TELEFONO: 0979098895", font, Brushes.Black, new RectangleF(0, y += 30, ancho, 20));

            e.Graphics.DrawString("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -", font, Brushes.Black, new RectangleF(0, y += 60, ancho, 20));

            e.Graphics.DrawString("PROVEEDOR: " + txtNombre.Text + " " + txtApellido.Text, font, Brushes.Black, new RectangleF(0, y += 30, ancho, 20));
            e.Graphics.DrawString("RUC: " + txtRucBuscar.Text, font, Brushes.Black, new RectangleF(0, y += 30, ancho, 20));
            e.Graphics.DrawString("EMPRESA: " + txtEmpresa.Text, font, Brushes.Black, new RectangleF(0, y += 30, ancho, 20));
            e.Graphics.DrawString("DIRECCIÓN: " + txtDireccion.Text, font, Brushes.Black, new RectangleF(0, y += 30, ancho, 20));
            e.Graphics.DrawString("TELÉFONO: " + txtTelefono.Text, font, Brushes.Black, new RectangleF(0, y += 30, ancho, 20));
            e.Graphics.DrawString("E-MAIL: " + txtCorreo.Text, font, Brushes.Black, new RectangleF(0, y += 30, ancho, 20));

            e.Graphics.DrawString("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));

            e.Graphics.DrawString("COMPROBANTE DE COMPRA: ", font, Brushes.Black, new RectangleF(0, y += 30, ancho, 20));
            e.Graphics.DrawString("No.: " + txtNFactura.Text, font, Brushes.Black, new RectangleF(0, y += 30, ancho, 20));
            e.Graphics.DrawString("FECHA: " + DateTime.Now.ToString(), font, Brushes.Black, new RectangleF(0, y += 30, ancho, 20));

            e.Graphics.DrawString("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));

            e.Graphics.DrawString("DESCRIPCIÓN          CANT.   P.UNIT   TOTAL: ", font, Brushes.Black, new RectangleF(0, y += 30, ancho, 20));

            e.Graphics.DrawString("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));


            foreach (DataRow row in dtProductos.Rows)
            {
                e.Graphics.DrawString(row["Descripcion"].ToString(), font, Brushes.Black, new RectangleF(0, y += 30, 150, 20));
                e.Graphics.DrawString(row["Cantidad"].ToString(), font, Brushes.Black, new RectangleF(190, y += 0, 50, 20), formatDerecha);
                e.Graphics.DrawString(row["precioCompraSinIva"].ToString(), font, Brushes.Black, new RectangleF(280, y += 0, 50, 20), formatDerecha);
                e.Graphics.DrawString(row["precioTotal"].ToString(), font, Brushes.Black, new RectangleF(380, y += 00, 50, 20), formatDerecha);
            }

            e.Graphics.DrawString("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));

            e.Graphics.DrawString("SUBTOTAL: ", font, Brushes.Black, new RectangleF(190, y += 30, ancho, 20));
            e.Graphics.DrawString(txtSubtotal.Text, font, Brushes.Black, new RectangleF(-30, y += 0, ancho, 20), formatDerecha);
            e.Graphics.DrawString("IVA 12%: ", font, Brushes.Black, new RectangleF(190, y += 30, ancho, 20));
            e.Graphics.DrawString(txtIva.Text, font, Brushes.Black, new RectangleF(-30, y += 0, ancho, 20), formatDerecha);          
            e.Graphics.DrawString("TOTAL: ", font, Brushes.Black, new RectangleF(190, y += 30, ancho, 20));
            e.Graphics.DrawString(txtTotal.Text, font, Brushes.Black, new RectangleF(-30, y += 0, ancho, 20), formatDerecha);

        }


        #endregion


        #region Buscar


        private void btnBuscarB_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxBusquedaB.SelectedItem != null)
                {
                    if (cbxBusquedaB.SelectedItem.Equals("Ruc Proveedor"))
                    {
                        DataTable comprobantes = cliente.BuscarComprobanteRuc(txtBusquedaB.Text);
                        dgvComprobantes.DataSource = comprobantes;
                    }
                    else if (cbxBusquedaB.SelectedItem.Equals("Fecha de Compra"))
                    {
                        DateTime fechaCompra = dtpFechaCompra.Value;


                        DataTable comprobantes = cliente.BuscarComprobanteCompraFecha(fechaCompra.ToString("yyyy'-'MM'-'dd"));
                        dgvComprobantes.DataSource = comprobantes;
                    }
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Seleccione un criterio de búsqueda", "Aviso", MessageBoxButtons.OK);
                }
                
            }
            catch (Exception)
            {
                DialogResult dialogResult = MessageBox.Show("Ha ocurrido un error de conexión", "Aviso", MessageBoxButtons.OK);
            }

        }

        private void cbxBusquedaB_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbxBusquedaB.SelectedItem.Equals("Ruc Proveedor"))
            {
                txtBusquedaB.Enabled = true;
                dtpFechaCompra.Enabled = false;

            }
            else if (cbxBusquedaB.SelectedItem.Equals("Fecha de Compra"))
            {
                txtBusquedaB.Enabled = false;
                dtpFechaCompra.Enabled = true;
            }
        }

        private void LoadBuscar()
        {
            txtBusquedaB.Enabled = false;
            dtpFechaCompra.Enabled = false;

            cbxBusquedaB.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void txtBusquedaB_KeyPress(object sender, KeyPressEventArgs e)
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

        #region Anular

        private void btnBuscarD_Click(object sender, EventArgs e)
        {
            try
            {
                LavadoraService.ComprobanteCompra comprobanteCompra = cliente.BuscarInfoComprobanteCompra(txtBusquedaD.Text);
                if (comprobanteCompra.ID == 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Este comprobante no existe", "Aviso", MessageBoxButtons.OK);
                }
                else
                {
                    if (comprobanteCompra.Estado == 0)
                    {
                        txtNFacturaD.Text = comprobanteCompra.NumDocumento;
                        txtNombreD.Text = comprobanteCompra.Nombre;
                        txtApellidoD.Text = comprobanteCompra.Apellido;
                        txtTelefonoD.Text = comprobanteCompra.Telefono;
                        txtCorreoD.Text = comprobanteCompra.Correo;
                        txtRucD.Text = comprobanteCompra.Ruc;
                        txtEmpresaD.Text = comprobanteCompra.Empresa;
                        txtDireccionD.Text = comprobanteCompra.Direccion;
                        txtSubTotalD.Text = comprobanteCompra.Subtotal.ToString();
                        txtIVAD.Text = comprobanteCompra.Iva.ToString();
                        txtTotalD.Text = comprobanteCompra.Total.ToString();

                        productos = cliente.BuscarProductosComprobanteCompra(txtBusquedaD.Text);
                        dgvProductosD.DataSource = productos;

                        txtBusquedaD.Enabled = false;
                    }
                    else if (comprobanteCompra.Estado == 1)
                    {
                        DialogResult dialogResult = MessageBox.Show("Este comprobante ya ha sido anulado", "Aviso", MessageBoxButtons.OK);
                    }
                }



            }
            catch (Exception)
            {
                DialogResult dialogResult = MessageBox.Show("Ha ocurrido un error de conexión", "Aviso", MessageBoxButtons.OK);
            }
        }

        private void btnDAnular_Click(object sender, EventArgs e)
        {
            idComprobante = 0;

            try
            {

                idComprobante = cliente.IngresarComprobanteCompra(txtRucD.Text, txtNFacturaD.Text, -Convert.ToDouble(txtSubTotalD.Text), -Convert.ToDouble(txtIVAD.Text), -Convert.ToDouble(txtTotalD.Text), 1, DateTime.Now);



                foreach (DataGridViewRow row in dgvProductosD.Rows)
                {
                    if ((row.Cells["dataGridViewTextBoxColumn3"].Value.ToString()).Contains("A-"))
                    {
                        cliente.IngresarAceiteComprobanteCompra(Convert.ToInt32(row.Cells[1].Value.ToString()), idComprobante, -Convert.ToInt32(row.Cells[4].Value.ToString()));
                        if (cliente.ValidarMinAceite(Convert.ToInt32(row.Cells[1].Value.ToString())))
                        {
                            MessageBox.Show("Producto: " + row.Cells[2].Value.ToString() + " está próximo a agotarse", "Aviso", MessageBoxButtons.OK);
                        }
                    }
                    if ((row.Cells["dataGridViewTextBoxColumn3"].Value.ToString()).Contains("F-"))
                    {
                        cliente.IngresarFiltroComprobanteCompra(Convert.ToInt32(row.Cells[1].Value.ToString()), idComprobante, -Convert.ToInt32(row.Cells[4].Value.ToString()));
                        if (cliente.ValidarMinFiltro(Convert.ToInt32(row.Cells[1].Value.ToString())))
                        {
                            MessageBox.Show("Producto: " + row.Cells[2].Value.ToString() + " está próximo a agotarse", "Aviso", MessageBoxButtons.OK);
                        }
                    }
                    if ((row.Cells["dataGridViewTextBoxColumn3"].Value.ToString()).Contains("P-"))
                    {
                        cliente.IngresarProductoComprobanteCompra(Convert.ToInt32(row.Cells[1].Value.ToString()), idComprobante, -Convert.ToInt32(row.Cells[4].Value.ToString()));
                        if (cliente.ValidarMinProducto(Convert.ToInt32(row.Cells[1].Value.ToString())))
                        {
                            MessageBox.Show("Producto: " + row.Cells[2].Value.ToString() + " está próximo a agotarse", "Aviso", MessageBoxButtons.OK);
                        }
                    }
                }

                cliente.ActualizarEstadoComprobanteCompra(Convert.ToInt32(txtBusquedaD.Text));

                //Parte para imprimir comprobante
                prtdComprobante = new PrintDocument();
                PrinterSettings ps = new PrinterSettings();
                prtdComprobante.PrinterSettings = ps;
                prtdComprobante.PrintPage += ImprimirAnulacion;
                prtdComprobante.Print();


                DialogResult dialogResult = MessageBox.Show("Comprobante anulado con éxito", "Aviso", MessageBoxButtons.OK);

                LimpiarCamposD();

            }
            catch (FormatException)
            {
                DialogResult dialogResult = MessageBox.Show("Ingrese un ID de comprobante válido", "Aviso", MessageBoxButtons.OK);
            }

            catch (Exception)
            {
                DialogResult dialogResult = MessageBox.Show("Ha ocurrido un error de conexión", "Aviso", MessageBoxButtons.OK);
            }
        }

        private void btnDCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCamposD();
        }

        private void LoadAnular()
        {
            DeshablitarCampos();
        }

        private void DeshablitarCampos()
        {

            txtNFacturaD.Enabled = false;
            txtNombreD.Enabled = false;
            txtApellidoD.Enabled = false;
            txtTelefonoD.Enabled = false;
            txtCorreoD.Enabled = false;
            txtRucD.Enabled = false;
            txtEmpresaD.Enabled = false;
            txtDireccionD.Enabled = false;
            txtSubTotalD.Enabled = false;
            txtIVAD.Enabled = false;
            txtTotalD.Enabled = false;
        }

        public void LimpiarCamposD()
        {
            txtNFacturaD.Clear();
            txtNombreD.Clear();
            txtApellidoD.Clear();
            txtRucD.Clear();
            txtEmpresaD.Clear();
            txtDireccionD.Clear();
            txtTelefonoD.Clear();
            txtCorreoD.Clear();
            txtSubTotalD.Clear();
            txtIVAD.Clear();
            txtTotalD.Clear();
            txtBusquedaD.Clear();
            txtBusquedaD.Enabled = true;


            productos.Rows.Clear();
            ActualizarDgvD();
        }

        public void ActualizarDgvD()
        {
            dgvProductosD.DataSource = productos;
        }

        private void ImprimirAnulacion(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 14);
            int ancho = 450;
            int y = 20;

            StringFormat formatDerecha = new StringFormat();
            formatDerecha.Alignment = StringAlignment.Far;
            formatDerecha.LineAlignment = StringAlignment.Far;

            e.Graphics.DrawString("- - - - - - - - A N U L A C I Ó N - - - - - - - - -", font, Brushes.Black, new RectangleF(0, y += 0, ancho, 20));

            e.Graphics.DrawString("Lavadora y Lubricadora Negritos - Lubrigaman", font, Brushes.Black, new RectangleF(0, y += 60, ancho, 20));
            e.Graphics.DrawString("RUC: 0705760924001", font, Brushes.Black, new RectangleF(0, y += 30, ancho, 20));
            e.Graphics.DrawString("Av. Mariscal Sucre y Pedro Concha", font, Brushes.Black, new RectangleF(0, y += 30, ancho, 20));
            e.Graphics.DrawString("QUITO - ECUADOR", font, Brushes.Black, new RectangleF(0, y += 30, ancho, 20));
            e.Graphics.DrawString("TELEFONO: 0979098895", font, Brushes.Black, new RectangleF(0, y += 30, ancho, 20));

            e.Graphics.DrawString("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -", font, Brushes.Black, new RectangleF(0, y += 60, ancho, 20));

            e.Graphics.DrawString("PROVEEDOR: " + txtNombreD.Text + " " + txtApellidoD.Text, font, Brushes.Black, new RectangleF(0, y += 30, ancho, 20));
            e.Graphics.DrawString("RUC: " + txtRucD.Text, font, Brushes.Black, new RectangleF(0, y += 30, ancho, 20));
            e.Graphics.DrawString("EMPRESA: " + txtEmpresaD.Text, font, Brushes.Black, new RectangleF(0, y += 30, ancho, 20));
            e.Graphics.DrawString("DIRECCIÓN: " + txtDireccionD.Text, font, Brushes.Black, new RectangleF(0, y += 30, ancho, 20));
            e.Graphics.DrawString("TELÉFONO: " + txtTelefonoD.Text, font, Brushes.Black, new RectangleF(0, y += 30, ancho, 20));
            e.Graphics.DrawString("E-MAIL: " + txtCorreoD.Text, font, Brushes.Black, new RectangleF(0, y += 30, ancho, 20));

            e.Graphics.DrawString("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));

            e.Graphics.DrawString("ANULACIÓN DE COMPROBANTE DE COMPRA: ", font, Brushes.Black, new RectangleF(0, y += 30, ancho, 20));
            e.Graphics.DrawString("No.: " + txtNFacturaD.Text, font, Brushes.Black, new RectangleF(0, y += 30, ancho, 20));
            e.Graphics.DrawString("FECHA DE ANULACIÓN: " + DateTime.Now.ToString(), font, Brushes.Black, new RectangleF(0, y += 30, ancho, 20));

            e.Graphics.DrawString("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));

            e.Graphics.DrawString("DESCRIPCIÓN          CANT. ", font, Brushes.Black, new RectangleF(0, y += 30, ancho, 20));

            e.Graphics.DrawString("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));


            foreach (DataRow row in productos.Rows)
            {
                e.Graphics.DrawString(row["Descripcion"].ToString(), font, Brushes.Black, new RectangleF(0, y += 30, 150, 20));
                e.Graphics.DrawString(row["Cantidad"].ToString(), font, Brushes.Black, new RectangleF(190, y += 0, 50, 20), formatDerecha);
            }

            e.Graphics.DrawString("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));

            e.Graphics.DrawString("SUBTOTAL: ", font, Brushes.Black, new RectangleF(190, y += 30, ancho, 20));
            e.Graphics.DrawString(txtSubTotalD.Text, font, Brushes.Black, new RectangleF(-30, y += 0, ancho, 20), formatDerecha);
            e.Graphics.DrawString("IVA 12%: ", font, Brushes.Black, new RectangleF(190, y += 30, ancho, 20));
            e.Graphics.DrawString(txtIVAD.Text, font, Brushes.Black, new RectangleF(-30, y += 0, ancho, 20), formatDerecha);
            e.Graphics.DrawString("TOTAL: ", font, Brushes.Black, new RectangleF(190, y += 30, ancho, 20));
            e.Graphics.DrawString(txtTotalD.Text, font, Brushes.Black, new RectangleF(-30, y += 0, ancho, 20), formatDerecha);

        }



        #endregion

        private void txtBusquedaD_KeyPress(object sender, KeyPressEventArgs e)
        {
              //defenimos el rango de codigos ASCII que admite solo numeros a la entrada
                if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 44 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
                {
                    MessageBox.Show("Solo está permitido números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Handled = true;
                    return;
                }
            
        }

        private void txtTelefonoD_KeyPress(object sender, KeyPressEventArgs e)
        {
            //defenimos el rango de codigos ASCII que admite solo numeros a la entrada
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 44 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo está permitido números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }
    }
}
