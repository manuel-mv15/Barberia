using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barberia.Administracion
{
    public partial class GenerarCita : Form
    {
        int idcliente = 0;
        int idbarbero = 0;
        int fila = 0, id = 0;
        Consultas consultas = new Consultas();
        public GenerarCita()
        {
            InitializeComponent();
            dgvBarberos.DataSource = consultas.ActualizarTabla("tbl_barberos");
            dgvClientes.DataSource = consultas.ActualizarTabla("tbl_clientes");
            dgvcitas.DataSource = consultas.ActualizarTabla("tbl_citas");
            dgvClientes.Visible = false;
            DateTime horaInicial = new DateTime(1, 1, 1, 7, 0, 0); // 7:00:00 AM
            DateTime horaFinal = new DateTime(1, 1, 1, 16, 0, 0); // 4:00:00 PM

            for (DateTime hora = horaInicial; hora <= horaFinal; hora = hora.AddHours(1))
            {
                cmbHora.Items.Add(hora.ToString("HH:mm:ss"));
            }
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            string fechaEntrada = mtxtFecha.Text; // Suponiendo que la fecha está en un formato reconocible, como "dd/MM/yyyy"
            string horaEntrada = cmbHora.Text; // Suponiendo que la hora está en un formato reconocible, como "HH:mm:ss"

            DateTime fecha;
            DateTime hora;

            if (DateTime.TryParse(fechaEntrada, out fecha) && DateTime.TryParse(horaEntrada, out hora))
            {
                DateTime fechaHora = fecha.Date + hora.TimeOfDay;


                string consulta = $"SELECT COUNT(*) FROM tbl_barberos WHERE idBarbero = {idbarbero} AND Fecha_Inicio = '{fechaHora.ToString("yyyy-MM-dd HH:mm:ss")}'";
                MySqlConnection conexion = Conexcion.MyConnection();
                conexion.Open();

                try
                {
                    // Primera consulta
                    MySqlCommand cont = new MySqlCommand(consulta, conexion);
                    int contar = Convert.ToInt32(cont.ExecuteScalar());

                    if (contar == 0)
                    {
                        string insertar = $"INSERT INTO tbl_citas (idBarbero, idCliente, Fecha,Descripcion) VALUES ({idbarbero}, {idcliente}, '{fechaHora.ToString("yyyy-MM-dd HH:mm:ss")},{txtDesticpcion.Text}')";
                        MySqlCommand cmd = new MySqlCommand(insertar, conexion);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cita agendada correctamente");

                        // Actualizar dgvCitas
                        consulta = @"

UPDATE tbl_citas
JOIN tbl_barberos ON tbl_citas.idBarbero = tbl_barberos.idBarbero
JOIN tbl_clientes ON tbl_citas.idCliente = tbl_clientes.idCliente
SET 
    tbl_citas.Nombre_Barbero = tbl_barberos.Nombre_Barbero,
    tbl_citas.Apellido_Barbero = tbl_barberos.Apellido_Barbero,
    tbl_citas.DUI_Barbero = tbl_barberos.DUI_Barbero,
    tbl_citas.Nombre_Cliente = tbl_clientes.Nombre_Cliente,
    tbl_citas.Apellido_Cliente = tbl_clientes.Apellido_Cliente,
    tbl_citas.DUI_Cliente = tbl_clientes.DUI_Cliente;;";
                        consultas.Query(consulta);
                        DataTable citas = consultas.ActualizarTabla("tbl_citas");
                        if (citas != null)
                        {
                            dgvcitas.DataSource = citas;
                            dgvcitas.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show("Error al actualizar la tabla de citas.");
                        }

                        idbarbero = 0;
                        idcliente = 0;
                        id = 0;
                        fila = 0;
                    }
                    else
                    {
                        MessageBox.Show("La fecha no está disponible");
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
            }
            else
            {
                MessageBox.Show("Error en el formato de la fecha o la hora");
            }

        }
        public static bool EsFechaValidaYMayor(string fechaStr)
        {
            DateTime fecha;
            bool esFechaValida = DateTime.TryParse(fechaStr, out fecha);

            if (!esFechaValida)
            {
                return false;
            }

            return fecha > DateTime.Now;
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {

            if (idbarbero != 0)
            {
                dgvClientes.Visible = true;

            }
        }

        private void dgvBarberos_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            if (dgvBarberos.CurrentRow != null)
            {
                fila = dgvBarberos.CurrentRow.Index;
                var cellValue = dgvBarberos.Rows[fila].Cells[0].Value;
                if (cellValue != null)
                {
                    idbarbero = int.Parse(cellValue.ToString());

                }
                else
                {
                    MessageBox.Show("La celda seleccionada está vacía.");
                }
            }
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            if (dgvClientes.CurrentRow != null)
            {
                fila = dgvClientes.CurrentRow.Index;
                var cellValue = dgvClientes.Rows[fila].Cells[0].Value;
                if (cellValue != null)
                {
                    idcliente = int.Parse(cellValue.ToString());

                }
                else
                {
                    MessageBox.Show("La celda seleccionada está vacía.");
                }
            }
        }
    }
}
