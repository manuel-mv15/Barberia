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
    public partial class RealizarVenta : Form
    {
        Consultas consultas = new Consultas();
        public RealizarVenta()
        {
            InitializeComponent();

            dgvMostrarDatos.DataSource = consultas.ActualizarTabla("tbl_clientes");
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {

            Home AbrirHome = new Home(1);
            AbrirHome.Show();
            Hide();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            //if (dgvMostrarDatos.CurrentRow != null)
            //{
            //    int index = dgvMostrarDatos.CurrentRow.Index;

            //    DataGridViewRow filaClienteSeleccion = dgvMostrarDatos.Rows[index];

            //    int idCLiente = int.Parse(filaClienteSeleccion.Cells[0].Value.ToString());
            //    string nombreCLiente = filaClienteSeleccion.Cells[1].Value.ToString();
            //    string apellidoCLiente = filaClienteSeleccion.Cells[2].Value.ToString();
            //    string duiCLiente = filaClienteSeleccion.Cells[5].Value.ToString();

            //    dgvMostrarDatos.DataSource = consultas.ActualizarTabla("tbl_productos");


            //    int indexProducto = dgvMostrarDatos.CurrentRow.Index;

            //    DataGridViewRow filaSeleccion = dgvMostrarDatos.Rows[indexProducto];

            //    int idProducto = int.Parse(filaSeleccion.Cells[0].Value.ToString());
            //    string nombreProducto = filaSeleccion.Cells[1].Value.ToString();
            //    double precioProducto = double.Parse(filaSeleccion.Cells[3].Value.ToString());
            //    int cantidadProducto = int.Parse(filaSeleccion.Cells[2].Value.ToString());

            //    nupCantidad.Maximum = cantidadProducto;
            //    nupCantidad.Minimum = 1;

            //    int cantidad = int.Parse(nupCantidad.Value.ToString());
            //    double total = cantidad * precioProducto;

            //    string queryVenta = "INSERT INTO `tbl_ventas`(`idProducto`, `Nombre_Producto`, `Precio`, `Cantidad`, `Total`, " +
            //        "`idCliente`, `Nombre_Cliente`, `Apellido_Cliente`, `DUI`, `Fecha_Facturacion`)" +
            //        $" VALUES ('{idProducto.ToString()}','{nombreProducto.ToString()}','{precioProducto.ToString()}','{cantidad.ToString()}'," +
            //        $"'{total.ToString()}','{idCLiente.ToString()}','{nombreCLiente.ToString()}','{apellidoCLiente.ToString()}','{duiCLiente.ToString()}','{mtbFechaFacturacion.Text}')";
            //        consultas.Query(queryVenta);
            //}

            // idCliente Nombre_Cliente  Apellido_Cliente DUI
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            consultas.ActualizarTabla("tbl_ventas");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
