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
        Consultas consultas = new Consultas();
        string consulta = "";
        int id = 0;
        int fila = 0;
        string tbl = "tbl_barberos";
        public GestionBarberos()
        {
            InitializeComponent();
            dgvBarberos.DataSource = consultas.ActualizarTabla(tbl);
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void dgvBarberos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBarberos.CurrentRow != null)
            {
                fila = dgvBarberos.CurrentRow.Index;
                var cellValue = dgvBarberos.Rows[fila].Cells[0].Value;
                if (cellValue != null)
                {
                    id = int.Parse(cellValue.ToString());
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtIDBarbero.Text = dgvBarberos.Rows[fila].Cells[0].Value.ToString();
            txtNombre_Barbero.Text = dgvBarberos.Rows[fila].Cells[1].Value.ToString();
            txtApellido_Barbero.Text = dgvBarberos.Rows[fila].Cells[2].Value.ToString();
            txtDireccion_Barbero.Text = dgvBarberos.Rows[fila].Cells[3].Value.ToString();
            mtxtTelefono_Barbero.Text = dgvBarberos.Rows[fila].Cells[4].Value.ToString();
            mtxtDUI_Barbero.Text = dgvBarberos.Rows[fila].Cells[5].Value.ToString();
            mtxtFechaInicio_Barbero.Text = dgvBarberos.Rows[fila].Cells[6].Value.ToString();
            btnAceptar.Visible = true;
            btnEliminar.Enabled = false;
            btnHome.Enabled = false;
            btnAgregar.Enabled = false;
        }
    }
}
