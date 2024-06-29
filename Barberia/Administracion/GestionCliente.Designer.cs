namespace Barberia
{
    partial class GestionCliente
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
            btnHome = new Button();
            grpCliente = new GroupBox();
            mtxtDUI_Cliente = new MaskedTextBox();
            label9 = new Label();
            label8 = new Label();
            txtContraseña = new TextBox();
            txtUsuario = new TextBox();
            label7 = new Label();
            txtIDCliente = new TextBox();
            mtxtTelefono_Cliente = new MaskedTextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtCorreo_Electronico = new TextBox();
            txtDireccion_Cliente = new TextBox();
            txtApellido_Cliente = new TextBox();
            txtNombre_Cliente = new TextBox();
            dgvGestionarClientes = new DataGridView();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnAceptar = new Button();
            label10 = new Label();
            label11 = new Label();
            pictureBox1 = new PictureBox();
            grpCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGestionarClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(14, 93, 136);
            btnHome.Font = new Font("Sitka Small", 10.2F, FontStyle.Bold);
            btnHome.ForeColor = SystemColors.Control;
            btnHome.Location = new Point(1185, 440);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(202, 45);
            btnHome.TabIndex = 0;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // grpCliente
            // 
            grpCliente.Controls.Add(mtxtDUI_Cliente);
            grpCliente.Controls.Add(label9);
            grpCliente.Controls.Add(label8);
            grpCliente.Controls.Add(txtContraseña);
            grpCliente.Controls.Add(txtUsuario);
            grpCliente.Controls.Add(label7);
            grpCliente.Controls.Add(txtIDCliente);
            grpCliente.Controls.Add(mtxtTelefono_Cliente);
            grpCliente.Controls.Add(label4);
            grpCliente.Controls.Add(label5);
            grpCliente.Controls.Add(label6);
            grpCliente.Controls.Add(label3);
            grpCliente.Controls.Add(label2);
            grpCliente.Controls.Add(label1);
            grpCliente.Controls.Add(txtCorreo_Electronico);
            grpCliente.Controls.Add(txtDireccion_Cliente);
            grpCliente.Controls.Add(txtApellido_Cliente);
            grpCliente.Controls.Add(txtNombre_Cliente);
            grpCliente.Font = new Font("Sitka Small", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpCliente.Location = new Point(329, 233);
            grpCliente.Margin = new Padding(1);
            grpCliente.Name = "grpCliente";
            grpCliente.Padding = new Padding(1);
            grpCliente.Size = new Size(836, 261);
            grpCliente.TabIndex = 1;
            grpCliente.TabStop = false;
            grpCliente.Text = "DATOS PERSONALES DE CLIENTE.";
            grpCliente.Enter += groupBox1_Enter;
            // 
            // mtxtDUI_Cliente
            // 
            mtxtDUI_Cliente.Location = new Point(596, 50);
            mtxtDUI_Cliente.Margin = new Padding(1);
            mtxtDUI_Cliente.Mask = "00000000-0";
            mtxtDUI_Cliente.Name = "mtxtDUI_Cliente";
            mtxtDUI_Cliente.Size = new Size(209, 26);
            mtxtDUI_Cliente.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(428, 178);
            label9.Margin = new Padding(1, 0, 1, 0);
            label9.Name = "label9";
            label9.Size = new Size(103, 23);
            label9.TabIndex = 19;
            label9.Text = "Contraseña:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(428, 136);
            label8.Margin = new Padding(1, 0, 1, 0);
            label8.Name = "label8";
            label8.Size = new Size(76, 23);
            label8.TabIndex = 7;
            label8.Text = "Usuario:";
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(596, 174);
            txtContraseña.Margin = new Padding(1);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(209, 26);
            txtContraseña.TabIndex = 18;
            txtContraseña.KeyPress += txtContraseña_KeyPress;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(596, 130);
            txtUsuario.Margin = new Padding(1);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(209, 26);
            txtUsuario.TabIndex = 17;
            txtUsuario.KeyPress += txtUsuario_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(428, 94);
            label7.Margin = new Padding(1, 0, 1, 0);
            label7.Name = "label7";
            label7.Size = new Size(158, 23);
            label7.TabIndex = 7;
            label7.Text = "Correo Electronico:";
            // 
            // txtIDCliente
            // 
            txtIDCliente.Enabled = false;
            txtIDCliente.Location = new Point(163, 50);
            txtIDCliente.Margin = new Padding(1);
            txtIDCliente.Name = "txtIDCliente";
            txtIDCliente.Size = new Size(184, 26);
            txtIDCliente.TabIndex = 7;
            // 
            // mtxtTelefono_Cliente
            // 
            mtxtTelefono_Cliente.Location = new Point(163, 207);
            mtxtTelefono_Cliente.Margin = new Padding(1);
            mtxtTelefono_Cliente.Mask = "0000-0000";
            mtxtTelefono_Cliente.Name = "mtxtTelefono_Cliente";
            mtxtTelefono_Cliente.Size = new Size(184, 26);
            mtxtTelefono_Cliente.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 174);
            label4.Margin = new Padding(1, 0, 1, 0);
            label4.Name = "label4";
            label4.Size = new Size(88, 23);
            label4.TabIndex = 13;
            label4.Text = "Direccion:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 214);
            label5.Margin = new Padding(1, 0, 1, 0);
            label5.Name = "label5";
            label5.Size = new Size(82, 23);
            label5.TabIndex = 14;
            label5.Text = "Telefono:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(428, 53);
            label6.Margin = new Padding(1, 0, 1, 0);
            label6.Name = "label6";
            label6.Size = new Size(45, 23);
            label6.TabIndex = 15;
            label6.Text = "DUI:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 136);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(77, 23);
            label3.TabIndex = 7;
            label3.Text = "Apellido:";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 97);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(76, 23);
            label2.TabIndex = 7;
            label2.Text = "Nombre:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 57);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(33, 23);
            label1.TabIndex = 7;
            label1.Text = "ID:";
            // 
            // txtCorreo_Electronico
            // 
            txtCorreo_Electronico.Location = new Point(596, 90);
            txtCorreo_Electronico.Margin = new Padding(1);
            txtCorreo_Electronico.Name = "txtCorreo_Electronico";
            txtCorreo_Electronico.Size = new Size(209, 26);
            txtCorreo_Electronico.TabIndex = 12;
            // 
            // txtDireccion_Cliente
            // 
            txtDireccion_Cliente.Location = new Point(163, 167);
            txtDireccion_Cliente.Margin = new Padding(1);
            txtDireccion_Cliente.Name = "txtDireccion_Cliente";
            txtDireccion_Cliente.Size = new Size(184, 26);
            txtDireccion_Cliente.TabIndex = 10;
            // 
            // txtApellido_Cliente
            // 
            txtApellido_Cliente.Location = new Point(163, 129);
            txtApellido_Cliente.Margin = new Padding(1);
            txtApellido_Cliente.Name = "txtApellido_Cliente";
            txtApellido_Cliente.Size = new Size(184, 26);
            txtApellido_Cliente.TabIndex = 8;
            txtApellido_Cliente.TextChanged += txtApellido_Cliente_TextChanged;
            txtApellido_Cliente.KeyPress += txtApellido_Cliente_KeyPress;
            // 
            // txtNombre_Cliente
            // 
            txtNombre_Cliente.Location = new Point(163, 94);
            txtNombre_Cliente.Margin = new Padding(1);
            txtNombre_Cliente.Name = "txtNombre_Cliente";
            txtNombre_Cliente.Size = new Size(184, 26);
            txtNombre_Cliente.TabIndex = 7;
            txtNombre_Cliente.KeyPress += txtNombre_Cliente_KeyPress;
            // 
            // dgvGestionarClientes
            // 
            dgvGestionarClientes.AllowUserToAddRows = false;
            dgvGestionarClientes.AllowUserToDeleteRows = false;
            dgvGestionarClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(14, 93, 136);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvGestionarClientes.DefaultCellStyle = dataGridViewCellStyle1;
            dgvGestionarClientes.Location = new Point(166, 528);
            dgvGestionarClientes.Margin = new Padding(1);
            dgvGestionarClientes.Name = "dgvGestionarClientes";
            dgvGestionarClientes.ReadOnly = true;
            dgvGestionarClientes.RowHeadersWidth = 102;
            dgvGestionarClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGestionarClientes.Size = new Size(1449, 437);
            dgvGestionarClientes.TabIndex = 2;
            dgvGestionarClientes.CellContentClick += dgvGestionarClientes_CellContentClick;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(14, 93, 136);
            btnAgregar.Font = new Font("Sitka Small", 10.2F, FontStyle.Bold);
            btnAgregar.ForeColor = SystemColors.Control;
            btnAgregar.Location = new Point(1185, 233);
            btnAgregar.Margin = new Padding(1);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(202, 47);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(14, 93, 136);
            btnEditar.Font = new Font("Sitka Small", 10.2F, FontStyle.Bold);
            btnEditar.ForeColor = SystemColors.Control;
            btnEditar.Location = new Point(1185, 283);
            btnEditar.Margin = new Padding(1);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(202, 50);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(14, 93, 136);
            btnEliminar.Font = new Font("Sitka Small", 10.2F, FontStyle.Bold);
            btnEliminar.ForeColor = SystemColors.Control;
            btnEliminar.Location = new Point(1185, 389);
            btnEliminar.Margin = new Padding(1);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(202, 45);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(14, 93, 136);
            btnAceptar.Font = new Font("Sitka Small", 10.2F, FontStyle.Bold);
            btnAceptar.ForeColor = SystemColors.Control;
            btnAceptar.Location = new Point(1185, 335);
            btnAceptar.Margin = new Padding(1);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(202, 46);
            btnAceptar.TabIndex = 6;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Visible = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Sitka Small", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(501, 73);
            label10.Name = "label10";
            label10.Size = new Size(1048, 118);
            label10.TabIndex = 30;
            label10.Text = "GESTIÓN DE CLIENTES\r\n";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Sitka Small", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(191, 73);
            label11.Name = "label11";
            label11.Size = new Size(236, 88);
            label11.TabIndex = 29;
            label11.Text = "       Manolo  \r\n  Barber Shop\r\n";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.barbero__3_;
            pictureBox1.Location = new Point(74, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 143);
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // GestionCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1924, 1055);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(pictureBox1);
            Controls.Add(btnAceptar);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvGestionarClientes);
            Controls.Add(grpCliente);
            Controls.Add(btnHome);
            Name = "GestionCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GestionCliente";
            Load += GestionCliente_Load;
            grpCliente.ResumeLayout(false);
            grpCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGestionarClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHome;
        private GroupBox grpCliente;
        private TextBox txtCorreo_Electronico;
        private TextBox txtDireccion_Cliente;
        private TextBox txtApellido_Cliente;
        private TextBox txtNombre_Cliente;
        private DataGridView dgvGestionarClientes;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnAgregar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnAceptar;
        private MaskedTextBox mtxtTelefono_Cliente;
        private TextBox txtIDCliente;
        private Label label9;
        private Label label8;
        private TextBox txtContraseña;
        private TextBox txtUsuario;
        private Label label7;
        private Label label10;
        private Label label11;
        private PictureBox pictureBox1;
        private MaskedTextBox mtxtDUI_Cliente;
    }
}