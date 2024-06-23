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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            txtFiltrarNombre = new TextBox();
            btnBuscarFiltro = new Button();
            btnMostrarProductos = new Button();
            btnMostrarClientes = new Button();
            btnMostrarUsuarios = new Button();
            btnRealizarVentas = new Button();
            btnAgendarCita = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnGestionUsuarios
            // 
            btnGestionUsuarios.Location = new Point(12, 12);
            btnGestionUsuarios.Name = "btnGestionUsuarios";
            btnGestionUsuarios.Size = new Size(210, 41);
            btnGestionUsuarios.TabIndex = 0;
            btnGestionUsuarios.Text = "Usuarios";
            btnGestionUsuarios.UseVisualStyleBackColor = true;
            btnGestionUsuarios.Click += btnGestionUsuarios_Click;
            // 
            // btnGestionClientes
            // 
            btnGestionClientes.Location = new Point(228, 12);
            btnGestionClientes.Name = "btnGestionClientes";
            btnGestionClientes.Size = new Size(223, 41);
            btnGestionClientes.TabIndex = 1;
            btnGestionClientes.Text = "Clientes";
            btnGestionClientes.UseVisualStyleBackColor = true;
            btnGestionClientes.Click += btnGestionClientes_Click;
            // 
            // btnGestionProductos
            // 
            btnGestionProductos.Location = new Point(457, 12);
            btnGestionProductos.Name = "btnGestionProductos";
            btnGestionProductos.Size = new Size(223, 41);
            btnGestionProductos.TabIndex = 2;
            btnGestionProductos.Text = "Productos";
            btnGestionProductos.UseVisualStyleBackColor = true;
            btnGestionProductos.Click += btnGestionProductos_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 275);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1240, 354);
            dataGridView1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 241);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 4;
            label1.Text = "Nombre:";
            // 
            // txtFiltrarNombre
            // 
            txtFiltrarNombre.Location = new Point(95, 238);
            txtFiltrarNombre.Name = "txtFiltrarNombre";
            txtFiltrarNombre.Size = new Size(234, 27);
            txtFiltrarNombre.TabIndex = 5;
            // 
            // btnBuscarFiltro
            // 
            btnBuscarFiltro.Location = new Point(357, 224);
            btnBuscarFiltro.Name = "btnBuscarFiltro";
            btnBuscarFiltro.Size = new Size(180, 41);
            btnBuscarFiltro.TabIndex = 6;
            btnBuscarFiltro.Text = "Buscar";
            btnBuscarFiltro.UseVisualStyleBackColor = true;
            // 
            // btnMostrarProductos
            // 
            btnMostrarProductos.Location = new Point(1039, 224);
            btnMostrarProductos.Name = "btnMostrarProductos";
            btnMostrarProductos.Size = new Size(223, 41);
            btnMostrarProductos.TabIndex = 9;
            btnMostrarProductos.Text = "Productos";
            btnMostrarProductos.UseVisualStyleBackColor = true;
            // 
            // btnMostrarClientes
            // 
            btnMostrarClientes.Location = new Point(810, 224);
            btnMostrarClientes.Name = "btnMostrarClientes";
            btnMostrarClientes.Size = new Size(223, 41);
            btnMostrarClientes.TabIndex = 8;
            btnMostrarClientes.Text = "Clientes";
            btnMostrarClientes.UseVisualStyleBackColor = true;
            // 
            // btnMostrarUsuarios
            // 
            btnMostrarUsuarios.Location = new Point(594, 224);
            btnMostrarUsuarios.Name = "btnMostrarUsuarios";
            btnMostrarUsuarios.Size = new Size(210, 41);
            btnMostrarUsuarios.TabIndex = 7;
            btnMostrarUsuarios.Text = "Usuarios";
            btnMostrarUsuarios.UseVisualStyleBackColor = true;
            // 
            // btnRealizarVentas
            // 
            btnRealizarVentas.Location = new Point(1009, 12);
            btnRealizarVentas.Name = "btnRealizarVentas";
            btnRealizarVentas.Size = new Size(253, 49);
            btnRealizarVentas.TabIndex = 10;
            btnRealizarVentas.Text = "Realizar Venta";
            btnRealizarVentas.UseVisualStyleBackColor = true;
            // 
            // btnAgendarCita
            // 
            btnAgendarCita.Location = new Point(1009, 67);
            btnAgendarCita.Name = "btnAgendarCita";
            btnAgendarCita.Size = new Size(253, 49);
            btnAgendarCita.TabIndex = 11;
            btnAgendarCita.Text = "Agendar Cita";
            btnAgendarCita.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1274, 646);
            Controls.Add(btnAgendarCita);
            Controls.Add(btnRealizarVentas);
            Controls.Add(btnMostrarProductos);
            Controls.Add(btnMostrarClientes);
            Controls.Add(btnMostrarUsuarios);
            Controls.Add(btnBuscarFiltro);
            Controls.Add(txtFiltrarNombre);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(btnGestionProductos);
            Controls.Add(btnGestionClientes);
            Controls.Add(btnGestionUsuarios);
            Name = "Home";
            Text = "Home";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGestionUsuarios;
        private Button btnGestionClientes;
        private Button btnGestionProductos;
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox txtFiltrarNombre;
        private Button btnBuscarFiltro;
        private Button btnMostrarProductos;
        private Button btnMostrarClientes;
        private Button btnMostrarUsuarios;
        private Button btnRealizarVentas;
        private Button btnAgendarCita;
    }
}