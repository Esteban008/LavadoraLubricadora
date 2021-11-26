﻿using System;
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
    public partial class frmBuscarFiltro : Form
    {
        LavadoraService.LavadoraServiceClient cliente;

        public frmBuscarFiltro()
        {
            InitializeComponent();
        }

        private void frmBuscarFiltro_Load(object sender, EventArgs e)
        {
            cliente = new LavadoraService.LavadoraServiceClient();

            cbxCriBusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            txtBusqueda.Visible = false;
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cbxCriBusqueda.SelectedItem.ToString().Equals("Codigo de Barras"))
            {
                DataTable aceites = cliente.BuscarFiltroCodigo(txtBusqueda.Text);
                dgvFiltrosE.DataSource = aceites;

            }
            else if (cbxCriBusqueda.SelectedItem.ToString().Equals("Marca"))
            {
                DataTable aceites = cliente.BuscarFiltroMarca(txtBusqueda.Text);
                dgvFiltrosE.DataSource = aceites;

            }
            else if (cbxCriBusqueda.SelectedItem.ToString().Equals("Mostrar Todos"))
            {
                DataTable aceites = cliente.ObtenerFiltros();
                dgvFiltrosE.DataSource = aceites;
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

        private void cbxCriBusqueda_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbxCriBusqueda.SelectedItem.ToString().Equals("Mostrar Todos"))
            {
                txtBusqueda.Visible = false;
                txtBusqueda.Clear();
            }
            else
            {
                txtBusqueda.Visible = true;
                txtBusqueda.Clear();
            }
        }
    }
}
