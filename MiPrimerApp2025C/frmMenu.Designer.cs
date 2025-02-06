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
            aplicacionesToolStripMenuItem = new ToolStripMenuItem();
            aplicacionesSimpleToolStripMenuItem = new ToolStripMenuItem();
            operacionesCon2ValoresToolStripMenuItem = new ToolStripMenuItem();
            relojToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, aplicacionesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 20);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(96, 22);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // aplicacionesToolStripMenuItem
            // 
            aplicacionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aplicacionesSimpleToolStripMenuItem, operacionesCon2ValoresToolStripMenuItem, relojToolStripMenuItem });
            aplicacionesToolStripMenuItem.Name = "aplicacionesToolStripMenuItem";
            aplicacionesToolStripMenuItem.Size = new Size(86, 20);
            aplicacionesToolStripMenuItem.Text = "Aplicaciones";
            // 
            // aplicacionesSimpleToolStripMenuItem
            // 
            aplicacionesSimpleToolStripMenuItem.Name = "aplicacionesSimpleToolStripMenuItem";
            aplicacionesSimpleToolStripMenuItem.Size = new Size(214, 22);
            aplicacionesSimpleToolStripMenuItem.Text = "Aplicaciones Simple";
            aplicacionesSimpleToolStripMenuItem.Click += aplicacionesSimpleToolStripMenuItem_Click;
            // 
            // operacionesCon2ValoresToolStripMenuItem
            // 
            operacionesCon2ValoresToolStripMenuItem.Name = "operacionesCon2ValoresToolStripMenuItem";
            operacionesCon2ValoresToolStripMenuItem.Size = new Size(214, 22);
            operacionesCon2ValoresToolStripMenuItem.Text = "Operaciones Con 2 Valores";
            operacionesCon2ValoresToolStripMenuItem.Click += operacionesCon2ValoresToolStripMenuItem_Click;
            // 
            // relojToolStripMenuItem
            // 
            relojToolStripMenuItem.Name = "relojToolStripMenuItem";
            relojToolStripMenuItem.Size = new Size(214, 22);
            relojToolStripMenuItem.Text = "Temporizador";
            relojToolStripMenuItem.Click += relojToolStripMenuItem_Click;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmMenu";
            Text = "Menu de Aplicaciones de Clase";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem aplicacionesToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem aplicacionesSimpleToolStripMenuItem;
        private ToolStripMenuItem operacionesCon2ValoresToolStripMenuItem;
        private ToolStripMenuItem relojToolStripMenuItem;
    }
}