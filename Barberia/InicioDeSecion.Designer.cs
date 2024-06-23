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
            SuspendLayout();
            // 
            // txt_Usuario
            // 
            txt_Usuario.Location = new Point(139, 52);
            txt_Usuario.Margin = new Padding(1);
            txt_Usuario.Name = "txt_Usuario";
            txt_Usuario.Size = new Size(120, 27);
            txt_Usuario.TabIndex = 0;
            // 
            // txt_Clave
            // 
            txt_Clave.Location = new Point(139, 98);
            txt_Clave.Margin = new Padding(1);
            txt_Clave.Name = "txt_Clave";
            txt_Clave.Size = new Size(120, 27);
            txt_Clave.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 52);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 2;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 105);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 3;
            label2.Text = "Clave";
            // 
            // btn_Ingresar
            // 
            btn_Ingresar.Location = new Point(90, 152);
            btn_Ingresar.Margin = new Padding(1);
            btn_Ingresar.Name = "btn_Ingresar";
            btn_Ingresar.Size = new Size(144, 44);
            btn_Ingresar.TabIndex = 4;
            btn_Ingresar.Text = "Ingresar";
            btn_Ingresar.UseVisualStyleBackColor = true;
            btn_Ingresar.Click += btn_Ingresar_Click;
            // 
            // InicioDeSecion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 255);
            Controls.Add(btn_Ingresar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_Clave);
            Controls.Add(txt_Usuario);
            Margin = new Padding(1);
            Name = "InicioDeSecion";
            Text = "Form1";
            Load += InicioDeSecion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Usuario;
        private TextBox txt_Clave;
        private Label label1;
        private Label label2;
        private Button btn_Ingresar;
    }
}
