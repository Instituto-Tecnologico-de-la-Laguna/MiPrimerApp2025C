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
            dataGridView1 = new DataGridView();
            ColumnaTexto = new DataGridViewTextBoxColumn();
            ColumnaTelefono = new DataGridViewTextBoxColumn();
            ColumnaSexo = new DataGridViewComboBoxColumn();
            ColumnaMayor = new DataGridViewCheckBoxColumn();
            ColumnaEditar = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnaTexto, ColumnaTelefono, ColumnaSexo, ColumnaMayor, ColumnaEditar });
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(541, 426);
            dataGridView1.TabIndex = 0;
            // 
            // ColumnaTexto
            // 
            ColumnaTexto.HeaderText = "Nombre";
            ColumnaTexto.Name = "ColumnaTexto";
            // 
            // ColumnaTelefono
            // 
            ColumnaTelefono.HeaderText = "Teléfono";
            ColumnaTelefono.Name = "ColumnaTelefono";
            // 
            // ColumnaSexo
            // 
            ColumnaSexo.HeaderText = "Sexo";
            ColumnaSexo.Name = "ColumnaSexo";
            // 
            // ColumnaMayor
            // 
            ColumnaMayor.HeaderText = "Mayor de edad";
            ColumnaMayor.Name = "ColumnaMayor";
            // 
            // ColumnaEditar
            // 
            ColumnaEditar.HeaderText = "Editar";
            ColumnaEditar.Name = "ColumnaEditar";
            // 
            // FrmDataGrid
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 450);
            Controls.Add(dataGridView1);
            Name = "FrmDataGrid";
            Text = "DataGrid";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColumnaTexto;
        private DataGridViewTextBoxColumn ColumnaTelefono;
        private DataGridViewComboBoxColumn ColumnaSexo;
        private DataGridViewCheckBoxColumn ColumnaMayor;
        private DataGridViewButtonColumn ColumnaEditar;
    }
}