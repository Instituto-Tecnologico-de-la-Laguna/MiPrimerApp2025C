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
            rdbDivi = new RadioButton();
            rdbMulti = new RadioButton();
            rdbResta = new RadioButton();
            rdbSuma = new RadioButton();
            butBorrar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 20);
            label1.Name = "label1";
            label1.Size = new Size(71, 25);
            label1.TabIndex = 0;
            label1.Text = "Valor 1:";
            // 
            // txtValor1
            // 
            txtValor1.Location = new Point(17, 48);
            txtValor1.Name = "txtValor1";
            txtValor1.Size = new Size(273, 31);
            txtValor1.TabIndex = 1;
            // 
            // txtValor2
            // 
            txtValor2.Location = new Point(17, 127);
            txtValor2.Name = "txtValor2";
            txtValor2.Size = new Size(273, 31);
            txtValor2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 99);
            label2.Name = "label2";
            label2.Size = new Size(71, 25);
            label2.TabIndex = 2;
            label2.Text = "Valor 2:";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(328, 48);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(112, 34);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbDivi);
            groupBox1.Controls.Add(rdbMulti);
            groupBox1.Controls.Add(rdbResta);
            groupBox1.Controls.Add(rdbSuma);
            groupBox1.Location = new Point(103, 208);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(388, 150);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "OPERACION";
            // 
            // rdbDivi
            // 
            rdbDivi.AutoSize = true;
            rdbDivi.Location = new Point(181, 95);
            rdbDivi.Name = "rdbDivi";
            rdbDivi.Size = new Size(113, 29);
            rdbDivi.TabIndex = 3;
            rdbDivi.TabStop = true;
            rdbDivi.Text = "DIVISION";
            rdbDivi.UseVisualStyleBackColor = true;
            // 
            // rdbMulti
            // 
            rdbMulti.AutoSize = true;
            rdbMulti.Location = new Point(181, 45);
            rdbMulti.Name = "rdbMulti";
            rdbMulti.Size = new Size(175, 29);
            rdbMulti.TabIndex = 2;
            rdbMulti.TabStop = true;
            rdbMulti.Text = "MULTIPLICACION";
            rdbMulti.UseVisualStyleBackColor = true;
            rdbMulti.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // rdbResta
            // 
            rdbResta.AutoSize = true;
            rdbResta.Location = new Point(29, 93);
            rdbResta.Name = "rdbResta";
            rdbResta.Size = new Size(87, 29);
            rdbResta.TabIndex = 1;
            rdbResta.TabStop = true;
            rdbResta.Text = "RESTA";
            rdbResta.UseVisualStyleBackColor = true;
            // 
            // rdbSuma
            // 
            rdbSuma.AutoSize = true;
            rdbSuma.Location = new Point(29, 45);
            rdbSuma.Name = "rdbSuma";
            rdbSuma.Size = new Size(87, 29);
            rdbSuma.TabIndex = 0;
            rdbSuma.TabStop = true;
            rdbSuma.Text = "SUMA";
            rdbSuma.UseVisualStyleBackColor = true;
            // 
            // butBorrar
            // 
            butBorrar.Location = new Point(328, 127);
            butBorrar.Name = "butBorrar";
            butBorrar.Size = new Size(112, 34);
            butBorrar.TabIndex = 6;
            butBorrar.Text = "Borrar";
            butBorrar.UseVisualStyleBackColor = true;
            butBorrar.Click += butBorrar_Click;
            // 
            // frmOperacion2Numeros
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(677, 390);
            Controls.Add(butBorrar);
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
        private RadioButton rdbDivi;
        private RadioButton rdbMulti;
        private RadioButton rdbResta;
        private RadioButton rdbSuma;
        private Button butBorrar;
    }
}