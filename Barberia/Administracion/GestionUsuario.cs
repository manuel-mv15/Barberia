using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barberia
{
    public partial class GestionUsuario : Form
    {
        Encriptador encriptador = new Encriptador();
        Consultas consultas = new Consultas();
        string consulta = "";
        string tbl = "tbl_usuarios";
        int id = 0;
        public GestionUsuario()
        {
            InitializeComponent();
            dgvGestionUsuario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGestionUsuario.RowHeadersVisible = false;
            txtIdUsuario.Enabled = false;

            txtTipodeUsuario.Enabled = false;

            btnCancelar.Visible = false;
            btnEditar.Visible = false;

            txtIdUsuario.Visible = false;
            txtTipodeUsuario.Visible = false;

        }
        // volver al home
        private void btnHome_Click(object sender, EventArgs e)
        {
            Home AbrirHome = new Home(1);
            AbrirHome.Show();
            Hide();
        }

        private void GestionUsuario_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        // boton para iniciar secion
        private void btnIniciar_Click(object sender, EventArgs e)
        {

            // inicio de secion 
            string Usuario = txtUsuario.Text;
            string Clave = txtClave.Text;

            consulta = $"SELECT * FROM tbl_usuarios WHERE Usuario = '{Usuario}' and Clave = '{encriptador.Encriptar(Clave)}';";
         
            // coneccion a la base de datos 
            MySqlConnection conexcion = Conexcion.MyConnection();
            conexcion.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand(consulta, conexcion);
                cmd.ExecuteNonQuery();

                int dato = Convert.ToInt32(cmd.ExecuteScalar());
                if (dato > 0)
                {


                    consulta = $"SELECT Tipo_Usuario FROM tbl_usuarios WHERE Usuario = '{txtUsuario.Text}'";
                    if ("Super Usuario" == consultas.BuscarDato(consulta))
                    {

                        consulta = $"SELECT `idUsuario` FROM tbl_usuarios WHERE `Usuario` = '{Usuario}'";
                        id = int.Parse(consultas.BuscarDato(consulta));
                        
                        
                        MessageBox.Show("Consulta SQL: " + consulta);

                        dgvGestionUsuario.DataSource = consultas.ActualizarTabla(tbl,1);
                    }
                    else if ("Administrador" == consultas.BuscarDato(consulta))
                    {
                        consulta = $"SELECT `idUsuario` FROM tbl_usuarios WHERE `Usuario` = '{Usuario}'";
                        id = int.Parse(consultas.BuscarDato(consulta));
                        
                        dgvGestionUsuario.DataSource = consultas.ActualizarTabla(tbl,2);
                    }
                    ObtenerDatosPorId(id);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }
        // obtener el dato por id 
        private void ObtenerDatosPorId(int idUsuario)
        {
            DataTable dt = new DataTable();
            dt = consultas.ActualizarTabla(tbl);
            foreach (DataRow row in dt.Rows)
            {
                
                if (row[0]!= null && row[0].ToString() == idUsuario.ToString())
                {
                    // Aquí obtienes los datos de la fila y lo mandamos a los txt
                    txtIdUsuario.Text = row[0].ToString();
                    txtUsuario.Text = row[1].ToString();
                    txtClave.Text = encriptador.desEncriptar(row[2].ToString());
                    txtTipodeUsuario.Text = row[3].ToString();
                    return;
                }
            }

            // Si no se encuentra la fila con el idUsuario especificado
            MessageBox.Show($"No se encontró ninguna fila con el ID Usuario: {idUsuario}");
        }

        // boton para editar el usuario y la clave
        private void btnEditar_Click(object sender, EventArgs e)
        {
            consulta = $"UPDATE `tbl_usuarios` SET `Usuario`='{txtUsuario.Text}',`Clave`='{encriptador.Encriptar(txtClave.Text)}' WHERE = {id}";
            limpiar(groupBox1);
        }
        // boton para limpiar los txt
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
        }
    }
}
