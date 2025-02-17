namespace MiPrimerApp2025C
{
    partial class FrmDataGrid
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
            DgvDatos = new DataGridView();
            ColumnaTexto = new DataGridViewTextBoxColumn();
            ColumnaTelefono = new DataGridViewTextBoxColumn();
            ColumnaSexo = new DataGridViewComboBoxColumn();
            ColumnaMayor = new DataGridViewCheckBoxColumn();
            ColumnaCURP = new DataGridViewTextBoxColumn();
            tableLayoutPanel1 = new TableLayoutPanel();
            BtnGuardar = new Button();
            SfdDataGrid = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)DgvDatos).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // DgvDatos
            // 
            DgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvDatos.Columns.AddRange(new DataGridViewColumn[] { ColumnaTexto, ColumnaTelefono, ColumnaSexo, ColumnaMayor, ColumnaCURP });
            DgvDatos.Dock = DockStyle.Fill;
            DgvDatos.Location = new Point(3, 3);
            DgvDatos.Name = "DgvDatos";
            DgvDatos.Size = new Size(740, 359);
            DgvDatos.TabIndex = 0;
            // 
            // ColumnaTexto
            // 
            ColumnaTexto.HeaderText = "Nombre";
            ColumnaTexto.Name = "ColumnaTexto";
            ColumnaTexto.Width = 300;
            // 
            // ColumnaTelefono
            // 
            ColumnaTelefono.HeaderText = "Teléfono";
            ColumnaTelefono.Name = "ColumnaTelefono";
            // 
            // ColumnaSexo
            // 
            ColumnaSexo.HeaderText = "Sexo";
            ColumnaSexo.Items.AddRange(new object[] { "Hombre", "Mujer" });
            ColumnaSexo.Name = "ColumnaSexo";
            // 
            // ColumnaMayor
            // 
            ColumnaMayor.HeaderText = "Mayor de edad";
            ColumnaMayor.Name = "ColumnaMayor";
            // 
            // ColumnaCURP
            // 
            ColumnaCURP.HeaderText = "CURP";
            ColumnaCURP.Name = "ColumnaCURP";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(DgvDatos, 0, 0);
            tableLayoutPanel1.Controls.Add(BtnGuardar, 0, 1);
            tableLayoutPanel1.Location = new Point(6, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 85.68075F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.3192492F));
            tableLayoutPanel1.Size = new Size(746, 426);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // BtnGuardar
            // 
            BtnGuardar.Location = new Point(3, 368);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(740, 23);
            BtnGuardar.TabIndex = 1;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = true;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // SfdDataGrid
            // 
            SfdDataGrid.Filter = "CSV File|.csv";
            // 
            // FrmDataGrid
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(756, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "FrmDataGrid";
            Text = "DataGrid";
            ((System.ComponentModel.ISupportInitialize)DgvDatos).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DgvDatos;
        private TableLayoutPanel tableLayoutPanel1;
        private Button BtnGuardar;
        private DataGridViewTextBoxColumn ColumnaTexto;
        private DataGridViewTextBoxColumn ColumnaTelefono;
        private DataGridViewComboBoxColumn ColumnaSexo;
        private DataGridViewCheckBoxColumn ColumnaMayor;
        private DataGridViewTextBoxColumn ColumnaCURP;
        private SaveFileDialog SfdDataGrid;
    }
}