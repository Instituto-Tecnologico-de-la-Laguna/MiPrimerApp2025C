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
            label2 = new Label();
            txtValor1 = new TextBox();
            txtValor2 = new TextBox();
            btnCalcular = new Button();
            groupBox1 = new GroupBox();
            rdbDivision = new RadioButton();
            rdbMultiplicacion = new RadioButton();
            rdbResta = new RadioButton();
            rdbSuma = new RadioButton();
            buttonBorrar = new Button();
            label3 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 35);
            label1.Name = "label1";
            label1.Size = new Size(71, 25);
            label1.TabIndex = 0;
            label1.Text = "Valor 1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 119);
            label2.Name = "label2";
            label2.Size = new Size(76, 25);
            label2.TabIndex = 1;
            label2.Text = "Valor 2 :";
            // 
            // txtValor1
            // 
            txtValor1.Location = new Point(25, 63);
            txtValor1.Name = "txtValor1";
            txtValor1.Size = new Size(232, 31);
            txtValor1.TabIndex = 2;
            // 
            // txtValor2
            // 
            txtValor2.Location = new Point(25, 147);
            txtValor2.Name = "txtValor2";
            txtValor2.Size = new Size(232, 31);
            txtValor2.TabIndex = 3;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(342, 63);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(112, 34);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbDivision);
            groupBox1.Controls.Add(rdbMultiplicacion);
            groupBox1.Controls.Add(rdbResta);
            groupBox1.Controls.Add(rdbSuma);
            groupBox1.Location = new Point(25, 259);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(362, 150);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Selecciona una Operacion: ";
            // 
            // rdbDivision
            // 
            rdbDivision.AutoSize = true;
            rdbDivision.Location = new Point(175, 88);
            rdbDivision.Name = "rdbDivision";
            rdbDivision.Size = new Size(100, 29);
            rdbDivision.TabIndex = 3;
            rdbDivision.TabStop = true;
            rdbDivision.Text = "Division";
            rdbDivision.UseVisualStyleBackColor = true;
            // 
            // rdbMultiplicacion
            // 
            rdbMultiplicacion.AutoSize = true;
            rdbMultiplicacion.Location = new Point(11, 88);
            rdbMultiplicacion.Name = "rdbMultiplicacion";
            rdbMultiplicacion.Size = new Size(146, 29);
            rdbMultiplicacion.TabIndex = 2;
            rdbMultiplicacion.TabStop = true;
            rdbMultiplicacion.Text = "Multiplicacion";
            rdbMultiplicacion.UseVisualStyleBackColor = true;
            // 
            // rdbResta
            // 
            rdbResta.AutoSize = true;
            rdbResta.Location = new Point(149, 33);
            rdbResta.Name = "rdbResta";
            rdbResta.Size = new Size(79, 29);
            rdbResta.TabIndex = 1;
            rdbResta.TabStop = true;
            rdbResta.Text = "Resta";
            rdbResta.UseVisualStyleBackColor = true;
            // 
            // rdbSuma
            // 
            rdbSuma.AutoSize = true;
            rdbSuma.Location = new Point(16, 33);
            rdbSuma.Name = "rdbSuma";
            rdbSuma.Size = new Size(82, 29);
            rdbSuma.TabIndex = 0;
            rdbSuma.TabStop = true;
            rdbSuma.Text = "Suma";
            rdbSuma.UseVisualStyleBackColor = true;
            // 
            // buttonBorrar
            // 
            buttonBorrar.Location = new Point(342, 119);
            buttonBorrar.Name = "buttonBorrar";
            buttonBorrar.Size = new Size(112, 34);
            buttonBorrar.TabIndex = 6;
            buttonBorrar.Text = "BORRAR";
            buttonBorrar.UseVisualStyleBackColor = true;
            buttonBorrar.Click += buttonBorrar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 231);
            label3.Name = "label3";
            label3.Size = new Size(195, 25);
            label3.TabIndex = 7;
            label3.Text = "Menu de Operaciones :";
            // 
            // frmOperacion2Numeros
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 467);
            Controls.Add(label3);
            Controls.Add(buttonBorrar);
            Controls.Add(groupBox1);
            Controls.Add(btnCalcular);
            Controls.Add(txtValor2);
            Controls.Add(txtValor1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmOperacion2Numeros";
            Text = " ";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtValor1;
        private TextBox txtValor2;
        private Button btnCalcular;
        private GroupBox groupBox1;
        private RadioButton rdbMultiplicacion;
        private RadioButton rdbResta;
        private RadioButton rdbSuma;
        private RadioButton rdbDivision;
        private Button buttonBorrar;
        private Label label3;
    }
}