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
            groupBox1 = new GroupBox();
            btnAgregar = new Button();
            btnAceptar = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            dgvGestionProductos = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGestionProductos).BeginInit();
            SuspendLayout();
            // 
            // btnHome
            // 
            btnHome.Location = new Point(1453, 194);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(124, 36);
            btnHome.TabIndex = 0;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 41);
            label1.Name = "label1";
            label1.Size = new Size(27, 20);
            label1.TabIndex = 1;
            label1.Text = "ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 185);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 4;
            label4.Text = "Precio:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 139);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 5;
            label5.Text = "Stock:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 87);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 6;
            label6.Text = "Nombre:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(507, 185);
            label7.Name = "label7";
            label7.Size = new Size(53, 20);
            label7.TabIndex = 7;
            label7.Text = "Marca:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(507, 139);
            label8.Name = "label8";
            label8.Size = new Size(146, 20);
            label8.TabIndex = 8;
            label8.Text = "Fecha de Caducidad:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(507, 87);
            label9.Name = "label9";
            label9.Size = new Size(124, 20);
            label9.TabIndex = 9;
            label9.Text = "Fecha de Ingreso:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(507, 41);
            label10.Name = "label10";
            label10.Size = new Size(77, 20);
            label10.TabIndex = 10;
            label10.Text = "Categoria:";
            // 
            // mtbFechaIngreso
            // 
            mtbFechaIngreso.Location = new Point(701, 84);
            mtbFechaIngreso.Mask = "0000/00/00";
            mtbFechaIngreso.Name = "mtbFechaIngreso";
            mtbFechaIngreso.Size = new Size(179, 27);
            mtbFechaIngreso.TabIndex = 11;
            mtbFechaIngreso.ValidatingType = typeof(DateTime);
            // 
            // mtbFechaCaducidad
            // 
            mtbFechaCaducidad.Location = new Point(701, 132);
            mtbFechaCaducidad.Mask = "0000/00/00";
            mtbFechaCaducidad.Name = "mtbFechaCaducidad";
            mtbFechaCaducidad.Size = new Size(179, 27);
            mtbFechaCaducidad.TabIndex = 12;
            mtbFechaCaducidad.ValidatingType = typeof(DateTime);
            // 
            // cmbCategoriaProducto
            // 
            cmbCategoriaProducto.FormattingEnabled = true;
            cmbCategoriaProducto.Items.AddRange(new object[] { "Cuidado para Barba", "Cuidado de Cabello", "Cuidado para la Piel", "Accesorios" });
            cmbCategoriaProducto.Location = new Point(701, 33);
            cmbCategoriaProducto.Name = "cmbCategoriaProducto";
            cmbCategoriaProducto.Size = new Size(179, 28);
            cmbCategoriaProducto.TabIndex = 13;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(701, 178);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(179, 27);
            txtMarca.TabIndex = 14;
            // 
            // txtIDProducto
            // 
            txtIDProducto.Location = new Point(119, 33);
            txtIDProducto.Name = "txtIDProducto";
            txtIDProducto.Size = new Size(241, 27);
            txtIDProducto.TabIndex = 15;
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(119, 80);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(241, 27);
            txtNombreProducto.TabIndex = 16;
            // 
            // txtStockProducto
            // 
            txtStockProducto.Location = new Point(119, 132);
            txtStockProducto.Name = "txtStockProducto";
            txtStockProducto.Size = new Size(241, 27);
            txtStockProducto.TabIndex = 17;
            // 
            // txtPrecioProducto
            // 
            txtPrecioProducto.Location = new Point(119, 178);
            txtPrecioProducto.Name = "txtPrecioProducto";
            txtPrecioProducto.Size = new Size(241, 27);
            txtPrecioProducto.TabIndex = 18;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtPrecioProducto);
            groupBox1.Controls.Add(txtStockProducto);
            groupBox1.Controls.Add(txtNombreProducto);
            groupBox1.Controls.Add(txtIDProducto);
            groupBox1.Controls.Add(txtMarca);
            groupBox1.Controls.Add(cmbCategoriaProducto);
            groupBox1.Controls.Add(mtbFechaCaducidad);
            groupBox1.Controls.Add(mtbFechaIngreso);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(295, 69);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(916, 245);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(1308, 69);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(119, 44);
            btnAgregar.TabIndex = 20;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click_1;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(1453, 125);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(103, 45);
            btnAceptar.TabIndex = 21;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(1308, 189);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(119, 41);
            btnEliminar.TabIndex = 22;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(1308, 125);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(119, 45);
            btnEditar.TabIndex = 23;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // dgvGestionProductos
            // 
            dgvGestionProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGestionProductos.Location = new Point(117, 329);
            dgvGestionProductos.Margin = new Padding(1);
            dgvGestionProductos.Name = "dgvGestionProductos";
            dgvGestionProductos.RowHeadersWidth = 102;
            dgvGestionProductos.Size = new Size(1427, 409);
            dgvGestionProductos.TabIndex = 24;
            dgvGestionProductos.CellContentClick += dgvGestionProductos_CellContentClick_1;
            // 
            // GestionProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1640, 773);
            Controls.Add(dgvGestionProductos);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAceptar);
            Controls.Add(btnAgregar);
            Controls.Add(groupBox1);
            Controls.Add(btnHome);
            Name = "GestionProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GestionProducto";
            Load += GestionProducto_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGestionProductos).EndInit();
            ResumeLayout(false);
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
        private GroupBox groupBox1;
        private Button btnAgregar;
        private Button btnAceptar;
        private Button btnEliminar;
        private Button btnEditar;
        private DataGridView dgvGestionProductos;
    }
}