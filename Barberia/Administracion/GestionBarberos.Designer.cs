namespace Barberia.Administracion
{
    partial class GestionBarberos
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
            label10 = new Label();
            label11 = new Label();
            pictureBox1 = new PictureBox();
            grpGestionBarberos = new GroupBox();
            mtxtFechaInicio_Barbero = new MaskedTextBox();
            mtxtDUI_Barbero = new MaskedTextBox();
            label7 = new Label();
            txtIDCliente = new TextBox();
            mtxtTelefono_Barbero = new MaskedTextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            label12 = new Label();
            txtDireccion_Barbero = new TextBox();
            txtApellido_Barbero = new TextBox();
            txtNombre_Barbero = new TextBox();
            btnAceptar = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnAgregar = new Button();
            btnHome = new Button();
            dgvBarberos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            grpGestionBarberos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBarberos).BeginInit();
            SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Sitka Small", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(548, 59);
            label10.Name = "label10";
            label10.Size = new Size(1078, 118);
            label10.TabIndex = 33;
            label10.Text = "GESTIÓN DE BARBEROS\r\n";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Sitka Small", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(238, 59);
            label11.Name = "label11";
            label11.Size = new Size(236, 88);
            label11.TabIndex = 32;
            label11.Text = "       Manolo  \r\n  Barber Shop\r\n";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.barbero__3_;
            pictureBox1.Location = new Point(121, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 143);
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            // 
            // grpGestionBarberos
            // 
            grpGestionBarberos.Controls.Add(mtxtFechaInicio_Barbero);
            grpGestionBarberos.Controls.Add(mtxtDUI_Barbero);
            grpGestionBarberos.Controls.Add(label7);
            grpGestionBarberos.Controls.Add(txtIDCliente);
            grpGestionBarberos.Controls.Add(mtxtTelefono_Barbero);
            grpGestionBarberos.Controls.Add(label4);
            grpGestionBarberos.Controls.Add(label5);
            grpGestionBarberos.Controls.Add(label6);
            grpGestionBarberos.Controls.Add(label3);
            grpGestionBarberos.Controls.Add(label2);
            grpGestionBarberos.Controls.Add(label12);
            grpGestionBarberos.Controls.Add(txtDireccion_Barbero);
            grpGestionBarberos.Controls.Add(txtApellido_Barbero);
            grpGestionBarberos.Controls.Add(txtNombre_Barbero);
            grpGestionBarberos.Font = new Font("Sitka Small", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpGestionBarberos.Location = new Point(317, 230);
            grpGestionBarberos.Name = "grpGestionBarberos";
            grpGestionBarberos.Size = new Size(1059, 281);
            grpGestionBarberos.TabIndex = 34;
            grpGestionBarberos.TabStop = false;
            grpGestionBarberos.Text = "DATOS PERSONALES BARBEROS";
            // 
            // mtxtFechaInicio_Barbero
            // 
            mtxtFechaInicio_Barbero.Location = new Point(742, 131);
            mtxtFechaInicio_Barbero.Margin = new Padding(1);
            mtxtFechaInicio_Barbero.Mask = "00/00/0000";
            mtxtFechaInicio_Barbero.Name = "mtxtFechaInicio_Barbero";
            mtxtFechaInicio_Barbero.Size = new Size(209, 29);
            mtxtFechaInicio_Barbero.TabIndex = 39;
            mtxtFechaInicio_Barbero.ValidatingType = typeof(DateTime);
            // 
            // mtxtDUI_Barbero
            // 
            mtxtDUI_Barbero.Location = new Point(742, 94);
            mtxtDUI_Barbero.Margin = new Padding(1);
            mtxtDUI_Barbero.Mask = "00000000-0";
            mtxtDUI_Barbero.Name = "mtxtDUI_Barbero";
            mtxtDUI_Barbero.Size = new Size(209, 29);
            mtxtDUI_Barbero.TabIndex = 38;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(574, 138);
            label7.Margin = new Padding(1, 0, 1, 0);
            label7.Name = "label7";
            label7.Size = new Size(149, 25);
            label7.TabIndex = 24;
            label7.Text = "Fecha de Inicio:";
            // 
            // txtIDCliente
            // 
            txtIDCliente.Enabled = false;
            txtIDCliente.Location = new Point(309, 45);
            txtIDCliente.Margin = new Padding(1);
            txtIDCliente.Name = "txtIDCliente";
            txtIDCliente.Size = new Size(184, 29);
            txtIDCliente.TabIndex = 25;
            // 
            // mtxtTelefono_Barbero
            // 
            mtxtTelefono_Barbero.Location = new Point(309, 202);
            mtxtTelefono_Barbero.Margin = new Padding(1);
            mtxtTelefono_Barbero.Mask = "0000-0000";
            mtxtTelefono_Barbero.Name = "mtxtTelefono_Barbero";
            mtxtTelefono_Barbero.Size = new Size(184, 29);
            mtxtTelefono_Barbero.TabIndex = 34;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(196, 169);
            label4.Margin = new Padding(1, 0, 1, 0);
            label4.Name = "label4";
            label4.Size = new Size(101, 25);
            label4.TabIndex = 31;
            label4.Text = "Direccion:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(196, 209);
            label5.Margin = new Padding(1, 0, 1, 0);
            label5.Name = "label5";
            label5.Size = new Size(93, 25);
            label5.TabIndex = 32;
            label5.Text = "Telefono:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(574, 97);
            label6.Margin = new Padding(1, 0, 1, 0);
            label6.Name = "label6";
            label6.Size = new Size(52, 25);
            label6.TabIndex = 33;
            label6.Text = "DUI:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(196, 131);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 27;
            label3.Text = "Apellido:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(196, 92);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 26;
            label2.Text = "Nombre:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(196, 52);
            label12.Margin = new Padding(1, 0, 1, 0);
            label12.Name = "label12";
            label12.Size = new Size(39, 25);
            label12.TabIndex = 23;
            label12.Text = "ID:";
            // 
            // txtDireccion_Barbero
            // 
            txtDireccion_Barbero.Location = new Point(309, 162);
            txtDireccion_Barbero.Margin = new Padding(1);
            txtDireccion_Barbero.Name = "txtDireccion_Barbero";
            txtDireccion_Barbero.Size = new Size(184, 29);
            txtDireccion_Barbero.TabIndex = 29;
            // 
            // txtApellido_Barbero
            // 
            txtApellido_Barbero.Location = new Point(309, 124);
            txtApellido_Barbero.Margin = new Padding(1);
            txtApellido_Barbero.Name = "txtApellido_Barbero";
            txtApellido_Barbero.Size = new Size(184, 29);
            txtApellido_Barbero.TabIndex = 28;
            txtApellido_Barbero.KeyPress += txtApellido_Barbero_KeyPress;
            // 
            // txtNombre_Barbero
            // 
            txtNombre_Barbero.Location = new Point(309, 89);
            txtNombre_Barbero.Margin = new Padding(1);
            txtNombre_Barbero.Name = "txtNombre_Barbero";
            txtNombre_Barbero.Size = new Size(184, 29);
            txtNombre_Barbero.TabIndex = 21;
            txtNombre_Barbero.KeyPress += txtNombre_Barbero_KeyPress;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(14, 93, 136);
            btnAceptar.Font = new Font("Sitka Small", 10.2F, FontStyle.Bold);
            btnAceptar.ForeColor = SystemColors.Control;
            btnAceptar.Location = new Point(1403, 340);
            btnAceptar.Margin = new Padding(1);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(202, 58);
            btnAceptar.TabIndex = 39;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Visible = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(14, 93, 136);
            btnEliminar.Font = new Font("Sitka Small", 10.2F, FontStyle.Bold);
            btnEliminar.ForeColor = SystemColors.Control;
            btnEliminar.Location = new Point(1403, 409);
            btnEliminar.Margin = new Padding(1);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(202, 54);
            btnEliminar.TabIndex = 38;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(14, 93, 136);
            btnEditar.Font = new Font("Sitka Small", 10.2F, FontStyle.Bold);
            btnEditar.ForeColor = SystemColors.Control;
            btnEditar.Location = new Point(1403, 274);
            btnEditar.Margin = new Padding(1);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(202, 59);
            btnEditar.TabIndex = 37;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(14, 93, 136);
            btnAgregar.Font = new Font("Sitka Small", 10.2F, FontStyle.Bold);
            btnAgregar.ForeColor = SystemColors.Control;
            btnAgregar.Location = new Point(1403, 210);
            btnAgregar.Margin = new Padding(1);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(202, 62);
            btnAgregar.TabIndex = 36;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(14, 93, 136);
            btnHome.Font = new Font("Sitka Small", 10.2F, FontStyle.Bold);
            btnHome.ForeColor = SystemColors.Control;
            btnHome.Location = new Point(1403, 471);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(202, 55);
            btnHome.TabIndex = 35;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            // 
            // dgvBarberos
            // 
            dgvBarberos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(14, 93, 136);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvBarberos.DefaultCellStyle = dataGridViewCellStyle1;
            dgvBarberos.Location = new Point(196, 548);
            dgvBarberos.Name = "dgvBarberos";
            dgvBarberos.RowHeadersWidth = 51;
            dgvBarberos.Size = new Size(1590, 458);
            dgvBarberos.TabIndex = 40;
            // 
            // GestionBarberos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(dgvBarberos);
            Controls.Add(btnAceptar);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(btnHome);
            Controls.Add(grpGestionBarberos);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(pictureBox1);
            Name = "GestionBarberos";
            Text = "GestionBarberos";
            Load += GestionBarberos_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            grpGestionBarberos.ResumeLayout(false);
            grpGestionBarberos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBarberos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label10;
        private Label label11;
        private PictureBox pictureBox1;
        private GroupBox grpGestionBarberos;
        private MaskedTextBox mtxtFechaInicio_Barbero;
        private MaskedTextBox mtxtDUI_Barbero;
        private Label label7;
        private TextBox txtIDCliente;
        private MaskedTextBox mtxtTelefono_Barbero;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label3;
        private Label label2;
        private Label label12;
        private TextBox txtDireccion_Barbero;
        private TextBox txtApellido_Barbero;
        private TextBox txtNombre_Barbero;
        private Button btnAceptar;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnAgregar;
        private Button btnHome;
        private DataGridView dgvBarberos;
    }
}