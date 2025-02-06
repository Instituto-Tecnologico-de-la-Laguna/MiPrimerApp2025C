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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            aplicacionesToolStripMenuItem = new ToolStripMenuItem();
            aplicacionSimpleToolStripMenuItem = new ToolStripMenuItem();
            aplicacion2ValoresToolStripMenuItem = new ToolStripMenuItem();
            temporizadorToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, aplicacionesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            toolStripMenuItem1.Image = Properties.Resources.utorrent;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(93, 24);
            toolStripMenuItem1.Text = "Archivo";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(224, 26);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // aplicacionesToolStripMenuItem
            // 
            aplicacionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aplicacionSimpleToolStripMenuItem, aplicacion2ValoresToolStripMenuItem, temporizadorToolStripMenuItem });
            aplicacionesToolStripMenuItem.Image = Properties.Resources.PS;
            aplicacionesToolStripMenuItem.Name = "aplicacionesToolStripMenuItem";
            aplicacionesToolStripMenuItem.Size = new Size(127, 24);
            aplicacionesToolStripMenuItem.Text = "Aplicaciones";
            // 
            // aplicacionSimpleToolStripMenuItem
            // 
            aplicacionSimpleToolStripMenuItem.Image = Properties.Resources.ICONO_DISCORD;
            aplicacionSimpleToolStripMenuItem.Name = "aplicacionSimpleToolStripMenuItem";
            aplicacionSimpleToolStripMenuItem.Size = new Size(225, 26);
            aplicacionSimpleToolStripMenuItem.Text = "Aplicacion Simple";
            aplicacionSimpleToolStripMenuItem.Click += aplicacionSimpleToolStripMenuItem_Click;
            // 
            // aplicacion2ValoresToolStripMenuItem
            // 
            aplicacion2ValoresToolStripMenuItem.Name = "aplicacion2ValoresToolStripMenuItem";
            aplicacion2ValoresToolStripMenuItem.Size = new Size(225, 26);
            aplicacion2ValoresToolStripMenuItem.Text = "Aplicacion 2 valores";
            aplicacion2ValoresToolStripMenuItem.Click += aplicacion2ValoresToolStripMenuItem_Click;
            // 
            // temporizadorToolStripMenuItem
            // 
            temporizadorToolStripMenuItem.Name = "temporizadorToolStripMenuItem";
            temporizadorToolStripMenuItem.Size = new Size(225, 26);
            temporizadorToolStripMenuItem.Text = "Temporizador";
            temporizadorToolStripMenuItem.Click += temporizadorToolStripMenuItem_Click;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
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
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem aplicacionesToolStripMenuItem;
        private ToolStripMenuItem aplicacionSimpleToolStripMenuItem;
        private ToolStripMenuItem aplicacion2ValoresToolStripMenuItem;
        private ToolStripMenuItem temporizadorToolStripMenuItem;
    }
}