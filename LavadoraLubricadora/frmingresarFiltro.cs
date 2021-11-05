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
    }
}
