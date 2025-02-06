namespace MiPrimerApp2025C
{
    partial class frmOperacion2numeros
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
            btncalcular = new Button();
            Operacion = new GroupBox();
            rdbdiv = new RadioButton();
            rdbmult = new RadioButton();
            rdbresta = new RadioButton();
            rdbsuma = new RadioButton();
            btnborrar = new Button();
            Operacion.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 40);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 0;
            label1.Text = "Valor 1: ";
            label1.Click += label1_Click;
            // 
            // txtValor1
            // 
            txtValor1.Location = new Point(132, 40);
            txtValor1.Name = "txtValor1";
            txtValor1.Size = new Size(246, 27);
            txtValor1.TabIndex = 1;
            // 
            // txtValor2
            // 
            txtValor2.Location = new Point(132, 100);
            txtValor2.Name = "txtValor2";
            txtValor2.Size = new Size(246, 27);
            txtValor2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 100);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 2;
            label2.Text = "Valor 2: ";
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(430, 36);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(94, 29);
            btncalcular.TabIndex = 4;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // Operacion
            // 
            Operacion.Controls.Add(rdbdiv);
            Operacion.Controls.Add(rdbmult);
            Operacion.Controls.Add(rdbresta);
            Operacion.Controls.Add(rdbsuma);
            Operacion.Location = new Point(64, 159);
            Operacion.Name = "Operacion";
            Operacion.Size = new Size(473, 200);
            Operacion.TabIndex = 5;
            Operacion.TabStop = false;
            Operacion.Text = "Operacion";
            // 
            // rdbdiv
            // 
            rdbdiv.AutoSize = true;
            rdbdiv.Location = new Point(185, 116);
            rdbdiv.Name = "rdbdiv";
            rdbdiv.Size = new Size(92, 24);
            rdbdiv.TabIndex = 3;
            rdbdiv.TabStop = true;
            rdbdiv.Text = "DIVISION";
            rdbdiv.UseVisualStyleBackColor = true;
            // 
            // rdbmult
            // 
            rdbmult.AutoSize = true;
            rdbmult.Location = new Point(185, 58);
            rdbmult.Name = "rdbmult";
            rdbmult.Size = new Size(144, 24);
            rdbmult.TabIndex = 2;
            rdbmult.TabStop = true;
            rdbmult.Text = "MULTIPLICACION";
            rdbmult.UseVisualStyleBackColor = true;
            // 
            // rdbresta
            // 
            rdbresta.AutoSize = true;
            rdbresta.Location = new Point(31, 116);
            rdbresta.Name = "rdbresta";
            rdbresta.Size = new Size(72, 24);
            rdbresta.TabIndex = 1;
            rdbresta.TabStop = true;
            rdbresta.Text = "RESTA";
            rdbresta.UseVisualStyleBackColor = true;
            // 
            // rdbsuma
            // 
            rdbsuma.AutoSize = true;
            rdbsuma.Location = new Point(31, 58);
            rdbsuma.Name = "rdbsuma";
            rdbsuma.Size = new Size(71, 24);
            rdbsuma.TabIndex = 0;
            rdbsuma.TabStop = true;
            rdbsuma.Text = "SUMA";
            rdbsuma.UseVisualStyleBackColor = true;
            // 
            // btnborrar
            // 
            btnborrar.Location = new Point(430, 96);
            btnborrar.Name = "btnborrar";
            btnborrar.Size = new Size(94, 29);
            btnborrar.TabIndex = 6;
            btnborrar.Text = "Borrar";
            btnborrar.UseVisualStyleBackColor = true;
            btnborrar.Click += btnborrar_Click;
            // 
            // frmOperacion2numeros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 371);
            Controls.Add(btnborrar);
            Controls.Add(Operacion);
            Controls.Add(btncalcular);
            Controls.Add(txtValor2);
            Controls.Add(label2);
            Controls.Add(txtValor1);
            Controls.Add(label1);
            Name = "frmOperacion2numeros";
            Text = "Operaciones 2 numeros";
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
        private Button btncalcular;
        private GroupBox Operacion;
        private RadioButton rdbdiv;
        private RadioButton rdbmult;
        private RadioButton rdbresta;
        private RadioButton rdbsuma;
        private Button btnborrar;
    }
}