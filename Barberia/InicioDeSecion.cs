using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System.Data;
using System.Text;

namespace Barberia
{
    public partial class InicioDeSecion : Form
    {
        Consultas consultas = new Consultas();
        public InicioDeSecion()
        {
            InitializeComponent();

        }
        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            Encriptador encriptador = new Encriptador();
            // inicio de secion 
            string Usuario = txt_Usuario.Text;
            string Clave = txt_Clave.Text;

            string consulta = $"SELECT * FROM tbl_usuarios WHERE Usuario = '{Usuario}' and Clave = '{encriptador.Encriptar(Clave)}';";
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
                    consulta = consulta = $"SELECT Tipo_Usuario FROM tbl_usuarios WHERE Usuario = '{txt_Usuario.Text}'";
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

                    Home abrirHome = new Home();
                    abrirHome.Show();
                    Hide();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }

        }
        

        private void InicioDeSecion_Load(object sender, EventArgs e)
        {

        }
    }
}
