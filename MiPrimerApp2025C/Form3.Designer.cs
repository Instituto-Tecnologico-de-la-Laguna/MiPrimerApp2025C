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
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 199);
            Controls.Add(button1);
            Controls.Add(VALOR2);
            Controls.Add(label2);
            Controls.Add(VALOR1);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox VALOR1;
        private TextBox VALOR2;
        private Label label2;
        private Button button1;
    }
}