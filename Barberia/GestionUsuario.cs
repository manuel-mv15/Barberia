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
        string tbl = "tbl_usuarios";
        int id = 0;
        public GestionUsuario()
        {
            InitializeComponent();
            dgvGestionUsuario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGestionUsuario.RowHeadersVisible = false;
            //txtIDUsuario.Enabled = false;

            dgvGestionUsuario.DataSource = consultas.ActualizarTabla(tbl);

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home AbrirHome = new Home();
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

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            
            // inicio de secion 
            string Usuario = txtUsuario.Text;
            string Clave = txtClave.Text;

            string consulta = $"SELECT * FROM tbl_usuarios WHERE Usuario = '{Usuario}' and Clave = '{encriptador.Encriptar(Clave)}';";
            MessageBox.Show(consulta);
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


                    consulta =  $"SELECT Tipo_Usuario FROM tbl_usuarios WHERE Usuario = '{txtUsuario.Text}'";
                    if ("Super Usuario" == consultas.BuscarDato(consulta))
                    {

                        consulta = $"SELECT `idUsuario` FROM tbl_usuarios WHERE `Usuario` = '{Usuario}'";
                        id = int.Parse(consultas.BuscarDato(consulta));
                    }
                    else if ("Administrador" == consultas.BuscarDato(consulta))
                    {

                    }
                    ObtenerDatosPorId(id);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }
        private void ObtenerDatosPorId(int idUsuario)
        {
            foreach (DataGridViewRow fila in dgvGestionUsuario.Rows)
            {
                if (fila.Cells["idUsuario"].Value != null && fila.Cells["idUsuario"].Value.ToString() == idUsuario.ToString())
                {
                    // Aquí obtienes los datos de la fila
                    txtIdUsuario.Text = fila.Cells[0].Value.ToString();
                    txtUsuario.Text = fila.Cells[1].Value.ToString();
                    txtClave.Text = encriptador.desEncriptar(fila.Cells[2].Value.ToString());
                    txtTipodeUsuario.Text = fila.Cells[3].Value.ToString();
                    return;
                }
            }

            // Si no se encuentra la fila con el idUsuario especificado
            MessageBox.Show($"No se encontró ninguna fila con el ID Usuario: {idUsuario}");
        }

    }
}
