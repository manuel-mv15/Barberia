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
            btnHome = new Button();
            groupBox1 = new GroupBox();
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
            txtDUI_Cliente = new TextBox();
            txtDireccion_Cliente = new TextBox();
            txtApellido_Cliente = new TextBox();
            txtNombre_Cliente = new TextBox();
            dgvGestionarClientes = new DataGridView();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnAceptar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGestionarClientes).BeginInit();
            SuspendLayout();
            // 
            // btnHome
            // 
            btnHome.Location = new Point(26, 25);
            btnHome.Margin = new Padding(6);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(230, 78);
            btnHome.TabIndex = 0;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtContraseña);
            groupBox1.Controls.Add(txtUsuario);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtIDCliente);
            groupBox1.Controls.Add(mtxtTelefono_Cliente);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtCorreo_Electronico);
            groupBox1.Controls.Add(txtDUI_Cliente);
            groupBox1.Controls.Add(txtDireccion_Cliente);
            groupBox1.Controls.Add(txtApellido_Cliente);
            groupBox1.Controls.Add(txtNombre_Cliente);
            groupBox1.Location = new Point(450, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(916, 466);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(497, 302);
            label9.Name = "label9";
            label9.Size = new Size(168, 41);
            label9.TabIndex = 19;
            label9.Text = "Contraseña";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(497, 224);
            label8.Name = "label8";
            label8.Size = new Size(119, 41);
            label8.TabIndex = 7;
            label8.Text = "Usuario";
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(640, 296);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(250, 47);
            txtContraseña.TabIndex = 18;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(640, 218);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(250, 47);
            txtUsuario.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(487, 130);
            label7.Name = "label7";
            label7.Size = new Size(263, 41);
            label7.TabIndex = 7;
            label7.Text = "Correo Electronico";
            // 
            // txtIDCliente
            // 
            txtIDCliente.Location = new Point(224, 64);
            txtIDCliente.Name = "txtIDCliente";
            txtIDCliente.Size = new Size(250, 47);
            txtIDCliente.TabIndex = 7;
            // 
            // mtxtTelefono_Cliente
            // 
            mtxtTelefono_Cliente.Location = new Point(224, 359);
            mtxtTelefono_Cliente.Mask = "0000-0000";
            mtxtTelefono_Cliente.Name = "mtxtTelefono_Cliente";
            mtxtTelefono_Cliente.Size = new Size(250, 47);
            mtxtTelefono_Cliente.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 283);
            label4.Name = "label4";
            label4.Size = new Size(150, 41);
            label4.TabIndex = 13;
            label4.Text = "Direccion ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(81, 365);
            label5.Name = "label5";
            label5.Size = new Size(129, 41);
            label5.TabIndex = 14;
            label5.Text = "telefono";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(497, 66);
            label6.Name = "label6";
            label6.Size = new Size(63, 41);
            label6.TabIndex = 15;
            label6.Text = "Dui";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 201);
            label3.Name = "label3";
            label3.Size = new Size(128, 41);
            label3.TabIndex = 7;
            label3.Text = "Apellido";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 131);
            label2.Name = "label2";
            label2.Size = new Size(128, 41);
            label2.TabIndex = 7;
            label2.Text = "Nombre";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 64);
            label1.Name = "label1";
            label1.Size = new Size(44, 41);
            label1.TabIndex = 7;
            label1.Text = "Id";
            // 
            // txtCorreo_Electronico
            // 
            txtCorreo_Electronico.Location = new Point(640, 124);
            txtCorreo_Electronico.Name = "txtCorreo_Electronico";
            txtCorreo_Electronico.Size = new Size(250, 47);
            txtCorreo_Electronico.TabIndex = 12;
            // 
            // txtDUI_Cliente
            // 
            txtDUI_Cliente.Location = new Point(640, 58);
            txtDUI_Cliente.Name = "txtDUI_Cliente";
            txtDUI_Cliente.Size = new Size(250, 47);
            txtDUI_Cliente.TabIndex = 11;
            // 
            // txtDireccion_Cliente
            // 
            txtDireccion_Cliente.Location = new Point(224, 277);
            txtDireccion_Cliente.Name = "txtDireccion_Cliente";
            txtDireccion_Cliente.Size = new Size(250, 47);
            txtDireccion_Cliente.TabIndex = 10;
            // 
            // txtApellido_Cliente
            // 
            txtApellido_Cliente.Location = new Point(224, 198);
            txtApellido_Cliente.Name = "txtApellido_Cliente";
            txtApellido_Cliente.Size = new Size(250, 47);
            txtApellido_Cliente.TabIndex = 8;
            // 
            // txtNombre_Cliente
            // 
            txtNombre_Cliente.Location = new Point(224, 127);
            txtNombre_Cliente.Name = "txtNombre_Cliente";
            txtNombre_Cliente.Size = new Size(250, 47);
            txtNombre_Cliente.TabIndex = 7;
            // 
            // dgvGestionarClientes
            // 
            dgvGestionarClientes.AllowUserToAddRows = false;
            dgvGestionarClientes.AllowUserToDeleteRows = false;
            dgvGestionarClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGestionarClientes.Location = new Point(26, 683);
            dgvGestionarClientes.Name = "dgvGestionarClientes";
            dgvGestionarClientes.ReadOnly = true;
            dgvGestionarClientes.RowHeadersWidth = 102;
            dgvGestionarClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGestionarClientes.Size = new Size(2647, 609);
            dgvGestionarClientes.TabIndex = 2;
            dgvGestionarClientes.CellContentClick += dgvGestionarClientes_CellContentClick;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(1454, 45);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(188, 58);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(1454, 131);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(188, 58);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(1454, 219);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(188, 58);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(1689, 131);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(188, 58);
            btnAceptar.TabIndex = 6;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Visible = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // GestionCliente
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2707, 1324);
            Controls.Add(btnAceptar);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvGestionarClientes);
            Controls.Add(groupBox1);
            Controls.Add(btnHome);
            Margin = new Padding(6);
            Name = "GestionCliente";
            Text = "GestionCliente";
            Load += GestionCliente_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGestionarClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnHome;
        private GroupBox groupBox1;
        private TextBox txtCorreo_Electronico;
        private TextBox txtDUI_Cliente;
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
    }
}