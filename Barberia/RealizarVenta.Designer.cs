﻿namespace Barberia
{
    partial class RealizarVenta
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
            button1 = new Button();
            numericUpDown1 = new NumericUpDown();
            dataGridView1 = new DataGridView();
            dataGridView3 = new DataGridView();
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            button4 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(15, 6);
            button1.Margin = new Padding(1);
            button1.Name = "button1";
            button1.Size = new Size(88, 28);
            button1.TabIndex = 2;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(501, 66);
            numericUpDown1.Margin = new Padding(1);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(170, 27);
            numericUpDown1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(7, 105);
            dataGridView1.Margin = new Padding(1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 102;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1011, 539);
            dataGridView1.TabIndex = 0;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(1038, 100);
            dataGridView3.Margin = new Padding(1);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 102;
            dataGridView3.Size = new Size(681, 540);
            dataGridView3.TabIndex = 4;
            dataGridView3.CellContentClick += dataGridView3_CellContentClick;
            // 
            // button2
            // 
            button2.Location = new Point(144, 6);
            button2.Margin = new Padding(1);
            button2.Name = "button2";
            button2.Size = new Size(88, 28);
            button2.TabIndex = 5;
            button2.Text = "Productos";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(265, 6);
            button3.Margin = new Padding(1);
            button3.Name = "button3";
            button3.Size = new Size(88, 28);
            button3.TabIndex = 6;
            button3.Text = "Clientes";
            button3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(7, 66);
            textBox1.Margin = new Padding(1);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(330, 27);
            textBox1.TabIndex = 7;
            // 
            // button4
            // 
            button4.Location = new Point(350, 65);
            button4.Margin = new Padding(1);
            button4.Name = "button4";
            button4.Size = new Size(134, 29);
            button4.TabIndex = 8;
            button4.Text = "Buscar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button6
            // 
            button6.Location = new Point(691, 65);
            button6.Margin = new Padding(1);
            button6.Name = "button6";
            button6.Size = new Size(88, 28);
            button6.TabIndex = 11;
            button6.Text = "Cantidad";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(1234, 62);
            button7.Margin = new Padding(1);
            button7.Name = "button7";
            button7.Size = new Size(88, 28);
            button7.TabIndex = 12;
            button7.Text = "Comprar";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(1366, 62);
            button8.Margin = new Padding(1);
            button8.Name = "button8";
            button8.Size = new Size(88, 28);
            button8.TabIndex = 13;
            button8.Text = "Eliminar";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(374, 6);
            button9.Margin = new Padding(1);
            button9.Name = "button9";
            button9.Size = new Size(88, 28);
            button9.TabIndex = 14;
            button9.Text = "Ventas";
            button9.UseVisualStyleBackColor = true;
            // 
            // RealizarVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1741, 808);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button4);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dataGridView3);
            Controls.Add(numericUpDown1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Margin = new Padding(1);
            Name = "RealizarVenta";
            Text = "Realizar Venta — Manolo Barber Shop";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private NumericUpDown numericUpDown1;
        private DataGridView dataGridView1;
        private DataGridView dataGridView3;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private Button button4;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
    }
}