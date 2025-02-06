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
            aRchivoToolStripMenuItem = new ToolStripMenuItem();
            aplicacionesToolStripMenuItem = new ToolStripMenuItem();
            aplicacionSimpleToolStripMenuItem = new ToolStripMenuItem();
            operacionesCon2ValoresToolStripMenuItem = new ToolStripMenuItem();
            temporizadorToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { aRchivoToolStripMenuItem, aplicacionesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // aRchivoToolStripMenuItem
            // 
            aRchivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            aRchivoToolStripMenuItem.Name = "aRchivoToolStripMenuItem";
            aRchivoToolStripMenuItem.Size = new Size(73, 24);
            aRchivoToolStripMenuItem.Text = "Archivo";
            // 
            // aplicacionesToolStripMenuItem
            // 
            aplicacionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aplicacionSimpleToolStripMenuItem, operacionesCon2ValoresToolStripMenuItem, temporizadorToolStripMenuItem });
            aplicacionesToolStripMenuItem.Name = "aplicacionesToolStripMenuItem";
            aplicacionesToolStripMenuItem.Size = new Size(107, 24);
            aplicacionesToolStripMenuItem.Text = "Aplicaciones";
            // 
            // aplicacionSimpleToolStripMenuItem
            // 
            aplicacionSimpleToolStripMenuItem.Name = "aplicacionSimpleToolStripMenuItem";
            aplicacionSimpleToolStripMenuItem.Size = new Size(267, 26);
            aplicacionSimpleToolStripMenuItem.Text = "Aplicacion Simple";
            aplicacionSimpleToolStripMenuItem.Click += aplicacionSimpleToolStripMenuItem_Click;
            // 
            // operacionesCon2ValoresToolStripMenuItem
            // 
            operacionesCon2ValoresToolStripMenuItem.Name = "operacionesCon2ValoresToolStripMenuItem";
            operacionesCon2ValoresToolStripMenuItem.Size = new Size(267, 26);
            operacionesCon2ValoresToolStripMenuItem.Text = "Operaciones con 2 Valores";
            operacionesCon2ValoresToolStripMenuItem.Click += operacionesCon2ValoresToolStripMenuItem_Click;
            // 
            // temporizadorToolStripMenuItem
            // 
            temporizadorToolStripMenuItem.Name = "temporizadorToolStripMenuItem";
            temporizadorToolStripMenuItem.Size = new Size(267, 26);
            temporizadorToolStripMenuItem.Text = "Temporizador";
            temporizadorToolStripMenuItem.Click += temporizadorToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(224, 26);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(800, 169);
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
        private ToolStripMenuItem aRchivoToolStripMenuItem;
        private ToolStripMenuItem aplicacionesToolStripMenuItem;
        private ToolStripMenuItem aplicacionSimpleToolStripMenuItem;
        private ToolStripMenuItem operacionesCon2ValoresToolStripMenuItem;
        private ToolStripMenuItem temporizadorToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
    }
}