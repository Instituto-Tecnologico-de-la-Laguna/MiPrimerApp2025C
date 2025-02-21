namespace MiPrimerApp2025C
{
    partial class FrmVarios
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
            DtpFechaNacimiento = new DateTimePicker();
            fechaNacimiento = new Label();
            DtpFechaCalculo = new DateTimePicker();
            FechaCalculo = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            BtnCalcular = new Button();
            BtnCalcularCurp = new Button();
            label1 = new Label();
            TxtBoxCurp = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // DtpFechaNacimiento
            // 
            DtpFechaNacimiento.Location = new Point(3, 31);
            DtpFechaNacimiento.Name = "DtpFechaNacimiento";
            DtpFechaNacimiento.Size = new Size(200, 23);
            DtpFechaNacimiento.TabIndex = 0;
            DtpFechaNacimiento.ValueChanged += DtpFechaNacimiento_ValueChanged;
            // 
            // fechaNacimiento
            // 
            fechaNacimiento.AutoSize = true;
            fechaNacimiento.Location = new Point(3, 0);
            fechaNacimiento.Name = "fechaNacimiento";
            fechaNacimiento.Size = new Size(120, 15);
            fechaNacimiento.TabIndex = 1;
            fechaNacimiento.Text = "Fecha de nacimiento:";
            // 
            // DtpFechaCalculo
            // 
            DtpFechaCalculo.Enabled = false;
            DtpFechaCalculo.Location = new Point(3, 92);
            DtpFechaCalculo.Name = "DtpFechaCalculo";
            DtpFechaCalculo.Size = new Size(200, 23);
            DtpFechaCalculo.TabIndex = 2;
            // 
            // FechaCalculo
            // 
            FechaCalculo.AutoSize = true;
            FechaCalculo.Location = new Point(3, 63);
            FechaCalculo.Name = "FechaCalculo";
            FechaCalculo.Size = new Size(98, 15);
            FechaCalculo.TabIndex = 3;
            FechaCalculo.Text = "Fecha de calculo:";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(DtpFechaNacimiento, 0, 1);
            tableLayoutPanel1.Controls.Add(DtpFechaCalculo, 0, 3);
            tableLayoutPanel1.Controls.Add(FechaCalculo, 0, 2);
            tableLayoutPanel1.Controls.Add(fechaNacimiento, 0, 0);
            tableLayoutPanel1.Controls.Add(BtnCalcular, 1, 4);
            tableLayoutPanel1.Location = new Point(12, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 44.4444427F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 55.5555573F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 83F));
            tableLayoutPanel1.Size = new Size(424, 210);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // BtnCalcular
            // 
            BtnCalcular.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BtnCalcular.Enabled = false;
            BtnCalcular.Location = new Point(215, 129);
            BtnCalcular.Name = "BtnCalcular";
            BtnCalcular.Size = new Size(206, 78);
            BtnCalcular.TabIndex = 4;
            BtnCalcular.Text = "Calcular";
            BtnCalcular.UseVisualStyleBackColor = true;
            BtnCalcular.Click += BtnCalcular_Click;
            // 
            // BtnCalcularCurp
            // 
            BtnCalcularCurp.Location = new Point(140, 279);
            BtnCalcularCurp.Name = "BtnCalcularCurp";
            BtnCalcularCurp.Size = new Size(75, 23);
            BtnCalcularCurp.TabIndex = 5;
            BtnCalcularCurp.Text = "CURP";
            BtnCalcularCurp.UseVisualStyleBackColor = true;
            BtnCalcularCurp.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 232);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 6;
            label1.Text = "CURP";
            // 
            // TxtBoxCurp
            // 
            TxtBoxCurp.Location = new Point(15, 250);
            TxtBoxCurp.Name = "TxtBoxCurp";
            TxtBoxCurp.Size = new Size(200, 23);
            TxtBoxCurp.TabIndex = 7;
            // 
            // FrmVarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 315);
            Controls.Add(TxtBoxCurp);
            Controls.Add(label1);
            Controls.Add(BtnCalcularCurp);
            Controls.Add(tableLayoutPanel1);
            Name = "FrmVarios";
            Text = "Fechas";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker DtpFechaNacimiento;
        private Label fechaNacimiento;
        private DateTimePicker DtpFechaCalculo;
        private Label FechaCalculo;
        private TableLayoutPanel tableLayoutPanel1;
        private Button BtnCalcular;
        private Button BtnCalcularCurp;
        private Label label1;
        private TextBox TxtBoxCurp;
    }
}