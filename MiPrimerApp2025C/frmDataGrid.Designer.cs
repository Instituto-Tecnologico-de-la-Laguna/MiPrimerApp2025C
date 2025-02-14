namespace MiPrimerApp2025C
{
    partial class frmDataGrid
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
            dgvDat = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewCheckBoxColumn();
            Column4 = new DataGridViewComboBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            tableLayoutPanel1 = new TableLayoutPanel();
            buttGuardar = new Button();
            saveFileDialogDataGrid = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)dgvDat).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDat
            // 
            dgvDat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDat.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dgvDat.Location = new Point(3, 3);
            dgvDat.Name = "dgvDat";
            dgvDat.RowHeadersWidth = 62;
            dgvDat.Size = new Size(1103, 275);
            dgvDat.TabIndex = 0;
            dgvDat.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nombre";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 400;
            // 
            // Column2
            // 
            Column2.HeaderText = "Telefono";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.HeaderText = "Mayor De Edad";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.HeaderText = "Sexo";
            Column4.Items.AddRange(new object[] { "Hombre ", "Mujer" });
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.Width = 150;
            // 
            // Column5
            // 
            Column5.HeaderText = "CURP";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.Width = 350;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(buttGuardar, 0, 1);
            tableLayoutPanel1.Controls.Add(dgvDat, 0, 0);
            tableLayoutPanel1.Location = new Point(12, 6);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 82.64706F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17.3529415F));
            tableLayoutPanel1.Size = new Size(1111, 340);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // buttGuardar
            // 
            buttGuardar.Location = new Point(3, 284);
            buttGuardar.Name = "buttGuardar";
            buttGuardar.Size = new Size(1105, 53);
            buttGuardar.TabIndex = 2;
            buttGuardar.Text = "Guardar";
            buttGuardar.UseVisualStyleBackColor = true;
            buttGuardar.Click += buttGuardar_Click;
            // 
            // saveFileDialogDataGrid
            // 
            saveFileDialogDataGrid.Filter = "Archivo CSV|*.csv";
            // 
            // frmDataGrid
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 349);
            Controls.Add(tableLayoutPanel1);
            Name = "frmDataGrid";
            Text = "frmDataGrid";
            ((System.ComponentModel.ISupportInitialize)dgvDat).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDat;
        private TableLayoutPanel tableLayoutPanel1;
        private Button buttGuardar;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewCheckBoxColumn Column3;
        private DataGridViewComboBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private SaveFileDialog saveFileDialogDataGrid;
    }
}