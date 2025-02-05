namespace MiPrimerApp2025C
{
    partial class frmOperaciones2Numeros
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
            textValor1 = new TextBox();
            textValor2 = new TextBox();
            label3 = new Label();
            btnCalcular = new Button();
            groupBox1 = new GroupBox();
            rdbresta = new RadioButton();
            rdbdivision = new RadioButton();
            rdbmultiplicacion = new RadioButton();
            rdbsuma = new RadioButton();
            butborrar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 9);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 9);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 1;
            label2.Text = "Valor 1:";
            // 
            // textValor1
            // 
            textValor1.Location = new Point(24, 32);
            textValor1.Name = "textValor1";
            textValor1.Size = new Size(296, 27);
            textValor1.TabIndex = 2;
            // 
            // textValor2
            // 
            textValor2.Location = new Point(24, 91);
            textValor2.Name = "textValor2";
            textValor2.Size = new Size(296, 27);
            textValor2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 68);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 3;
            label3.Text = "Valor 2:";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(387, 89);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbresta);
            groupBox1.Controls.Add(rdbdivision);
            groupBox1.Controls.Add(rdbmultiplicacion);
            groupBox1.Controls.Add(rdbsuma);
            groupBox1.Location = new Point(12, 124);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(469, 125);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Operacion";
            // 
            // rdbresta
            // 
            rdbresta.AutoSize = true;
            rdbresta.Location = new Point(18, 78);
            rdbresta.Name = "rdbresta";
            rdbresta.Size = new Size(66, 24);
            rdbresta.TabIndex = 3;
            rdbresta.TabStop = true;
            rdbresta.Text = "Resta";
            rdbresta.UseVisualStyleBackColor = true;
            // 
            // rdbdivision
            // 
            rdbdivision.AutoSize = true;
            rdbdivision.Location = new Point(307, 78);
            rdbdivision.Name = "rdbdivision";
            rdbdivision.Size = new Size(83, 24);
            rdbdivision.TabIndex = 2;
            rdbdivision.TabStop = true;
            rdbdivision.Text = "Division";
            rdbdivision.UseVisualStyleBackColor = true;
            // 
            // rdbmultiplicacion
            // 
            rdbmultiplicacion.AutoSize = true;
            rdbmultiplicacion.Location = new Point(307, 26);
            rdbmultiplicacion.Name = "rdbmultiplicacion";
            rdbmultiplicacion.Size = new Size(124, 24);
            rdbmultiplicacion.TabIndex = 1;
            rdbmultiplicacion.TabStop = true;
            rdbmultiplicacion.Text = "Multiplicacion";
            rdbmultiplicacion.UseVisualStyleBackColor = true;
            // 
            // rdbsuma
            // 
            rdbsuma.AutoSize = true;
            rdbsuma.Location = new Point(18, 26);
            rdbsuma.Name = "rdbsuma";
            rdbsuma.Size = new Size(67, 24);
            rdbsuma.TabIndex = 0;
            rdbsuma.TabStop = true;
            rdbsuma.Text = "Suma";
            rdbsuma.UseVisualStyleBackColor = true;
            // 
            // butborrar
            // 
            butborrar.Location = new Point(387, 32);
            butborrar.Name = "butborrar";
            butborrar.Size = new Size(94, 29);
            butborrar.TabIndex = 7;
            butborrar.Text = "Borrar";
            butborrar.UseVisualStyleBackColor = true;
            butborrar.Click += butborrar_Click;
            // 
            // frmOperaciones2Numeros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(529, 293);
            Controls.Add(butborrar);
            Controls.Add(groupBox1);
            Controls.Add(btnCalcular);
            Controls.Add(textValor2);
            Controls.Add(label3);
            Controls.Add(textValor1);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.Black;
            Name = "frmOperaciones2Numeros";
            Text = "Operaciones 2 Numeros";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textValor1;
        private TextBox textValor2;
        private Label label3;
        private Button btnCalcular;
        private GroupBox groupBox1;
        private RadioButton rdbresta;
        private RadioButton rdbdivision;
        private RadioButton rdbmultiplicacion;
        private RadioButton rdbsuma;
        private Button butborrar;
    }
}