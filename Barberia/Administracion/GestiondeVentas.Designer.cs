namespace Barberia.Administracion
{
    partial class GestiondeVentas
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
            btnSemanales = new Button();
            btnDiarias = new Button();
            btnAnuales = new Button();
            dgvVentas = new DataGridView();
            mtxtFecha = new MaskedTextBox();
            label1 = new Label();
            label10 = new Label();
            label11 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(14, 93, 136);
            btnHome.Font = new Font("Sitka Small", 9F, FontStyle.Bold);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(621, 296);
            btnHome.Margin = new Padding(1, 1, 1, 1);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(238, 48);
            btnHome.TabIndex = 0;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // btnSemanales
            // 
            btnSemanales.BackColor = Color.FromArgb(14, 93, 136);
            btnSemanales.Font = new Font("Sitka Small", 9F, FontStyle.Bold);
            btnSemanales.ForeColor = Color.White;
            btnSemanales.Location = new Point(1341, 296);
            btnSemanales.Margin = new Padding(1, 1, 1, 1);
            btnSemanales.Name = "btnSemanales";
            btnSemanales.Size = new Size(238, 48);
            btnSemanales.TabIndex = 1;
            btnSemanales.Text = "Ventas Semanales";
            btnSemanales.UseVisualStyleBackColor = false;
            btnSemanales.Click += btnSemanales_Click;
            // 
            // btnDiarias
            // 
            btnDiarias.BackColor = Color.FromArgb(14, 93, 136);
            btnDiarias.Font = new Font("Sitka Small", 9F, FontStyle.Bold);
            btnDiarias.ForeColor = Color.White;
            btnDiarias.Location = new Point(861, 296);
            btnDiarias.Margin = new Padding(1, 1, 1, 1);
            btnDiarias.Name = "btnDiarias";
            btnDiarias.Size = new Size(238, 48);
            btnDiarias.TabIndex = 2;
            btnDiarias.Text = "Ventas Diarias";
            btnDiarias.UseVisualStyleBackColor = false;
            btnDiarias.Click += btnDiarias_Click;
            // 
            // btnAnuales
            // 
            btnAnuales.BackColor = Color.FromArgb(14, 93, 136);
            btnAnuales.Font = new Font("Sitka Small", 9F, FontStyle.Bold);
            btnAnuales.ForeColor = Color.White;
            btnAnuales.Location = new Point(1101, 296);
            btnAnuales.Margin = new Padding(1, 1, 1, 1);
            btnAnuales.Name = "btnAnuales";
            btnAnuales.Size = new Size(238, 48);
            btnAnuales.TabIndex = 3;
            btnAnuales.Text = "Ventas Anuales";
            btnAnuales.UseVisualStyleBackColor = false;
            btnAnuales.Click += btnAnuales_Click;
            // 
            // dgvVentas
            // 
            dgvVentas.AllowUserToAddRows = false;
            dgvVentas.AllowUserToDeleteRows = false;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Location = new Point(226, 357);
            dgvVentas.Margin = new Padding(1, 1, 1, 1);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.ReadOnly = true;
            dgvVentas.RowHeadersWidth = 102;
            dgvVentas.Size = new Size(1353, 654);
            dgvVentas.TabIndex = 4;
            dgvVentas.CellContentClick += dgvVentas_CellContentClick;
            // 
            // mtxtFecha
            // 
            mtxtFecha.Location = new Point(226, 308);
            mtxtFecha.Margin = new Padding(1, 1, 1, 1);
            mtxtFecha.Mask = "0000-00-00";
            mtxtFecha.Name = "mtxtFecha";
            mtxtFecha.Size = new Size(247, 27);
            mtxtFecha.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(226, 277);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 6;
            label1.Text = "Buscar Fecha:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Sitka Small", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(461, 52);
            label10.Name = "label10";
            label10.Size = new Size(1048, 118);
            label10.TabIndex = 33;
            label10.Text = "GESTIÓN DE CLIENTES\r\n";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Sitka Small", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(152, 51);
            label11.Name = "label11";
            label11.Size = new Size(236, 88);
            label11.TabIndex = 32;
            label11.Text = "       Manolo  \r\n  Barber Shop\r\n";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.barbero__3_;
            pictureBox1.Location = new Point(35, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 143);
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            // 
            // GestiondeVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1924, 1055);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(mtxtFecha);
            Controls.Add(dgvVentas);
            Controls.Add(btnAnuales);
            Controls.Add(btnDiarias);
            Controls.Add(btnSemanales);
            Controls.Add(btnHome);
            Margin = new Padding(1, 1, 1, 1);
            Name = "GestiondeVentas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GestiondeVentas";
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHome;
        private Button btnSemanales;
        private Button btnDiarias;
        private Button btnAnuales;
        private DataGridView dgvVentas;
        private MaskedTextBox mtxtFecha;
        private Label label1;
        private Label label10;
        private Label label11;
        private PictureBox pictureBox1;
    }
}