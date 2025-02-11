
namespace MiPrimerApp2025C
{
    partial class FrmEditor
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
            menuStrip1 = new MenuStrip();
            MenuEditor = new ToolStripMenuItem();
            nuevoToolStripMenuItem = new ToolStripMenuItem();
            abrirToolStripMenuItem = new ToolStripMenuItem();
            gurardarToolStripMenuItem = new ToolStripMenuItem();
            guardarComoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            OfdEditor = new OpenFileDialog();
            SfdEditor = new SaveFileDialog();
            RtbEditor = new RichTextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { MenuEditor });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // MenuEditor
            // 
            MenuEditor.DropDownItems.AddRange(new ToolStripItem[] { nuevoToolStripMenuItem, abrirToolStripMenuItem, gurardarToolStripMenuItem, guardarComoToolStripMenuItem, salirToolStripMenuItem });
            MenuEditor.Name = "MenuEditor";
            MenuEditor.Size = new Size(60, 20);
            MenuEditor.Text = "Archivo";
            MenuEditor.Click += archivoToolStripMenuItem_Click;
            // 
            // nuevoToolStripMenuItem
            // 
            nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            nuevoToolStripMenuItem.Size = new Size(150, 22);
            nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.Size = new Size(150, 22);
            abrirToolStripMenuItem.Text = "Abrir";
            abrirToolStripMenuItem.Click += guardarToolStripMenuItem_Click;
            // 
            // gurardarToolStripMenuItem
            // 
            gurardarToolStripMenuItem.Name = "gurardarToolStripMenuItem";
            gurardarToolStripMenuItem.Size = new Size(150, 22);
            gurardarToolStripMenuItem.Text = "Guardar";
            gurardarToolStripMenuItem.Click += gurardarComoToolStripMenuItem_Click;
            // 
            // guardarComoToolStripMenuItem
            // 
            guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            guardarComoToolStripMenuItem.Size = new Size(150, 22);
            guardarComoToolStripMenuItem.Text = "Guardar como";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(150, 22);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // OfdEditor
            // 
            OfdEditor.FileName = "openFileDialog1";
            OfdEditor.Filter = "Archivo de texto |*.txt";
            // 
            // SfdEditor
            // 
            SfdEditor.FileName = "saveFileDialog1";
            SfdEditor.Filter = "Archivo de texto | *.txt";
            // 
            // RtbEditor
            // 
            RtbEditor.Dock = DockStyle.Fill;
            RtbEditor.Location = new Point(0, 24);
            RtbEditor.Name = "RtbEditor";
            RtbEditor.Size = new Size(800, 426);
            RtbEditor.TabIndex = 1;
            RtbEditor.Text = "";
            RtbEditor.TextChanged += richTextBox1_TextChanged;
            // 
            // FrmEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RtbEditor);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmEditor";
            Text = "Editor de texto";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem MenuEditor;
        private ToolStripMenuItem nuevoToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem gurardarToolStripMenuItem;
        private ToolStripMenuItem guardarComoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private OpenFileDialog OfdEditor;
        private SaveFileDialog SfdEditor;
        private RichTextBox RtbEditor;
    }
}