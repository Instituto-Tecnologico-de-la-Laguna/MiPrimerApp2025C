namespace MiPrimerApp2025C
{
    partial class frmEditor
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
            menuEditor = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            nuevoToolStripMenuItem = new ToolStripMenuItem();
            abrirToolStripMenuItem = new ToolStripMenuItem();
            guardarToolStripMenuItem = new ToolStripMenuItem();
            guardarComoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            editarToolStripMenuItem = new ToolStripMenuItem();
            fuenteToolStripMenuItem = new ToolStripMenuItem();
            colorToolStripMenuItem = new ToolStripMenuItem();
            herramientasToolStripMenuItem = new ToolStripMenuItem();
            contarLetrasToolStripMenuItem = new ToolStripMenuItem();
            rtbEditor = new RichTextBox();
            saveFileDialogEditor = new SaveFileDialog();
            openFileDialogEditor = new OpenFileDialog();
            fontDialogEditor = new FontDialog();
            colorDialogEditor = new ColorDialog();
            menuEditor.SuspendLayout();
            SuspendLayout();
            // 
            // menuEditor
            // 
            menuEditor.ImageScalingSize = new Size(20, 20);
            menuEditor.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, editarToolStripMenuItem, herramientasToolStripMenuItem });
            menuEditor.Location = new Point(0, 0);
            menuEditor.Name = "menuEditor";
            menuEditor.Size = new Size(800, 28);
            menuEditor.TabIndex = 0;
            menuEditor.Text = "menuEditor";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevoToolStripMenuItem, abrirToolStripMenuItem, guardarToolStripMenuItem, guardarComoToolStripMenuItem, salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(73, 24);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            nuevoToolStripMenuItem.Size = new Size(198, 26);
            nuevoToolStripMenuItem.Text = "Nuevo";
            nuevoToolStripMenuItem.Click += nuevoToolStripMenuItem_Click;
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.Size = new Size(198, 26);
            abrirToolStripMenuItem.Text = "Abrir";
            abrirToolStripMenuItem.Click += abrirToolStripMenuItem_Click_1;
            // 
            // guardarToolStripMenuItem
            // 
            guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            guardarToolStripMenuItem.Size = new Size(198, 26);
            guardarToolStripMenuItem.Text = "Guardar";
            guardarToolStripMenuItem.Click += guardarToolStripMenuItem_Click;
            // 
            // guardarComoToolStripMenuItem
            // 
            guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            guardarComoToolStripMenuItem.Size = new Size(198, 26);
            guardarComoToolStripMenuItem.Text = "Guardar Como...";
            guardarComoToolStripMenuItem.Click += guardarComoToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(198, 26);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fuenteToolStripMenuItem, colorToolStripMenuItem });
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(62, 24);
            editarToolStripMenuItem.Text = "Editar";
            // 
            // fuenteToolStripMenuItem
            // 
            fuenteToolStripMenuItem.Name = "fuenteToolStripMenuItem";
            fuenteToolStripMenuItem.Size = new Size(136, 26);
            fuenteToolStripMenuItem.Text = "Fuente";
            fuenteToolStripMenuItem.Click += fuenteToolStripMenuItem_Click;
            // 
            // colorToolStripMenuItem
            // 
            colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            colorToolStripMenuItem.Size = new Size(136, 26);
            colorToolStripMenuItem.Text = "Color";
            colorToolStripMenuItem.Click += colorToolStripMenuItem_Click;
            // 
            // herramientasToolStripMenuItem
            // 
            herramientasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { contarLetrasToolStripMenuItem });
            herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            herramientasToolStripMenuItem.Size = new Size(112, 24);
            herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // contarLetrasToolStripMenuItem
            // 
            contarLetrasToolStripMenuItem.Name = "contarLetrasToolStripMenuItem";
            contarLetrasToolStripMenuItem.Size = new Size(224, 26);
            contarLetrasToolStripMenuItem.Text = "Contar Letras";
            contarLetrasToolStripMenuItem.Click += contarLetrasToolStripMenuItem_Click;
            // 
            // rtbEditor
            // 
            rtbEditor.Dock = DockStyle.Fill;
            rtbEditor.Location = new Point(0, 28);
            rtbEditor.Margin = new Padding(2);
            rtbEditor.Name = "rtbEditor";
            rtbEditor.Size = new Size(800, 422);
            rtbEditor.TabIndex = 2;
            rtbEditor.Text = "";
            // 
            // saveFileDialogEditor
            // 
            saveFileDialogEditor.Filter = "Archivo de Texto|*.txt";
            // 
            // openFileDialogEditor
            // 
            openFileDialogEditor.FileName = "openFileDialog1";
            openFileDialogEditor.Filter = "Archivo de Texto|*.txt";
            // 
            // frmEditor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rtbEditor);
            Controls.Add(menuEditor);
            MainMenuStrip = menuEditor;
            Name = "frmEditor";
            Text = "Editor de Texto";
            Load += frmEditor_Load;
            menuEditor.ResumeLayout(false);
            menuEditor.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuEditor;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem nuevoToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem guardarToolStripMenuItem;
        private ToolStripMenuItem guardarComoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private RichTextBox rtbEditor;
        private SaveFileDialog saveFileDialogEditor;
        private OpenFileDialog openFileDialogEditor;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem fuenteToolStripMenuItem;
        private ToolStripMenuItem colorToolStripMenuItem;
        private ToolStripMenuItem herramientasToolStripMenuItem;
        private ToolStripMenuItem contarLetrasToolStripMenuItem;
        private FontDialog fontDialogEditor;
        private ColorDialog colorDialogEditor;
    }
}