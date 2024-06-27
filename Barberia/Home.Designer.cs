namespace Barberia
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
            label1 = new Label();
            txtFiltrarNombre = new TextBox();
            btnBuscarFiltro = new Button();
            btnMostrarProductos = new Button();
            btnMostrarClientes = new Button();
            btnMostrarBarberos = new Button();
            btnRealizarVentas = new Button();
            btnAgendarCita = new Button();
            button1 = new Button();
            button2 = new Button();
            grpGestiones = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvMostrar).BeginInit();
            grpGestiones.SuspendLayout();
            SuspendLayout();
            // 
            // btnGestionUsuarios
            // 
            btnGestionUsuarios.BackColor = Color.FromArgb(14, 93, 136);
            btnGestionUsuarios.Cursor = Cursors.Hand;
            btnGestionUsuarios.ForeColor = Color.White;
            btnGestionUsuarios.Location = new Point(80, 73);
            btnGestionUsuarios.Name = "btnGestionUsuarios";
            btnGestionUsuarios.Size = new Size(210, 41);
            btnGestionUsuarios.TabIndex = 0;
            btnGestionUsuarios.Text = "Usuarios";
            btnGestionUsuarios.UseVisualStyleBackColor = false;
            btnGestionUsuarios.Click += btnGestionUsuarios_Click;
            // 
            // btnGestionClientes
            // 
            btnGestionClientes.BackColor = Color.FromArgb(14, 93, 136);
            btnGestionClientes.Cursor = Cursors.Hand;
            btnGestionClientes.ForeColor = Color.White;
            btnGestionClientes.Location = new Point(80, 313);
            btnGestionClientes.Name = "btnGestionClientes";
            btnGestionClientes.Size = new Size(210, 41);
            btnGestionClientes.TabIndex = 1;
            btnGestionClientes.Text = "Clientes";
            btnGestionClientes.UseVisualStyleBackColor = false;
            btnGestionClientes.Click += btnGestionClientes_Click;
            // 
            // btnGestionProductos
            // 
            btnGestionProductos.BackColor = Color.FromArgb(14, 93, 136);
            btnGestionProductos.Cursor = Cursors.Hand;
            btnGestionProductos.ForeColor = Color.White;
            btnGestionProductos.Location = new Point(80, 149);
            btnGestionProductos.Name = "btnGestionProductos";
            btnGestionProductos.Size = new Size(210, 41);
            btnGestionProductos.TabIndex = 2;
            btnGestionProductos.Text = "Productos";
            btnGestionProductos.UseVisualStyleBackColor = false;
            btnGestionProductos.Click += btnGestionProductos_Click;
            // 
            // dgvMostrar
            // 
            dgvMostrar.AllowUserToAddRows = false;
            dgvMostrar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMostrar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(14, 93, 136);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvMostrar.DefaultCellStyle = dataGridViewCellStyle1;
            dgvMostrar.Location = new Point(24, 232);
            dgvMostrar.Name = "dgvMostrar";
            dgvMostrar.RowHeadersWidth = 51;
            dgvMostrar.Size = new Size(1359, 555);
            dgvMostrar.TabIndex = 3;
            dgvMostrar.CellContentClick += dgvMostrar_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 189);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 4;
            label1.Text = "Nombre:";
            // 
            // txtFiltrarNombre
            // 
            txtFiltrarNombre.Location = new Point(98, 186);
            txtFiltrarNombre.Name = "txtFiltrarNombre";
            txtFiltrarNombre.Size = new Size(234, 27);
            txtFiltrarNombre.TabIndex = 5;
            // 
            // btnBuscarFiltro
            // 
            btnBuscarFiltro.BackColor = Color.FromArgb(14, 93, 136);
            btnBuscarFiltro.Cursor = Cursors.Hand;
            btnBuscarFiltro.ForeColor = Color.White;
            btnBuscarFiltro.Location = new Point(360, 172);
            btnBuscarFiltro.Name = "btnBuscarFiltro";
            btnBuscarFiltro.Size = new Size(180, 41);
            btnBuscarFiltro.TabIndex = 6;
            btnBuscarFiltro.Text = "Buscar";
            btnBuscarFiltro.UseVisualStyleBackColor = false;
            btnBuscarFiltro.Click += btnBuscarFiltro_Click;
            // 
            // btnMostrarProductos
            // 
            btnMostrarProductos.BackColor = Color.FromArgb(14, 93, 136);
            btnMostrarProductos.Cursor = Cursors.Hand;
            btnMostrarProductos.ForeColor = Color.White;
            btnMostrarProductos.Location = new Point(771, 823);
            btnMostrarProductos.Name = "btnMostrarProductos";
            btnMostrarProductos.Size = new Size(223, 58);
            btnMostrarProductos.TabIndex = 9;
            btnMostrarProductos.Text = "Productos";
            btnMostrarProductos.UseVisualStyleBackColor = false;
            btnMostrarProductos.Click += btnMostrarProductos_Click;
            // 
            // btnMostrarClientes
            // 
            btnMostrarClientes.BackColor = Color.FromArgb(14, 93, 136);
            btnMostrarClientes.Cursor = Cursors.Hand;
            btnMostrarClientes.ForeColor = Color.White;
            btnMostrarClientes.Location = new Point(542, 823);
            btnMostrarClientes.Name = "btnMostrarClientes";
            btnMostrarClientes.Size = new Size(223, 58);
            btnMostrarClientes.TabIndex = 8;
            btnMostrarClientes.Text = "Clientes";
            btnMostrarClientes.UseVisualStyleBackColor = false;
            btnMostrarClientes.Click += btnMostrarClientes_Click;
            // 
            // btnMostrarBarberos
            // 
            btnMostrarBarberos.BackColor = Color.FromArgb(14, 93, 136);
            btnMostrarBarberos.Cursor = Cursors.Hand;
            btnMostrarBarberos.ForeColor = Color.White;
            btnMostrarBarberos.Location = new Point(326, 823);
            btnMostrarBarberos.Name = "btnMostrarBarberos";
            btnMostrarBarberos.Size = new Size(210, 58);
            btnMostrarBarberos.TabIndex = 7;
            btnMostrarBarberos.Text = "Barberos";
            btnMostrarBarberos.UseVisualStyleBackColor = false;
            btnMostrarBarberos.Click += btnMostrarUsuarios_Click;
            // 
            // btnRealizarVentas
            // 
            btnRealizarVentas.BackColor = Color.FromArgb(14, 93, 136);
            btnRealizarVentas.Cursor = Cursors.Hand;
            btnRealizarVentas.FlatAppearance.BorderColor = Color.CadetBlue;
            btnRealizarVentas.FlatAppearance.BorderSize = 2;
            btnRealizarVentas.ForeColor = Color.White;
            btnRealizarVentas.Location = new Point(1550, 243);
            btnRealizarVentas.Name = "btnRealizarVentas";
            btnRealizarVentas.Size = new Size(253, 49);
            btnRealizarVentas.TabIndex = 10;
            btnRealizarVentas.Text = "Realizar Venta";
            btnRealizarVentas.UseVisualStyleBackColor = false;
            btnRealizarVentas.Click += btnRealizarVentas_Click;
            // 
            // btnAgendarCita
            // 
            btnAgendarCita.BackColor = Color.FromArgb(14, 93, 136);
            btnAgendarCita.ForeColor = Color.White;
            btnAgendarCita.Location = new Point(1550, 298);
            btnAgendarCita.Name = "btnAgendarCita";
            btnAgendarCita.Size = new Size(253, 49);
            btnAgendarCita.TabIndex = 11;
            btnAgendarCita.Text = "Agendar Cita";
            btnAgendarCita.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(14, 93, 136);
            button1.Cursor = Cursors.Hand;
            button1.ForeColor = Color.White;
            button1.Location = new Point(80, 395);
            button1.Name = "button1";
            button1.Size = new Size(210, 41);
            button1.TabIndex = 12;
            button1.Text = "Citas";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(14, 93, 136);
            button2.Cursor = Cursors.Hand;
            button2.ForeColor = Color.White;
            button2.Location = new Point(80, 232);
            button2.Name = "button2";
            button2.Size = new Size(210, 41);
            button2.TabIndex = 13;
            button2.Text = "Ventas";
            button2.UseVisualStyleBackColor = false;
            // 
            // grpGestiones
            // 
            grpGestiones.BackColor = Color.WhiteSmoke;
            grpGestiones.Controls.Add(btnGestionUsuarios);
            grpGestiones.Controls.Add(button1);
            grpGestiones.Controls.Add(button2);
            grpGestiones.Controls.Add(btnGestionProductos);
            grpGestiones.Controls.Add(btnGestionClientes);
            grpGestiones.Location = new Point(1488, 445);
            grpGestiones.Name = "grpGestiones";
            grpGestiones.Size = new Size(360, 505);
            grpGestiones.TabIndex = 14;
            grpGestiones.TabStop = false;
            grpGestiones.Text = "Gestión de Datos";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1924, 1055);
            Controls.Add(grpGestiones);
            Controls.Add(btnAgendarCita);
            Controls.Add(btnRealizarVentas);
            Controls.Add(btnMostrarProductos);
            Controls.Add(btnMostrarClientes);
            Controls.Add(btnMostrarBarberos);
            Controls.Add(btnBuscarFiltro);
            Controls.Add(txtFiltrarNombre);
            Controls.Add(label1);
            Controls.Add(dgvMostrar);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            Load += Home_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMostrar).EndInit();
            grpGestiones.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGestionUsuarios;
        private Button btnGestionClientes;
        private Button btnGestionProductos;
        private DataGridView dgvMostrar;
        private Label label1;
        private TextBox txtFiltrarNombre;
        private Button btnBuscarFiltro;
        private Button btnMostrarProductos;
        private Button btnMostrarClientes;
        private Button btnMostrarBarberos;
        private Button btnRealizarVentas;
        private Button btnAgendarCita;
        private Button button1;
        private Button button2;
        private GroupBox grpGestiones;
    }
}