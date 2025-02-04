namespace MiPrimerApp2025C
{
    partial class frmMenu
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
            salirToolStripMenuItem = new ToolStripMenuItem();
            aplicaciónSimpleToolStripMenuItem = new ToolStripMenuItem();
            aplicaciónSimpleToolStripMenuItem1 = new ToolStripMenuItem();
            operacionesDe2ValoresToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, aplicaciónSimpleToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(73, 24);
            archivoToolStripMenuItem.Text = "Archivo";
            archivoToolStripMenuItem.Click += archivoToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(121, 26);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // aplicaciónSimpleToolStripMenuItem
            // 
            aplicaciónSimpleToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aplicaciónSimpleToolStripMenuItem1, operacionesDe2ValoresToolStripMenuItem });
            aplicaciónSimpleToolStripMenuItem.Name = "aplicaciónSimpleToolStripMenuItem";
            aplicaciónSimpleToolStripMenuItem.Size = new Size(93, 24);
            aplicaciónSimpleToolStripMenuItem.Text = "Aplicación";
            // 
            // aplicaciónSimpleToolStripMenuItem1
            // 
            aplicaciónSimpleToolStripMenuItem1.Name = "aplicaciónSimpleToolStripMenuItem1";
            aplicaciónSimpleToolStripMenuItem1.Size = new Size(259, 26);
            aplicaciónSimpleToolStripMenuItem1.Text = "Aplicación Simple";
            aplicaciónSimpleToolStripMenuItem1.Click += aplicaciónSimpleToolStripMenuItem1_Click;
            // 
            // operacionesDe2ValoresToolStripMenuItem
            // 
            operacionesDe2ValoresToolStripMenuItem.Name = "operacionesDe2ValoresToolStripMenuItem";
            operacionesDe2ValoresToolStripMenuItem.Size = new Size(259, 26);
            operacionesDe2ValoresToolStripMenuItem.Text = "Operaciones de 2 valores";
            operacionesDe2ValoresToolStripMenuItem.Click += operacionesDe2ValoresToolStripMenuItem_Click;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmMenu";
            Text = "Menu de aplicaciones en clase";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem aplicaciónSimpleToolStripMenuItem;
        private ToolStripMenuItem aplicaciónSimpleToolStripMenuItem1;
        private ToolStripMenuItem operacionesDe2ValoresToolStripMenuItem;
    }
}