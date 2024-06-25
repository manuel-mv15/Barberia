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
            ((System.ComponentModel.ISupportInitialize)dgvMostrar).BeginInit();
            SuspendLayout();
            // 
            // btnGestionUsuarios
            // 
            btnGestionUsuarios.Location = new Point(26, 25);
            btnGestionUsuarios.Margin = new Padding(6);
            btnGestionUsuarios.Name = "btnGestionUsuarios";
            btnGestionUsuarios.Size = new Size(446, 84);
            btnGestionUsuarios.TabIndex = 0;
            btnGestionUsuarios.Text = "Usuarios";
            btnGestionUsuarios.UseVisualStyleBackColor = true;
            btnGestionUsuarios.Click += btnGestionUsuarios_Click;
            // 
            // btnGestionClientes
            // 
            btnGestionClientes.Location = new Point(26, 121);
            btnGestionClientes.Margin = new Padding(6);
            btnGestionClientes.Name = "btnGestionClientes";
            btnGestionClientes.Size = new Size(447, 84);
            btnGestionClientes.TabIndex = 1;
            btnGestionClientes.Text = "Clientes";
            btnGestionClientes.UseVisualStyleBackColor = true;
            btnGestionClientes.Click += btnGestionClientes_Click;
            // 
            // btnGestionProductos
            // 
            btnGestionProductos.Location = new Point(484, 25);
            btnGestionProductos.Margin = new Padding(6);
            btnGestionProductos.Name = "btnGestionProductos";
            btnGestionProductos.Size = new Size(447, 84);
            btnGestionProductos.TabIndex = 2;
            btnGestionProductos.Text = "Productos";
            btnGestionProductos.UseVisualStyleBackColor = true;
            btnGestionProductos.Click += btnGestionProductos_Click;
            // 
            // dgvMostrar
            // 
            dgvMostrar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMostrar.Location = new Point(47, 564);
            dgvMostrar.Margin = new Padding(6);
            dgvMostrar.Name = "dgvMostrar";
            dgvMostrar.RowHeadersWidth = 51;
            dgvMostrar.Size = new Size(2635, 726);
            dgvMostrar.TabIndex = 3;
            dgvMostrar.CellContentClick += dgvMostrar_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 494);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(135, 41);
            label1.TabIndex = 4;
            label1.Text = "Nombre:";
            // 
            // txtFiltrarNombre
            // 
            txtFiltrarNombre.Location = new Point(202, 488);
            txtFiltrarNombre.Margin = new Padding(6);
            txtFiltrarNombre.Name = "txtFiltrarNombre";
            txtFiltrarNombre.Size = new Size(493, 47);
            txtFiltrarNombre.TabIndex = 5;
            // 
            // btnBuscarFiltro
            // 
            btnBuscarFiltro.Location = new Point(759, 459);
            btnBuscarFiltro.Margin = new Padding(6);
            btnBuscarFiltro.Name = "btnBuscarFiltro";
            btnBuscarFiltro.Size = new Size(382, 84);
            btnBuscarFiltro.TabIndex = 6;
            btnBuscarFiltro.Text = "Buscar";
            btnBuscarFiltro.UseVisualStyleBackColor = true;
            btnBuscarFiltro.Click += btnBuscarFiltro_Click;
            // 
            // btnMostrarProductos
            // 
            btnMostrarProductos.Location = new Point(2208, 459);
            btnMostrarProductos.Margin = new Padding(6);
            btnMostrarProductos.Name = "btnMostrarProductos";
            btnMostrarProductos.Size = new Size(474, 84);
            btnMostrarProductos.TabIndex = 9;
            btnMostrarProductos.Text = "Productos";
            btnMostrarProductos.UseVisualStyleBackColor = true;
            btnMostrarProductos.Click += btnMostrarProductos_Click;
            // 
            // btnMostrarClientes
            // 
            btnMostrarClientes.Location = new Point(1721, 459);
            btnMostrarClientes.Margin = new Padding(6);
            btnMostrarClientes.Name = "btnMostrarClientes";
            btnMostrarClientes.Size = new Size(474, 84);
            btnMostrarClientes.TabIndex = 8;
            btnMostrarClientes.Text = "Clientes";
            btnMostrarClientes.UseVisualStyleBackColor = true;
            btnMostrarClientes.Click += btnMostrarClientes_Click;
            // 
            // btnMostrarBarberos
            // 
            btnMostrarBarberos.Location = new Point(1262, 459);
            btnMostrarBarberos.Margin = new Padding(6);
            btnMostrarBarberos.Name = "btnMostrarBarberos";
            btnMostrarBarberos.Size = new Size(446, 84);
            btnMostrarBarberos.TabIndex = 7;
            btnMostrarBarberos.Text = "Barberos";
            btnMostrarBarberos.UseVisualStyleBackColor = true;
            btnMostrarBarberos.Click += btnMostrarUsuarios_Click;
            // 
            // btnRealizarVentas
            // 
            btnRealizarVentas.Location = new Point(2144, 25);
            btnRealizarVentas.Margin = new Padding(6);
            btnRealizarVentas.Name = "btnRealizarVentas";
            btnRealizarVentas.Size = new Size(538, 100);
            btnRealizarVentas.TabIndex = 10;
            btnRealizarVentas.Text = "Realizar Venta";
            btnRealizarVentas.UseVisualStyleBackColor = true;
            btnRealizarVentas.Click += btnRealizarVentas_Click;
            // 
            // btnAgendarCita
            // 
            btnAgendarCita.Location = new Point(2144, 137);
            btnAgendarCita.Margin = new Padding(6);
            btnAgendarCita.Name = "btnAgendarCita";
            btnAgendarCita.Size = new Size(538, 100);
            btnAgendarCita.TabIndex = 11;
            btnAgendarCita.Text = "Agendar Cita";
            btnAgendarCita.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(484, 121);
            button1.Margin = new Padding(6);
            button1.Name = "button1";
            button1.Size = new Size(447, 84);
            button1.TabIndex = 12;
            button1.Text = "Citas";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(943, 25);
            button2.Margin = new Padding(6);
            button2.Name = "button2";
            button2.Size = new Size(447, 84);
            button2.TabIndex = 13;
            button2.Text = "Ventas";
            button2.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2707, 1324);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnAgendarCita);
            Controls.Add(btnRealizarVentas);
            Controls.Add(btnMostrarProductos);
            Controls.Add(btnMostrarClientes);
            Controls.Add(btnMostrarBarberos);
            Controls.Add(btnBuscarFiltro);
            Controls.Add(txtFiltrarNombre);
            Controls.Add(label1);
            Controls.Add(dgvMostrar);
            Controls.Add(btnGestionProductos);
            Controls.Add(btnGestionClientes);
            Controls.Add(btnGestionUsuarios);
            Margin = new Padding(6);
            Name = "Home";
            Text = "Home";
            ((System.ComponentModel.ISupportInitialize)dgvMostrar).EndInit();
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
    }
}