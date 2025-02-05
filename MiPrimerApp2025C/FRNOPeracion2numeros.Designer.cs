namespace MiPrimerApp2025C
{
    partial class FRNOPeracion2numeros
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
            TXTValor1 = new TextBox();
            TXTValor2 = new TextBox();
            BTNCalcular = new Button();
            groupBox1 = new GroupBox();
            RDBDivision = new RadioButton();
            RDBMultiplicacion = new RadioButton();
            RDBResta = new RadioButton();
            RDBSuma = new RadioButton();
            BTNBorrar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 37);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 0;
            label1.Text = "Valor 1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 104);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 1;
            label2.Text = "Valor 2:";
            // 
            // TXTValor1
            // 
            TXTValor1.Location = new Point(12, 61);
            TXTValor1.Name = "TXTValor1";
            TXTValor1.Size = new Size(228, 27);
            TXTValor1.TabIndex = 2;
            // 
            // TXTValor2
            // 
            TXTValor2.Location = new Point(12, 127);
            TXTValor2.Name = "TXTValor2";
            TXTValor2.Size = new Size(228, 27);
            TXTValor2.TabIndex = 3;
            // 
            // BTNCalcular
            // 
            BTNCalcular.Location = new Point(331, 61);
            BTNCalcular.Name = "BTNCalcular";
            BTNCalcular.Size = new Size(94, 29);
            BTNCalcular.TabIndex = 4;
            BTNCalcular.Text = "Calcular";
            BTNCalcular.UseVisualStyleBackColor = true;
            BTNCalcular.Click += BTNCalcular_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(RDBDivision);
            groupBox1.Controls.Add(RDBMultiplicacion);
            groupBox1.Controls.Add(RDBResta);
            groupBox1.Controls.Add(RDBSuma);
            groupBox1.Location = new Point(12, 187);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(423, 125);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Operación";
            // 
            // RDBDivision
            // 
            RDBDivision.AutoSize = true;
            RDBDivision.Location = new Point(181, 76);
            RDBDivision.Name = "RDBDivision";
            RDBDivision.Size = new Size(83, 24);
            RDBDivision.TabIndex = 3;
            RDBDivision.TabStop = true;
            RDBDivision.Text = "División";
            RDBDivision.UseVisualStyleBackColor = true;
            // 
            // RDBMultiplicacion
            // 
            RDBMultiplicacion.AutoSize = true;
            RDBMultiplicacion.Location = new Point(181, 26);
            RDBMultiplicacion.Name = "RDBMultiplicacion";
            RDBMultiplicacion.Size = new Size(124, 24);
            RDBMultiplicacion.TabIndex = 2;
            RDBMultiplicacion.TabStop = true;
            RDBMultiplicacion.Text = "Multiplicación";
            RDBMultiplicacion.UseVisualStyleBackColor = true;
            // 
            // RDBResta
            // 
            RDBResta.AutoSize = true;
            RDBResta.Location = new Point(7, 76);
            RDBResta.Name = "RDBResta";
            RDBResta.Size = new Size(66, 24);
            RDBResta.TabIndex = 1;
            RDBResta.TabStop = true;
            RDBResta.Text = "Resta";
            RDBResta.UseVisualStyleBackColor = true;
            // 
            // RDBSuma
            // 
            RDBSuma.AutoSize = true;
            RDBSuma.Location = new Point(6, 26);
            RDBSuma.Name = "RDBSuma";
            RDBSuma.Size = new Size(67, 24);
            RDBSuma.TabIndex = 0;
            RDBSuma.TabStop = true;
            RDBSuma.Text = "Suma";
            RDBSuma.UseVisualStyleBackColor = true;
            // 
            // BTNBorrar
            // 
            BTNBorrar.Location = new Point(331, 125);
            BTNBorrar.Name = "BTNBorrar";
            BTNBorrar.Size = new Size(94, 29);
            BTNBorrar.TabIndex = 6;
            BTNBorrar.Text = "Borrar";
            BTNBorrar.UseVisualStyleBackColor = true;
            BTNBorrar.Click += BTNBorrar_Click;
            // 
            // FRNOPeracion2numeros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 334);
            Controls.Add(BTNBorrar);
            Controls.Add(groupBox1);
            Controls.Add(BTNCalcular);
            Controls.Add(TXTValor2);
            Controls.Add(TXTValor1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FRNOPeracion2numeros";
            Text = "Operaciones 2 Numeros";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TXTValor1;
        private TextBox TXTValor2;
        private Button BTNCalcular;
        private GroupBox groupBox1;
        private RadioButton RDBDivision;
        private RadioButton RDBMultiplicacion;
        private RadioButton RDBResta;
        private RadioButton RDBSuma;
        private Button BTNBorrar;
    }
}