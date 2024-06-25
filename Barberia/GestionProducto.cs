using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Barberia
{
    public partial class GestionProducto : Form
    {
        Consultas consultas = new Consultas();
        string consulta = "";
        int id = 0;
        int fila = 0;
        public GestionProducto()
        {
            InitializeComponent();
            //dgvGestionProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            txtIDProducto.Enabled = false;
            consulta = $"SELECT \r\n  idProducto,\r\n  Nombre,\r\n  Stock,\r\n  Precio,\r\n  Categoria,\r\n  DATE_FORMAT(Fecha_Ingreso, '%Y/%m/%d') AS Fecha_Ingreso,\r\n  DATE_FORMAT(Fecha_Caducidad, '%Y/%m/%d') AS Fecha_Caducidad,\r\n  Marca\r\nFROM tbl_productos;";
            dgvGestionProductos.DataSource = consultas.ActualizarTabla(consulta);

        }

        DataTable dtProducto = new DataTable();


        private void btnHome_Click(object sender, EventArgs e)
        {
            Home AbrirHome = new Home();
            AbrirHome.Show();
            Hide();
        }

        private void GestionProducto_Load(object sender, EventArgs e)
        {

        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (CamposValidacion(groupBox1))
            {
                consulta = $"INSERT INTO tbl_productos(Nombre, Stock, Precio, Categoria, Fecha_Ingreso, Fecha_Caducidad, Marca) VALUES ('{txtNombreProducto.Text}'," +
                   $"'{txtStockProducto.Text}','{txtPrecioProducto.Text}','{cmbCategoriaProducto.Text}','{mtbFechaIngreso.Text}','{mtbFechaCaducidad.Text}','{txtMarca.Text}')";

                consultas.Query(consulta);
                consultas.ActualizarTabla("tbl_productos");
                limpiar(groupBox1);
            }
        }

        private bool CamposValidacion(GroupBox grp)
        {
            bool validacion = true;

            validacion = validartxt(groupBox1);
            if (string.IsNullOrEmpty(txtNombreProducto.Text))
            {
                MessageBox.Show("Ingrese el nombre del producto");
                txtNombreProducto.Focus();
            }
            if (string.IsNullOrEmpty(txtStockProducto.Text))
            {
                MessageBox.Show("Ingrese la cantidad disponible del producto");
                txtStockProducto.Focus();
            }
            if (string.IsNullOrEmpty(txtPrecioProducto.Text))
            {
                MessageBox.Show("Ingrese el precio del producto");
                txtPrecioProducto.Focus();
            }
            if (string.IsNullOrEmpty(cmbCategoriaProducto.Text))
            {
                MessageBox.Show("Ingrese la categoria del producto");
                cmbCategoriaProducto.Focus();
            }
            if (string.IsNullOrEmpty(txtMarca.Text))
            {
                validacion = false;
                MessageBox.Show("Ingrese la marca del producto");
                txtMarca.Focus();
            }

            return validacion;

        }

        private void limpiar(GroupBox gb)
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
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtIDProducto.Text = dgvGestionProductos.Rows[fila].Cells[0].Value.ToString();
            txtNombreProducto.Text = dgvGestionProductos.Rows[fila].Cells[1].Value.ToString();
            txtStockProducto.Text = dgvGestionProductos.Rows[fila].Cells[2].Value.ToString();
            txtPrecioProducto.Text = dgvGestionProductos.Rows[fila].Cells[3].Value.ToString();
            cmbCategoriaProducto.Text = dgvGestionProductos.Rows[fila].Cells[4].Value.ToString();
            mtbFechaIngreso.Text = dgvGestionProductos.Rows[fila].Cells[5].Value.ToString();
            mtbFechaCaducidad.Text = dgvGestionProductos.Rows[fila].Cells[6].Value.ToString();

            btnAceptar.Visible = true;
            btnEliminar.Enabled = false;
            btnHome.Enabled = false;
            btnAgregar.Enabled = false;
        }



        private void dgvGestionProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            fila = dgvGestionProductos.CurrentRow.Index;
            id = int.Parse(dgvGestionProductos.Rows[fila].Cells[0].Value.ToString());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {


            consulta = $"DELETE FROM `tbl_productos` WHERE idCliente = {id} ";
            consultas.Query(consulta);
            dgvGestionProductos.DataSource = consultas.ActualizarTabla("tbl_productos");
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            if (CamposValidacion(groupBox1))
            {
                consulta = $"UPDATE `tbl_productos` SET `Nombre`='{txtNombreProducto.Text}',`Stock`={int.Parse(txtStockProducto.Text)},`Precio`={decimal.Parse(txtPrecioProducto.Text)},`Categoria`='{cmbCategoriaProducto.Text}',`Fecha_Ingreso`='{mtbFechaIngreso.Text}',`Fecha_Caducidad`='{mtbFechaCaducidad.Text}',`Marca`='{txtMarca.Text}' WHERE `idProducto` = {id}";
                consultas.Query(consulta);
                dgvGestionProductos.DataSource = consultas.ActualizarTabla("tbl_clientes");

                btnAceptar.Visible = false;
                btnEliminar.Enabled = true;
                btnHome.Enabled = true;
                btnAgregar.Enabled = true;
                limpiar(groupBox1);
            }
            else
            {
                MessageBox.Show("Llene todos los campos");

            }

        }
        private bool validartxt(GroupBox gb)
        {
            foreach (Control item in gb.Controls)
            {
                if (item is TextBox)
                {
                    if (item.Text == "")
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
