﻿using MySql.Data.MySqlClient;
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
        // funcion para llenar el dgv con los datos de la tbl
        public DataTable ActualizarTabla(string tbl)
        {
            MySqlConnection miconcexcion = Conexcion.MyConnection();
            miconcexcion.Open();
            try
            {
                MessageBox.Show(tblconsulta(tbl));
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
       // funcion para mostrar la tbl depende del nivel de usuario
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
        // funcion para buscar por nombre, apellido y/o dui en la tbl tambien por marca si es producto
        public DataTable Buscardato(string tbl, string Nombre)
        {

            string consulta = tblconsulta(tbl);
            

            if (tbl == "tbl_clientes")
            {
                consulta += $" WHERE Nombre_Cliente LIKE '%{Nombre}%' OR Apellido_Cliente LIKE '%{Nombre}%' OR DUI_Cliente LIKE '%{Nombre}%';";
            }
            else if (tbl == "tbl_barberos")
            {
                consulta += $" WHERE Nombre_Barbero LIKE '%{Nombre}%' OR Apellido_Barbero LIKE '%{Nombre}%' OR DUI_Barbero LIKE '%{Nombre}%';";
            }
            else if (tbl == "tbl_productos")
            {
                consulta += $" WHERE Nombre  LIKE '%{Nombre}%'  OR Marca LIKE '%{Nombre}%' ;";
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
        // con el nombre de la tbl devolvemos su consulta correspondiente
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
                consulta = @"SELECT 
   idCita,
   Descripcion,
   idBarbero,
   Nombre_Barbero,
   Apellido_Barbero,
   DUI_Barbero,
   idCliente,
   Nombre_Cliente,
   Apellido_Cliente,
   DUI_Cliente,
   DATE_FORMAT(Fecha, '%Y/%m/%d') AS Fecha 
FROM tbl_citas;";
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
                consulta = @"SELECT  
`idBarbero`, 
`Nombre_Barbero`,  
`Apellido_Barbero`,  
`Direccion_Barbero`,  
`Telefono_Barbero`,  
`DUI_Barbero`,   
DATE_FORMAT(`Fecha_Inicio`, '%Y/%m/%d') AS `Fecha_Inicio` 
FROM   tbl_barberos ";
            }
            else if (tbl == "tbl_usuarios")
            {
                consulta = "SELECT * FROM `tbl_usuarios` ";
            }

            else if (tbl == "tbl_ventas")
            {
                consulta = "SELECT * FROM `tbl_ventas`";
            }
            else if (tbl == "tbl_citas")
            {
                consulta = "SELECT * FROM `tbl_citas` ";
            }
            return consulta;
        }
        // funcion para mostrar la tbl depende del nivel de usuario
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
        // funcion para buscar un dato en la tbl
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
