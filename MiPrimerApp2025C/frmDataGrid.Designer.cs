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
            dgvDatos = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Sexo = new DataGridViewComboBoxColumn();
            CURP = new DataGridViewTextBoxColumn();
            Mayor_Edad = new DataGridViewCheckBoxColumn();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnGuardar = new Button();
            saveFileDialogDataGrid = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDatos
            // 
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { Nombre, Telefono, Sexo, CURP, Mayor_Edad });
            dgvDatos.Location = new Point(3, 3);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.RowHeadersWidth = 62;
            dgvDatos.Size = new Size(961, 338);
            dgvDatos.TabIndex = 0;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 8;
            Nombre.Name = "Nombre";
            Nombre.Width = 250;
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.MinimumWidth = 8;
            Telefono.Name = "Telefono";
            Telefono.Width = 150;
            // 
            // Sexo
            // 
            Sexo.HeaderText = "Sexo";
            Sexo.Items.AddRange(new object[] { "Hombre", "Mujer" });
            Sexo.MinimumWidth = 8;
            Sexo.Name = "Sexo";
            Sexo.Resizable = DataGridViewTriState.True;
            Sexo.SortMode = DataGridViewColumnSortMode.Automatic;
            Sexo.Width = 150;
            // 
            // CURP
            // 
            CURP.HeaderText = "CURP";
            CURP.MinimumWidth = 8;
            CURP.Name = "CURP";
            CURP.Width = 200;
            // 
            // Mayor_Edad
            // 
            Mayor_Edad.HeaderText = "Mayor de Edad";
            Mayor_Edad.MinimumWidth = 8;
            Mayor_Edad.Name = "Mayor_Edad";
            Mayor_Edad.Resizable = DataGridViewTriState.True;
            Mayor_Edad.SortMode = DataGridViewColumnSortMode.Automatic;
            Mayor_Edad.Width = 150;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(dgvDatos, 0, 0);
            tableLayoutPanel1.Controls.Add(btnGuardar, 0, 1);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 84.7290649F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15.270936F));
            tableLayoutPanel1.Size = new Size(967, 406);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnGuardar.Location = new Point(3, 358);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(961, 34);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // frmDataGrid
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(988, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "frmDataGrid";
            Text = "DataGridView";
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDatos;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnGuardar;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewComboBoxColumn Sexo;
        private DataGridViewTextBoxColumn CURP;
        private DataGridViewCheckBoxColumn Mayor_Edad;
        private SaveFileDialog saveFileDialogDataGrid;
    }
}