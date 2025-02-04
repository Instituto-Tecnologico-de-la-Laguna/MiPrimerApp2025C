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
            accionesToolStripMenuItem = new ToolStripMenuItem();
            aplicacionesToolStripMenuItem = new ToolStripMenuItem();
            aplicacionesSimplesToolStripMenuItem = new ToolStripMenuItem();
            operacionesCon2ValoresToolStripMenuItem = new ToolStripMenuItem();
            menuStrip2 = new MenuStrip();
            salirToolStripMenuItem = new ToolStripMenuItem();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // accionesToolStripMenuItem
            // 
            accionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            accionesToolStripMenuItem.Name = "accionesToolStripMenuItem";
            accionesToolStripMenuItem.Size = new Size(82, 24);
            accionesToolStripMenuItem.Text = "Acciones";
            accionesToolStripMenuItem.Click += accionesToolStripMenuItem_Click;
            // 
            // aplicacionesToolStripMenuItem
            // 
            aplicacionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aplicacionesSimplesToolStripMenuItem, operacionesCon2ValoresToolStripMenuItem });
            aplicacionesToolStripMenuItem.Name = "aplicacionesToolStripMenuItem";
            aplicacionesToolStripMenuItem.Size = new Size(107, 24);
            aplicacionesToolStripMenuItem.Text = "Aplicaciones";
            // 
            // aplicacionesSimplesToolStripMenuItem
            // 
            aplicacionesSimplesToolStripMenuItem.Name = "aplicacionesSimplesToolStripMenuItem";
            aplicacionesSimplesToolStripMenuItem.Size = new Size(266, 26);
            aplicacionesSimplesToolStripMenuItem.Text = "Aplicaciones Simples";
            aplicacionesSimplesToolStripMenuItem.Click += aplicacionesSimplesToolStripMenuItem_Click;
            // 
            // operacionesCon2ValoresToolStripMenuItem
            // 
            operacionesCon2ValoresToolStripMenuItem.Name = "operacionesCon2ValoresToolStripMenuItem";
            operacionesCon2ValoresToolStripMenuItem.Size = new Size(266, 26);
            operacionesCon2ValoresToolStripMenuItem.Text = "Operaciones con 2 valores";
            operacionesCon2ValoresToolStripMenuItem.Click += operacionesCon2ValoresToolStripMenuItem_Click;
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { accionesToolStripMenuItem, aplicacionesToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(800, 28);
            menuStrip2.TabIndex = 1;
            menuStrip2.Text = "menuStrip2";
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
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip2);
            Name = "frmMenu";
            Text = "frmMenu";
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStripMenuItem accionesToolStripMenuItem;
        private ToolStripMenuItem aplicacionesToolStripMenuItem;
        private ToolStripMenuItem aplicacionesSimplesToolStripMenuItem;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem operacionesCon2ValoresToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
    }
}