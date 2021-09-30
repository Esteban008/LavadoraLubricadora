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
    public partial class frmBusquedaProductos : Form
    {
        LavadoraService.LavadoraServiceClient cliente;
        public frmBusquedaProductos()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Seguro que desea Salir?", "Aviso", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frmBusquedaProductos_Load(object sender, EventArgs e)
        {
            cbxTipoProducto.Items.AddRange(new string[] { "Aceite", "Filtro", "Otro" });
            cbxTipoProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            //cbxTipoProducto.SelectedIndex = 0;
            cbxViscocidad.Visible = false;
            txtBusqueda.Visible = false;
            lblCriterioBusqueda.Visible = false;

            cliente = new LavadoraService.LavadoraServiceClient();
        }

        private void cbxTipoProducto_SelectedValueChanged(object sender, EventArgs e)
        {
            //Si el usuario selecciona
            if (cbxTipoProducto.SelectedItem.Equals("Aceite"))
            {
                txtBusqueda.Visible = false;
                lblCriterioBusqueda.Visible = true;
                lblCriterioBusqueda.Text = "Seleccione Viscosidad (SAE):";
                cbxViscocidad.Visible = true;
                cbxViscocidad.DropDownStyle = ComboBoxStyle.DropDownList;
                //cbxViscocidad.SelectedIndex = 0;            
                //Necesitamos una clase que llame lista de aceites para importar aca
                LavadoraService.Aceite aceite = new LavadoraService.Aceite();

                LavadoraService.ListaAceite aceites = new LavadoraService.ListaAceite();
                aceites = cliente.GetAceite();

                for (int i = 0; i < aceites.Aceites.Length; i++)
                {
                    Console.WriteLine(aceites.Aceites.);
                }
                           
            }
            //Si el usuario selecciona
            if (cbxTipoProducto.SelectedItem.Equals("Filtro"))
            {
                cbxViscocidad.Visible = false;
                lblCriterioBusqueda.Visible = true;
                lblCriterioBusqueda.Text = "Ingrese Codigo:";
                txtBusqueda.Visible = true;
            }
            
            if (cbxTipoProducto.SelectedItem.Equals("Otro"))
            {
                cbxViscocidad.Visible = false;
                lblCriterioBusqueda.Visible = true;
                lblCriterioBusqueda.Text = "Ingrese el Nombre:";
                txtBusqueda.Visible = true;
            }
        }
    }
}
