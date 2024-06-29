using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barberia.Administracion
{
    public partial class GestionBarberos : Form
    {
        public GestionBarberos()
        {
            InitializeComponent();
        }

        private void GestionBarberos_Load(object sender, EventArgs e)
        {

        }
        private bool CamposValidacion(GroupBox grp)// terminado
        {
            bool validacion = true;

            if (string.IsNullOrEmpty(txtNombre_Barbero.Text))
            {
                validacion = false;
                MessageBox.Show("Ingrese el nombre del barbero");
                txtNombre_Barbero.Focus();
            }

            else if (string.IsNullOrEmpty(txtApellido_Barbero.Text))
            {
                validacion = false;
                MessageBox.Show("Ingrese el apellido del barbero");
                txtApellido_Barbero.Focus();
            }

            else if (string.IsNullOrEmpty(txtDireccion_Barbero.Text))
            {
                validacion = false;
                MessageBox.Show("Ingrese la direccion del barbero");
                txtDireccion_Barbero.Focus();
            }

            else if (string.IsNullOrEmpty(mtxtTelefono_Barbero.Text))
            {
                validacion = false;
                MessageBox.Show("Ingrese el numero de telefono del barbero");
                mtxtTelefono_Barbero.Focus();
            }

            else if (string.IsNullOrEmpty(mtxtDUI_Barbero.Text))
            {
                validacion = false;
                MessageBox.Show("Ingrese el DUI del barbero");
                mtxtDUI_Barbero.Focus();
            }
            else if (string.IsNullOrEmpty(mtxtFechaInicio_Barbero.Text))
            {
                validacion = false;
                MessageBox.Show("Ingrese la fecha de inicio del barbero");
                mtxtFechaInicio_Barbero.Focus();
            }

            return validacion;

        }

        //limpiar los txt 
        private void limpiar(GroupBox gb)//termindado
        {
            foreach (Control item in gb.Controls)
            {
                if (item is TextBox)
                {
                    if (item != null)
                    {
                        item.Text = "";
                    }
                }
            }
            mtxtFechaInicio_Barbero.Text = null;
            mtxtTelefono_Barbero.Text = null;
            mtxtDUI_Barbero.Text = null;
        }

        private void txtNombre_Barbero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txtApellido_Barbero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }
    }
}
