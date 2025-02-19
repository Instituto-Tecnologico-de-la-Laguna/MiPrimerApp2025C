namespace MiPrimerApp2025C
{
    partial class frmVarios
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
            dtpFechaNac = new DateTimePicker();
            label1 = new Label();
            dtpFechaDeCalculo = new DateTimePicker();
            label2 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            buttCalcular = new Button();
            buttCurp = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dtpFechaNac
            // 
            dtpFechaNac.Location = new Point(3, 52);
            dtpFechaNac.Name = "dtpFechaNac";
            dtpFechaNac.Size = new Size(365, 31);
            dtpFechaNac.TabIndex = 0;
            dtpFechaNac.ValueChanged += dtpFechaNac_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(177, 25);
            label1.TabIndex = 1;
            label1.Text = "Fecha de Nacimiento";
            // 
            // dtpFechaDeCalculo
            // 
            dtpFechaDeCalculo.Enabled = false;
            dtpFechaDeCalculo.Location = new Point(3, 190);
            dtpFechaDeCalculo.Name = "dtpFechaDeCalculo";
            dtpFechaDeCalculo.Size = new Size(365, 31);
            dtpFechaDeCalculo.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 149);
            label2.Name = "label2";
            label2.Size = new Size(144, 25);
            label2.TabIndex = 3;
            label2.Text = "Fecha de Calculo";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(dtpFechaNac, 0, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(dtpFechaDeCalculo, 0, 3);
            tableLayoutPanel1.Controls.Add(buttCalcular, 1, 4);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.1288338F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 66.87116F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanel1.Size = new Size(764, 288);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // buttCalcular
            // 
            buttCalcular.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            buttCalcular.Location = new Point(385, 248);
            buttCalcular.Name = "buttCalcular";
            buttCalcular.Size = new Size(376, 34);
            buttCalcular.TabIndex = 4;
            buttCalcular.Text = "Calcular";
            buttCalcular.UseVisualStyleBackColor = true;
            buttCalcular.Click += buttCalcular_Click;
            // 
            // buttCurp
            // 
            buttCurp.Location = new Point(328, 351);
            buttCurp.Name = "buttCurp";
            buttCurp.Size = new Size(112, 34);
            buttCurp.TabIndex = 5;
            buttCurp.Text = "CURP";
            buttCurp.UseVisualStyleBackColor = true;
            buttCurp.Click += buttCurp_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(15, 351);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(282, 31);
            textBox1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 314);
            label3.Name = "label3";
            label3.Size = new Size(56, 25);
            label3.TabIndex = 7;
            label3.Text = "CURP";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 409);
            label4.Name = "label4";
            label4.Size = new Size(68, 25);
            label4.TabIndex = 8;
            label4.Text = "Datos: ";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(127, 424);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 10;
            // 
            // frmVarios
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 483);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(buttCurp);
            Controls.Add(tableLayoutPanel1);
            Name = "frmVarios";
            Text = "frmVarios";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpFechaNac;
        private Label label1;
        private DateTimePicker dtpFechaDeCalculo;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private Button buttCalcular;
        private Button buttCurp;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
    }
}