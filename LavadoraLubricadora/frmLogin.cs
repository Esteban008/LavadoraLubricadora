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
using System.ServiceModel;

namespace LavadoraLubricadora
{
    public partial class frmLogin : Form
    {
         LavadoraService.LavadoraServiceClient cliente;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /// Metodo que nos permite arrastrar
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelBarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "CORREO/USUARIO")
            {
                txtCorreo.Text = "";
                txtCorreo.ForeColor = Color.Black;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "")
            {
                txtCorreo.Text = "CORREO/USUARIO";
                txtCorreo.ForeColor = Color.DimGray;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "CONTRASEÑA")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "CONTRASEÑA";
                txtPassword.ForeColor = Color.DimGray;
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCorreo.Text != "CORREO/USUARIO")
                {
                    if (txtPassword.Text != "CONTRASEÑA")
                    {
                        if (cliente.Login(txtCorreo.Text, txtPassword.Text))
                        {
                            frmPrincipalP frmPrincipal = new frmPrincipalP();
                            frmPrincipal.Show();
                            frmPrincipal.FormClosed += Logout;
                            this.Hide();                           
                        }
                        else
                        {
                            lblMensajeError.Text = "       Usuario o Contraseña incorrecta \n        Intente de nuevo";
                            lblMensajeError.Visible = true;

                        }
                    }
                    else
                    {
                        lblMensajeError.Text = "       Ingrese su clave";
                        lblMensajeError.Visible = true;
                    }
                }
                else
                {
                    lblMensajeError.Text = "       Ingrese su correo";
                    lblMensajeError.Visible = true;
                }
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

        private void frmLogin_Load(object sender, EventArgs e)
        {
            cliente = new LavadoraService.LavadoraServiceClient();
        }

        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtPassword.Clear();
            txtCorreo.Clear();
            lblMensajeError.Visible = false;
            this.Show();
        }
    }
}
