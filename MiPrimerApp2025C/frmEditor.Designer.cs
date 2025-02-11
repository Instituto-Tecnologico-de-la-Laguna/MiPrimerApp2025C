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
            menuStrip = new ToolStripMenuItem();
            nuevoToolStripMenuItem = new ToolStripMenuItem();
            abrirToolStripMenuItem = new ToolStripMenuItem();
            guardarToolStripMenuItem = new ToolStripMenuItem();
            guardarComoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            rtbEditor = new RichTextBox();
            openFileDialogEditor = new OpenFileDialog();
            saveFileDialogEditor = new SaveFileDialog();
            menuEditor.SuspendLayout();
            SuspendLayout();
            // 
            // menuEditor
            // 
            menuEditor.ImageScalingSize = new Size(20, 20);
            menuEditor.Items.AddRange(new ToolStripItem[] { menuStrip });
            menuEditor.Location = new Point(0, 0);
            menuEditor.Name = "menuEditor";
            menuEditor.Size = new Size(800, 28);
            menuEditor.TabIndex = 0;
            menuEditor.Text = "menuStrip1";
            // 
            // menuStrip
            // 
            menuStrip.DropDownItems.AddRange(new ToolStripItem[] { nuevoToolStripMenuItem, abrirToolStripMenuItem, guardarToolStripMenuItem, guardarComoToolStripMenuItem, salirToolStripMenuItem });
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(73, 24);
            menuStrip.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            nuevoToolStripMenuItem.Size = new Size(224, 26);
            nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.Size = new Size(224, 26);
            abrirToolStripMenuItem.Text = "Abrir";
            abrirToolStripMenuItem.Click += abrirToolStripMenuItem_Click;
            // 
            // guardarToolStripMenuItem
            // 
            guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            guardarToolStripMenuItem.Size = new Size(224, 26);
            guardarToolStripMenuItem.Text = "Guardar";
            guardarToolStripMenuItem.Click += guardarToolStripMenuItem_Click;
            // 
            // guardarComoToolStripMenuItem
            // 
            guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            guardarComoToolStripMenuItem.Size = new Size(224, 26);
            guardarComoToolStripMenuItem.Text = "Guardar como..";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(224, 26);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // rtbEditor
            // 
            rtbEditor.Dock = DockStyle.Fill;
            rtbEditor.Location = new Point(0, 28);
            rtbEditor.Name = "rtbEditor";
            rtbEditor.Size = new Size(800, 422);
            rtbEditor.TabIndex = 1;
            rtbEditor.Text = "";
            // 
            // openFileDialogEditor
            // 
            openFileDialogEditor.FileName = "openFileDialog1";
            openFileDialogEditor.Filter = "Archivo de Texto|*.txt";
            // 
            // saveFileDialogEditor
            // 
            saveFileDialogEditor.Filter = "Archivo de Texto|*.txt";
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
        private ToolStripMenuItem menuStrip;
        private ToolStripMenuItem nuevoToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem guardarToolStripMenuItem;
        private ToolStripMenuItem guardarComoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private RichTextBox rtbEditor;
        private OpenFileDialog openFileDialogEditor;
        private SaveFileDialog saveFileDialogEditor;
    }
}