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
    public partial class RealizarVenta : Form
    {
        Consultas consultas = new Consultas();
        public RealizarVenta()
        {
            InitializeComponent();
            dataGridView1.DataSource = consultas.ActualizarTabla("tbl_productos");
            dataGridView2.DataSource = consultas.ActualizarTabla("tbl_clientes");
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
