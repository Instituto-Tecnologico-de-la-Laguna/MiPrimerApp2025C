namespace MiPrimerApp2025C
{
    partial class Form3
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
            label1 = new Label();
            VALOR1 = new TextBox();
            VALOR2 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            groupBox1 = new GroupBox();
            MULT = new RadioButton();
            DIV = new RadioButton();
            RESTA = new RadioButton();
            SUMA = new RadioButton();
            button2 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 11);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 0;
            label1.Text = "Valor 1:";
            // 
            // VALOR1
            // 
            VALOR1.Location = new Point(90, 8);
            VALOR1.Name = "VALOR1";
            VALOR1.Size = new Size(125, 27);
            VALOR1.TabIndex = 1;
            // 
            // VALOR2
            // 
            VALOR2.Location = new Point(90, 41);
            VALOR2.Name = "VALOR2";
            VALOR2.Size = new Size(125, 27);
            VALOR2.TabIndex = 3;
            VALOR2.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 44);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 2;
            label2.Text = "Valor 2:";
            // 
            // button1
            // 
            button1.Location = new Point(243, 24);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "CALCULAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(MULT);
            groupBox1.Controls.Add(DIV);
            groupBox1.Controls.Add(RESTA);
            groupBox1.Controls.Add(SUMA);
            groupBox1.Location = new Point(17, 74);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(456, 196);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "OPERACIONES";
            // 
            // MULT
            // 
            MULT.AutoSize = true;
            MULT.Location = new Point(148, 26);
            MULT.Name = "MULT";
            MULT.Size = new Size(124, 24);
            MULT.TabIndex = 3;
            MULT.TabStop = true;
            MULT.Text = "multiplicacion";
            MULT.UseVisualStyleBackColor = true;
            // 
            // DIV
            // 
            DIV.AutoSize = true;
            DIV.Location = new Point(278, 26);
            DIV.Name = "DIV";
            DIV.Size = new Size(81, 24);
            DIV.TabIndex = 2;
            DIV.TabStop = true;
            DIV.Text = "division";
            DIV.UseVisualStyleBackColor = true;
            // 
            // RESTA
            // 
            RESTA.AutoSize = true;
            RESTA.Location = new Point(77, 26);
            RESTA.Name = "RESTA";
            RESTA.Size = new Size(62, 24);
            RESTA.TabIndex = 1;
            RESTA.TabStop = true;
            RESTA.Text = "resta";
            RESTA.UseVisualStyleBackColor = true;
            // 
            // SUMA
            // 
            SUMA.AutoSize = true;
            SUMA.Location = new Point(6, 26);
            SUMA.Name = "SUMA";
            SUMA.Size = new Size(65, 24);
            SUMA.TabIndex = 0;
            SUMA.TabStop = true;
            SUMA.Text = "suma";
            SUMA.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(479, 241);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 6;
            button2.Text = "BORRAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 310);
            Controls.Add(button2);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(VALOR2);
            Controls.Add(label2);
            Controls.Add(VALOR1);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox VALOR1;
        private TextBox VALOR2;
        private Label label2;
        private Button button1;
        private GroupBox groupBox1;
        private RadioButton MULT;
        private RadioButton DIV;
        private RadioButton RESTA;
        private RadioButton SUMA;
        private Button button2;
    }
}