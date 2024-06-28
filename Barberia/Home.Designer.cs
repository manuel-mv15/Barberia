﻿namespace Barberia
{
    partial class Home
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            btnGestionUsuarios = new Button();
            btnGestionClientes = new Button();
            btnGestionProductos = new Button();
            dgvMostrar = new DataGridView();
            lblFiltroNombre = new Label();
            txtFiltrarNombre = new TextBox();
            btnMostrarProductos = new Button();
            btnMostrarClientes = new Button();
            btnMostrarBarberos = new Button();
            btnRealizarVentas = new Button();
            btnAgendarCita = new Button();
            button1 = new Button();
            button2 = new Button();
            btnCerrarSesion = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMostrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnGestionUsuarios
            // 
            btnGestionUsuarios.BackColor = Color.FromArgb(14, 93, 136);
            btnGestionUsuarios.Cursor = Cursors.Hand;
            btnGestionUsuarios.Font = new Font("Sitka Small", 9F, FontStyle.Bold);
            btnGestionUsuarios.ForeColor = Color.White;
            btnGestionUsuarios.Location = new Point(51, 472);
            btnGestionUsuarios.Name = "btnGestionUsuarios";
            btnGestionUsuarios.Size = new Size(253, 54);
            btnGestionUsuarios.TabIndex = 0;
            btnGestionUsuarios.Text = "Gestión de Usuarios";
            btnGestionUsuarios.UseVisualStyleBackColor = false;
            btnGestionUsuarios.Click += btnGestionUsuarios_Click;
            // 
            // btnGestionClientes
            // 
            btnGestionClientes.BackColor = Color.FromArgb(14, 93, 136);
            btnGestionClientes.Cursor = Cursors.Hand;
            btnGestionClientes.Font = new Font("Sitka Small", 9F, FontStyle.Bold);
            btnGestionClientes.ForeColor = Color.White;
            btnGestionClientes.Location = new Point(51, 552);
            btnGestionClientes.Name = "btnGestionClientes";
            btnGestionClientes.Size = new Size(253, 58);
            btnGestionClientes.TabIndex = 1;
            btnGestionClientes.Text = "Gestión de Clientes";
            btnGestionClientes.UseVisualStyleBackColor = false;
            btnGestionClientes.Click += btnGestionClientes_Click;
            // 
            // btnGestionProductos
            // 
            btnGestionProductos.BackColor = Color.FromArgb(14, 93, 136);
            btnGestionProductos.Cursor = Cursors.Hand;
            btnGestionProductos.Font = new Font("Sitka Small", 9F, FontStyle.Bold);
            btnGestionProductos.ForeColor = Color.White;
            btnGestionProductos.Location = new Point(51, 736);
            btnGestionProductos.Name = "btnGestionProductos";
            btnGestionProductos.Size = new Size(253, 57);
            btnGestionProductos.TabIndex = 2;
            btnGestionProductos.Text = "Gestión de Productos";
            btnGestionProductos.UseVisualStyleBackColor = false;
            btnGestionProductos.Click += btnGestionProductos_Click;
            // 
            // dgvMostrar
            // 
            dgvMostrar.AllowUserToAddRows = false;
            dgvMostrar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMostrar.BackgroundColor = Color.FromArgb(14, 93, 136);
            dgvMostrar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(14, 93, 136);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvMostrar.DefaultCellStyle = dataGridViewCellStyle1;
            dgvMostrar.Location = new Point(410, 299);
            dgvMostrar.Name = "dgvMostrar";
            dgvMostrar.RowHeadersWidth = 51;
            dgvMostrar.Size = new Size(1463, 675);
            dgvMostrar.TabIndex = 3;
            dgvMostrar.Visible = false;
            dgvMostrar.CellContentClick += dgvMostrar_CellContentClick;
            // 
            // lblFiltroNombre
            // 
            lblFiltroNombre.AutoSize = true;
            lblFiltroNombre.Font = new Font("Sitka Small", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFiltroNombre.Location = new Point(410, 249);
            lblFiltroNombre.Name = "lblFiltroNombre";
            lblFiltroNombre.Size = new Size(96, 26);
            lblFiltroNombre.TabIndex = 4;
            lblFiltroNombre.Text = "Nombre:";
            lblFiltroNombre.Visible = false;
            // 
            // txtFiltrarNombre
            // 
            txtFiltrarNombre.Location = new Point(512, 248);
            txtFiltrarNombre.Name = "txtFiltrarNombre";
            txtFiltrarNombre.Size = new Size(384, 27);
            txtFiltrarNombre.TabIndex = 5;
            txtFiltrarNombre.Visible = false;
            txtFiltrarNombre.TextChanged += txtFiltrarNombre_TextChanged;
            // 
            // btnMostrarProductos
            // 
            btnMostrarProductos.BackColor = Color.FromArgb(14, 93, 136);
            btnMostrarProductos.Cursor = Cursors.Hand;
            btnMostrarProductos.Font = new Font("Sitka Small", 9F, FontStyle.Bold);
            btnMostrarProductos.ForeColor = Color.White;
            btnMostrarProductos.Location = new Point(1380, 154);
            btnMostrarProductos.Name = "btnMostrarProductos";
            btnMostrarProductos.Size = new Size(253, 49);
            btnMostrarProductos.TabIndex = 9;
            btnMostrarProductos.Text = "Mostrar Productos";
            btnMostrarProductos.UseVisualStyleBackColor = false;
            btnMostrarProductos.Click += btnMostrarProductos_Click;
            // 
            // btnMostrarClientes
            // 
            btnMostrarClientes.BackColor = Color.FromArgb(14, 93, 136);
            btnMostrarClientes.Cursor = Cursors.Hand;
            btnMostrarClientes.Font = new Font("Sitka Small", 9F, FontStyle.Bold);
            btnMostrarClientes.ForeColor = Color.White;
            btnMostrarClientes.Location = new Point(1024, 154);
            btnMostrarClientes.Name = "btnMostrarClientes";
            btnMostrarClientes.Size = new Size(253, 49);
            btnMostrarClientes.TabIndex = 8;
            btnMostrarClientes.Text = "Mostrar Clientes";
            btnMostrarClientes.UseVisualStyleBackColor = false;
            btnMostrarClientes.Click += btnMostrarClientes_Click;
            // 
            // btnMostrarBarberos
            // 
            btnMostrarBarberos.BackColor = Color.FromArgb(14, 93, 136);
            btnMostrarBarberos.Cursor = Cursors.Hand;
            btnMostrarBarberos.Font = new Font("Sitka Small", 9F, FontStyle.Bold);
            btnMostrarBarberos.ForeColor = Color.White;
            btnMostrarBarberos.ImageAlign = ContentAlignment.MiddleLeft;
            btnMostrarBarberos.Location = new Point(665, 154);
            btnMostrarBarberos.Name = "btnMostrarBarberos";
            btnMostrarBarberos.Size = new Size(253, 49);
            btnMostrarBarberos.TabIndex = 7;
            btnMostrarBarberos.Text = "Mostar Barberos";
            btnMostrarBarberos.UseVisualStyleBackColor = false;
            btnMostrarBarberos.Click += btnMostrarUsuarios_Click;
            // 
            // btnRealizarVentas
            // 
            btnRealizarVentas.BackColor = Color.FromArgb(14, 93, 136);
            btnRealizarVentas.Cursor = Cursors.Hand;
            btnRealizarVentas.FlatAppearance.BorderColor = Color.CadetBlue;
            btnRealizarVentas.FlatAppearance.BorderSize = 2;
            btnRealizarVentas.Font = new Font("Sitka Small", 9F, FontStyle.Bold);
            btnRealizarVentas.ForeColor = Color.White;
            btnRealizarVentas.Location = new Point(51, 380);
            btnRealizarVentas.Name = "btnRealizarVentas";
            btnRealizarVentas.Size = new Size(253, 58);
            btnRealizarVentas.TabIndex = 10;
            btnRealizarVentas.Text = "Realizar Venta";
            btnRealizarVentas.UseVisualStyleBackColor = false;
            btnRealizarVentas.Click += btnRealizarVentas_Click;
            // 
            // btnAgendarCita
            // 
            btnAgendarCita.BackColor = Color.FromArgb(14, 93, 136);
            btnAgendarCita.Font = new Font("Sitka Small", 9F, FontStyle.Bold);
            btnAgendarCita.ForeColor = Color.White;
            btnAgendarCita.Location = new Point(51, 299);
            btnAgendarCita.Name = "btnAgendarCita";
            btnAgendarCita.Size = new Size(253, 55);
            btnAgendarCita.TabIndex = 11;
            btnAgendarCita.Text = "Agendar Cita";
            btnAgendarCita.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(14, 93, 136);
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Sitka Small", 9F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(51, 639);
            button1.Name = "button1";
            button1.Size = new Size(253, 57);
            button1.TabIndex = 12;
            button1.Text = "Gestión de Citas";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(14, 93, 136);
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Sitka Small", 9F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(51, 826);
            button2.Name = "button2";
            button2.Size = new Size(253, 59);
            button2.TabIndex = 13;
            button2.Text = "Gestión de Ventas";
            button2.UseVisualStyleBackColor = false;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.FromArgb(14, 93, 136);
            btnCerrarSesion.Font = new Font("Sitka Small", 9F, FontStyle.Bold);
            btnCerrarSesion.ForeColor = Color.White;
            btnCerrarSesion.Location = new Point(51, 918);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(253, 56);
            btnCerrarSesion.TabIndex = 15;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.barbero__3_;
            pictureBox1.Location = new Point(64, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 143);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Small", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(181, 69);
            label2.Name = "label2";
            label2.Size = new Size(236, 88);
            label2.TabIndex = 17;
            label2.Text = "       Manolo  \r\n  Barber Shop\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(846, 10);
            label1.Name = "label1";
            label1.Size = new Size(321, 118);
            label1.TabIndex = 18;
            label1.Text = "HOME";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1924, 1055);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnGestionProductos);
            Controls.Add(btnGestionUsuarios);
            Controls.Add(btnCerrarSesion);
            Controls.Add(btnGestionClientes);
            Controls.Add(btnAgendarCita);
            Controls.Add(btnRealizarVentas);
            Controls.Add(btnMostrarProductos);
            Controls.Add(btnMostrarClientes);
            Controls.Add(btnMostrarBarberos);
            Controls.Add(txtFiltrarNombre);
            Controls.Add(lblFiltroNombre);
            Controls.Add(dgvMostrar);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            Load += Home_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMostrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGestionUsuarios;
        private Button btnGestionClientes;
        private Button btnGestionProductos;
        private DataGridView dgvMostrar;
        private Label lblFiltroNombre;
        private TextBox txtFiltrarNombre;
        private Button btnMostrarProductos;
        private Button btnMostrarClientes;
        private Button btnMostrarBarberos;
        private Button btnRealizarVentas;
        private Button btnAgendarCita;
        private Button button1;
        private Button button2;
        private Button btnCerrarSesion;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
    }
}