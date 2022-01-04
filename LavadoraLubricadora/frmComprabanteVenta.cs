﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace LavadoraLubricadora
{
    public partial class frmComprabanteVenta : Form
    {

        LavadoraService.LavadoraServiceClient cliente;
        private static string busqueda;
        private static string valor;
        

        private static bool estadoIngresar = false;
        private static DataTable dtProductos;
        private static DataTable productos;

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
                        txtCedula.Text = txtCedulaBuscar.Text;
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
                LavadoraService.ProductoComprobante productoObj;
                if (chkPrecio.Checked == true)
                {
                    productoObj = cliente.BuscarProductosCBarrasMayor(txtCodigoBarras.Text);
                }
                else
                {
                    productoObj = cliente.BuscarProductosCBarrasMenor(txtCodigoBarras.Text);
                }
                

                if (productoObj.Id != 0)
                {
                    if (txtCantidad.Text != String.Empty && productoObj.CantidadActual >= Convert.ToInt32(txtCantidad.Text))
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
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("No se dispone esa cantidad de productos", "Aviso", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Producto no Encontrado", "Aviso", MessageBoxButtons.OK);
                }

            }
            catch (Exception es)
            {
                DialogResult dialogResult = MessageBox.Show("Ha ocurrido un error de connección "+es, "Aviso", MessageBoxButtons.OK);
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
            catch (Exception)
            {
                DialogResult dialogResult = MessageBox.Show("Ha ocurrido un error de connección", "Aviso", MessageBoxButtons.OK);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            int idComprobante = 0;


            try
            {
                if (cbxTipoPago.SelectedIndex >= 0)
                {
                    if (estadoIngresar)
                    {
                        cliente.IngresarCliente(txtNombre.Text, txtApellido.Text, txtTelefono.Text, txtCorreo.Text, txtCedula.Text, txtDireccion.Text);

                        idComprobante = cliente.IngresarComprobanteVenta(txtCedulaBuscar.Text, txtNFactura.Text, Convert.ToDouble(txtSubtotal.Text), Convert.ToDouble(txtIva.Text), Convert.ToDouble(txtTotal.Text), (cbxTipoPago.SelectedIndex +1), DateTime.Now);

                        foreach (DataGridViewRow row in dgvProductosI.Rows)
                        {
                            if ((row.Cells["dataGridViewTextBoxColumn26"].Value.ToString()).Contains("A-"))
                            {
                                cliente.IngresarAceiteComprobanteVenta(Convert.ToInt32(row.Cells[0].Value.ToString()), idComprobante, Convert.ToInt32(row.Cells[3].Value.ToString()));

                            }
                            if ((row.Cells["dataGridViewTextBoxColumn26"].Value.ToString()).Contains("F-"))
                            {
                                cliente.IngresarFiltroComprobanteVenta(Convert.ToInt32(row.Cells[0].Value.ToString()), idComprobante, Convert.ToInt32(row.Cells[3].Value.ToString()));
                            }
                            if ((row.Cells["dataGridViewTextBoxColumn26"].Value.ToString()).Contains("P-"))
                            {
                                cliente.IngresarProductoComprobanteVenta(Convert.ToInt32(row.Cells[0].Value.ToString()), idComprobante, Convert.ToInt32(row.Cells[3].Value.ToString()));
                            }
                        }
                    }
                    else
                    {
                        idComprobante = cliente.IngresarComprobanteVenta(txtCedulaBuscar.Text, txtNFactura.Text, Convert.ToDouble(txtSubtotal.Text), Convert.ToDouble(txtIva.Text), Convert.ToDouble(txtTotal.Text), (cbxTipoPago.SelectedIndex + 1), DateTime.Now);

                        foreach (DataGridViewRow row in dgvProductosI.Rows)
                        {
                            if ((row.Cells["dataGridViewTextBoxColumn26"].Value.ToString()).Contains("A-"))
                            {
                                cliente.IngresarAceiteComprobanteVenta(Convert.ToInt32(row.Cells[0].Value.ToString()), idComprobante, Convert.ToInt32(row.Cells[3].Value.ToString()));

                            }
                            if ((row.Cells["dataGridViewTextBoxColumn26"].Value.ToString()).Contains("F-"))
                            {
                                cliente.IngresarFiltroComprobanteVenta(Convert.ToInt32(row.Cells[0].Value.ToString()), idComprobante, Convert.ToInt32(row.Cells[3].Value.ToString()));
                            }
                            if ((row.Cells["dataGridViewTextBoxColumn26"].Value.ToString()).Contains("P-"))
                            {
                                cliente.IngresarProductoComprobanteVenta(Convert.ToInt32(row.Cells[0].Value.ToString()), idComprobante, Convert.ToInt32(row.Cells[3].Value.ToString()));
                            }
                        }
                    }

                    if (cbxTipoPago.SelectedIndex == 1)
                    {
                        cliente.IngresarCreditoCliente(txtCedula.Text, DateTime.Now, Convert.ToDouble(txtTotal.Text), idComprobante);
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
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Seleccione Tipo de Pago", "Aviso", MessageBoxButtons.OK);
                }    
               
            }
            catch (Exception ex)
            {
                DialogResult dialogResult = MessageBox.Show("Ha ocurrido un error de connección"+ex, "Aviso", MessageBoxButtons.OK);
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
            dtProductos.Columns.Add("precioVenta");
            dtProductos.Columns.Add("precioTotal");

            txtSubtotal.Enabled = false;
            txtIva.Enabled = false;
            txtTotal.Enabled = false;
            
            cbxTipoPago.DropDownStyle = ComboBoxStyle.DropDownList;
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

        public void LimpiarCampos()
        {
            txtNFactura.Clear();
            txtCedulaBuscar.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtCedula.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtCodigoBarras.Clear();
            txtCantidad.Clear();
            txtSubtotal.Clear();
            txtIva.Clear();
            txtDescuento.Clear();
            txtTotal.Clear();

            dtProductos.Rows.Clear();
            ActualizarDgv();
            cbxTipoPago.SelectedIndex = -1;
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

        private void txtCedulaBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            //defenimos el rango de codigos ASCII que admite solo numeros a la entrada
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 44 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo está permitido números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }
        private void Imprimir(object sender,PrintPageEventArgs e)
        {
            Font font = new Font("Arial",14);
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

            e.Graphics.DrawString("CLIENTE: "+txtNombre.Text+ " "+txtApellido.Text, font, Brushes.Black, new RectangleF(0, y += 30, ancho, 20));
            e.Graphics.DrawString("CÉDULA/RUC: "+txtCedula.Text, font, Brushes.Black, new RectangleF(0, y += 30, ancho, 20));
            e.Graphics.DrawString("DIRECCIÓN: "+txtDireccion.Text, font, Brushes.Black, new RectangleF(0, y += 30, ancho, 20));
            e.Graphics.DrawString("TELÉFONO: "+txtTelefono.Text, font, Brushes.Black, new RectangleF(0, y += 30, ancho, 20));
            e.Graphics.DrawString("E-MAIL: "+txtCorreo.Text, font, Brushes.Black, new RectangleF(0, y += 30, ancho, 20));

            e.Graphics.DrawString("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));

            e.Graphics.DrawString("COMPROBANTE DE VENTA: ", font, Brushes.Black, new RectangleF(0, y += 30, ancho, 20));
            e.Graphics.DrawString("No.: " + txtNFactura.Text, font, Brushes.Black, new RectangleF(0, y += 30, ancho, 20));
            e.Graphics.DrawString("FECHA: " + DateTime.Now.ToString(), font, Brushes.Black, new RectangleF(0, y += 30, ancho, 20));
            e.Graphics.DrawString("TIPO PAGO: "+cbxTipoPago.SelectedItem.ToString(), font, Brushes.Black, new RectangleF(0, y += 30, ancho, 20));

            e.Graphics.DrawString("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));

            e.Graphics.DrawString("DESCRIPCIÓN          CANT.   P. VENTA   TOTAL: ", font, Brushes.Black, new RectangleF(0, y += 30, ancho, 20));

            e.Graphics.DrawString("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));


            foreach (DataRow row in dtProductos.Rows)
            {
                e.Graphics.DrawString(row["Descripcion"].ToString(), font, Brushes.Black, new RectangleF(0, y += 30, 150, 20));
                e.Graphics.DrawString(row["Cantidad"].ToString(), font, Brushes.Black, new RectangleF(190, y += 0, 50, 20), formatDerecha);
                e.Graphics.DrawString(row["precioVenta"].ToString(), font, Brushes.Black, new RectangleF(280, y += 0, 50, 20), formatDerecha);
                e.Graphics.DrawString(row["precioTotal"].ToString(), font, Brushes.Black, new RectangleF(380, y += 00, 50, 20), formatDerecha);
            }

            e.Graphics.DrawString("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));

            e.Graphics.DrawString("SUBTOTAL: ", font, Brushes.Black, new RectangleF(190, y += 30, ancho, 20));
            e.Graphics.DrawString(txtSubtotal.Text, font, Brushes.Black, new RectangleF(-30, y += 0, ancho, 20), formatDerecha);
            e.Graphics.DrawString("IVA 12%: ", font, Brushes.Black, new RectangleF(190, y += 30, ancho, 20));
            e.Graphics.DrawString(txtIva.Text, font, Brushes.Black, new RectangleF(-30, y += 0, ancho, 20), formatDerecha);
           
            if (txtDescuento.Text != String.Empty)
            {
                e.Graphics.DrawString("DSCTO: " + txtDescuento.Text + " %", font, Brushes.Black, new RectangleF(190, y += 30, ancho, 20));
                e.Graphics.DrawString(((Convert.ToDouble(txtSubtotal.Text) + Convert.ToDouble(txtIva.Text)) * ((Convert.ToDouble(txtDescuento.Text) / 100))).ToString(), font, Brushes.Black, new RectangleF(-30, y += 0, ancho, 20), formatDerecha);
            }
            else
            {
                e.Graphics.DrawString("DSCTO: 0 %", font, Brushes.Black, new RectangleF(190, y += 30, ancho, 20));
                e.Graphics.DrawString("0", font, Brushes.Black, new RectangleF(-30, y += 0, ancho, 20), formatDerecha);
            }          
            e.Graphics.DrawString("TOTAL: " ,font, Brushes.Black, new RectangleF(190, y += 30, ancho, 20));
            e.Graphics.DrawString(txtTotal.Text, font, Brushes.Black, new RectangleF(-30, y += 0, ancho, 20), formatDerecha);

        }


        #endregion


        private void DeshablitarCampos()
        {

            txtNFacturaD.Enabled = false;
            txtNombreD.Enabled = false;
            txtApellidoD.Enabled = false;
            txtTelefonoD.Enabled = false;
            txtCorreoD.Enabled = false;
            txtCedulaD.Enabled = false;
            txtDireccionD.Enabled = false;
            txtSubTotalD.Enabled = false;
            txtIVAD.Enabled = false;
            txtTotalD.Enabled = false;
            txtTipoPago.Enabled = false;
        }

        private void btnBuscarD_Click(object sender, EventArgs e)
        {
            try
            {
                LavadoraService.ComprobanteVenta comprobanteVenta = cliente.BuscarInfoComprobanteVenta(txtBusquedaD.Text);

                txtNFacturaD.Text = comprobanteVenta.NumDocumento;
                txtNombreD.Text = comprobanteVenta.Nombre;
                txtApellidoD.Text = comprobanteVenta.Apellido;
                txtTelefonoD.Text = comprobanteVenta.Telefono;
                txtCorreoD.Text = comprobanteVenta.Correo;
                txtCedulaD.Text = comprobanteVenta.Cedula;
                txtDireccionD.Text = comprobanteVenta.Direccion;
                txtSubTotalD.Text = comprobanteVenta.Subtotal.ToString();
                txtIVAD.Text = comprobanteVenta.Iva.ToString();
                txtTotalD.Text = comprobanteVenta.Total.ToString();
                txtTipoPago.Text = comprobanteVenta.TipoPago;

                productos = cliente.BuscarProductosComprobanteVenta(txtBusquedaD.Text);
                dgvProductosD.DataSource = productos;
            }
            catch (Exception)
            {
                DialogResult dialogResult = MessageBox.Show("Ha ocurrido un error de connección", "Aviso", MessageBoxButtons.OK);
            }
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

            e.Graphics.DrawString("CLIENTE: " + txtNombreD.Text + " " + txtApellidoD.Text, font, Brushes.Black, new RectangleF(0, y += 30, ancho, 20));
            e.Graphics.DrawString("CÉDULA/RUC: " + txtCedulaD.Text, font, Brushes.Black, new RectangleF(0, y += 30, ancho, 20));
            e.Graphics.DrawString("DIRECCIÓN: " + txtDireccionD.Text, font, Brushes.Black, new RectangleF(0, y += 30, ancho, 20));
            e.Graphics.DrawString("TELÉFONO: " + txtTelefonoD.Text, font, Brushes.Black, new RectangleF(0, y += 30, ancho, 20));
            e.Graphics.DrawString("E-MAIL: " + txtCorreoD.Text, font, Brushes.Black, new RectangleF(0, y += 30, ancho, 20));

            e.Graphics.DrawString("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));

            e.Graphics.DrawString("ANULACIÓN DE COMPROBANTE DE VENTA: ", font, Brushes.Black, new RectangleF(0, y += 30, ancho, 20));
            e.Graphics.DrawString("No.: " + txtNFacturaD.Text, font, Brushes.Black, new RectangleF(0, y += 30, ancho, 20));
            e.Graphics.DrawString("FECHA DE ANULACIÓN: " + DateTime.Now.ToString(), font, Brushes.Black, new RectangleF(0, y += 30, ancho, 20));
            e.Graphics.DrawString("TIPO PAGO: " + txtTipoPago.Text, font, Brushes.Black, new RectangleF(0, y += 30, ancho, 20));

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

        private void btnDAnular_Click(object sender, EventArgs e)
        {
            //Parte para imprimir comprobante
            prtdComprobante = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            prtdComprobante.PrinterSettings = ps;
            prtdComprobante.PrintPage += ImprimirAnulacion;
            prtdComprobante.Print();



            DialogResult dialogResult = MessageBox.Show("Comprobante generado con éxito", "Aviso", MessageBoxButtons.OK);

            LimpiarCamposD();
        }

        public void LimpiarCamposD()
        {
            txtNFacturaD.Clear();
            txtNombreD.Clear();
            txtApellidoD.Clear();
            txtCedulaD.Clear();
            txtDireccionD.Clear();
            txtTelefonoD.Clear();
            txtCorreoD.Clear();
            txtSubTotalD.Clear();
            txtIVAD.Clear();
            txtTotalD.Clear();

            productos.Rows.Clear();
            ActualizarDgvD();
            cbxTipoPago.SelectedIndex = -1;
        }

        public void ActualizarDgvD()
        {
            dgvProductosD.DataSource = productos;
        }
    }
}
