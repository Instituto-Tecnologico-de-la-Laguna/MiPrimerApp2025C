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
            Txtvalor1 = new TextBox();
            Txtvalor2 = new TextBox();
            label2 = new Label();
            Btncalcular = new Button();
            groupBox1 = new GroupBox();
            rdbdivision = new RadioButton();
            rdbmultiplicacion = new RadioButton();
            rdbresta = new RadioButton();
            rdbsuma = new RadioButton();
            btnborrar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 40);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 0;
            label1.Text = "Valor 1:";
            label1.Click += label1_Click;
            // 
            // Txtvalor1
            // 
            Txtvalor1.Location = new Point(70, 83);
            Txtvalor1.Name = "Txtvalor1";
            Txtvalor1.Size = new Size(125, 27);
            Txtvalor1.TabIndex = 1;
            // 
            // Txtvalor2
            // 
            Txtvalor2.Location = new Point(70, 199);
            Txtvalor2.Name = "Txtvalor2";
            Txtvalor2.Size = new Size(125, 27);
            Txtvalor2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 162);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 2;
            label2.Text = "Valor 2:";
            // 
            // Btncalcular
            // 
            Btncalcular.Location = new Point(420, 83);
            Btncalcular.Name = "Btncalcular";
            Btncalcular.Size = new Size(94, 29);
            Btncalcular.TabIndex = 4;
            Btncalcular.Text = "Calcular";
            Btncalcular.UseVisualStyleBackColor = true;
            Btncalcular.Click += Btncalcular_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbdivision);
            groupBox1.Controls.Add(rdbmultiplicacion);
            groupBox1.Controls.Add(rdbresta);
            groupBox1.Controls.Add(rdbsuma);
            groupBox1.Location = new Point(42, 242);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(505, 215);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Operacion";
            // 
            // rdbdivision
            // 
            rdbdivision.AutoSize = true;
            rdbdivision.Location = new Point(192, 102);
            rdbdivision.Name = "rdbdivision";
            rdbdivision.Size = new Size(83, 24);
            rdbdivision.TabIndex = 3;
            rdbdivision.TabStop = true;
            rdbdivision.Text = "Division";
            rdbdivision.UseVisualStyleBackColor = true;
            // 
            // rdbmultiplicacion
            // 
            rdbmultiplicacion.AutoSize = true;
            rdbmultiplicacion.Location = new Point(192, 43);
            rdbmultiplicacion.Name = "rdbmultiplicacion";
            rdbmultiplicacion.Size = new Size(124, 24);
            rdbmultiplicacion.TabIndex = 2;
            rdbmultiplicacion.TabStop = true;
            rdbmultiplicacion.Text = "Multiplicacion";
            rdbmultiplicacion.UseVisualStyleBackColor = true;
            // 
            // rdbresta
            // 
            rdbresta.AutoSize = true;
            rdbresta.Location = new Point(25, 102);
            rdbresta.Name = "rdbresta";
            rdbresta.Size = new Size(66, 24);
            rdbresta.TabIndex = 1;
            rdbresta.TabStop = true;
            rdbresta.Text = "Resta";
            rdbresta.UseVisualStyleBackColor = true;
            // 
            // rdbsuma
            // 
            rdbsuma.AutoSize = true;
            rdbsuma.Location = new Point(25, 43);
            rdbsuma.Name = "rdbsuma";
            rdbsuma.Size = new Size(67, 24);
            rdbsuma.TabIndex = 0;
            rdbsuma.TabStop = true;
            rdbsuma.Text = "Suma";
            rdbsuma.UseVisualStyleBackColor = true;
            // 
            // btnborrar
            // 
            btnborrar.Location = new Point(420, 162);
            btnborrar.Name = "btnborrar";
            btnborrar.Size = new Size(94, 29);
            btnborrar.TabIndex = 6;
            btnborrar.Text = "Borrar";
            btnborrar.UseVisualStyleBackColor = true;
            btnborrar.Click += btnborrar_Click;
            // 
            // frmOperacion2Numeros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(830, 478);
            Controls.Add(btnborrar);
            Controls.Add(groupBox1);
            Controls.Add(Btncalcular);
            Controls.Add(Txtvalor2);
            Controls.Add(label2);
            Controls.Add(Txtvalor1);
            Controls.Add(label1);
            Name = "frmOperacion2Numeros";
            Text = "frmOperacion2Numeros";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox Txtvalor1;
        private TextBox Txtvalor2;
        private Label label2;
        private Button Btncalcular;
        private GroupBox groupBox1;
        private RadioButton rdbdivision;
        private RadioButton rdbmultiplicacion;
        private RadioButton rdbresta;
        private RadioButton rdbsuma;
        private Button btnborrar;
    }
}