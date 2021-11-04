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
    public partial class frmEditarAceite : Form
    {
        LavadoraService.LavadoraServiceClient cliente;
        private static string busqueda;
        private static string valor;
        public frmEditarAceite()
        {
            InitializeComponent();
        }

        private void frmEditarAceite_Load(object sender, EventArgs e)
        {
            cliente = new LavadoraService.LavadoraServiceClient();
            cbxCriBusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxApi.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxPresentacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxSae.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxTipoAceite.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxTipoCombustible.DropDownStyle = ComboBoxStyle.DropDownList;
            llenarCbxs();
            DeshabilitarCampos();
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

        public void DeshabilitarCampos()
        {
            txtPreCIva.Enabled = false;
            txtMargenMayor.Enabled = false;
            txtMargenMenor.Enabled = false;
            txtPreVMayor.Enabled = false;
        }

        public void llenarCbxs()
        {
            cbxPresentacion.Items.AddRange(cliente.ObtenerPresentacion());
            cbxSae.Items.AddRange(cliente.ObtenerSAE());
            cbxTipoCombustible.Items.AddRange(cliente.ObtenerTipoCombustible());
            cbxTipoAceite.Items.AddRange(cliente.ObtenerTipoAceite());
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            cliente.EditarAceite(Convert.ToInt32(dgvAceites.SelectedCells[0].Value), txtMarca.Text, txtDescripcion.Text, txtCodigoB.Text, Convert.ToInt32(txtCantidad.Text),
                Convert.ToInt32(txtCantidadMin.Text), cbxPresentacion.SelectedItem.ToString(), cbxSae.SelectedItem.ToString(),
                cbxTipoCombustible.SelectedItem.ToString(), cbxApi.SelectedItem.ToString(), cbxTipoAceite.SelectedItem.ToString(),
                Convert.ToDouble(txtPreSIva.Text), Convert.ToDouble(txtPreCIva.Text), Convert.ToDouble(txtPreVMayor.Text),
                Convert.ToDouble(txtPrecioVMenor.Text), Convert.ToDouble(txtMargenMayor.Text), Convert.ToDouble(txtMargenMenor.Text));
            
            DialogResult dialogResult = MessageBox.Show("Aceite actualizado con éxito", "Aviso", MessageBoxButtons.OK);
            ActualizarDgvAceite();
            LimpiarCampos();
            llenarCbxs();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cbxCriBusqueda.SelectedItem.ToString().Equals("Codigo de Barras"))
            {
                DataTable aceites = cliente.BuscarAceiteCodigo(txtBusqueda.Text);
                dgvAceites.DataSource = aceites;

            }
            else if (cbxCriBusqueda.SelectedItem.ToString().Equals("Marca"))
            {
                DataTable aceites = cliente.BuscarAceiteMarca(txtBusqueda.Text);
                dgvAceites.DataSource = aceites;

            }
            else if (cbxCriBusqueda.SelectedItem.ToString().Equals("Mostrar Todos"))
            {
                DataTable aceites = cliente.ObtenerAceite();
                dgvAceites.DataSource = aceites;
            }
            busqueda = cbxCriBusqueda.SelectedItem.ToString();
            valor = txtBusqueda.Text;
        }

        public void ActualizarDgvAceite()
        {
            if (busqueda.Equals("Codigo de Barras"))
            {
                DataTable aceites = cliente.BuscarAceiteCodigo(valor);
                dgvAceites.DataSource = aceites;

            }
            else if (busqueda.Equals("Marca"))
            {
                DataTable aceites = cliente.BuscarAceiteMarca(valor);
                dgvAceites.DataSource = aceites;

            }
            else if (busqueda.Equals("Mostrar Todos"))
            {
                DataTable aceites = cliente.ObtenerAceite();
                dgvAceites.DataSource = aceites;
            }
        }

        private void dgvAceites_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMarca.Text = dgvAceites.SelectedCells[1].Value.ToString();
            txtDescripcion.Text = dgvAceites.SelectedCells[2].Value.ToString();
            cbxPresentacion.SelectedItem = dgvAceites.SelectedCells[3].Value.ToString();
            cbxSae.SelectedItem = dgvAceites.SelectedCells[4].Value.ToString();            
            cbxTipoAceite.SelectedItem = dgvAceites.SelectedCells[6].Value.ToString();
            cbxTipoCombustible.SelectedItem = dgvAceites.SelectedCells[7].Value.ToString();
            txtCodigoB.Text = dgvAceites.SelectedCells[8].Value.ToString();            
            txtPreSIva.Text = Math.Round(Convert.ToDouble(dgvAceites.SelectedCells[9].Value.ToString()), 2).ToString();
            txtPreCIva.Text = Math.Round(Convert.ToDouble(dgvAceites.SelectedCells[10].Value.ToString()), 2).ToString();
            txtPreVMayor.Text = Math.Round(Convert.ToDouble(dgvAceites.SelectedCells[11].Value.ToString()), 2).ToString();
            txtPrecioVMenor.Text = Math.Round(Convert.ToDouble(dgvAceites.SelectedCells[12].Value.ToString()), 2).ToString();
            txtMargenMayor.Text = Math.Round(Convert.ToDouble(dgvAceites.SelectedCells[13].Value.ToString()), 2).ToString();
            txtMargenMenor.Text = Math.Round(Convert.ToDouble(dgvAceites.SelectedCells[14].Value.ToString()), 2).ToString();
            txtCantidad.Text = dgvAceites.SelectedCells[15].Value.ToString();
            txtCantidadMin.Text = dgvAceites.SelectedCells[16].Value.ToString();
            txtGananPorMayor.Text = Math.Round((Convert.ToDouble(txtPreVMayor.Text) - Convert.ToDouble(txtPreCIva.Text)), 2).ToString();
            cbxApi.SelectedItem = dgvAceites.SelectedCells[5].Value.ToString();
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
