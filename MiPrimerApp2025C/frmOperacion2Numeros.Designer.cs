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
            groupBox1 = new GroupBox();
            rbdDivision = new RadioButton();
            rbdMultiplicacion = new RadioButton();
            rbdResta = new RadioButton();
            rbdSuma = new RadioButton();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "Valor 1:";
            // 
            // txtValor1
            // 
            txtValor1.Location = new Point(12, 29);
            txtValor1.Margin = new Padding(2);
            txtValor1.Name = "txtValor1";
            txtValor1.Size = new Size(192, 23);
            txtValor1.TabIndex = 1;
            // 
            // txtValor2
            // 
            txtValor2.Location = new Point(12, 76);
            txtValor2.Margin = new Padding(2);
            txtValor2.Name = "txtValor2";
            txtValor2.Size = new Size(192, 23);
            txtValor2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 59);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 2;
            label2.Text = "Valor 2:";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(239, 32);
            btnCalcular.Margin = new Padding(2);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(78, 20);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbdDivision);
            groupBox1.Controls.Add(rbdMultiplicacion);
            groupBox1.Controls.Add(rbdResta);
            groupBox1.Controls.Add(rbdSuma);
            groupBox1.Location = new Point(44, 157);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(273, 100);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Operacion";
            // 
            // rbdDivision
            // 
            rbdDivision.AutoSize = true;
            rbdDivision.Location = new Point(135, 60);
            rbdDivision.Name = "rbdDivision";
            rbdDivision.Size = new Size(67, 19);
            rbdDivision.TabIndex = 3;
            rbdDivision.TabStop = true;
            rbdDivision.Text = "Division";
            rbdDivision.UseVisualStyleBackColor = true;
            // 
            // rbdMultiplicacion
            // 
            rbdMultiplicacion.AutoSize = true;
            rbdMultiplicacion.Location = new Point(135, 29);
            rbdMultiplicacion.Name = "rbdMultiplicacion";
            rbdMultiplicacion.Size = new Size(101, 19);
            rbdMultiplicacion.TabIndex = 2;
            rbdMultiplicacion.TabStop = true;
            rbdMultiplicacion.Text = "Multiplicacion";
            rbdMultiplicacion.UseVisualStyleBackColor = true;
            // 
            // rbdResta
            // 
            rbdResta.AutoSize = true;
            rbdResta.Location = new Point(19, 60);
            rbdResta.Name = "rbdResta";
            rbdResta.Size = new Size(53, 19);
            rbdResta.TabIndex = 1;
            rbdResta.TabStop = true;
            rbdResta.Text = "Resta";
            rbdResta.UseVisualStyleBackColor = true;
            // 
            // rbdSuma
            // 
            rbdSuma.AutoSize = true;
            rbdSuma.Location = new Point(19, 29);
            rbdSuma.Name = "rbdSuma";
            rbdSuma.Size = new Size(55, 19);
            rbdSuma.TabIndex = 0;
            rbdSuma.TabStop = true;
            rbdSuma.Text = "Suma";
            rbdSuma.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(242, 66);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Borrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmOperacion2Numeros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 281);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(btnCalcular);
            Controls.Add(txtValor2);
            Controls.Add(label2);
            Controls.Add(txtValor1);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "frmOperacion2Numeros";
            Text = "Operaciones 2 Numeros";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtValor1;
        private TextBox txtValor2;
        private Label label2;
        private Button btnCalcular;
        private GroupBox groupBox1;
        private RadioButton rbdDivision;
        private RadioButton rbdMultiplicacion;
        private RadioButton rbdResta;
        private RadioButton rbdSuma;
        private Button button1;
    }
}