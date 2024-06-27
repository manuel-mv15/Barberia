namespace Barberia
{
    partial class InicioDeSecion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txt_Usuario = new TextBox();
            txt_Clave = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btn_Ingresar = new Button();
            label3 = new Label();
            label4 = new Label();
            btnRegistrarse = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // txt_Usuario
            // 
            txt_Usuario.Location = new Point(261, 256);
            txt_Usuario.Margin = new Padding(1);
            txt_Usuario.Name = "txt_Usuario";
            txt_Usuario.Size = new Size(182, 27);
            txt_Usuario.TabIndex = 0;
            txt_Usuario.Text = "Admin";
            // 
            // txt_Clave
            // 
            txt_Clave.Location = new Point(261, 332);
            txt_Clave.Margin = new Padding(1);
            txt_Clave.Name = "txt_Clave";
            txt_Clave.PasswordChar = '*';
            txt_Clave.Size = new Size(182, 27);
            txt_Clave.TabIndex = 1;
            txt_Clave.Text = "1234";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(308, 226);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(76, 21);
            label1.TabIndex = 2;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bookman Old Style", 10F);
            label2.Location = new Point(321, 301);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(57, 21);
            label2.TabIndex = 3;
            label2.Text = "Clave";
            // 
            // btn_Ingresar
            // 
            btn_Ingresar.BackColor = Color.FromArgb(14, 93, 136);
            btn_Ingresar.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            btn_Ingresar.FlatStyle = FlatStyle.Flat;
            btn_Ingresar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btn_Ingresar.ForeColor = SystemColors.ControlLight;
            btn_Ingresar.Location = new Point(198, 392);
            btn_Ingresar.Margin = new Padding(1);
            btn_Ingresar.Name = "btn_Ingresar";
            btn_Ingresar.Size = new Size(289, 44);
            btn_Ingresar.TabIndex = 4;
            btn_Ingresar.Text = "Iniciar Sesión";
            btn_Ingresar.UseVisualStyleBackColor = false;
            btn_Ingresar.Click += btn_Ingresar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Small", 25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(163, 47);
            label3.Name = "label3";
            label3.Size = new Size(484, 62);
            label3.TabIndex = 6;
            label3.Text = "Manolo Barber Shop";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Small", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(219, 156);
            label4.Name = "label4";
            label4.Size = new Size(241, 50);
            label4.TabIndex = 7;
            label4.Text = "USER LOGIN";
            // 
            // btnRegistrarse
            // 
            btnRegistrarse.BackColor = Color.FromArgb(14, 93, 136);
            btnRegistrarse.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            btnRegistrarse.FlatStyle = FlatStyle.Flat;
            btnRegistrarse.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRegistrarse.ForeColor = SystemColors.ControlLight;
            btnRegistrarse.Location = new Point(198, 447);
            btnRegistrarse.Margin = new Padding(1);
            btnRegistrarse.Name = "btnRegistrarse";
            btnRegistrarse.Size = new Size(289, 44);
            btnRegistrarse.TabIndex = 10;
            btnRegistrarse.Text = "Registrarse";
            btnRegistrarse.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.barbero;
            pictureBox1.Location = new Point(32, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 142);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.usuario__7_;
            pictureBox2.Location = new Point(219, 256);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 27);
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.candado;
            pictureBox3.Location = new Point(219, 332);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(38, 27);
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            // 
            // InicioDeSecion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(680, 537);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnRegistrarse);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btn_Ingresar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_Clave);
            Controls.Add(txt_Usuario);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(1);
            Name = "InicioDeSecion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += InicioDeSecion_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Usuario;
        private TextBox txt_Clave;
        private Label label1;
        private Label label2;
        private Button btn_Ingresar;
        private Label label3;
        private Label label4;
        private Button btnRegistrarse;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}
