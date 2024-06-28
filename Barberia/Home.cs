using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barberia
{
    public partial class Home : Form
    {
        public int IDUSUARIO { get; set; }
        public Home(int id)
        {
            InitializeComponent();
            this.IDUSUARIO = id;
        }
        string tbl = "";
        string consulta = "";
        Consultas consultas = new Consultas();
        private void btnGestionUsuarios_Click(object sender, EventArgs e)
        {
            GestionUsuario AbriGestionUsuario = new GestionUsuario();
            AbriGestionUsuario.Show();
            Hide();
        }

        private void btnGestionClientes_Click(object sender, EventArgs e)
        {
            GestionCliente AbrirGestionCliente = new GestionCliente();
            AbrirGestionCliente.Show();
            Hide();
        }

        private void btnGestionProductos_Click(object sender, EventArgs e)
        {
            GestionProducto AbrirGestionProducto = new GestionProducto();
            AbrirGestionProducto.Show();
            Hide();
        }

        private void btnBuscarFiltro_Click(object sender, EventArgs e)
        {
            if (txtFiltrarNombre.Text != null)// verificamos que el campo no este vacio
            {
                // verificabos que tabla es y creamos la consulta

                dgvMostrar.DataSource = consultas.Buscardato(tbl, txtFiltrarNombre.Text);

            }
            else
            {
                MessageBox.Show("Asegurese de que la casilla 'Nombre' no este vacia");
            }
        }

        private void btnMostrarUsuarios_Click(object sender, EventArgs e)
        {
            dgvMostrar.Visible = true;
            lblFiltroNombre.Visible = true;
            txtFiltrarNombre.Visible = true;
            tbl = "tbl_barberos";
            dgvMostrar.DataSource = consultas.ActualizarTabla(tbl);
        }

        private void btnMostrarClientes_Click(object sender, EventArgs e)
        {
            dgvMostrar.Visible = true;
            lblFiltroNombre.Visible = true;
            txtFiltrarNombre.Visible = true;
            tbl = "tbl_clientes";
            dgvMostrar.DataSource = consultas.ActualizarTabla(tbl);
        }

        private void btnMostrarProductos_Click(object sender, EventArgs e)
        {
            dgvMostrar.Visible = true;
            lblFiltroNombre.Visible = true;
            txtFiltrarNombre.Visible = true;
            tbl = "tbl_productos";

            dgvMostrar.DataSource = consultas.ActualizarTabla(tbl);

        }

        private void dgvMostrar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRealizarVentas_Click(object sender, EventArgs e)
        {
            // abrir formulario de ventas
            RealizarVenta AbrirRealizarVenta = new RealizarVenta();
            AbrirRealizarVenta.Show();
            Hide();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void txtFiltrarNombre_TextChanged(object sender, EventArgs e)
        {
            string filtroNombre = txtFiltrarNombre.Text;

            if (!string.IsNullOrEmpty(filtroNombre))
            {

                dgvMostrar.DataSource = consultas.Buscardato(tbl, filtroNombre);
            }
            else
            {
                dgvMostrar.DataSource = consultas.ActualizarTabla(tbl);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InicioDeSecion inicioDeSecion = new InicioDeSecion();
            inicioDeSecion.Show();
            Hide();
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            if(rbtnExcel.Checked)
            {

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "CSV Files|*.csv";
                saveFileDialog.Title = "Guardar como CSV";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ExportDataGridViewToCSV(dgvMostrar, saveFileDialog.FileName);
                }
            }
            else if(rbtnPdf.Checked)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF Files|*.pdf";
                saveFileDialog.Title = "Guardar como PDF";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ExportDataGridViewToPDF(dgvMostrar, saveFileDialog.FileName);
                    MessageBox.Show("Exportación a PDF completada.");
                }
            }
            else
            {
                MessageBox.Show("Por favor seleccione en que lo quiere importar");
            }
        }
        private void ExportDataGridViewToHTML(DataGridView dgv, string filename)
        {
            using (StreamWriter sw = new StreamWriter(filename))
            {
                sw.WriteLine("<html><head><style>table { width: 100%; border-collapse: collapse; } th, td { border: 1px solid black; padding: 8px; text-align: left; }</style></head><body>");
                sw.WriteLine("<table>");

                // Agregar los encabezados de columna
                sw.WriteLine("<tr>");
                foreach (DataGridViewColumn column in dgv.Columns)
                {
                    sw.WriteLine($"<th>{column.HeaderText}</th>");
                }
                sw.WriteLine("</tr>");

                // Agregar las filas del DataGridView
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    sw.WriteLine("<tr>");
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        sw.WriteLine($"<td>{cell.Value?.ToString()}</td>");
                    }
                    sw.WriteLine("</tr>");
                }

                sw.WriteLine("</table>");
                sw.WriteLine("</body></html>");
            }
        }
        private void PrintHTMLToPDF(string htmlFilename, string pdfFilename)
        {
            var startInfo = new System.Diagnostics.ProcessStartInfo
            {
                FileName = htmlFilename,
                Verb = "print",
                CreateNoWindow = true,
                WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
            };

            using (var process = new System.Diagnostics.Process { StartInfo = startInfo })
            {
                process.Start();
            }
        }

        private void ExportDataGridViewToPDF(DataGridView dgv, string pdfFilename)
        {
            // Generar un archivo HTML temporal
            string tempHtmlFilename = Path.Combine(Path.GetTempPath(), "temp.html");
            ExportDataGridViewToHTML(dgv, tempHtmlFilename);

            // Imprimir el archivo HTML como PDF
            PrintHTMLToPDF(tempHtmlFilename, pdfFilename);

            // Eliminar el archivo HTML temporal
            File.Delete(tempHtmlFilename);
        }

        private void ExportDataGridViewToCSV(DataGridView dgv, string filename)
        {
            using (StreamWriter sw = new StreamWriter(filename))
            {
                // Escribir encabezados de columna
                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    sw.Write(dgv.Columns[i].HeaderText);
                    if (i < dgv.Columns.Count - 1) sw.Write(",");
                }
                sw.WriteLine();

                // Escribir filas
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    for (int i = 0; i < dgv.Columns.Count; i++)
                    {
                        sw.Write(row.Cells[i].Value?.ToString());
                        if (i < dgv.Columns.Count - 1) sw.Write(",");
                    }
                    sw.WriteLine();
                }
            }

            MessageBox.Show("Exportación a CSV completada.");
        }


    }
}
