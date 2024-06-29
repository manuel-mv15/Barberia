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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnCancelar = new Button();
            btnEditar = new Button();
            btnIniciar = new Button();
            txtTipodeUsuario = new TextBox();
            txtClave = new TextBox();
            txtUsuario = new TextBox();
            txtIdUsuario = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvGestionUsuario).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnHome
            // 
            btnHome.Location = new Point(12, 12);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(115, 39);
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
            dgvGestionUsuario.Location = new Point(530, 12);
            dgvGestionUsuario.Margin = new Padding(1, 1, 1, 1);
            dgvGestionUsuario.Name = "dgvGestionUsuario";
            dgvGestionUsuario.ReadOnly = true;
            dgvGestionUsuario.RowHeadersWidth = 102;
            dgvGestionUsuario.Size = new Size(725, 628);
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
            groupBox1.Location = new Point(97, 125);
            groupBox1.Margin = new Padding(1, 1, 1, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(1, 1, 1, 1);
            groupBox1.Size = new Size(304, 310);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 151);
            label4.Margin = new Padding(1, 0, 1, 0);
            label4.Name = "label4";
            label4.Size = new Size(112, 20);
            label4.TabIndex = 12;
            label4.Text = "Tipo de usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 109);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 11;
            label3.Text = "Clave";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 73);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 10;
            label2.Text = "Usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 38);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 9;
            label1.Text = "id";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(194, 250);
            btnCancelar.Margin = new Padding(1, 1, 1, 1);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(88, 28);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Calcelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += button3_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(21, 250);
            btnEditar.Margin = new Padding(1, 1, 1, 1);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(88, 28);
            btnEditar.TabIndex = 7;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(104, 199);
            btnIniciar.Margin = new Padding(1, 1, 1, 1);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(88, 28);
            btnIniciar.TabIndex = 7;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // txtTipodeUsuario
            // 
            txtTipodeUsuario.Location = new Point(146, 151);
            txtTipodeUsuario.Margin = new Padding(1, 1, 1, 1);
            txtTipodeUsuario.Name = "txtTipodeUsuario";
            txtTipodeUsuario.Size = new Size(120, 27);
            txtTipodeUsuario.TabIndex = 6;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(146, 111);
            txtClave.Margin = new Padding(1, 1, 1, 1);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(120, 27);
            txtClave.TabIndex = 6;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(146, 73);
            txtUsuario.Margin = new Padding(1, 1, 1, 1);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(120, 27);
            txtUsuario.TabIndex = 6;
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.Location = new Point(146, 38);
            txtIdUsuario.Margin = new Padding(1, 1, 1, 1);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.Size = new Size(120, 27);
            txtIdUsuario.TabIndex = 6;
            // 
            // GestionUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 670);
            Controls.Add(groupBox1);
            Controls.Add(dgvGestionUsuario);
            Controls.Add(btnHome);
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