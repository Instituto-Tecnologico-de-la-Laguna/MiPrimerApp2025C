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
            txtBox2 = new TextBox();
            label2 = new Label();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(139, 21);
            label1.Name = "label1";
            label1.Size = new Size(71, 25);
            label1.TabIndex = 0;
            label1.Text = "Valor 1:";
            // 
            // txtValor1
            // 
            txtValor1.Location = new Point(82, 62);
            txtValor1.Name = "txtValor1";
            txtValor1.Size = new Size(189, 31);
            txtValor1.TabIndex = 1;
            // 
            // txtBox2
            // 
            txtBox2.Location = new Point(83, 174);
            txtBox2.Name = "txtBox2";
            txtBox2.Size = new Size(189, 31);
            txtBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(140, 133);
            label2.Name = "label2";
            label2.Size = new Size(71, 25);
            label2.TabIndex = 2;
            label2.Text = "Valor 2:";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(122, 269);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(112, 34);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // frmOperacion2Numeros
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 345);
            Controls.Add(btnCalcular);
            Controls.Add(txtBox2);
            Controls.Add(label2);
            Controls.Add(txtValor1);
            Controls.Add(label1);
            Name = "frmOperacion2Numeros";
            Text = "Operaciones 2 Numeros";
            Load += frmOperacion2Numeros_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtValor1;
        private TextBox txtBox2;
        private Label label2;
        private Button btnCalcular;
    }
}