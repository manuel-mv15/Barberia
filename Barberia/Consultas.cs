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

        public DataTable ActualizarTabla(string tbl)
        {
            MySqlConnection miconcexcion = Conexcion.MyConnection();
            miconcexcion.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand(tblconsulta(tbl), miconcexcion);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

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
        public DataTable ActualizarTabla(string tbl, int tipo)
        {
            MySqlConnection miconcexcion = Conexcion.MyConnection();
            miconcexcion.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand(tblconsulta(tbl,tipo), miconcexcion);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

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

            string consulta = tblconsulta(tbl);
            

            if (tbl == "tbl_clientes")
            {
                consulta += $" WHERE Nombre_Cliente LIKE '%{Nombre}%';";
            }
            else if (tbl == "tbl_barberos")
            {
                consulta += $" WHERE Nombre_Barbero LIKE '%{Nombre}%';";
            }
            else if (tbl == "tbl_productos")
            {
                consulta += $" WHERE Nombre  LIKE '%{Nombre}%';";
            }
            else
            {
                MessageBox.Show("Seleccione una tabla para filtrar ");
            }
            MySqlConnection miconcexcion = Conexcion.MyConnection();
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
        private string tblconsulta(string tbl)
        {
            string consulta = "";
            if (tbl == "tbl_productos")
            {
                consulta = @$"SELECT 
                                    `idProducto`, 
                                    `Nombre`, 
                                    `Stock`, 
                                    `Precio`, 
                                    `Categoria`, 
                                    DATE_FORMAT(`Fecha_Ingreso`, '%Y/%m/%d') AS `Fecha_Ingreso`, 
                                    DATE_FORMAT(`Fecha_Caducidad`, '%Y/%m/%d') AS `Fecha_Caducidad`, 
                                    `Marca` 
                                 FROM `{tbl}`";
            }
            else if (tbl == "tbl_citas")
            {
                consulta = @"SELECT \r\n  idCita,\r\n  idCliente,\r\n  idBarbero,\r\n  Descripcion,\r\n  DATE_FORMAT(Fecha_Inicio, '%Y/%m/%d') AS Fecha_Inicio,\r\n  DATE_FORMAT(Fecha_Finalizacion, '%Y/%m/%d') AS Fecha_Finalizacion\r\nFROM tbl_citas ";
            }
            else if (tbl == "tbl_clientes")
            {
                consulta = @"SELECT 
`idCliente`,
`Nombre_Cliente`,
`Apellido_Cliente`,
`Direccion_Cliente`,
`Telefono_Cliente`,
`DUI_Cliente`,
`Correo_Electronico`,
DATE_FORMAT(`Fecha_Registro`, '%Y/%m/%d') AS `Fecha_Registro`
FROM tbl_clientes";
            }
            else if (tbl == "tbl_barberos")
            {
                consulta = "SELECT \r\n  `idBarbero`,\r\n  `Nombre_Barbero`,\r\n  `Apellido_Barbero`,\r\n  `Direccion_Barbero`,\r\n  `Telefono_Barbero`,\r\n  `DUI_Barbero`, \r\n  DATE_FORMAT(`Fecha_Inicio`, '%Y/%m/%d') AS `Fecha_Inicio`\r\nFROM \r\n  tbl_barberos ";
            }
            else if (tbl == "tbl_usuarios")
            {
                consulta = "SELECT * FROM `tbl_usuarios` ";
            }

            else if (tbl == "tbl_ventas")
            {
                consulta = "";
            }
            return consulta;
        }

        private string tblconsulta(string tbl,int tipo)
        {

            string consulta = "";
            if (tbl == "tbl_usuarios" && tipo ==1)
            {
                consulta = "SELECT `idUsuario`,`Usuario`,`Tipo_Usuario` FROM tbl_usuarios";
            }
            else if (tbl == "tbl_usuarios" && tipo == 2)
            {
                consulta = "";
            }

                return consulta;

        }
        public string BuscarDato(string consulta)
        {
            MySqlConnection conexion = Conexcion.MyConnection();
            conexion.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand(consulta, conexion);
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    return result.ToString();
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }
            finally
            {
                conexion.Close();
            }
        }
    }

}
