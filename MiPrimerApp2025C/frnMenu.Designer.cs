namespace MiPrimerApp2025C
{
    partial class frnMenu
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
            arrchivoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            aplicacionToolStripMenuItem = new ToolStripMenuItem();
            aplicacionSimpleToolStripMenuItem = new ToolStripMenuItem();
            operacionesConDosValoresToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { arrchivoToolStripMenuItem, aplicacionToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // arrchivoToolStripMenuItem
            // 
            arrchivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            arrchivoToolStripMenuItem.Name = "arrchivoToolStripMenuItem";
            arrchivoToolStripMenuItem.Size = new Size(73, 24);
            arrchivoToolStripMenuItem.Text = "Archivo";
            arrchivoToolStripMenuItem.Click += arrchivoToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(224, 26);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // aplicacionToolStripMenuItem
            // 
            aplicacionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aplicacionSimpleToolStripMenuItem, operacionesConDosValoresToolStripMenuItem });
            aplicacionToolStripMenuItem.Name = "aplicacionToolStripMenuItem";
            aplicacionToolStripMenuItem.Size = new Size(93, 24);
            aplicacionToolStripMenuItem.Text = "Aplicacion";
            // 
            // aplicacionSimpleToolStripMenuItem
            // 
            aplicacionSimpleToolStripMenuItem.Name = "aplicacionSimpleToolStripMenuItem";
            aplicacionSimpleToolStripMenuItem.Size = new Size(283, 26);
            aplicacionSimpleToolStripMenuItem.Text = "Aplicacion Simple";
            aplicacionSimpleToolStripMenuItem.Click += aplicacionSimpleToolStripMenuItem_Click;
            // 
            // operacionesConDosValoresToolStripMenuItem
            // 
            operacionesConDosValoresToolStripMenuItem.Name = "operacionesConDosValoresToolStripMenuItem";
            operacionesConDosValoresToolStripMenuItem.Size = new Size(283, 26);
            operacionesConDosValoresToolStripMenuItem.Text = "Operaciones con dos Valores";
            operacionesConDosValoresToolStripMenuItem.Click += operacionesConDosValoresToolStripMenuItem_Click;
            // 
            // frnMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frnMenu";
            Text = "Menu de Aplicaiones en Clase";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem arrchivoToolStripMenuItem;
        private ToolStripMenuItem aplicacionToolStripMenuItem;
        private ToolStripMenuItem aplicacionSimpleToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem operacionesConDosValoresToolStripMenuItem;
    }
}