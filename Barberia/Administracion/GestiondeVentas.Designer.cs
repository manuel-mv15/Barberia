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
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            SuspendLayout();
            // 
            // btnHome
            // 
            btnHome.Location = new Point(40, 12);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(188, 58);
            btnHome.TabIndex = 0;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            // 
            // btnSemanales
            // 
            btnSemanales.Location = new Point(560, 12);
            btnSemanales.Name = "btnSemanales";
            btnSemanales.Size = new Size(188, 58);
            btnSemanales.TabIndex = 1;
            btnSemanales.Text = "Semanales";
            btnSemanales.UseVisualStyleBackColor = true;
            btnSemanales.Click += btnSemanales_Click;
            // 
            // btnDiarias
            // 
            btnDiarias.Location = new Point(291, 12);
            btnDiarias.Name = "btnDiarias";
            btnDiarias.Size = new Size(188, 58);
            btnDiarias.TabIndex = 2;
            btnDiarias.Text = "Diarias";
            btnDiarias.UseVisualStyleBackColor = true;
            btnDiarias.Click += btnDiarias_Click;
            // 
            // btnAnuales
            // 
            btnAnuales.Location = new Point(791, 12);
            btnAnuales.Name = "btnAnuales";
            btnAnuales.Size = new Size(188, 58);
            btnAnuales.TabIndex = 3;
            btnAnuales.Text = "Anuales";
            btnAnuales.UseVisualStyleBackColor = true;
            btnAnuales.Click += btnAnuales_Click;
            // 
            // dgvVentas
            // 
            dgvVentas.AllowUserToAddRows = false;
            dgvVentas.AllowUserToDeleteRows = false;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Location = new Point(1328, 506);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.ReadOnly = true;
            dgvVentas.RowHeadersWidth = 102;
            dgvVentas.Size = new Size(1998, 504);
            dgvVentas.TabIndex = 4;
            // 
            // mtxtFecha
            // 
            mtxtFecha.Location = new Point(254, 404);
            mtxtFecha.Mask = "0000-00-00";
            mtxtFecha.Name = "mtxtFecha";
            mtxtFecha.Size = new Size(250, 47);
            mtxtFecha.TabIndex = 5;
            // 
            // GestiondeVentas
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(3844, 2163);
            Controls.Add(mtxtFecha);
            Controls.Add(dgvVentas);
            Controls.Add(btnAnuales);
            Controls.Add(btnDiarias);
            Controls.Add(btnSemanales);
            Controls.Add(btnHome);
            Name = "GestiondeVentas";
            Text = "GestiondeVentas";
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
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
    }
}