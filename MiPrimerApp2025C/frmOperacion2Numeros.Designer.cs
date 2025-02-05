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
            Operacion = new GroupBox();
            rdbSuma = new RadioButton();
            rdbresta = new RadioButton();
            rdbMultiplicacion = new RadioButton();
            rdbDivision = new RadioButton();
            btnborrar = new Button();
            Operacion.SuspendLayout();
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
            btnCalcular.Location = new Point(256, 29);
            btnCalcular.Margin = new Padding(2);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(78, 20);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // Operacion
            // 
            Operacion.Controls.Add(rdbDivision);
            Operacion.Controls.Add(rdbSuma);
            Operacion.Controls.Add(rdbMultiplicacion);
            Operacion.Controls.Add(rdbresta);
            Operacion.Location = new Point(12, 119);
            Operacion.Name = "Operacion";
            Operacion.Size = new Size(238, 118);
            Operacion.TabIndex = 5;
            Operacion.TabStop = false;
            Operacion.Text = "groupBox1";
            // 
            // rdbSuma
            // 
            rdbSuma.AutoSize = true;
            rdbSuma.Location = new Point(6, 22);
            rdbSuma.Name = "rdbSuma";
            rdbSuma.Size = new Size(55, 19);
            rdbSuma.TabIndex = 6;
            rdbSuma.TabStop = true;
            rdbSuma.Text = "Suma";
            rdbSuma.UseVisualStyleBackColor = true;
            // 
            // rdbresta
            // 
            rdbresta.AutoSize = true;
            rdbresta.Location = new Point(6, 66);
            rdbresta.Name = "rdbresta";
            rdbresta.Size = new Size(53, 19);
            rdbresta.TabIndex = 7;
            rdbresta.TabStop = true;
            rdbresta.Text = "Resta";
            rdbresta.UseVisualStyleBackColor = true;
            // 
            // rdbMultiplicacion
            // 
            rdbMultiplicacion.AutoSize = true;
            rdbMultiplicacion.Location = new Point(91, 22);
            rdbMultiplicacion.Name = "rdbMultiplicacion";
            rdbMultiplicacion.Size = new Size(101, 19);
            rdbMultiplicacion.TabIndex = 8;
            rdbMultiplicacion.TabStop = true;
            rdbMultiplicacion.Text = "Multiplicacion";
            rdbMultiplicacion.UseVisualStyleBackColor = true;
            // 
            // rdbDivision
            // 
            rdbDivision.AutoSize = true;
            rdbDivision.Location = new Point(91, 66);
            rdbDivision.Name = "rdbDivision";
            rdbDivision.Size = new Size(67, 19);
            rdbDivision.TabIndex = 9;
            rdbDivision.TabStop = true;
            rdbDivision.Text = "Division";
            rdbDivision.UseVisualStyleBackColor = true;
            // 
            // btnborrar
            // 
            btnborrar.Location = new Point(256, 76);
            btnborrar.Name = "btnborrar";
            btnborrar.Size = new Size(75, 23);
            btnborrar.TabIndex = 6;
            btnborrar.Text = "Borrar";
            btnborrar.UseVisualStyleBackColor = true;
            btnborrar.Click += btnborrar_Click;
            // 
            // frmOperacion2Numeros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(590, 261);
            Controls.Add(btnborrar);
            Controls.Add(Operacion);
            Controls.Add(btnCalcular);
            Controls.Add(txtValor2);
            Controls.Add(label2);
            Controls.Add(txtValor1);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "frmOperacion2Numeros";
            Text = "Operaciones 2 Numeros";
            Operacion.ResumeLayout(false);
            Operacion.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtValor1;
        private TextBox txtValor2;
        private Label label2;
        private Button btnCalcular;
        private GroupBox Operacion;
        private RadioButton rdbSuma;
        private RadioButton rdbresta;
        private RadioButton rdbMultiplicacion;
        private RadioButton rdbDivision;
        private Button btnborrar;
    }
}