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
            rdbMultiplicacion = new RadioButton();
            rdbDivision = new RadioButton();
            rdbResta = new RadioButton();
            rdbSuma = new RadioButton();
            buttonBorrar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 23);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 0;
            label1.Text = "Valor 1:";
            // 
            // txtValor1
            // 
            txtValor1.Location = new Point(32, 63);
            txtValor1.Name = "txtValor1";
            txtValor1.Size = new Size(257, 27);
            txtValor1.TabIndex = 1;
            txtValor1.TextChanged += textBox1_TextChanged;
            // 
            // txtValor2
            // 
            txtValor2.Location = new Point(32, 160);
            txtValor2.Name = "txtValor2";
            txtValor2.Size = new Size(257, 27);
            txtValor2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 120);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 2;
            label2.Text = "Valor 2:";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(334, 61);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(164, 29);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbMultiplicacion);
            groupBox1.Controls.Add(rdbDivision);
            groupBox1.Controls.Add(rdbResta);
            groupBox1.Controls.Add(rdbSuma);
            groupBox1.Location = new Point(30, 221);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(293, 125);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Operacion";
            // 
            // rdbMultiplicacion
            // 
            rdbMultiplicacion.AutoSize = true;
            rdbMultiplicacion.Location = new Point(126, 38);
            rdbMultiplicacion.Name = "rdbMultiplicacion";
            rdbMultiplicacion.Size = new Size(124, 24);
            rdbMultiplicacion.TabIndex = 3;
            rdbMultiplicacion.TabStop = true;
            rdbMultiplicacion.Text = "Multiplicacion";
            rdbMultiplicacion.UseVisualStyleBackColor = true;
            // 
            // rdbDivision
            // 
            rdbDivision.AutoSize = true;
            rdbDivision.Location = new Point(126, 86);
            rdbDivision.Name = "rdbDivision";
            rdbDivision.Size = new Size(83, 24);
            rdbDivision.TabIndex = 2;
            rdbDivision.TabStop = true;
            rdbDivision.Text = "Division";
            rdbDivision.UseVisualStyleBackColor = true;
            // 
            // rdbResta
            // 
            rdbResta.AutoSize = true;
            rdbResta.Location = new Point(8, 86);
            rdbResta.Name = "rdbResta";
            rdbResta.Size = new Size(66, 24);
            rdbResta.TabIndex = 1;
            rdbResta.TabStop = true;
            rdbResta.Text = "Resta";
            rdbResta.UseVisualStyleBackColor = true;
            // 
            // rdbSuma
            // 
            rdbSuma.AutoSize = true;
            rdbSuma.Location = new Point(8, 38);
            rdbSuma.Name = "rdbSuma";
            rdbSuma.Size = new Size(67, 24);
            rdbSuma.TabIndex = 0;
            rdbSuma.TabStop = true;
            rdbSuma.Text = "Suma";
            rdbSuma.UseVisualStyleBackColor = true;
            // 
            // buttonBorrar
            // 
            buttonBorrar.Location = new Point(334, 158);
            buttonBorrar.Name = "buttonBorrar";
            buttonBorrar.Size = new Size(164, 29);
            buttonBorrar.TabIndex = 6;
            buttonBorrar.Text = "Borrar";
            buttonBorrar.UseVisualStyleBackColor = true;
            buttonBorrar.Click += buttonBorrar_Click;
            // 
            // frmOperacion2Numeros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 420);
            Controls.Add(buttonBorrar);
            Controls.Add(groupBox1);
            Controls.Add(btnCalcular);
            Controls.Add(txtValor2);
            Controls.Add(label2);
            Controls.Add(txtValor1);
            Controls.Add(label1);
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
        private RadioButton rdbMultiplicacion;
        private RadioButton rdbDivision;
        private RadioButton rdbResta;
        private RadioButton rdbSuma;
        private Button buttonBorrar;
    }
}