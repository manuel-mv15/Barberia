namespace Barberia.Administracion
{
    partial class GenerarCita
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
            dgvBarberos = new DataGridView();
            dgvClientes = new DataGridView();
            dgvcitas = new DataGridView();
            cmbHora = new ComboBox();
            mtxtFecha = new MaskedTextBox();
            btnAgendar = new Button();
            Aceptar = new Button();
            txtDesticpcion = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvBarberos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvcitas).BeginInit();
            SuspendLayout();
            // 
            // dgvBarberos
            // 
            dgvBarberos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBarberos.Location = new Point(129, 190);
            dgvBarberos.Name = "dgvBarberos";
            dgvBarberos.RowHeadersWidth = 102;
            dgvBarberos.Size = new Size(600, 375);
            dgvBarberos.TabIndex = 0;
            dgvBarberos.CellClick += dgvBarberos_CellClick;
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(129, 813);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersWidth = 102;
            dgvClientes.Size = new Size(600, 375);
            dgvClientes.TabIndex = 1;
            dgvClientes.CellClick += dgvClientes_CellClick;
            // 
            // dgvcitas
            // 
            dgvcitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvcitas.Location = new Point(1351, 576);
            dgvcitas.Name = "dgvcitas";
            dgvcitas.RowHeadersWidth = 102;
            dgvcitas.Size = new Size(600, 375);
            dgvcitas.TabIndex = 2;
            // 
            // cmbHora
            // 
            cmbHora.FormattingEnabled = true;
            cmbHora.Location = new Point(1630, 335);
            cmbHora.Name = "cmbHora";
            cmbHora.Size = new Size(302, 49);
            cmbHora.TabIndex = 3;
            // 
            // mtxtFecha
            // 
            mtxtFecha.Location = new Point(1311, 337);
            mtxtFecha.Mask = "0000-00-00";
            mtxtFecha.Name = "mtxtFecha";
            mtxtFecha.Size = new Size(250, 47);
            mtxtFecha.TabIndex = 4;
            // 
            // btnAgendar
            // 
            btnAgendar.Location = new Point(2100, 430);
            btnAgendar.Name = "btnAgendar";
            btnAgendar.Size = new Size(188, 58);
            btnAgendar.TabIndex = 5;
            btnAgendar.Text = "Agendar";
            btnAgendar.UseVisualStyleBackColor = true;
            btnAgendar.Click += btnAgendar_Click;
            // 
            // Aceptar
            // 
            Aceptar.Location = new Point(760, 627);
            Aceptar.Name = "Aceptar";
            Aceptar.Size = new Size(188, 58);
            Aceptar.TabIndex = 6;
            Aceptar.Text = "Aceptar";
            Aceptar.UseVisualStyleBackColor = true;
            Aceptar.Click += Aceptar_Click;
            // 
            // txtDesticpcion
            // 
            txtDesticpcion.Location = new Point(1418, 1214);
            txtDesticpcion.Name = "txtDesticpcion";
            txtDesticpcion.Size = new Size(250, 47);
            txtDesticpcion.TabIndex = 7;
            // 
            // GenerarCita
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(3844, 1954);
            Controls.Add(txtDesticpcion);
            Controls.Add(Aceptar);
            Controls.Add(btnAgendar);
            Controls.Add(mtxtFecha);
            Controls.Add(cmbHora);
            Controls.Add(dgvcitas);
            Controls.Add(dgvClientes);
            Controls.Add(dgvBarberos);
            Name = "GenerarCita";
            Text = "GenerarCita";
            ((System.ComponentModel.ISupportInitialize)dgvBarberos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvcitas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvBarberos;
        private DataGridView dgvClientes;
        private DataGridView dgvcitas;
        private ComboBox cmbHora;
        private MaskedTextBox mtxtFecha;
        private Button btnAgendar;
        private Button Aceptar;
        private TextBox txtDesticpcion;
    }
}