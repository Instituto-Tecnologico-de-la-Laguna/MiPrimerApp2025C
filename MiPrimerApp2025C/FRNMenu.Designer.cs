namespace MiPrimerApp2025C
{
    partial class FRNMenu
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
            toolStripMenuItem1 = new ToolStripMenuItem();
            abToolStripMenuItem = new ToolStripMenuItem();
            aplicacionToolStripMenuItem = new ToolStripMenuItem();
            operacion2ValoresToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, aplicacionToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { abToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(78, 24);
            toolStripMenuItem1.Text = "Nombre";
            // 
            // abToolStripMenuItem
            // 
            abToolStripMenuItem.Name = "abToolStripMenuItem";
            abToolStripMenuItem.Size = new Size(224, 26);
            abToolStripMenuItem.Text = "Nombre";
            abToolStripMenuItem.Click += abToolStripMenuItem_Click;
            // 
            // aplicacionToolStripMenuItem
            // 
            aplicacionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { operacion2ValoresToolStripMenuItem });
            aplicacionToolStripMenuItem.Name = "aplicacionToolStripMenuItem";
            aplicacionToolStripMenuItem.Size = new Size(93, 24);
            aplicacionToolStripMenuItem.Text = "Aplicacion";
            // 
            // operacion2ValoresToolStripMenuItem
            // 
            operacion2ValoresToolStripMenuItem.Name = "operacion2ValoresToolStripMenuItem";
            operacion2ValoresToolStripMenuItem.Size = new Size(224, 26);
            operacion2ValoresToolStripMenuItem.Text = "Operacion 2 valores";
            operacion2ValoresToolStripMenuItem.Click += operacion2ValoresToolStripMenuItem_Click;
            // 
            // FRNMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FRNMenu";
            Text = "Menu de Aplicaciones en Clase";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem abToolStripMenuItem;
        private ToolStripMenuItem aplicacionToolStripMenuItem;
        private ToolStripMenuItem operacion2ValoresToolStripMenuItem;
    }
}