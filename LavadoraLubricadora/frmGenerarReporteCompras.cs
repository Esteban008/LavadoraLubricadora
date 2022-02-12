using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LavadoraLubricadora
{
    public partial class frmGenerarReporteCompras : Form
    {
        LavadoraService.LavadoraServiceClient cliente;
        public frmGenerarReporteCompras()
        {
            InitializeComponent();
        }

        private void frmGenerarReporteCompras_Load(object sender, EventArgs e)
        {

            cliente = new LavadoraService.LavadoraServiceClient();

            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaInicio = dtpFechaInicio.Value;
                DateTime fechaFin = dtpFechaFin.Value;


                ComprobanteCompraBindingSource.DataSource = cliente.BuscarComprobanteCompraRangoFecha(fechaInicio.ToString("yyyy'-'MM'-'dd"), fechaFin.ToString("yyyy'-'MM'-'dd"));
                this.rvpCompras.RefreshReport();
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

        private void btnHoy_Click(object sender, EventArgs e)
        {
            try
            {
                var fechaInicio = DateTime.Now;
                var fechaFin = DateTime.Now;

                ComprobanteCompraBindingSource.DataSource = cliente.BuscarComprobanteCompraRangoFecha(fechaInicio.ToString("yyyy'-'MM'-'dd"), fechaFin.ToString("yyyy'-'MM'-'dd"));
                this.rvpCompras.RefreshReport();
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

        private void btnSemana_Click(object sender, EventArgs e)
        {
            try
            {
                var fechaInicio = DateTime.Now.AddDays(-7);
                var fechaFin = DateTime.Now;

                ComprobanteCompraBindingSource.DataSource = cliente.BuscarComprobanteCompraRangoFecha(fechaInicio.ToString("yyyy'-'MM'-'dd"), fechaFin.ToString("yyyy'-'MM'-'dd"));
                this.rvpCompras.RefreshReport();
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

        private void btnMes_Click(object sender, EventArgs e)
        {
            try
            {
                var fechaInicio = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                var fechaFin = DateTime.Now;

                ComprobanteCompraBindingSource.DataSource = cliente.BuscarComprobanteCompraRangoFecha(fechaInicio.ToString("yyyy'-'MM'-'dd"), fechaFin.ToString("yyyy'-'MM'-'dd"));
                this.rvpCompras.RefreshReport();
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
