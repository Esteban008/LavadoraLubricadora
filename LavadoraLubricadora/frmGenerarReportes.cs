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
    public partial class frmGenerarReportes : Form
    {
        LavadoraService.LavadoraServiceClient cliente;
        public frmGenerarReportes()
        {
            InitializeComponent();
        }

        private void frmGenerarReportes_Load(object sender, EventArgs e)
        {
            cliente = new LavadoraService.LavadoraServiceClient();
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = dtpFechaInicio.Value;
            DateTime fechaFin = dtpFechaFin.Value;


            ComprobanteVentaBindingSource.DataSource = cliente.BuscarComprobanteRangoFecha(fechaInicio.ToString("yyyy'-'MM'-'dd"), fechaFin.ToString("yyyy'-'MM'-'dd"));
            this.rpvVentas.RefreshReport();
        }

        private void btnHoy_Click(object sender, EventArgs e)
        {
            var fechaInicio = DateTime.Now;
            var fechaFin = DateTime.Now;
            ComprobanteVentaBindingSource.DataSource = cliente.BuscarComprobanteRangoFecha(fechaInicio.ToString("yyyy'-'MM'-'dd"), fechaFin.ToString("yyyy'-'MM'-'dd"));
            this.rpvVentas.RefreshReport();
        }

        private void btnSemana_Click(object sender, EventArgs e)
        {
            var fechaInicio = DateTime.Now.AddDays(-7);
            var fechaFin = DateTime.Now;
            ComprobanteVentaBindingSource.DataSource = cliente.BuscarComprobanteRangoFecha(fechaInicio.ToString("yyyy'-'MM'-'dd"), fechaFin.ToString("yyyy'-'MM'-'dd"));
            this.rpvVentas.RefreshReport();
        }

        private void btnMes_Click(object sender, EventArgs e)
        {
            var fechaInicio = new DateTime(DateTime.Now.Year, DateTime.Now.Month,1);
            var fechaFin = DateTime.Now;
            ComprobanteVentaBindingSource.DataSource = cliente.BuscarComprobanteRangoFecha(fechaInicio.ToString("yyyy'-'MM'-'dd"), fechaFin.ToString("yyyy'-'MM'-'dd"));
            this.rpvVentas.RefreshReport();
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