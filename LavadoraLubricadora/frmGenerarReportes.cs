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
            ComprobanteVentaBindingSource.DataSource = cliente.BuscarComprobanteRangoFecha("2022-01-17", "2022-01-17");
            //this.rpvComprobantes.RefreshReport();

            //this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
