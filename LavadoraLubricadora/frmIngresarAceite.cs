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
    public partial class frmIngresarAceite : Form
    {
        LavadoraService.LavadoraServiceClient cliente;
        public frmIngresarAceite()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cliente.ValidarAceite(txtCodigoB.Text))
            {
                MessageBox.Show("\t\tEste Aceite ya existe. \nSi desea actualizar los datos seleccione el boton editar Editar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cliente.IngresarAceite(txtMarca.Text, txtDescripcion.Text, txtCodigoB.Text, Convert.ToInt32(txtCantidad.Text),
                Convert.ToInt32(txtCantidadMin.Text), cbxPresentacion.SelectedItem.ToString(), cbxSae.SelectedItem.ToString(),
                cbxTipoCombustible.SelectedItem.ToString(), cbxApi.SelectedItem.ToString(), cbxTipoAceite.SelectedItem.ToString(),
                Convert.ToDouble(txtPreSIva.Text), Convert.ToDouble(txtPreCIva.Text), Convert.ToDouble(txtPreVMayor.Text),
                Convert.ToDouble(txtPrecioVMenor.Text), Convert.ToDouble(txtMargenMayor.Text), Convert.ToDouble(txtMargenMenor.Text));

                LimpiarCampos();
            }
            
        }

        private void frmIngresarAceite_Load(object sender, EventArgs e)
        {
            cliente = new LavadoraService.LavadoraServiceClient();
            cbxApi.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxPresentacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxSae.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxTipoAceite.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxTipoCombustible.DropDownStyle = ComboBoxStyle.DropDownList;
            llenarCbxs();
            DeshabilitarCampos();
            
        }

        public void llenarCbxs()
        {
            cbxPresentacion.Items.AddRange(cliente.ObtenerPresentacion());
            cbxSae.Items.AddRange(cliente.ObtenerSAE());
            cbxTipoCombustible.Items.AddRange(cliente.ObtenerTipoCombustible());
            cbxTipoAceite.Items.AddRange(cliente.ObtenerTipoAceite());
        }

        public void DeshabilitarCampos()
        {
            txtPreCIva.Enabled = false;
            txtMargenMayor.Enabled = false;
            txtMargenMenor.Enabled = false;
            txtPreVMayor.Enabled = false;
        }

        private void cbxTipoCombustible_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbxTipoCombustible.SelectedItem.ToString().Equals("Gasolina"))
            {
                cbxApi.Items.Clear();
                cbxApi.Items.AddRange(cliente.ObtenerApi(1));
            }
            else if (cbxTipoCombustible.SelectedItem.ToString().Equals("Diesel"))
            {
                cbxApi.Items.Clear();
                cbxApi.Items.AddRange(cliente.ObtenerApi(2));
            }
            else if (cbxTipoCombustible.SelectedItem.ToString().Equals("N/A"))
            {
                cbxApi.Items.Clear();
                cbxApi.Items.AddRange(cliente.ObtenerApi(3));
            }


        }

        private void txtPreSIva_KeyUp(object sender, KeyEventArgs e)
        {
            double baseImpo = 0;

            //Conversion del valor en txtBaseImponible
            Double.TryParse(txtPreSIva.Text, out baseImpo);

            //Calculo del IVA
            double iva = baseImpo * 0.12;

            //Calculo del total
            double total = Math.Round((baseImpo + iva), 2);

            //Actualizacion de los campos correspondientes
            
            txtPreCIva.Text = total.ToString();

            Recalcular();

            
        }

        private void txtPreSIva_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            //defenimos el rango de codigos ASCII que admite solo numeros a la entrada
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 45 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo está permitido números y la coma", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }

        private void txtGananPorMayor_KeyPress(object sender, KeyPressEventArgs e)
        {
            //defenimos el rango de codigos ASCII que admite solo numeros a la entrada
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 45 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo está permitido números y la coma", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }

        private void txtGananPorMayor_KeyUp(object sender, KeyEventArgs e)
        {
            double porcenGanancia = 0;
            double precioCompraConIva = 0;


            //Conversion del valor en txtBaseImponible
            Double.TryParse(txtGananPorMayor.Text, out porcenGanancia);
            Double.TryParse(txtPreCIva.Text, out precioCompraConIva);

            //Calculo del IVA
            double margenxMayor = Math.Round(((porcenGanancia / 100) * precioCompraConIva),2);

            //Calculo del total
            double precioVentaMayor = Math.Round((precioCompraConIva + margenxMayor), 2);

            //Actualizacion de los campos correspondientes

            txtPreVMayor.Text = precioVentaMayor.ToString();
            txtMargenMayor.Text = margenxMayor.ToString();
        }

        private void txtPrecioVMenor_KeyUp(object sender, KeyEventArgs e)
        {
            double precioVMenor = 0;
            double precioCompraConIva = 0;

            //Conversion del valor en txtBaseImponible
            Double.TryParse(txtPrecioVMenor.Text, out precioVMenor);
            Double.TryParse(txtPreCIva.Text, out precioCompraConIva);

            //Calculo del IVA
            double magenxmenor = Math.Round((precioVMenor - precioCompraConIva),2);

            

            //Actualizacion de los campos correspondientes

            txtMargenMenor.Text = magenxmenor.ToString();
        }

        private void txtPrecioVMenor_KeyPress(object sender, KeyPressEventArgs e)
        {
            //defenimos el rango de codigos ASCII que admite solo numeros a la entrada
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 45 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo está permitido números y la coma", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }


        public void Recalcular()
        {
            double precioVMenor = 0;
            double precioCompraConIva = 0;

            //Conversion del valor en txtBaseImponible
            Double.TryParse(txtPrecioVMenor.Text, out precioVMenor);
            Double.TryParse(txtPreCIva.Text, out precioCompraConIva);

            //Calculo del IVA
            double magenxmenor = Math.Round((precioVMenor - precioCompraConIva), 2);



            //Actualizacion de los campos correspondientes

            txtMargenMenor.Text = magenxmenor.ToString();


            double porcenGanancia = 0;
            


            //Conversion del valor en txtBaseImponible
            Double.TryParse(txtGananPorMayor.Text, out porcenGanancia);
            

            //Calculo del IVA
            double margenxMayor = Math.Round(((porcenGanancia / 100) * precioCompraConIva), 2);

            //Calculo del total
            double precioVentaMayor = Math.Round((precioCompraConIva + margenxMayor), 2);

            //Actualizacion de los campos correspondientes

            txtPreVMayor.Text = precioVentaMayor.ToString();
            txtMargenMayor.Text = margenxMayor.ToString();
        }

        
        public void LimpiarCampos()
        {
            txtMarca.Clear();
            txtDescripcion.Clear();
            txtCodigoB.Clear();
            txtCantidad.Clear();
            txtCantidadMin.Clear();
            cbxPresentacion.Items.Clear();
            cbxSae.Items.Clear();
            cbxTipoCombustible.Items.Clear();
            cbxApi.Items.Clear();
            cbxTipoAceite.Items.Clear();
            txtPreSIva.Clear();
            txtPreCIva.Clear();
            txtGananPorMayor.Clear();
            txtPrecioVMenor.Clear();
            txtPreVMayor.Clear();
            txtMargenMayor.Clear();
            txtMargenMenor.Clear();
        }
    }
}
