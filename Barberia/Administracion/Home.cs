using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
using Barberia.Administracion;

namespace Barberia
{
    public partial class Home : Form
    {
        public int IDUSUARIO { get; set; }
        public Home()
        {
            InitializeComponent();
           
        }
        public Home(int id)
        {
            InitializeComponent();
            this.IDUSUARIO = id;
        }
        string tbl = "";
        string consulta = "";
        Consultas consultas = new Consultas();
        // bonotes para abrir otros formn
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
        //-----------------fin de botones para abrir otros formularios
//botones para mostrar informacion

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
        //-----------------fin de botones para mostrar informacion
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

        //txt para buscar 
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
        // btn para exportar
        private void btnImportar_Click(object sender, EventArgs e)
        {
            if (rbtnExcel.Checked)
            {
                exportarExcel(dgvMostrar);
            }
            else if (rbtnPdf.Checked)
            {
                exportarPDF(dgvMostrar);
            }
            else
            {
                MessageBox.Show("Por favor seleccione en que lo quiere importar");
            }
        }
        // funcion para exportar a excel
        public void exportarExcel(DataGridView dgv)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);
            int indiceColumna = 0;
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                indiceColumna++;
                excel.Cells[1, indiceColumna] = col.Name;
            }
            int indiceFila = 0;
            foreach (DataGridViewRow row in dgv.Rows)
            {
                indiceFila++;
                indiceColumna = 0;
                foreach (DataGridViewColumn col in dgv.Columns)
                {
                    indiceColumna++;
                    excel.Cells[indiceFila + 1, indiceColumna] = row.Cells[col.Name].Value;
                }
            }
            excel.Visible = true;
        }
        //funcion para exportar a pdf
        private static void exportarPDF(DataGridView dgvMostrar)
        {
            // Create and configure the save file dialog
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
            saveFileDialog.Title = "Save PDF File";
            saveFileDialog.FileName = "test.pdf";

            // Show the dialog and check if the user clicked the save button
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Create a new PDF document with landscape A4 size
                Document doc = new Document(PageSize.A4.Rotate());
                try
                {
                    // Get the instance of the PDF writer
                    PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(saveFileDialog.FileName, FileMode.Create));
                    doc.Open();

                    // Create a new PDF table with the same number of columns as the DataGridView
                    PdfPTable pdfTable = new PdfPTable(dgvMostrar.ColumnCount);
                    pdfTable.DefaultCell.Padding = 3;
                    pdfTable.WidthPercentage = 100;
                    pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
                    pdfTable.DefaultCell.BorderWidth = 1;

                    // Add the headers from the DataGridView to the PDF table
                    foreach (DataGridViewColumn column in dgvMostrar.Columns)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                        pdfTable.AddCell(cell);
                    }

                    // Add the rows from the DataGridView to the PDF table
                    foreach (DataGridViewRow row in dgvMostrar.Rows)
                    {
                        // Avoid adding the empty row at the end
                        if (!row.IsNewRow)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                // Check for null values in cells
                                pdfTable.AddCell(cell.Value?.ToString() ?? string.Empty);
                            }
                        }
                    }

                    // Add the table to the PDF document
                    doc.Add(pdfTable);
                }
                catch (Exception ex)
                {
                    // Handle exceptions
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    // Close the document
                    doc.Close();
                }
            }
        }

        // fin de funciones para exportar

        // btn para abrir formn
        private void btnAgendarCita_Click(object sender, EventArgs e)
        {
            GenerarCita generarCita = new GenerarCita();
            generarCita.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        // fin de botones para abrir formn
       
    }
}
