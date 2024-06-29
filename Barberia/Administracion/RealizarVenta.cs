using Barberia.Administracion;
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
        string tbl = "";
        int fila = 0, id = 0, idcliente = 0;
        public RealizarVenta()
        {
            InitializeComponent();
            tbl = "tbl_clientes";
            dgvMostrarDatos.DataSource = consultas.ActualizarTabla(tbl);
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            GestionProducto gestionProducto = new GestionProducto();
            gestionProducto.Show();
            Hide();

        }

         void button4_Click(object sender, EventArgs e)
        {
            tbl = "tbl_productos";
            dgvMostrarDatos.DataSource = consultas.ActualizarTabla(tbl);
            btnAgregar.Visible = true;
            nupCantidad.Visible = true;
            mtbFechaFacturacion.Visible = true;
            label1.Visible = true;
            btnComprar.Visible = true;
            btnEliminar.Visible = true;
            dgvVenta.Visible = true;
            btnAceptar.Visible = false;

            MessageBox.Show(id.ToString());
            idcliente = id;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

            Home AbrirHome = new Home(1);
            AbrirHome.Show();
            Hide();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(fila.ToString());
            if (dgvMostrarDatos.CurrentRow != null)
            {
                int indexProducto = fila;

                DataGridViewRow filaSeleccion = dgvMostrarDatos.Rows[indexProducto];

                int idProducto = int.Parse(filaSeleccion.Cells[0].Value.ToString());
                string nombreProducto = filaSeleccion.Cells[1].Value.ToString();
                double precioProducto = double.Parse(filaSeleccion.Cells[3].Value.ToString());
                int cantidadProducto = int.Parse(filaSeleccion.Cells[2].Value.ToString());

                nupCantidad.Maximum = cantidadProducto;
                nupCantidad.Minimum = 1;

                int cantidad = int.Parse(nupCantidad.Value.ToString());
                dgvVenta.Rows.Add(idProducto, nombreProducto, precioProducto, cantidad, cantidad * precioProducto);


            }

        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            tbl = "tbl_clientes";
            dgvMostrarDatos.DataSource = consultas.ActualizarTabla(tbl);
            btnAgregar.Visible = !true;
            nupCantidad.Visible = !true;
            mtbFechaFacturacion.Visible = !true;
            label1.Visible = !true;
            btnComprar.Visible = !true;
            btnEliminar.Visible = !true;
            dgvVenta.Visible = !true;
            btnAceptar.Visible = !false;

            // bucar en todas las filas del datagrid
            foreach (DataGridViewRow row in dgvVenta.Rows)
            {
                if (row.Cells[0].Value != null)
                {

                    int indexProducto = row.Index;
                    if (dgvMostrarDatos.CurrentRow != null)
                    {


                        DataGridViewRow filaSeleccion = dgvVenta.Rows[indexProducto];

                        int idProducto = int.Parse(filaSeleccion.Cells[0].Value.ToString());
                        int cantidad = int.Parse(filaSeleccion.Cells[3].Value.ToString());

                        string queryVenta = $"INSERT INTO tbl_ventas (idProducto, Cantidad, idCliente, Fecha_Facturacion,`Total`) VALUES ({idProducto},{cantidad},{idcliente}, now(),{filaSeleccion.Cells[4].Value.ToString()})";

                        consultas.Query(queryVenta);
                    }
                    string consulta = @"UPDATE tbl_ventas
JOIN tbl_clientes ON tbl_ventas.idCliente = tbl_clientes.idCliente
JOIN tbl_productos ON tbl_ventas.idProducto = tbl_productos.idProducto
SET 
    tbl_ventas.Nombre_Producto = tbl_productos.Nombre,
    tbl_ventas.Precio = tbl_productos.Precio,
    tbl_ventas.Nombre_Cliente = tbl_clientes.Nombre_Cliente,
    tbl_ventas.Apellido_Cliente = tbl_clientes.Apellido_Cliente,
    tbl_ventas.DUI = LEFT(tbl_clientes.DUI_Cliente, 10); ";
                       consultas.Query(consulta);
                    dgvVenta.DataSource = null;
                }
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string filtroNombre = txtFiltrarNombre.Text;

            if (!string.IsNullOrEmpty(filtroNombre))
            {

                dgvMostrarDatos.DataSource = consultas.Buscardato(tbl, filtroNombre);
            }
            else
            {
                dgvMostrarDatos.DataSource = consultas.ActualizarTabla(tbl);
            }
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            GestionCliente gestionCliente = new GestionCliente();
            gestionCliente.Show();
            Hide();


        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            GestiondeVentas gestiondeVentas = new GestiondeVentas();
            gestiondeVentas.Show();
            Hide();
        }

        private void dgvMostrarDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (dgvMostrarDatos.CurrentRow != null)
            //{
            //    fila = dgvMostrarDatos.CurrentRow.Index;
            //    var cellValue = dgvMostrarDatos.Rows[fila].Cells[0].Value;
            //    if (cellValue != null)
            //    {
            //        idcliente = int.Parse(cellValue.ToString());
            //    }
            //}
        }
        private void dgvMostrarDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMostrarDatos.CurrentRow != null)
            {
                int fila = dgvMostrarDatos.CurrentRow.Index;
                var cellValue = dgvMostrarDatos.Rows[fila].Cells[0].Value;
                if (cellValue != null)
                {
                    idcliente = int.Parse(cellValue.ToString());
                    MessageBox.Show($"idcliente actualizado: {idcliente}"); // Depuración
                }
                else
                {
                    MessageBox.Show("La celda seleccionada está vacía.");
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // eliminar fila de dgvventas
            if (dgvVenta.CurrentRow != null)
            {
                dgvVenta.Rows.RemoveAt(dgvVenta.CurrentRow.Index);
            }
        }

        private void dgvMostrarDatos_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
                if (dgvMostrarDatos.CurrentRow != null)
                {
                     fila = dgvMostrarDatos.CurrentRow.Index;
                    var cellValue = dgvMostrarDatos.Rows[fila].Cells[0].Value;
                if (cellValue != null)
                {
                    id = int.Parse(cellValue.ToString());
                 
                }
                else
                {
                    MessageBox.Show("La celda seleccionada está vacía.");
                }
                }
            

        }
    }
}
