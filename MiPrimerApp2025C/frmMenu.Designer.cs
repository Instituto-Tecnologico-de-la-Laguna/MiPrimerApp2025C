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
            aplicacionSimpleToolStripMenuItem = new ToolStripMenuItem();
            operaciones2NumerosToolStripMenuItem = new ToolStripMenuItem();
            temporizadorToolStripMenuItem = new ToolStripMenuItem();
            editorDeTextoToolStripMenuItem = new ToolStripMenuItem();
            temporizador2ToolStripMenuItem = new ToolStripMenuItem();
            temporizadorToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, aplicacionesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(88, 29);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(147, 34);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // aplicacionesToolStripMenuItem
            // 
            aplicacionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aplicacionSimpleToolStripMenuItem, operaciones2NumerosToolStripMenuItem, temporizadorToolStripMenuItem, editorDeTextoToolStripMenuItem, temporizador2ToolStripMenuItem, temporizadorToolStripMenuItem1 });
            aplicacionesToolStripMenuItem.Name = "aplicacionesToolStripMenuItem";
            aplicacionesToolStripMenuItem.Size = new Size(126, 29);
            aplicacionesToolStripMenuItem.Text = "Aplicaciones";
            // 
            // aplicacionSimpleToolStripMenuItem
            // 
            aplicacionSimpleToolStripMenuItem.Name = "aplicacionSimpleToolStripMenuItem";
            aplicacionSimpleToolStripMenuItem.Size = new Size(306, 34);
            aplicacionSimpleToolStripMenuItem.Text = "Aplicacion Simple";
            aplicacionSimpleToolStripMenuItem.Click += aplicacionSimpleToolStripMenuItem_Click;
            // 
            // operaciones2NumerosToolStripMenuItem
            // 
            operaciones2NumerosToolStripMenuItem.Name = "operaciones2NumerosToolStripMenuItem";
            operaciones2NumerosToolStripMenuItem.Size = new Size(306, 34);
            operaciones2NumerosToolStripMenuItem.Text = "Operaciones 2 Numeros";
            operaciones2NumerosToolStripMenuItem.Click += operaciones2NumerosToolStripMenuItem_Click;
            // 
            // temporizadorToolStripMenuItem
            // 
            temporizadorToolStripMenuItem.Name = "temporizadorToolStripMenuItem";
            temporizadorToolStripMenuItem.Size = new Size(306, 34);
            temporizadorToolStripMenuItem.Text = "Reloj";
            temporizadorToolStripMenuItem.Click += temporizadorToolStripMenuItem_Click;
            // 
            // editorDeTextoToolStripMenuItem
            // 
            editorDeTextoToolStripMenuItem.Name = "editorDeTextoToolStripMenuItem";
            editorDeTextoToolStripMenuItem.Size = new Size(306, 34);
            editorDeTextoToolStripMenuItem.Text = "Editor de Texto";
            editorDeTextoToolStripMenuItem.Click += editorDeTextoToolStripMenuItem_Click;
            // 
            // temporizador2ToolStripMenuItem
            // 
            temporizador2ToolStripMenuItem.Name = "temporizador2ToolStripMenuItem";
            temporizador2ToolStripMenuItem.Size = new Size(306, 34);
            temporizador2ToolStripMenuItem.Text = "Temporizador 2";
            temporizador2ToolStripMenuItem.Click += temporizador2ToolStripMenuItem_Click;
            // 
            // temporizadorToolStripMenuItem1
            // 
            temporizadorToolStripMenuItem1.Name = "temporizadorToolStripMenuItem1";
            temporizadorToolStripMenuItem1.Size = new Size(306, 34);
            temporizadorToolStripMenuItem1.Text = "ShowGrid";
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
        private ToolStripMenuItem aplicacionSimpleToolStripMenuItem;
        private ToolStripMenuItem operaciones2NumerosToolStripMenuItem;
        private ToolStripMenuItem temporizadorToolStripMenuItem;
        private ToolStripMenuItem editorDeTextoToolStripMenuItem;
        private ToolStripMenuItem temporizador2ToolStripMenuItem;
        private ToolStripMenuItem temporizadorToolStripMenuItem1;
    }
}