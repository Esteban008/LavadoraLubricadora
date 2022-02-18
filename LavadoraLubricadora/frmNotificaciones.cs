
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
    public partial class frmNotificaciones : Form
    {

        LavadoraService.LavadoraServiceClient cliente;
        public frmNotificaciones()
        {
            InitializeComponent();
        }

        private void frmNotificaciones_Load(object sender, EventArgs e)
        {
            cliente = new LavadoraService.LavadoraServiceClient();

            try
            {
                DataTable notificaciones = cliente.ObtenerNotificaciones();
                dgvNotificaciones.DataSource = notificaciones;
            }
            catch (Exception)
            {

                DialogResult dialogResult = MessageBox.Show("Ha ocurrido un error de connección", "Aviso", MessageBoxButtons.OK);
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
