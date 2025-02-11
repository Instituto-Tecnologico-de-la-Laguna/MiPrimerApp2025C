namespace MiPrimerApp2025C
{
    partial class FrmMenu2
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
            archivoToolStripMenuItem = new ToolStripMenuItem();
            apliccaionesToolStripMenuItem = new ToolStripMenuItem();
            aplicacionesSimplesToolStripMenuItem = new ToolStripMenuItem();
            operaciones2NumerosToolStripMenuItem = new ToolStripMenuItem();
            temporizadorToolStripMenuItem = new ToolStripMenuItem();
            editorDeTextoToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, apliccaionesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(73, 24);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // apliccaionesToolStripMenuItem
            // 
            apliccaionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aplicacionesSimplesToolStripMenuItem, operaciones2NumerosToolStripMenuItem, temporizadorToolStripMenuItem, editorDeTextoToolStripMenuItem });
            apliccaionesToolStripMenuItem.Name = "apliccaionesToolStripMenuItem";
            apliccaionesToolStripMenuItem.Size = new Size(107, 24);
            apliccaionesToolStripMenuItem.Text = "Apliccaiones";
            // 
            // aplicacionesSimplesToolStripMenuItem
            // 
            aplicacionesSimplesToolStripMenuItem.Name = "aplicacionesSimplesToolStripMenuItem";
            aplicacionesSimplesToolStripMenuItem.Size = new Size(248, 26);
            aplicacionesSimplesToolStripMenuItem.Text = "Aplicaciones Simples";
            aplicacionesSimplesToolStripMenuItem.Click += aplicacionesSimplesToolStripMenuItem_Click;
            // 
            // operaciones2NumerosToolStripMenuItem
            // 
            operaciones2NumerosToolStripMenuItem.Name = "operaciones2NumerosToolStripMenuItem";
            operaciones2NumerosToolStripMenuItem.Size = new Size(248, 26);
            operaciones2NumerosToolStripMenuItem.Text = "Operaciones 2 numeros";
            operaciones2NumerosToolStripMenuItem.Click += operaciones2NumerosToolStripMenuItem_Click;
            // 
            // temporizadorToolStripMenuItem
            // 
            temporizadorToolStripMenuItem.Name = "temporizadorToolStripMenuItem";
            temporizadorToolStripMenuItem.Size = new Size(248, 26);
            temporizadorToolStripMenuItem.Text = "Temporizador";
            temporizadorToolStripMenuItem.Click += temporizadorToolStripMenuItem_Click;
            // 
            // editorDeTextoToolStripMenuItem
            // 
            editorDeTextoToolStripMenuItem.Name = "editorDeTextoToolStripMenuItem";
            editorDeTextoToolStripMenuItem.Size = new Size(248, 26);
            editorDeTextoToolStripMenuItem.Text = "Editor de Texto";
            editorDeTextoToolStripMenuItem.Click += editorDeTextoToolStripMenuItem_Click;
            // 
            // FrmMenu2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmMenu2";
            Text = "FrmMenu2";
            Load += FrmMenu2_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem apliccaionesToolStripMenuItem;
        private ToolStripMenuItem aplicacionesSimplesToolStripMenuItem;
        private ToolStripMenuItem operaciones2NumerosToolStripMenuItem;
        private ToolStripMenuItem temporizadorToolStripMenuItem;
        private ToolStripMenuItem editorDeTextoToolStripMenuItem;
    }
}