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
            groupBox1.Size = new Size(916, 353);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            groupBox1.Enter += groupBox1_Enter;
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
            mtxtTelefono_Cliente.Location = new Point(642, 64);
            mtxtTelefono_Cliente.Name = "mtxtTelefono_Cliente";
            mtxtTelefono_Cliente.Size = new Size(250, 47);
            mtxtTelefono_Cliente.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(499, 80);
            label4.Name = "label4";
            label4.Size = new Size(97, 41);
            label4.TabIndex = 13;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(499, 141);
            label5.Name = "label5";
            label5.Size = new Size(97, 41);
            label5.TabIndex = 14;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(499, 220);
            label6.Name = "label6";
            label6.Size = new Size(97, 41);
            label6.TabIndex = 15;
            label6.Text = "label6";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 220);
            label3.Name = "label3";
            label3.Size = new Size(97, 41);
            label3.TabIndex = 7;
            label3.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 150);
            label2.Name = "label2";
            label2.Size = new Size(97, 41);
            label2.TabIndex = 7;
            label2.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 70);
            label1.Name = "label1";
            label1.Size = new Size(97, 41);
            label1.TabIndex = 7;
            label1.Text = "label1";
            // 
            // txtCorreo_Electronico
            // 
            txtCorreo_Electronico.Location = new Point(642, 194);
            txtCorreo_Electronico.Name = "txtCorreo_Electronico";
            txtCorreo_Electronico.Size = new Size(250, 47);
            txtCorreo_Electronico.TabIndex = 12;
            // 
            // txtDUI_Cliente
            // 
            txtDUI_Cliente.Location = new Point(642, 128);
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
    }
}