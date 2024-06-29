using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barberia.Administracion
{
    public partial class GestiondeVentas : Form
    {
        Consultas consultas = new Consultas();
        DateTime fecha;
        public GestiondeVentas()
        {
            InitializeComponent();
        }
        public bool EsFechaValida()
        {
            string _fecha = mtxtFecha.Text;
            fecha = DateTime.Parse(_fecha);
            DateTime fechaResultado;
            return DateTime.TryParse(_fecha, out fechaResultado);
        }
        private void btnDiarias_Click(object sender, EventArgs e)
        {
            if (EsFechaValida())
            {

                string ventasDiariasQuery = @"
                SELECT 
                    DATE(fecha) AS Dia,
                    SUM(Sub_Total) AS Total_Ventas
                FROM 
                    Reporte
                WHERE
                    fecha = @Fecha
                GROUP BY 
                    DATE(fecha);";
                dgvVentas.DataSource = consultas.ActualizarTabla(ventasDiariasQuery);

            }
        }

        private void btnSemanales_Click(object sender, EventArgs e)
        {
            if (EsFechaValida())
            {

                string ventasSemanalesQuery = @"
                SELECT 
                    YEAR(fecha) AS Año,
                    WEEK(fecha) AS Semana,
                    SUM(Sub_Total) AS Total_Ventas
                FROM 
                    Reporte
                WHERE
                    YEAR(fecha) = YEAR(@Fecha) AND WEEK(fecha) = WEEK(@Fecha)
                GROUP BY 
                    YEAR(fecha), WEEK(fecha);";

                dgvVentas.DataSource = consultas.ActualizarTabla(ventasSemanalesQuery);

            }
        }

        private void btnAnuales_Click(object sender, EventArgs e)
        {
            if (EsFechaValida())
            {

                string ventasMensualesQuery = @"
                SELECT 
                    YEAR(fecha) AS Año,
                    MONTH(fecha) AS Mes,
                    SUM(Sub_Total) AS Total_Ventas
                FROM 
                    Reporte
                WHERE
                    YEAR(fecha) = YEAR(@Fecha) AND MONTH(fecha) = MONTH(@Fecha)
                GROUP BY 
                    YEAR(fecha), MONTH(fecha);";

                dgvVentas.DataSource = consultas.ActualizarTabla(ventasMensualesQuery);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            Hide();

        }

        private void dgvVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
