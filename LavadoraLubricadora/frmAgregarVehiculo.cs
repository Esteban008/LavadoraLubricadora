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
    public partial class frmAgregarVehiculo : Form
    {
        LavadoraService.LavadoraServiceClient cliente;
        DataTable dtLista;
        public frmAgregarVehiculo()
        {
            InitializeComponent();
        }

        private void frmAgregarVehiculo_Load(object sender, EventArgs e)
        {
            cliente = new LavadoraService.LavadoraServiceClient();
            cbxCriBusquedaE.DropDownStyle = ComboBoxStyle.DropDownList;
            txtBusquedaE.Visible = false;

            dtLista = new DataTable();
            dtLista.Clear();
            dtLista.Columns.Add("ID");
            dtLista.Columns.Add("Marca");
            dtLista.Columns.Add("Modelo");
            dtLista.Columns.Add("Tipo_Motor");
            dtLista.Columns.Add("Anio");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Seguro que desea Salir?", "Aviso", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Seguro que desea Salir?", "Aviso", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void cbxCriBusquedaE_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbxCriBusquedaE.SelectedItem.ToString().Equals("Mostrar Todos"))
            {
                txtBusquedaE.Visible = false;
                txtBusquedaE.Clear();
            }
            else
            {
                txtBusquedaE.Visible = true;
                txtBusquedaE.Clear();
            }
        }

        private void btnBuscarE_Click(object sender, EventArgs e)
        {
            if (cbxCriBusquedaE.SelectedItem.ToString().Equals("Marca"))
            {
                DataTable vehiculos = cliente.BuscarVehiculoMarca(txtBusquedaE.Text);
                dgvVehiculosE.DataSource = vehiculos;

            }
            else if (cbxCriBusquedaE.SelectedItem.ToString().Equals("Modelo"))
            {
                DataTable vehiculos = cliente.BuscarVehiculoModelo(txtBusquedaE.Text);
                dgvVehiculosE.DataSource = vehiculos;
            }
            else if (cbxCriBusquedaE.SelectedItem.ToString().Equals("Mostrar Todos"))
            {
                DataTable vehiculos = cliente.ObtenerVehiculos();
                dgvVehiculosE.DataSource = vehiculos;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            object[] v =
            {
                dgvVehiculosE.SelectedCells[0].Value.ToString(),
                dgvVehiculosE.SelectedCells[1].Value.ToString(),
                dgvVehiculosE.SelectedCells[2].Value.ToString(),
                dgvVehiculosE.SelectedCells[3].Value.ToString(),
                dgvVehiculosE.SelectedCells[4].Value.ToString()
            };

            dtLista.Rows.Add(v);

            
            DataView vista = new DataView(dtLista);
            DataTable dtListaVehiculosSD = vista.ToTable(true, "ID", "Marca", "Modelo", "Tipo_Motor", "Anio");
            dgvVehiculos2.DataSource = dtListaVehiculosSD;
            
           // dgvVehiculos2.DataSource = dtLista;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            dtLista.AcceptChanges();
            foreach (DataRow row in dtLista.Rows)
            {
                if (row["ID"].ToString() == dgvVehiculos2.SelectedCells[0].Value.ToString())
                row.Delete();
            }
            dtLista.AcceptChanges();

            dgvVehiculos2.DataSource = dtLista;
        }

        private void btnGuardarVehiculos_Click(object sender, EventArgs e)
        {
            List<int> idVehiculos = new List<int>();

            foreach (DataGridViewRow row in dgvVehiculos2.Rows)
            {
                idVehiculos.Add(Convert.ToInt32(dgvVehiculos2.CurrentCell.Value.ToString()));
            }

            
        }


        


    }
}
