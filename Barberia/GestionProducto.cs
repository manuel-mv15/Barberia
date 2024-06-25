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
        public GestionProducto()
        {
            InitializeComponent();
            //dgvGestionProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            txtIDProducto.Enabled = false;
            CargarDatos();

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

        void CargarDatos()
        {
            string consulta = $"SELECT * FROM tbl_productos";
            MySqlConnection conexionCargarDatos = Conexcion.MyConnection();
            conexionCargarDatos.Open();

            try
            {
                MySqlCommand comandoCargarDatos = new MySqlCommand(consulta, conexionCargarDatos);
                comandoCargarDatos.ExecuteNonQuery();
                MySqlDataAdapter adapter = new MySqlDataAdapter(comandoCargarDatos);
                adapter.Fill(dtProducto);
                dgvGestionProductos.DataSource = dtProducto;
                conexionCargarDatos.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No fue posible mostrar los datos " + ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (CamposValidacion(groupBox1))
            {
                string consulta = $"INSERT INTO tbl_productos(Nombre, Stock, Precio, Categoria, Fecha_Ingreso, Fecha_Caducidad, Marca) VALUES ('{txtNombreProducto.Text}'," +
                    $"'{txtStockProducto.Text}','{txtPrecioProducto.Text}','{cmbCategoriaProducto.Text}','{mtbFechaIngreso.Text}','{mtbFechaCaducidad.Text}','{txtMarca.Text}')";

                MySqlConnection ConexionAgregarProducto = Conexcion.MyConnection();
                ConexionAgregarProducto.Open();

                try
                {
                    MySqlCommand comandoAgregar = new MySqlCommand(consulta, ConexionAgregarProducto);
                    comandoAgregar.ExecuteNonQuery();
                    ConexionAgregarProducto.Close();
                    MySqlDataAdapter Adapter = new MySqlDataAdapter("SELECT * FROM tbl_productos", Conexcion.MyConnection());
                    Adapter.Fill(dtProducto);
                    dgvGestionProductos.DataSource = dtProducto;


                }
                catch (Exception ex)
                {

                }
                LimpiarCampos();
            }
        }

        private bool CamposValidacion(GroupBox grp)
        {
            bool validacion = true;
            foreach (Control control in grp.Controls)
            {
                if (control is TextBox textbox || control is ComboBox comboBox)
                {


                    if (string.IsNullOrEmpty(txtNombreProducto.Text))
                    {
                        validacion = false;
                        MessageBox.Show("Ingrese el nombre del producto");
                        txtNombreProducto.Focus();
                    }
                    if (string.IsNullOrEmpty(txtStockProducto.Text))
                    {
                        validacion = false;
                        MessageBox.Show("Ingrese la cantidad disponible del producto");
                        txtStockProducto.Focus();
                    }
                    if (string.IsNullOrEmpty(txtPrecioProducto.Text))
                    {
                        validacion = false;
                        MessageBox.Show("Ingrese el precio del producto");
                        txtPrecioProducto.Focus();
                    }
                    if (string.IsNullOrEmpty(cmbCategoriaProducto.Text))
                    {
                        validacion = false;
                        MessageBox.Show("Ingrese la categoria del producto");
                        cmbCategoriaProducto.Focus();
                    }
                    if (string.IsNullOrEmpty(txtMarca.Text))
                    {
                        validacion = false;
                        MessageBox.Show("Ingrese la marca del producto");
                        txtMarca.Focus();
                    }



                }
            }
            return validacion;

        }

        void LimpiarCampos()
        {
            txtNombreProducto.Clear();
            txtPrecioProducto.Clear();
            txtStockProducto.Clear();
            txtMarca.Clear();
            cmbCategoriaProducto.ResetText();
            mtbFechaCaducidad.Clear();
            mtbFechaIngreso.Clear();
        }


    }
}
