using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barberia
{
    internal class Consultas
    {
        string consulta = "";

        public DataTable ActualizarTabla(string tbl)
        {
            tblconsulta(tbl);
            MySqlConnection miconcexcion = Conexcion.MyConnection();
            miconcexcion.Open();
            
            try
            {
                MySqlCommand cmd = new MySqlCommand(consulta, miconcexcion);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt); // fila 25

              

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR " + ex);
                return null;
            }
            finally
            {
                miconcexcion.Close();
            }
        }
       
        public DataTable Buscardato(string tbl, string Nombre)
        {
            tblconsulta(tbl);

            if (tbl == "tbl_clientes")
            {
                consulta += $" WHERE Nombre_Cliente = '{Nombre}';";
            }
            else if (tbl == "tbl_barberos")
            {
                consulta += $" WHERE Nombre_Barbero = '{Nombre}';";
            }
            else if (tbl == " tbl_productos")
            {
                consulta += $" WHERE Nombre = '{Nombre}';";
            }
            else
            {
                MessageBox.Show("Seleccione una tabla para filtrar ");
            }

            MySqlConnection miconcexcion = Conexcion .MyConnection();
            miconcexcion.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand(consulta, miconcexcion);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch
            {
                MessageBox.Show("ERROR");
                return null;
            }
        }
        // Query
        public void Query(string _consulta)
        {
            MySqlConnection miconcexcion = Conexcion.MyConnection();
            miconcexcion.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand(_consulta, miconcexcion);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR " + ex);
            }
        }
        //---------
        void tblconsulta(string tbl)
        {
            if (tbl == "tbl_productos")
            {
                consulta = "SELECT \r\n  idProducto,\r\n  Nombre,\r\n  Stock,\r\n  Precio,\r\n  Categoria,\r\n  DATE_FORMAT(Fecha_Ingreso, '%Y/%m/%d') AS Fecha_Ingreso,\r\n  DATE_FORMAT(Fecha_Caducidad, '%Y/%m/%d') AS Fecha_Caducidad,\r\n  Marca\r\nFROM tbl_productos ";
            }
            else if (tbl == "tbl_citas")
            {
                consulta = "SELECT \r\n  idCita,\r\n  idCliente,\r\n  idBarbero,\r\n  Descripcion,\r\n  DATE_FORMAT(Fecha_Inicio, '%Y/%m/%d') AS Fecha_Inicio,\r\n  DATE_FORMAT(Fecha_Finalizacion, '%Y/%m/%d') AS Fecha_Finalizacion\r\nFROM tbl_citas ";
            }
            else if (tbl == "tbl_clientes")
            {
                consulta = "SELECT \r\n  idCliente,\r\n  Nombre_Cliente,\r\n  Apellido_Cliente,\r\n Direccion_Cliente,\r\n  Telefono_Cliente,\r\n  DUI_Cliente,\r\n  Correo_Electronico,\r\n  DATE_FORMAT(Fecha_Registro, '%Y/%m/%d') AS Fecha_Registro\r\n  \r\nFROM tbl_clientes ";
            }
            else if (tbl == "tbl_barberos")
            {
                consulta = "SELECT \r\n  `idBarbero`,\r\n  `Nombre_Barbero`,\r\n  `Apellido_Barbero`,\r\n  `Direccion_Barbero`,\r\n  `Telefono_Barbero`,\r\n  `DUI_Barbero`, \r\n  DATE_FORMAT(`Fecha_Inicio`, '%Y/%m/%d') AS `Fecha_Inicio`\r\nFROM \r\n  tbl_barberos ";
            }
            else if (tbl == "tbl_usuarios")
            {
                consulta = "SELECT `idUsuario`,`Usuario`,`Clave`,`Tipo_Usuario` FROM tbl_usuarios";
            }
            else if (tbl == "tbl_ventas")
            {
                consulta = "";
            }
            else
            {
                consulta = $"SELECT * FROM {tbl}";
            }
        }
    }

}
