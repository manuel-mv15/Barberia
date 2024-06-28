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
       public int IDUSUARIO { get; set; }
        public Home(int id)
        {
            InitializeComponent();
            this.IDUSUARIO = id;
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

                dgvMostrar.DataSource = consultas.Buscardato(tbl, txtFiltrarNombre.Text);

            }
            else
            {
                MessageBox.Show("Asegurese de que la casilla 'Nombre' no este vacia");
            }
        }

        private void btnMostrarUsuarios_Click(object sender, EventArgs e)
        {
            dgvMostrar.Visible = true;
            lblFiltroNombre.Visible = true;
            txtFiltrarNombre.Visible = true;
            tbl = "tbl_barberos";
            dgvMostrar.DataSource = consultas.ActualizarTabla(tbl);
        }

        private void btnMostrarClientes_Click(object sender, EventArgs e)
        {
            dgvMostrar.Visible = true;
            lblFiltroNombre.Visible = true;
            txtFiltrarNombre.Visible = true;
            tbl = "tbl_clientes";
            dgvMostrar.DataSource = consultas.ActualizarTabla(tbl);
        }

        private void btnMostrarProductos_Click(object sender, EventArgs e)
        {
            dgvMostrar.Visible = true;
            lblFiltroNombre.Visible = true;
            txtFiltrarNombre.Visible = true;
            tbl = "tbl_productos";

            dgvMostrar.DataSource = consultas.ActualizarTabla(tbl);

        }

        private void dgvMostrar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRealizarVentas_Click(object sender, EventArgs e)
        {
            // abrir formulario de ventas
            RealizarVenta AbrirRealizarVenta = new RealizarVenta();
            AbrirRealizarVenta.Show();
            Hide();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void txtFiltrarNombre_TextChanged(object sender, EventArgs e)
        {
            string filtroNombre = txtFiltrarNombre.Text;
            
            if (!string.IsNullOrEmpty(filtroNombre))
            {
                
                dgvMostrar.DataSource = consultas.Buscardato(tbl, filtroNombre);
            }
            else
            {
                dgvMostrar.DataSource = consultas.ActualizarTabla(tbl);
            }
        }
    }
}
