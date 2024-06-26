﻿using MySql.Data.MySqlClient;
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
        string tbl = "tbl_productos";
        int id = 0;
        int fila = 0;


        public GestionProducto()// terminado
        {
            InitializeComponent();
            dgvGestionProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGestionProductos.RowHeadersVisible = false;
            txtIDProducto.Enabled = false;
            dgvGestionProductos.DataSource = consultas.ActualizarTabla(tbl);

        }

        DataTable dtProducto = new DataTable();

        // para volver al home 
        private void btnHome_Click(object sender, EventArgs e)// termindado
        {
            Home AbrirHome = new Home(1);
            AbrirHome.Show();
            Hide();
        }

        private void GestionProducto_Load(object sender, EventArgs e)
        {

        }

        // boton para aceptar los cambios y mandarlos al servidor

        //validar los campos de texto
        private bool CamposValidacion(GroupBox grp)// terminado
        {
            bool validacion = true;

            if (string.IsNullOrEmpty(txtNombreProducto.Text))
            {
                validacion = false;
                MessageBox.Show("Ingrese el nombre del producto");
                txtNombreProducto.Focus();
            }

            else if (string.IsNullOrEmpty(txtStockProducto.Text))
            {
                validacion = false;
                MessageBox.Show("Ingrese la cantidad disponible del producto");
                txtStockProducto.Focus();
            }

            else if (string.IsNullOrEmpty(txtPrecioProducto.Text))
            {
                validacion = false;
                MessageBox.Show("Ingrese el precio del producto");
                txtPrecioProducto.Focus();
            }

            else if (string.IsNullOrEmpty(cmbCategoriaProducto.Text))
            {
                validacion = false;
                MessageBox.Show("Ingrese la categoria del producto");
                cmbCategoriaProducto.Focus();
            }

            else if (string.IsNullOrEmpty(txtMarca.Text))
            {
                validacion = false;
                MessageBox.Show("Ingrese la marca del producto");
                txtMarca.Focus();
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
            mtbFechaCaducidad.Text = null;
            mtbFechaIngreso.Text = null;
            cmbCategoriaProducto.Text = null;
        }
        // mandar los datos a los txt
        private void btnEditar_Click(object sender, EventArgs e) // termindado
        {
            txtIDProducto.Text = dgvGestionProductos.Rows[fila].Cells[0].Value.ToString();
            txtNombreProducto.Text = dgvGestionProductos.Rows[fila].Cells[1].Value.ToString();
            txtStockProducto.Text = dgvGestionProductos.Rows[fila].Cells[2].Value.ToString();
            txtPrecioProducto.Text = dgvGestionProductos.Rows[fila].Cells[3].Value.ToString();
            cmbCategoriaProducto.Text = dgvGestionProductos.Rows[fila].Cells[4].Value.ToString();
            mtbFechaIngreso.Text = dgvGestionProductos.Rows[fila].Cells[5].Value.ToString();
            mtbFechaCaducidad.Text = dgvGestionProductos.Rows[fila].Cells[6].Value.ToString();
            txtMarca.Text = dgvGestionProductos.Rows[fila].Cells[7].Value.ToString();

            btnAceptar.Visible = true;
            btnEliminar.Enabled = false;
            btnHome.Enabled = false;
            btnAgregar.Enabled = false;
            btnEditar.Enabled = false;
        }


        // boton para eliminar
        private void btnEliminar_Click(object sender, EventArgs e)//termindado 
        {
            consulta = $"DELETE FROM `tbl_productos` WHERE idCliente = {id} ";
            consultas.Query(consulta);
            dgvGestionProductos.DataSource = consultas.ActualizarTabla("tbl_productos");
        }
        // boton para agregar y mandarlos al servidor
        private void btnAgregar_Click_1(object sender, EventArgs e) //termindado
        {
            if (CamposValidacion(grpGestionProducto))
            {
                consulta = $@"INSERT INTO tbl_productos(Nombre, Stock, Precio, Categoria, Fecha_Ingreso, Fecha_Caducidad, Marca) 
VALUES 
('{txtNombreProducto.Text}','{txtStockProducto.Text}','{txtPrecioProducto.Text}','{cmbCategoriaProducto.Text}','{mtbFechaIngreso.Text}','{mtbFechaCaducidad.Text}','{txtMarca.Text}')";
                consultas.Query(consulta);
                dgvGestionProductos.DataSource = consultas.ActualizarTabla(tbl);
                limpiar(grpGestionProducto);
            }
            else
            {
            }
        }
        // boton para aceptar los cambios y mandarlos al servidor
        private void btnAceptar_Click(object sender, EventArgs e) //termindado
        {

            if (CamposValidacion(grpGestionProducto))
            {
                consulta = $"UPDATE `tbl_productos` SET `Nombre`='{txtNombreProducto.Text}',`Stock`={int.Parse(txtStockProducto.Text)},`Precio`={decimal.Parse(txtPrecioProducto.Text)},`Categoria`='{cmbCategoriaProducto.Text}',`Fecha_Ingreso`='{mtbFechaIngreso.Text}',`Fecha_Caducidad`='{mtbFechaCaducidad.Text}',`Marca`='{txtMarca.Text}' WHERE `idProducto` = {id}";
                consultas.Query(consulta);
                dgvGestionProductos.DataSource = consultas.ActualizarTabla("tbl_productos");

                btnAceptar.Visible = false;
                btnEliminar.Enabled = true;
                btnHome.Enabled = true;
                btnAgregar.Enabled = true;
                btnEditar.Enabled = true;
                limpiar(grpGestionProducto);
                id = 0;
            }
            else
            {

            }
        }
        // obtener el id y la fila seleccionada 
        private void dgvGestionProductos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)//terminado
        {
            if (dgvGestionProductos.CurrentRow != null)
            {
                fila = dgvGestionProductos.CurrentRow.Index;
                var cellValue = dgvGestionProductos.Rows[fila].Cells[0].Value;
                if (cellValue != null)
                {
                    id = int.Parse(cellValue.ToString());
                }
            }
        }

        private void txtNombreProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cmbCategoriaProducto_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsLetterOrDigit(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtStockProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPrecioProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsPunctuation(e.KeyChar) || char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
