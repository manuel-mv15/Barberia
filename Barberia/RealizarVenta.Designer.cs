﻿namespace Barberia
{
    partial class RealizarVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnHome = new Button();
            nupCantidad = new NumericUpDown();
            dgvMostrarDatos = new DataGridView();
            dgvVenta = new DataGridView();
            btnProductos = new Button();
            btnClientes = new Button();
            textBox1 = new TextBox();
            btnBuscar = new Button();
            btnAgregar = new Button();
            btnComprar = new Button();
            btnEliminar = new Button();
            btnVentas = new Button();
            label1 = new Label();
            mtbFechaFacturacion = new MaskedTextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)nupCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMostrarDatos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvVenta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(14, 93, 136);
            btnHome.Font = new Font("Sitka Small", 9F, FontStyle.Bold);
            btnHome.ForeColor = SystemColors.Control;
            btnHome.Location = new Point(190, 181);
            btnHome.Margin = new Padding(1);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(139, 39);
            btnHome.TabIndex = 2;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // nupCantidad
            // 
            nupCantidad.Location = new Point(447, 312);
            nupCantidad.Margin = new Padding(1);
            nupCantidad.Name = "nupCantidad";
            nupCantidad.Size = new Size(170, 27);
            nupCantidad.TabIndex = 3;
            // 
            // dgvMostrarDatos
            // 
            dgvMostrarDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMostrarDatos.Location = new Point(35, 352);
            dgvMostrarDatos.Margin = new Padding(1);
            dgvMostrarDatos.Name = "dgvMostrarDatos";
            dgvMostrarDatos.RowHeadersVisible = false;
            dgvMostrarDatos.RowHeadersWidth = 102;
            dgvMostrarDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMostrarDatos.Size = new Size(959, 677);
            dgvMostrarDatos.TabIndex = 0;
            // 
            // dgvVenta
            // 
            dgvVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVenta.Location = new Point(1025, 352);
            dgvVenta.Margin = new Padding(1);
            dgvVenta.Name = "dgvVenta";
            dgvVenta.RowHeadersWidth = 102;
            dgvVenta.Size = new Size(871, 677);
            dgvVenta.TabIndex = 4;
            dgvVenta.CellContentClick += dataGridView3_CellContentClick;
            // 
            // btnProductos
            // 
            btnProductos.BackColor = Color.FromArgb(14, 93, 136);
            btnProductos.Font = new Font("Sitka Small", 9F, FontStyle.Bold);
            btnProductos.ForeColor = SystemColors.Control;
            btnProductos.Location = new Point(35, 237);
            btnProductos.Margin = new Padding(1);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(139, 39);
            btnProductos.TabIndex = 5;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = false;
            btnProductos.Click += button2_Click;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.FromArgb(14, 93, 136);
            btnClientes.Font = new Font("Sitka Small", 9F, FontStyle.Bold);
            btnClientes.ForeColor = SystemColors.Control;
            btnClientes.Location = new Point(35, 181);
            btnClientes.Margin = new Padding(1);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(139, 39);
            btnClientes.TabIndex = 6;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(35, 313);
            textBox1.Margin = new Padding(1);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(242, 27);
            textBox1.TabIndex = 7;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(14, 93, 136);
            btnBuscar.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = SystemColors.Control;
            btnBuscar.Location = new Point(293, 297);
            btnBuscar.Margin = new Padding(1);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(134, 43);
            btnBuscar.TabIndex = 8;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += button4_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(14, 93, 136);
            btnAgregar.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = SystemColors.Control;
            btnAgregar.Location = new Point(872, 297);
            btnAgregar.Margin = new Padding(1);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(122, 43);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnComprar
            // 
            btnComprar.BackColor = Color.FromArgb(14, 93, 136);
            btnComprar.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnComprar.ForeColor = SystemColors.Control;
            btnComprar.Location = new Point(1025, 295);
            btnComprar.Margin = new Padding(1);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(128, 43);
            btnComprar.TabIndex = 12;
            btnComprar.Text = "Comprar";
            btnComprar.UseVisualStyleBackColor = false;
            btnComprar.Click += btnComprar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(14, 93, 136);
            btnEliminar.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = SystemColors.Control;
            btnEliminar.Location = new Point(1170, 295);
            btnEliminar.Margin = new Padding(1);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(135, 43);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnVentas
            // 
            btnVentas.BackColor = Color.FromArgb(14, 93, 136);
            btnVentas.Font = new Font("Sitka Small", 9F, FontStyle.Bold);
            btnVentas.ForeColor = SystemColors.Control;
            btnVentas.Location = new Point(190, 237);
            btnVentas.Margin = new Padding(1);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(139, 39);
            btnVentas.TabIndex = 14;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(633, 276);
            label1.Name = "label1";
            label1.Size = new Size(186, 23);
            label1.TabIndex = 15;
            label1.Text = "Fecha de Facturacion:";
            // 
            // mtbFechaFacturacion
            // 
            mtbFechaFacturacion.Location = new Point(639, 311);
            mtbFechaFacturacion.Mask = "0000/00/00 00:00:00";
            mtbFechaFacturacion.Name = "mtbFechaFacturacion";
            mtbFechaFacturacion.Size = new Size(180, 27);
            mtbFechaFacturacion.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Small", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(152, 36);
            label2.Name = "label2";
            label2.Size = new Size(236, 88);
            label2.TabIndex = 19;
            label2.Text = "       Manolo  \r\n  Barber Shop\r\n";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.barbero__3_;
            pictureBox1.Location = new Point(35, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 143);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Small", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(779, 36);
            label3.Name = "label3";
            label3.Size = new Size(394, 118);
            label3.TabIndex = 20;
            label3.Text = "VENTAS";
            // 
            // RealizarVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(mtbFechaFacturacion);
            Controls.Add(label1);
            Controls.Add(btnVentas);
            Controls.Add(btnEliminar);
            Controls.Add(btnComprar);
            Controls.Add(btnAgregar);
            Controls.Add(btnBuscar);
            Controls.Add(textBox1);
            Controls.Add(btnClientes);
            Controls.Add(btnProductos);
            Controls.Add(dgvVenta);
            Controls.Add(nupCantidad);
            Controls.Add(btnHome);
            Controls.Add(dgvMostrarDatos);
            Margin = new Padding(1);
            Name = "RealizarVenta";
            Text = "Realizar Venta — Manolo Barber Shop";
            ((System.ComponentModel.ISupportInitialize)nupCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMostrarDatos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvVenta).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnHome;
        private NumericUpDown nupCantidad;
        private DataGridView dgvMostrarDatos;
        private DataGridView dgvVenta;
        private Button btnProductos;
        private Button btnClientes;
        private TextBox textBox1;
        private Button btnBuscar;
        private Button btnAgregar;
        private Button btnComprar;
        private Button btnEliminar;
        private Button btnVentas;
        private Label label1;
        private MaskedTextBox mtbFechaFacturacion;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
    }
}