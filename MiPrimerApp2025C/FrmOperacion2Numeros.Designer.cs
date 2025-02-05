namespace MiPrimerApp2025C
{
    partial class FrmOperacion2Numeros
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
            rdbDivisión = new RadioButton();
            rdbMultiplicación = new RadioButton();
            rdbResta = new RadioButton();
            rdbSuma = new RadioButton();
            btnBorrar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "Valor 1:";
            // 
            // txtValor1
            // 
            txtValor1.Location = new Point(12, 45);
            txtValor1.Name = "txtValor1";
            txtValor1.Size = new Size(183, 23);
            txtValor1.TabIndex = 1;
            // 
            // txtValor2
            // 
            txtValor2.Location = new Point(12, 108);
            txtValor2.Name = "txtValor2";
            txtValor2.Size = new Size(183, 23);
            txtValor2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 90);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 2;
            label2.Text = "Valor 2:";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(201, 69);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(92, 36);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbDivisión);
            groupBox1.Controls.Add(rdbMultiplicación);
            groupBox1.Controls.Add(rdbResta);
            groupBox1.Controls.Add(rdbSuma);
            groupBox1.Location = new Point(12, 154);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(364, 118);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Operación:";
            // 
            // rdbDivisión
            // 
            rdbDivisión.AutoSize = true;
            rdbDivisión.Location = new Point(203, 79);
            rdbDivisión.Name = "rdbDivisión";
            rdbDivisión.Size = new Size(67, 19);
            rdbDivisión.TabIndex = 3;
            rdbDivisión.TabStop = true;
            rdbDivisión.Text = "División";
            rdbDivisión.UseVisualStyleBackColor = true;
            // 
            // rdbMultiplicación
            // 
            rdbMultiplicación.AutoSize = true;
            rdbMultiplicación.Location = new Point(203, 31);
            rdbMultiplicación.Name = "rdbMultiplicación";
            rdbMultiplicación.Size = new Size(98, 19);
            rdbMultiplicación.TabIndex = 2;
            rdbMultiplicación.TabStop = true;
            rdbMultiplicación.Text = "Multipicación";
            rdbMultiplicación.UseVisualStyleBackColor = true;
            // 
            // rdbResta
            // 
            rdbResta.AutoSize = true;
            rdbResta.Location = new Point(70, 79);
            rdbResta.Name = "rdbResta";
            rdbResta.Size = new Size(53, 19);
            rdbResta.TabIndex = 1;
            rdbResta.TabStop = true;
            rdbResta.Text = "Resta";
            rdbResta.UseVisualStyleBackColor = true;
            // 
            // rdbSuma
            // 
            rdbSuma.AutoSize = true;
            rdbSuma.Location = new Point(70, 31);
            rdbSuma.Name = "rdbSuma";
            rdbSuma.Size = new Size(55, 19);
            rdbSuma.TabIndex = 0;
            rdbSuma.TabStop = true;
            rdbSuma.Text = "Suma";
            rdbSuma.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(311, 125);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(75, 23);
            btnBorrar.TabIndex = 6;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // FrmOperacion2Numeros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 284);
            Controls.Add(btnBorrar);
            Controls.Add(groupBox1);
            Controls.Add(btnCalcular);
            Controls.Add(txtValor2);
            Controls.Add(label2);
            Controls.Add(txtValor1);
            Controls.Add(label1);
            Name = "FrmOperacion2Numeros";
            Text = "Operaciones 2 números";
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
        private RadioButton rdbDivisión;
        private RadioButton rdbMultiplicación;
        private RadioButton rdbResta;
        private RadioButton rdbSuma;
        private Button btnBorrar;
    }
}