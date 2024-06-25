using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barberia
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        string tbl = "";
        string consulta = "";
        Consultas consultas = new Consultas();
        private void btnGestionUsuarios_Click(object sender, EventArgs e)
        {
            GestionUsuario AbriGestionUsuario = new GestionUsuario();
            AbriGestionUsuario.Show();
            Hide();
        }

        private void btnGestionClientes_Click(object sender, EventArgs e)
        {
            GestionCliente AbrirGestionCliente = new GestionCliente();
            AbrirGestionCliente.Show();
            Hide();
        }

        private void btnGestionProductos_Click(object sender, EventArgs e)
        {
            GestionProducto AbrirGestionProducto = new GestionProducto();
            AbrirGestionProducto.Show();
            Hide();
        }

        private void btnBuscarFiltro_Click(object sender, EventArgs e)
        {
            if (txtFiltrarNombre.Text != null)// verificamos que el campo no este vacio
            {
                // verificabos que tabla es y creamos la consulta
                if (tbl == "tbl_clientes")
                {
                    consulta = $"SELECT * FROM {tbl} WHERE Nombre_Cliente = '{txtFiltrarNombre.Text}';";
                }
                else if (tbl == "tbl_usuarios")
                {
                    consulta = $"SELECT * FROM {tbl} WHERE Nombre_Barbero = '{txtFiltrarNombre.Text}';";
                }
                else if (tbl == " tbl_productos")
                {
                    consulta = $"SELECT * FROM {tbl} WHERE Nombre = '{txtFiltrarNombre.Text}';";
                }
                else
                {
                    MessageBox.Show("Seleccione una tabla para filtrar");
                }
                dgvMostrar.DataSource = consultas.Buscardato(consulta);

            }
            else
            {
                MessageBox.Show("Asegurese de que la casilla 'Nombre' no este vacia");
            }
        }

        private void btnMostrarUsuarios_Click(object sender, EventArgs e)
        {
            tbl = "tbl_barberos";
            dgvMostrar.DataSource = consultas.ActualizarTabla(tbl);
        }

        private void btnMostrarClientes_Click(object sender, EventArgs e)
        {
            tbl = "tbl_clientes";
            dgvMostrar.DataSource = consultas.ActualizarTabla(tbl);
        }

        private void btnMostrarProductos_Click(object sender, EventArgs e)
        {
            tbl = "tbl_productos";

            dgvMostrar.DataSource = consultas.ActualizarTabla(tbl);
        }

        private void dgvMostrar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
