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
            radioButton3 = new RadioButton();
            rbdMultiplicacion = new RadioButton();
            rbdSuma = new RadioButton();
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
            btnCalcular.Location = new Point(239, 54);
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
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(rbdMultiplicacion);
            groupBox1.Controls.Add(rbdSuma);
            groupBox1.Location = new Point(165, 128);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(332, 154);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Operacion";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // rbdDivision
            // 
            rbdDivision.AutoSize = true;
            rbdDivision.Location = new Point(205, 111);
            rbdDivision.Name = "rbdDivision";
            rbdDivision.Size = new Size(67, 19);
            rbdDivision.TabIndex = 3;
            rbdDivision.Text = "Division";
            rbdDivision.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(17, 111);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(53, 19);
            radioButton3.TabIndex = 2;
            radioButton3.Text = "Resta";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // rbdMultiplicacion
            // 
            rbdMultiplicacion.AutoSize = true;
            rbdMultiplicacion.Location = new Point(196, 45);
            rbdMultiplicacion.Name = "rbdMultiplicacion";
            rbdMultiplicacion.Size = new Size(101, 19);
            rbdMultiplicacion.TabIndex = 1;
            rbdMultiplicacion.Text = "Multiplicacion";
            rbdMultiplicacion.UseVisualStyleBackColor = true;
            rbdMultiplicacion.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // rbdSuma
            // 
            rbdSuma.AutoSize = true;
            rbdSuma.Location = new Point(17, 39);
            rbdSuma.Name = "rbdSuma";
            rbdSuma.Size = new Size(55, 19);
            rbdSuma.TabIndex = 0;
            rbdSuma.Text = "Suma";
            rbdSuma.UseVisualStyleBackColor = true;
            rbdSuma.Visible = false;
            rbdSuma.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // frmOperacion2Numeros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(690, 333);
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
        private RadioButton radioButton3;
        private RadioButton rbdMultiplicacion;
        private RadioButton rbdSuma;
    }
}