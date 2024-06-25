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
            btnHome.Location = new Point(26, 25);
            btnHome.Margin = new Padding(6);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(264, 74);
            btnHome.TabIndex = 0;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 84);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(54, 41);
            label1.TabIndex = 1;
            label1.Text = "ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 379);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(107, 41);
            label4.TabIndex = 4;
            label4.Text = "Precio:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(55, 285);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(97, 41);
            label5.TabIndex = 5;
            label5.Text = "Stock:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(55, 178);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(135, 41);
            label6.TabIndex = 6;
            label6.Text = "Nombre:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1077, 379);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(106, 41);
            label7.TabIndex = 7;
            label7.Text = "Marca:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1077, 285);
            label8.Margin = new Padding(6, 0, 6, 0);
            label8.Name = "label8";
            label8.Size = new Size(293, 41);
            label8.TabIndex = 8;
            label8.Text = "Fecha de Caducidad:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(1077, 178);
            label9.Margin = new Padding(6, 0, 6, 0);
            label9.Name = "label9";
            label9.Size = new Size(252, 41);
            label9.TabIndex = 9;
            label9.Text = "Fecha de Ingreso:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(1077, 84);
            label10.Margin = new Padding(6, 0, 6, 0);
            label10.Name = "label10";
            label10.Size = new Size(153, 41);
            label10.TabIndex = 10;
            label10.Text = "Categoria:";
            // 
            // mtbFechaIngreso
            // 
            mtbFechaIngreso.Location = new Point(1490, 172);
            mtbFechaIngreso.Margin = new Padding(6);
            mtbFechaIngreso.Mask = "0000/00/00";
            mtbFechaIngreso.Name = "mtbFechaIngreso";
            mtbFechaIngreso.Size = new Size(376, 47);
            mtbFechaIngreso.TabIndex = 11;
            mtbFechaIngreso.ValidatingType = typeof(DateTime);
            // 
            // mtbFechaCaducidad
            // 
            mtbFechaCaducidad.Location = new Point(1490, 271);
            mtbFechaCaducidad.Margin = new Padding(6);
            mtbFechaCaducidad.Mask = "0000/00/00";
            mtbFechaCaducidad.Name = "mtbFechaCaducidad";
            mtbFechaCaducidad.Size = new Size(376, 47);
            mtbFechaCaducidad.TabIndex = 12;
            mtbFechaCaducidad.ValidatingType = typeof(DateTime);
            // 
            // cmbCategoriaProducto
            // 
            cmbCategoriaProducto.FormattingEnabled = true;
            cmbCategoriaProducto.Items.AddRange(new object[] { "Cuidado para Barba", "Cuidado de Cabello", "Cuidado para la Piel", "Accesorios" });
            cmbCategoriaProducto.Location = new Point(1490, 68);
            cmbCategoriaProducto.Margin = new Padding(6);
            cmbCategoriaProducto.Name = "cmbCategoriaProducto";
            cmbCategoriaProducto.Size = new Size(376, 49);
            cmbCategoriaProducto.TabIndex = 13;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(1490, 365);
            txtMarca.Margin = new Padding(6);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(376, 47);
            txtMarca.TabIndex = 14;
            // 
            // txtIDProducto
            // 
            txtIDProducto.Location = new Point(253, 68);
            txtIDProducto.Margin = new Padding(6);
            txtIDProducto.Name = "txtIDProducto";
            txtIDProducto.Size = new Size(508, 47);
            txtIDProducto.TabIndex = 15;
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(253, 164);
            txtNombreProducto.Margin = new Padding(6);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(508, 47);
            txtNombreProducto.TabIndex = 16;
            // 
            // txtStockProducto
            // 
            txtStockProducto.Location = new Point(253, 271);
            txtStockProducto.Margin = new Padding(6);
            txtStockProducto.Name = "txtStockProducto";
            txtStockProducto.Size = new Size(508, 47);
            txtStockProducto.TabIndex = 17;
            // 
            // txtPrecioProducto
            // 
            txtPrecioProducto.Location = new Point(253, 365);
            txtPrecioProducto.Margin = new Padding(6);
            txtPrecioProducto.Name = "txtPrecioProducto";
            txtPrecioProducto.Size = new Size(508, 47);
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
            groupBox1.Location = new Point(737, 78);
            groupBox1.Margin = new Padding(6);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(6);
            groupBox1.Size = new Size(1946, 502);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(2780, 141);
            btnAgregar.Margin = new Padding(6);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(253, 90);
            btnAgregar.TabIndex = 20;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click_1;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(3088, 256);
            btnAceptar.Margin = new Padding(6);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(219, 92);
            btnAceptar.TabIndex = 21;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
//            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(2780, 387);
            btnEliminar.Margin = new Padding(6);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(253, 84);
            btnEliminar.TabIndex = 22;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(2780, 256);
            btnEditar.Margin = new Padding(6);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(253, 92);
            btnEditar.TabIndex = 23;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // dgvGestionProductos
            // 
            dgvGestionProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGestionProductos.Location = new Point(115, 650);
            dgvGestionProductos.Margin = new Padding(6);
            dgvGestionProductos.Name = "dgvGestionProductos";
            dgvGestionProductos.RowHeadersWidth = 51;
            dgvGestionProductos.Size = new Size(3787, 929);
            dgvGestionProductos.TabIndex = 24;
            dgvGestionProductos.CellContentClick += dgvGestionProductos_CellContentClick;
            // 
            // GestionProducto
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(3844, 2163);
            Controls.Add(dgvGestionProductos);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAceptar);
            Controls.Add(btnAgregar);
            Controls.Add(groupBox1);
            Controls.Add(btnHome);
            Margin = new Padding(6);
            Name = "GestionProducto";
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