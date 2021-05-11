using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LavadoraLubricadora
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }
        #region Panel de Control
        //Boton que permite cerrar el programa
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Boton que permite minimizar el programa
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        /// Metodo que nos permite arrastrar
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Evento sobre el panel a arrastrar
        private void panelBarraTitulo_MouseMove_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        //METODO PARA ABRIR FORMULARIOS DENTRO DEL PANEL
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            //Busca en la colecion el formulario
            formulario = panelFormularios.Controls.OfType<MiForm>().FirstOrDefault();
            //si el formulario instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelFormularios.Controls.Add(formulario);
                panelFormularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CloseForms);
            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }

        //Metodo que nos permite cerrar los Formularios del Panel
        private void CloseForms(object sender, FormClosedEventArgs e)
        {
            
            if (Application.OpenForms["frmActualizarFactura"] == null)
                btnBuscarProductos.BackColor = Color.FromArgb(244, 232, 50);
            /*
            if (Application.OpenForms["frmBorrarFacturas"] == null)
                btnBorrarFacturas.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["frmBuscarFactura"] == null)
                btnBuscarFactura.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["frmCrearFactura"] == null)
                btnCrearFactura.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["frmListarFacturas"] == null)
                btnListarFactura.BackColor = Color.FromArgb(4, 41, 68);
            */
        }

        private void btnBuscarProductos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmBusquedaProductos>();
            btnBuscarProductos.BackColor = Color.FromArgb(253, 250, 218);
        }
    }
}
