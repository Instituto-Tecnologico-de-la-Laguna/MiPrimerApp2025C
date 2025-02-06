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
            appSimpleToolStripMenuItem = new ToolStripMenuItem();
            appOp2NumerosToolStripMenuItem = new ToolStripMenuItem();
            temporizadorToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, aplicacionesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(522, 24);
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
            aplicacionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { appSimpleToolStripMenuItem, appOp2NumerosToolStripMenuItem, temporizadorToolStripMenuItem });
            aplicacionesToolStripMenuItem.Name = "aplicacionesToolStripMenuItem";
            aplicacionesToolStripMenuItem.Size = new Size(86, 20);
            aplicacionesToolStripMenuItem.Text = "Aplicaciones";
            // 
            // appSimpleToolStripMenuItem
            // 
            appSimpleToolStripMenuItem.Name = "appSimpleToolStripMenuItem";
            appSimpleToolStripMenuItem.Size = new Size(180, 22);
            appSimpleToolStripMenuItem.Text = "App Simple";
            appSimpleToolStripMenuItem.Click += appSimpleToolStripMenuItem_Click;
            // 
            // appOp2NumerosToolStripMenuItem
            // 
            appOp2NumerosToolStripMenuItem.Name = "appOp2NumerosToolStripMenuItem";
            appOp2NumerosToolStripMenuItem.Size = new Size(180, 22);
            appOp2NumerosToolStripMenuItem.Text = "App Op 2 numeros";
            appOp2NumerosToolStripMenuItem.Click += appOp2NumerosToolStripMenuItem_Click;
            // 
            // temporizadorToolStripMenuItem
            // 
            temporizadorToolStripMenuItem.Name = "temporizadorToolStripMenuItem";
            temporizadorToolStripMenuItem.Size = new Size(180, 22);
            temporizadorToolStripMenuItem.Text = "Temporizador";
            temporizadorToolStripMenuItem.Click += temporizadorToolStripMenuItem_Click;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 304);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmMenu";
            Text = "Menu de Aplicaciones en Clase";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem aplicacionesToolStripMenuItem;
        private ToolStripMenuItem appSimpleToolStripMenuItem;
        private ToolStripMenuItem appOp2NumerosToolStripMenuItem;
        private ToolStripMenuItem temporizadorToolStripMenuItem;
    }
}