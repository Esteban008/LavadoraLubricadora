using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;

namespace LavadoraLubricadora
{
    public partial class frmBuscarProducto : Form
    {
        LavadoraService.LavadoraServiceClient cliente;
        public frmBuscarProducto()
        {
            InitializeComponent();
        }

        private void frmBuscarProducto_Load(object sender, EventArgs e)
        {
            //instancia de nuevo objeto de conexion a servicio web 
            cliente = new LavadoraService.LavadoraServiceClient();

            cbxCriBusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            txtBusqueda.Visible = false;
        }

        //Este evento nos permite buscar un aceite dependiendo del parametro criterio de
        //busqueda desde el combo box cbxCriBusqueda
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxCriBusqueda.SelectedItem != null)
                {

                        if (cbxCriBusqueda.SelectedItem.ToString().Equals("Código de Barras"))
                        {
                            DataTable productos = cliente.BuscarProductoCodigo(txtBusqueda.Text);
                            dgvProducto.DataSource = productos;
                        }
                        else if (cbxCriBusqueda.SelectedItem.ToString().Equals("Marca"))
                        {
                            DataTable productos = cliente.BuscarProductoMarca(txtBusqueda.Text);
                            dgvProducto.DataSource = productos;
                        }
                        else if (cbxCriBusqueda.SelectedItem.ToString().Equals("Mostrar Todos"))
                        {
                            DataTable productos = cliente.ObtenerProducto();
                            dgvProducto.DataSource = productos;
                        }

                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Seleccione un criterio de búsqueda", "Aviso", MessageBoxButtons.OK);
                }
            }
            catch (EndpointNotFoundException)
            {
                DialogResult dialogResult = MessageBox.Show("Ha ocurrido un error de conexión", "Aviso", MessageBoxButtons.OK);
            }
            catch (NullReferenceException)
            {
                DialogResult dialogResult = MessageBox.Show("Seleccione un criterio de búsqueda", "Aviso", MessageBoxButtons.OK);
            }
            catch (Exception)
            {
                DialogResult dialogResult = MessageBox.Show("Ha ocurrido un error", "Aviso", MessageBoxButtons.OK);
            }
        }

        //Este evento nos permite habilitar y deshabilitar el control respectivo
        //para el criterio de busqueda seleccionado
        private void cbxCriBusqueda_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbxCriBusqueda.SelectedItem != null)
                {
                    if (cbxCriBusqueda.SelectedItem.ToString().Equals("Mostrar Todos"))
                    {
                        txtBusqueda.Visible = false;
                        txtBusqueda.Clear();
                    }
                    else
                    {
                        txtBusqueda.Visible = true;
                        txtBusqueda.Clear();
                    }
                }
            }
            catch (NullReferenceException)
            {
                DialogResult dialogResult = MessageBox.Show("Seleccione un criterio de búsqueda", "Aviso", MessageBoxButtons.OK);
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Aviso", MessageBoxButtons.YesNo);
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
