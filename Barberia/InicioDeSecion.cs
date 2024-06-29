using Barberia.Administracion;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System.Data;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Barberia
{
    public partial class InicioDeSecion : Form

    {
        public int IDUSUARIO { get; private set; }
        Consultas consultas = new Consultas();
        public InicioDeSecion()
        {
            InitializeComponent();
            this.Text = "Inicio de Sesión — Barber Shop";
            pictureBox1.Image = Properties.Resources.barbero;

        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            Encriptador encriptador = new Encriptador();
            // inicio de secion 
            string Usuario = txt_Usuario.Text;
            string Clave = txt_Clave.Text;
            string claveEncriptada = encriptador.Encriptar(Clave);
            string consultaPrimaria = $"SELECT * FROM tbl_usuarios WHERE Usuario = '{Usuario}' AND Clave = '{claveEncriptada}';";
            string consultaSecundaria = $"SELECT * FROM `tbl_clientes` WHERE `Usuario` ={Usuario} and  `Contraseña` ={claveEncriptada}";

            MySqlConnection conexion = Conexcion.MyConnection();
            conexion.Open();

            try
            {
                // Primera consulta
                MySqlCommand cmdPrimaria = new MySqlCommand(consultaPrimaria, conexion);
                int datoPrimario = Convert.ToInt32(cmdPrimaria.ExecuteScalar());

                if (datoPrimario > 0)
                {


                    string consulta = $"SELECT Tipo_Usuario FROM tbl_usuarios WHERE Usuario = '{txt_Usuario.Text}'";
                    //validamos que tipo de usuario es
                    if ("Super Usuario" == consultas.BuscarDato(consulta))
                    {
                        MessageBox.Show("Hola " + consultas.BuscarDato(consulta));
                    }
                    else if ("Administrador" == consultas.BuscarDato(consulta))
                    {

                    }
                    else if ("Usuario Común" == consultas.BuscarDato(consulta))
                    {

                    }
                    IDUSUARIO = Convert.ToInt32(consultas.BuscarDato($"SELECT `idUsuario` FROM tbl_usuarios WHERE `Usuario` = '{Usuario}'")); // obtenemos el id del usuario 


                    Home abrirHome = new Home(IDUSUARIO); // abrimos el home y mandamos el id
                    abrirHome.Show();
                    this.Hide();
                }
                else
                {
                    // Usuario no encontrado en la primera tabla, realizar la segunda consulta de clientes
                    MySqlCommand cmdSecundaria = new MySqlCommand(consultaSecundaria, conexion);
                    int datoSecundario = Convert.ToInt32(cmdSecundaria.ExecuteScalar());

                    if (datoSecundario > 0)
                    {

                    }
                    else
                    {
                        // Usuario no encontrado en ninguna tabla
                        MessageBox.Show("Usuario o clave incorrectos.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
            MySqlConnection conexcion = Conexcion.MyConnection();
            conexcion.Open();

        }


        private void InicioDeSecion_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            //CrearUsuario crearUsuario = new CrearUsuario();
            //crearUsuario.Show();
            //Hide();

            
            //Encriptador encriptador = new Encriptador();
        }
    }
}
