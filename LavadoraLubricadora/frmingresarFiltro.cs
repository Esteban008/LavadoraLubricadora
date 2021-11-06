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
    public partial class frmingresarFiltro : Form
    {
        public frmingresarFiltro()
        {
            InitializeComponent();
            this.toolTipMsj.SetToolTip(this.rtxtCodigos, "Ingrese un código por linea");
        }

        private void frmingresarFiltro_Load(object sender, EventArgs e)
        {
            
        }

        //METODO PARA ABRIR FORMULARIOS DENTRO DEL PANEL
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            //Busca en la colecion el formulario
            formulario = pnlPrincipal.Controls.OfType<MiForm>().FirstOrDefault();
            //si el formulario instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                pnlPrincipal.Controls.Add(formulario);
                pnlPrincipal.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                
            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }

        


        public List<string> recuperarRtxt()
        {
            string[] list = rtxtCodigos.Lines;
            List<string> codigos = new List<string>(list);

            return codigos;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            recuperarRtxt();
        }

        private void btnAgregarVehiculos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmAgregarVehiculo>();
            

        }
    }
}
