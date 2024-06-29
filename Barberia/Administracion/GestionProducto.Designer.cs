namespace Barberia
{
    partial class GestionProducto
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
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            mtbFechaIngreso = new MaskedTextBox();
            mtbFechaCaducidad = new MaskedTextBox();
            cmbCategoriaProducto = new ComboBox();
            txtMarca = new TextBox();
            txtIDProducto = new TextBox();
            txtNombreProducto = new TextBox();
            txtStockProducto = new TextBox();
            txtPrecioProducto = new TextBox();
            grpGestionProducto = new GroupBox();
            btnAgregar = new Button();
            btnAceptar = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            dgvGestionProductos = new DataGridView();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            grpGestionProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGestionProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(14, 93, 136);
            btnHome.Font = new Font("Sitka Small", 10.2F, FontStyle.Bold);
            btnHome.ForeColor = SystemColors.Control;
            btnHome.Location = new Point(1326, 490);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(119, 47);
            btnHome.TabIndex = 0;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 41);
            label1.Name = "label1";
            label1.Size = new Size(33, 23);
            label1.TabIndex = 1;
            label1.Text = "ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 185);
            label4.Name = "label4";
            label4.Size = new Size(63, 23);
            label4.TabIndex = 4;
            label4.Text = "Precio:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 139);
            label5.Name = "label5";
            label5.Size = new Size(57, 23);
            label5.TabIndex = 5;
            label5.Text = "Stock:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 87);
            label6.Name = "label6";
            label6.Size = new Size(76, 23);
            label6.TabIndex = 6;
            label6.Text = "Nombre:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(507, 185);
            label7.Name = "label7";
            label7.Size = new Size(64, 23);
            label7.TabIndex = 7;
            label7.Text = "Marca:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(507, 139);
            label8.Name = "label8";
            label8.Size = new Size(167, 23);
            label8.TabIndex = 8;
            label8.Text = "Fecha de Caducidad:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(507, 87);
            label9.Name = "label9";
            label9.Size = new Size(147, 23);
            label9.TabIndex = 9;
            label9.Text = "Fecha de Ingreso:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(507, 41);
            label10.Name = "label10";
            label10.Size = new Size(89, 23);
            label10.TabIndex = 10;
            label10.Text = "Categoria:";
            // 
            // mtbFechaIngreso
            // 
            mtbFechaIngreso.Location = new Point(701, 84);
            mtbFechaIngreso.Mask = "0000/00/00";
            mtbFechaIngreso.Name = "mtbFechaIngreso";
            mtbFechaIngreso.Size = new Size(179, 26);
            mtbFechaIngreso.TabIndex = 11;
            mtbFechaIngreso.ValidatingType = typeof(DateTime);
            // 
            // mtbFechaCaducidad
            // 
            mtbFechaCaducidad.Location = new Point(701, 132);
            mtbFechaCaducidad.Mask = "0000/00/00";
            mtbFechaCaducidad.Name = "mtbFechaCaducidad";
            mtbFechaCaducidad.Size = new Size(179, 26);
            mtbFechaCaducidad.TabIndex = 12;
            mtbFechaCaducidad.ValidatingType = typeof(DateTime);
            // 
            // cmbCategoriaProducto
            // 
            cmbCategoriaProducto.FormattingEnabled = true;
            cmbCategoriaProducto.Items.AddRange(new object[] { "Cuidado para Barba", "Cuidado de Cabello", "Cuidado para la Piel", "Accesorios" });
            cmbCategoriaProducto.Location = new Point(701, 33);
            cmbCategoriaProducto.Name = "cmbCategoriaProducto";
            cmbCategoriaProducto.Size = new Size(179, 31);
            cmbCategoriaProducto.TabIndex = 13;
            cmbCategoriaProducto.KeyPress += cmbCategoriaProducto_KeyPress;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(701, 178);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(179, 26);
            txtMarca.TabIndex = 14;
            // 
            // txtIDProducto
            // 
            txtIDProducto.Enabled = false;
            txtIDProducto.Location = new Point(119, 33);
            txtIDProducto.Name = "txtIDProducto";
            txtIDProducto.Size = new Size(241, 26);
            txtIDProducto.TabIndex = 15;
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(119, 80);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(241, 26);
            txtNombreProducto.TabIndex = 16;
            txtNombreProducto.KeyPress += txtNombreProducto_KeyPress;
            // 
            // txtStockProducto
            // 
            txtStockProducto.Location = new Point(119, 132);
            txtStockProducto.Name = "txtStockProducto";
            txtStockProducto.Size = new Size(241, 26);
            txtStockProducto.TabIndex = 17;
            txtStockProducto.KeyPress += txtStockProducto_KeyPress;
            // 
            // txtPrecioProducto
            // 
            txtPrecioProducto.Location = new Point(119, 178);
            txtPrecioProducto.Name = "txtPrecioProducto";
            txtPrecioProducto.Size = new Size(241, 26);
            txtPrecioProducto.TabIndex = 18;
            txtPrecioProducto.KeyPress += txtPrecioProducto_KeyPress;
            // 
            // grpGestionProducto
            // 
            grpGestionProducto.Controls.Add(txtPrecioProducto);
            grpGestionProducto.Controls.Add(txtStockProducto);
            grpGestionProducto.Controls.Add(txtNombreProducto);
            grpGestionProducto.Controls.Add(txtIDProducto);
            grpGestionProducto.Controls.Add(txtMarca);
            grpGestionProducto.Controls.Add(cmbCategoriaProducto);
            grpGestionProducto.Controls.Add(mtbFechaCaducidad);
            grpGestionProducto.Controls.Add(mtbFechaIngreso);
            grpGestionProducto.Controls.Add(label10);
            grpGestionProducto.Controls.Add(label9);
            grpGestionProducto.Controls.Add(label8);
            grpGestionProducto.Controls.Add(label7);
            grpGestionProducto.Controls.Add(label6);
            grpGestionProducto.Controls.Add(label5);
            grpGestionProducto.Controls.Add(label4);
            grpGestionProducto.Controls.Add(label1);
            grpGestionProducto.Font = new Font("Sitka Small", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpGestionProducto.Location = new Point(384, 292);
            grpGestionProducto.Name = "grpGestionProducto";
            grpGestionProducto.Size = new Size(916, 245);
            grpGestionProducto.TabIndex = 19;
            grpGestionProducto.TabStop = false;
            grpGestionProducto.Text = "DETALLES DE PRODUCTOS";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(14, 93, 136);
            btnAgregar.Font = new Font("Sitka Small", 10.2F, FontStyle.Bold);
            btnAgregar.ForeColor = SystemColors.Control;
            btnAgregar.Location = new Point(1326, 292);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(119, 44);
            btnAgregar.TabIndex = 20;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click_1;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(14, 93, 136);
            btnAceptar.Font = new Font("Sitka Small", 10.2F, FontStyle.Bold);
            btnAceptar.ForeColor = SystemColors.Control;
            btnAceptar.Location = new Point(1326, 393);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(119, 45);
            btnAceptar.TabIndex = 21;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(14, 93, 136);
            btnEliminar.Font = new Font("Sitka Small", 10.2F, FontStyle.Bold);
            btnEliminar.ForeColor = SystemColors.Control;
            btnEliminar.Location = new Point(1326, 444);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(119, 40);
            btnEliminar.TabIndex = 22;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(14, 93, 136);
            btnEditar.Font = new Font("Sitka Small", 10.2F, FontStyle.Bold);
            btnEditar.ForeColor = SystemColors.Control;
            btnEditar.Location = new Point(1326, 342);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(119, 45);
            btnEditar.TabIndex = 23;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // dgvGestionProductos
            // 
            dgvGestionProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGestionProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(14, 93, 136);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvGestionProductos.DefaultCellStyle = dataGridViewCellStyle1;
            dgvGestionProductos.Location = new Point(77, 575);
            dgvGestionProductos.Margin = new Padding(1);
            dgvGestionProductos.Name = "dgvGestionProductos";
            dgvGestionProductos.RowHeadersWidth = 102;
            dgvGestionProductos.Size = new Size(1657, 409);
            dgvGestionProductos.TabIndex = 24;
            dgvGestionProductos.CellContentClick += dgvGestionProductos_CellContentClick_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Small", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(495, 81);
            label3.Name = "label3";
            label3.Size = new Size(1141, 118);
            label3.TabIndex = 27;
            label3.Text = "GESTIÓN DE PRODUCTOS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Small", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(185, 81);
            label2.Name = "label2";
            label2.Size = new Size(236, 88);
            label2.TabIndex = 26;
            label2.Text = "       Manolo  \r\n  Barber Shop\r\n";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.barbero__3_;
            pictureBox1.Location = new Point(68, 57);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 143);
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // GestionProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1924, 1055);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(dgvGestionProductos);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAceptar);
            Controls.Add(btnAgregar);
            Controls.Add(grpGestionProducto);
            Controls.Add(btnHome);
            Name = "GestionProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GestionProducto";
            Load += GestionProducto_Load;
            grpGestionProducto.ResumeLayout(false);
            grpGestionProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGestionProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHome;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private MaskedTextBox mtbFechaIngreso;
        private MaskedTextBox mtbFechaCaducidad;
        private ComboBox cmbCategoriaProducto;
        private TextBox txtMarca;
        private TextBox txtIDProducto;
        private TextBox txtNombreProducto;
        private TextBox txtStockProducto;
        private TextBox txtPrecioProducto;
        private GroupBox grpGestionProducto;
        private Button btnAgregar;
        private Button btnAceptar;
        private Button btnEliminar;
        private Button btnEditar;
        private DataGridView dgvGestionProductos;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
    }
}