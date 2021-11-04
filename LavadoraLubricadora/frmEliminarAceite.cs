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
    public partial class frmEliminarAceite : Form
    {
        LavadoraService.LavadoraServiceClient cliente;
        private static string busqueda;
        private static string valor;

        public frmEliminarAceite()
        {
            InitializeComponent();
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            cliente.EliminarAceite(Convert.ToInt32(dgvAceites.SelectedCells[0].Value));
            DialogResult dialogResult = MessageBox.Show("Aceite eliminado con éxito", "Aviso", MessageBoxButtons.OK);
            ActualizarDgvAceite();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Seguro que desea Salir?", "Aviso", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
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

        private void frmEliminarAceite_Load(object sender, EventArgs e)
        {
            cbxCriBusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            cliente = new LavadoraService.LavadoraServiceClient();
        }
    }
}
