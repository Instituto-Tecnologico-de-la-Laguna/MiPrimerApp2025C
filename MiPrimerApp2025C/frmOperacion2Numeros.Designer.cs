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
            txtBox2 = new TextBox();
            label2 = new Label();
            btnCalcular = new Button();
            groupBox1 = new GroupBox();
            rdBDiv = new RadioButton();
            rdBMul = new RadioButton();
            rdBRes = new RadioButton();
            rdBSum = new RadioButton();
            btnBorrar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(139, 21);
            label1.Name = "label1";
            label1.Size = new Size(71, 25);
            label1.TabIndex = 0;
            label1.Text = "Valor 1:";
            // 
            // txtValor1
            // 
            txtValor1.Location = new Point(82, 62);
            txtValor1.Name = "txtValor1";
            txtValor1.Size = new Size(189, 31);
            txtValor1.TabIndex = 1;
            // 
            // txtBox2
            // 
            txtBox2.Location = new Point(83, 174);
            txtBox2.Name = "txtBox2";
            txtBox2.Size = new Size(189, 31);
            txtBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(140, 133);
            label2.Name = "label2";
            label2.Size = new Size(71, 25);
            label2.TabIndex = 2;
            label2.Text = "Valor 2:";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(123, 224);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(112, 34);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdBDiv);
            groupBox1.Controls.Add(rdBMul);
            groupBox1.Controls.Add(rdBRes);
            groupBox1.Controls.Add(rdBSum);
            groupBox1.Location = new Point(298, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 275);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Operacion";
            // 
            // rdBDiv
            // 
            rdBDiv.AutoSize = true;
            rdBDiv.Location = new Point(34, 160);
            rdBDiv.Name = "rdBDiv";
            rdBDiv.Size = new Size(100, 29);
            rdBDiv.TabIndex = 3;
            rdBDiv.TabStop = true;
            rdBDiv.Text = "Division";
            rdBDiv.UseVisualStyleBackColor = true;
            // 
            // rdBMul
            // 
            rdBMul.AutoSize = true;
            rdBMul.Location = new Point(34, 116);
            rdBMul.Name = "rdBMul";
            rdBMul.Size = new Size(146, 29);
            rdBMul.TabIndex = 2;
            rdBMul.TabStop = true;
            rdBMul.Text = "Multiplicacion";
            rdBMul.UseVisualStyleBackColor = true;
            // 
            // rdBRes
            // 
            rdBRes.AutoSize = true;
            rdBRes.Location = new Point(34, 75);
            rdBRes.Name = "rdBRes";
            rdBRes.Size = new Size(79, 29);
            rdBRes.TabIndex = 1;
            rdBRes.TabStop = true;
            rdBRes.Text = "Resta";
            rdBRes.UseVisualStyleBackColor = true;
            // 
            // rdBSum
            // 
            rdBSum.AutoSize = true;
            rdBSum.Location = new Point(34, 34);
            rdBSum.Name = "rdBSum";
            rdBSum.Size = new Size(82, 29);
            rdBSum.TabIndex = 0;
            rdBSum.TabStop = true;
            rdBSum.Text = "Suma";
            rdBSum.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(125, 277);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(112, 34);
            btnBorrar.TabIndex = 6;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // frmOperacion2Numeros
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 345);
            Controls.Add(btnBorrar);
            Controls.Add(groupBox1);
            Controls.Add(btnCalcular);
            Controls.Add(txtBox2);
            Controls.Add(label2);
            Controls.Add(txtValor1);
            Controls.Add(label1);
            Name = "frmOperacion2Numeros";
            Text = "Operaciones 2 Numeros";
            Load += frmOperacion2Numeros_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtValor1;
        private TextBox txtBox2;
        private Label label2;
        private Button btnCalcular;
        private GroupBox groupBox1;
        private RadioButton rdBDiv;
        private RadioButton rdBMul;
        private RadioButton rdBRes;
        private RadioButton rdBSum;
        private Button btnBorrar;
    }
}