namespace MiPrimerApp2025C
{
    partial class Formenu
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
            salirToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem1 = new ToolStripMenuItem();
            aplicacionesToolStripMenuItem = new ToolStripMenuItem();
            aplicacionSimpleToolStripMenuItem = new ToolStripMenuItem();
            operacionDe2NumerosToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { salirToolStripMenuItem, aplicacionesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(557, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem1 });
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(41, 20);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // salirToolStripMenuItem1
            // 
            salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            salirToolStripMenuItem1.Size = new Size(95, 22);
            salirToolStripMenuItem1.Text = "salir";
            // 
            // aplicacionesToolStripMenuItem
            // 
            aplicacionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aplicacionSimpleToolStripMenuItem, operacionDe2NumerosToolStripMenuItem });
            aplicacionesToolStripMenuItem.Name = "aplicacionesToolStripMenuItem";
            aplicacionesToolStripMenuItem.Size = new Size(86, 20);
            aplicacionesToolStripMenuItem.Text = "Aplicaciones";
            // 
            // aplicacionSimpleToolStripMenuItem
            // 
            aplicacionSimpleToolStripMenuItem.Name = "aplicacionSimpleToolStripMenuItem";
            aplicacionSimpleToolStripMenuItem.Size = new Size(202, 22);
            aplicacionSimpleToolStripMenuItem.Text = "aplicacion simple";
            aplicacionSimpleToolStripMenuItem.Click += aplicacionSimpleToolStripMenuItem_Click;
            // 
            // operacionDe2NumerosToolStripMenuItem
            // 
            operacionDe2NumerosToolStripMenuItem.Name = "operacionDe2NumerosToolStripMenuItem";
            operacionDe2NumerosToolStripMenuItem.Size = new Size(202, 22);
            operacionDe2NumerosToolStripMenuItem.Text = "operacion de 2 numeros";
            operacionDe2NumerosToolStripMenuItem.Click += operacionDe2NumerosToolStripMenuItem_Click;
            // 
            // Formenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 168);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Formenu";
            Text = "Formenu";
            Load += Formenu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem aplicacionesToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem1;
        private ToolStripMenuItem aplicacionSimpleToolStripMenuItem;
        private ToolStripMenuItem operacionDe2NumerosToolStripMenuItem;
    }
}