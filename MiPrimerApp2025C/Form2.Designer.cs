namespace MiPrimerApp2025C
{
    partial class Form2
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
            txt1 = new TextBox();
            txt2 = new TextBox();
            button1 = new Button();
            rdbmultiplicacion = new RadioButton();
            rdbdiv = new RadioButton();
            resta = new RadioButton();
            suma = new RadioButton();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 41);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "valor 1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 128);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 1;
            label2.Text = "valor 2";
            label2.Click += label2_Click;
            // 
            // txt1
            // 
            txt1.Location = new Point(140, 33);
            txt1.Name = "txt1";
            txt1.Size = new Size(100, 23);
            txt1.TabIndex = 2;
            // 
            // txt2
            // 
            txt2.Location = new Point(140, 128);
            txt2.Name = "txt2";
            txt2.Size = new Size(100, 23);
            txt2.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(313, 75);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "sumar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // rdbmultiplicacion
            // 
            rdbmultiplicacion.AutoSize = true;
            rdbmultiplicacion.Location = new Point(130, 217);
            rdbmultiplicacion.Name = "rdbmultiplicacion";
            rdbmultiplicacion.Size = new Size(101, 19);
            rdbmultiplicacion.TabIndex = 5;
            rdbmultiplicacion.TabStop = true;
            rdbmultiplicacion.Text = "multiplicacion";
            rdbmultiplicacion.UseVisualStyleBackColor = true;
            // 
            // rdbdiv
            // 
            rdbdiv.AutoSize = true;
            rdbdiv.Location = new Point(130, 261);
            rdbdiv.Name = "rdbdiv";
            rdbdiv.Size = new Size(66, 19);
            rdbdiv.TabIndex = 6;
            rdbdiv.TabStop = true;
            rdbdiv.Text = "division";
            rdbdiv.UseVisualStyleBackColor = true;
            // 
            // resta
            // 
            resta.AutoSize = true;
            resta.Location = new Point(350, 216);
            resta.Name = "resta";
            resta.Size = new Size(50, 19);
            resta.TabIndex = 7;
            resta.TabStop = true;
            resta.Text = "resta";
            resta.UseVisualStyleBackColor = true;
            // 
            // suma
            // 
            suma.AutoSize = true;
            suma.Location = new Point(350, 261);
            suma.Name = "suma";
            suma.Size = new Size(54, 19);
            suma.TabIndex = 8;
            suma.TabStop = true;
            suma.Text = "suma";
            suma.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(313, 120);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 9;
            button2.Text = "borrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(suma);
            Controls.Add(resta);
            Controls.Add(rdbdiv);
            Controls.Add(rdbmultiplicacion);
            Controls.Add(button1);
            Controls.Add(txt2);
            Controls.Add(txt1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "expresion de 2 numeros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt1;
        private TextBox txt2;
        private Button button1;
        private RadioButton rdbmultiplicacion;
        private RadioButton rdbdiv;
        private RadioButton resta;
        private RadioButton suma;
        private Button button2;
    }
}