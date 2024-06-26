namespace Barberia
{
    partial class GestionUsuario
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
            dgvGestionUsuario = new DataGridView();
            groupBox1 = new GroupBox();
            label4 = new Label();
            txtTipodeUsuario = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtClave = new TextBox();
            btnCancelar = new Button();
            btnIniciar = new Button();
            btnEditar = new Button();
            txtUsuario = new TextBox();
            txtIdUsuario = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvGestionUsuario).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnHome
            // 
            btnHome.Location = new Point(26, 25);
            btnHome.Margin = new Padding(6);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(244, 80);
            btnHome.TabIndex = 0;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // dgvGestionUsuario
            // 
            dgvGestionUsuario.AllowUserToAddRows = false;
            dgvGestionUsuario.AllowUserToDeleteRows = false;
            dgvGestionUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGestionUsuario.Location = new Point(1127, 25);
            dgvGestionUsuario.Name = "dgvGestionUsuario";
            dgvGestionUsuario.ReadOnly = true;
            dgvGestionUsuario.RowHeadersWidth = 102;
            dgvGestionUsuario.Size = new Size(1541, 1287);
            dgvGestionUsuario.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(btnEditar);
            groupBox1.Controls.Add(btnIniciar);
            groupBox1.Controls.Add(txtTipodeUsuario);
            groupBox1.Controls.Add(txtClave);
            groupBox1.Controls.Add(txtUsuario);
            groupBox1.Controls.Add(txtIdUsuario);
            groupBox1.Location = new Point(206, 257);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(645, 636);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 309);
            label4.Name = "label4";
            label4.Size = new Size(224, 41);
            label4.TabIndex = 12;
            label4.Text = "Tipo de usuario";
            // 
            // txtTipodeUsuario
            // 
            txtTipodeUsuario.Location = new Point(311, 309);
            txtTipodeUsuario.Name = "txtTipodeUsuario";
            txtTipodeUsuario.Size = new Size(250, 47);
            txtTipodeUsuario.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 224);
            label3.Name = "label3";
            label3.Size = new Size(89, 41);
            label3.TabIndex = 11;
            label3.Text = "Clave";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 149);
            label2.Name = "label2";
            label2.Size = new Size(119, 41);
            label2.TabIndex = 10;
            label2.Text = "Usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 77);
            label1.Name = "label1";
            label1.Size = new Size(43, 41);
            label1.TabIndex = 9;
            label1.Text = "id";
            // 
            // txtClave
            // 
            txtClave.Location = new Point(311, 227);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(250, 47);
            txtClave.TabIndex = 6;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(413, 513);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(188, 58);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Calcelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += button3_Click;
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(221, 407);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(188, 58);
            btnIniciar.TabIndex = 7;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(44, 513);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(188, 58);
            btnEditar.TabIndex = 7;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(311, 149);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(250, 47);
            txtUsuario.TabIndex = 6;
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.Location = new Point(311, 77);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.Size = new Size(250, 47);
            txtIdUsuario.TabIndex = 6;
            // 
            // GestionUsuario
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2707, 1324);
            Controls.Add(groupBox1);
            Controls.Add(dgvGestionUsuario);
            Controls.Add(btnHome);
            Margin = new Padding(6);
            Name = "GestionUsuario";
            Text = "GestionUsuario";
            Load += GestionUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGestionUsuario).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnHome;
        private DataGridView dgvGestionUsuario;
        private GroupBox groupBox1;
        private Button btnIniciar;
        private Button btnEditar;
        private TextBox txtUsuario;
        private TextBox txtIdUsuario;
        private Button btnCancelar;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtClave;
        private Label label4;
        private TextBox txtTipodeUsuario;
    }
}