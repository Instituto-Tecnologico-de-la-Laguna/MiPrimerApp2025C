namespace MiPrimerApp2025C
{
    partial class frmOperacion2Numeros
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
            Txtvalor1 = new TextBox();
            Txtvalor2 = new TextBox();
            label2 = new Label();
            Btncalcular = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 40);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 0;
            label1.Text = "Valor 1:";
            label1.Click += label1_Click;
            // 
            // Txtvalor1
            // 
            Txtvalor1.Location = new Point(70, 83);
            Txtvalor1.Name = "Txtvalor1";
            Txtvalor1.Size = new Size(125, 27);
            Txtvalor1.TabIndex = 1;
            // 
            // Txtvalor2
            // 
            Txtvalor2.Location = new Point(70, 222);
            Txtvalor2.Name = "Txtvalor2";
            Txtvalor2.Size = new Size(125, 27);
            Txtvalor2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 179);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 2;
            label2.Text = "Valor 2:";
            // 
            // Btncalcular
            // 
            Btncalcular.Location = new Point(416, 127);
            Btncalcular.Name = "Btncalcular";
            Btncalcular.Size = new Size(94, 29);
            Btncalcular.TabIndex = 4;
            Btncalcular.Text = "Calcular";
            Btncalcular.UseVisualStyleBackColor = true;
            Btncalcular.Click += Btncalcular_Click;
            // 
            // frmOperacion2Numeros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(686, 370);
            Controls.Add(Btncalcular);
            Controls.Add(Txtvalor2);
            Controls.Add(label2);
            Controls.Add(Txtvalor1);
            Controls.Add(label1);
            Name = "frmOperacion2Numeros";
            Text = "frmOperacion2Numeros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox Txtvalor1;
        private TextBox Txtvalor2;
        private Label label2;
        private Button Btncalcular;
    }
}