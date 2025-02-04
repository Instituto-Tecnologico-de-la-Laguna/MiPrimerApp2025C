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
            txtValor1 = new TextBox();
            txtValor2 = new TextBox();
            label2 = new Label();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 43);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 0;
            label1.Text = "Valor 1:";
            label1.Click += label1_Click;
            // 
            // txtValor1
            // 
            txtValor1.Location = new Point(55, 75);
            txtValor1.Name = "txtValor1";
            txtValor1.Size = new Size(248, 27);
            txtValor1.TabIndex = 2;
            // 
            // txtValor2
            // 
            txtValor2.Location = new Point(55, 153);
            txtValor2.Name = "txtValor2";
            txtValor2.Size = new Size(248, 27);
            txtValor2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 121);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 3;
            label2.Text = "Valor 2:";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(351, 112);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // frmOperacion2Numeros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 242);
            Controls.Add(btnCalcular);
            Controls.Add(txtValor2);
            Controls.Add(label2);
            Controls.Add(txtValor1);
            Controls.Add(label1);
            Name = "frmOperacion2Numeros";
            Text = "Operaciones 2 Numeros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtValor1;
        private TextBox txtValor2;
        private Label label2;
        private Button btnCalcular;
    }
}