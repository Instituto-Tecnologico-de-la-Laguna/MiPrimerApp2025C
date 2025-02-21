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
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            dtpFechaNacimiento = new DateTimePicker();
            label2 = new Label();
            dtpFechaCalculo = new DateTimePicker();
            btnCalcular = new Button();
            label3 = new Label();
            label4 = new Label();
            txtCurp = new TextBox();
            cbxDatos = new ComboBox();
            btnCurp = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(dtpFechaNacimiento, 0, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(dtpFechaCalculo, 0, 3);
            tableLayoutPanel1.Controls.Add(btnCalcular, 1, 4);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 37.64706F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 62.35294F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 67F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 118F));
            tableLayoutPanel1.Size = new Size(664, 296);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(146, 20);
            label1.TabIndex = 0;
            label1.Text = "Fecha de nacimiento";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(3, 31);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(316, 27);
            dtpFechaNacimiento.TabIndex = 1;
            dtpFechaNacimiento.ValueChanged += dtpFechaNacimiento_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 76);
            label2.Name = "label2";
            label2.Size = new Size(121, 20);
            label2.TabIndex = 2;
            label2.Text = "Fecha de Calculo";
            // 
            // dtpFechaCalculo
            // 
            dtpFechaCalculo.Location = new Point(3, 113);
            dtpFechaCalculo.Name = "dtpFechaCalculo";
            dtpFechaCalculo.Size = new Size(316, 27);
            dtpFechaCalculo.TabIndex = 3;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(335, 180);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(318, 29);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 339);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 1;
            label3.Text = "CURP";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 395);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 2;
            label4.Text = "Datos";
            // 
            // txtCurp
            // 
            txtCurp.Location = new Point(108, 338);
            txtCurp.Name = "txtCurp";
            txtCurp.Size = new Size(236, 27);
            txtCurp.TabIndex = 3;
            // 
            // cbxDatos
            // 
            cbxDatos.FormattingEnabled = true;
            cbxDatos.Location = new Point(108, 395);
            cbxDatos.Name = "cbxDatos";
            cbxDatos.Size = new Size(236, 28);
            cbxDatos.TabIndex = 4;
            cbxDatos.SelectedIndexChanged += cbxDatos_SelectedIndexChanged;
            // 
            // btnCurp
            // 
            btnCurp.Location = new Point(456, 339);
            btnCurp.Name = "btnCurp";
            btnCurp.Size = new Size(94, 29);
            btnCurp.TabIndex = 5;
            btnCurp.Text = "Curp";
            btnCurp.UseVisualStyleBackColor = true;
            btnCurp.Click += btnCurp_Click;
            // 
            // frmVarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(708, 480);
            Controls.Add(btnCurp);
            Controls.Add(cbxDatos);
            Controls.Add(txtCurp);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(tableLayoutPanel1);
            Name = "frmVarios";
            Text = "frmVarios";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private DateTimePicker dtpFechaNacimiento;
        private Label label2;
        private DateTimePicker dtpFechaCalculo;
        private Button btnCalcular;
        private Label label3;
        private Label label4;
        private TextBox txtCurp;
        private ComboBox cbxDatos;
        private Button btnCurp;
    }
}