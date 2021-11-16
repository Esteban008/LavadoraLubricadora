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
    public partial class frmAdminFiltros : Form
    {
        LavadoraService.LavadoraServiceClient cliente;
        private static string busqueda;
        private static string valor;

        public static List<int> idVehiculos;

        public frmAdminFiltros()
        {
            InitializeComponent();
        }

        private void frmAdminFiltros_Load(object sender, EventArgs e)
        {
            cliente = new LavadoraService.LavadoraServiceClient();
            idVehiculos = new List<int>();
            this.toolTipMsj.SetToolTip(this.rtxtCodigos, "Ingrese un código por linea");

            LoadIngresar();
        }

        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            //Busca en la colecion el formulario
            formulario = pnlContenedor.Controls.OfType<MiForm>().FirstOrDefault();
            //si el formulario instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                pnlContenedor.Controls.Add(formulario);
                pnlContenedor.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }



        #region Tab Ingresar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            List<int> idVehiculos = cliente.DevolverIDsVehiculos().ToList();
            List<string> codigos = recuperarRtxt();

            if (cliente.ValidarFiltro(txtCodigoB.Text))
            {
                MessageBox.Show("\t\tEste Aceite ya existe. \nSi desea actualizar los datos seleccione el boton editar Editar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cliente.IngresarFiltro(cbxTipoFiltro.SelectedItem.ToString(), txtRosca.Text, txtMarca.Text, txtDescripcion.Text, txtCodigoB.Text, Convert.ToInt32(txtCantidad.Text),
                       Convert.ToInt32(txtCantidadMin.Text), Convert.ToDouble(txtPreSIva.Text), Convert.ToDouble(txtPreCIva.Text), Convert.ToDouble(txtPreVMayor.Text),
                       Convert.ToDouble(txtPrecioVMenor.Text), Convert.ToDouble(txtMargenMayor.Text), Convert.ToDouble(txtMargenMenor.Text));

                foreach (var idVehiculo in idVehiculos)
                {
                    cliente.IngresarVehiculoFiltro(txtCodigoB.Text, idVehiculo);
                }

                foreach (var codigo in codigos)
                {
                    cliente.IngresarCodigoFiltro(txtCodigoB.Text, codigo);
                }

                DialogResult dialogResult = MessageBox.Show("Aceite ingresado con éxito", "Aviso", MessageBoxButtons.OK);

                LimpiarCampos();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnAgregarVehiculos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmAgregarVehiculo>();
        }

        private void LoadIngresar()
        {
            cbxTipoFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxTipoFiltro.Items.AddRange(cliente.ObtenerTipoFiltro());

            DeshabilitarCampos();

        }

        public void DeshabilitarCampos()
        {
            txtPreCIva.Enabled = false;
            txtMargenMayor.Enabled = false;
            txtMargenMenor.Enabled = false;
            txtPreVMayor.Enabled = false;
        }

        public void LimpiarCampos()
        {
            txtMarca.Clear();
            txtDescripcion.Clear();
            txtCodigoB.Clear();
            txtCantidad.Clear();
            txtCantidadMin.Clear();
            txtRosca.Clear();
            rtxtCodigos.Clear();
            cbxTipoFiltro.SelectedIndex = -1;
            txtPreSIva.Clear();
            txtPreCIva.Clear();
            txtGananPorMayor.Clear();
            txtPrecioVMenor.Clear();
            txtPreVMayor.Clear();
            txtMargenMayor.Clear();
            txtMargenMenor.Clear();

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
            double margenxMayor = Math.Round(((porcenGanancia / 100) * precioCompraConIva), 2);

            //Calculo del total
            double precioVentaMayor = Math.Round((precioCompraConIva + margenxMayor), 2);

            //Actualizacion de los campos correspondientes

            txtPreVMayor.Text = precioVentaMayor.ToString();
            txtMargenMayor.Text = margenxMayor.ToString();
        }


        public List<string> recuperarRtxt()
        {
            string[] list = rtxtCodigos.Lines;
            List<string> codigos = new List<string>(list);

            return codigos;
        }


        #endregion

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Seguro que desea Salir?", "Aviso", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
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

        private void txtPrecioVMenor_KeyUp(object sender, KeyEventArgs e)
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
        }

    }
}
