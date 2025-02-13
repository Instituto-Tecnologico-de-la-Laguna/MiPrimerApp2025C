
namespace MiPrimerApp2025C
{
    partial class FrmMenu
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
            aplicaciónSimpleToolStripMenuItem = new ToolStripMenuItem();
            operacionesDe2ValoresToolStripMenuItem = new ToolStripMenuItem();
            temporizadorToolStripMenuItem = new ToolStripMenuItem();
            editorDeTextoToolStripMenuItem = new ToolStripMenuItem();
            temporizador2ToolStripMenuItem = new ToolStripMenuItem();
            dataGridToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, aplicacionesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(322, 24);
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
            aplicacionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aplicaciónSimpleToolStripMenuItem, operacionesDe2ValoresToolStripMenuItem, temporizadorToolStripMenuItem, editorDeTextoToolStripMenuItem, temporizador2ToolStripMenuItem, dataGridToolStripMenuItem });
            aplicacionesToolStripMenuItem.Name = "aplicacionesToolStripMenuItem";
            aplicacionesToolStripMenuItem.Size = new Size(86, 20);
            aplicacionesToolStripMenuItem.Text = "Aplicaciones";
            aplicacionesToolStripMenuItem.Click += aplicacionesToolStripMenuItem_Click;
            // 
            // aplicaciónSimpleToolStripMenuItem
            // 
            aplicaciónSimpleToolStripMenuItem.Name = "aplicaciónSimpleToolStripMenuItem";
            aplicaciónSimpleToolStripMenuItem.Size = new Size(205, 22);
            aplicaciónSimpleToolStripMenuItem.Text = "Aplicación Simple";
            aplicaciónSimpleToolStripMenuItem.Click += aplicaciónSimpleToolStripMenuItem_Click;
            // 
            // operacionesDe2ValoresToolStripMenuItem
            // 
            operacionesDe2ValoresToolStripMenuItem.Name = "operacionesDe2ValoresToolStripMenuItem";
            operacionesDe2ValoresToolStripMenuItem.Size = new Size(205, 22);
            operacionesDe2ValoresToolStripMenuItem.Text = "Operaciones de 2 valores";
            operacionesDe2ValoresToolStripMenuItem.Click += operacionesDe2ValoresToolStripMenuItem_Click;
            // 
            // temporizadorToolStripMenuItem
            // 
            temporizadorToolStripMenuItem.Name = "temporizadorToolStripMenuItem";
            temporizadorToolStripMenuItem.Size = new Size(205, 22);
            temporizadorToolStripMenuItem.Text = "Temporizador";
            temporizadorToolStripMenuItem.Click += temporizadorToolStripMenuItem_Click;
            // 
            // editorDeTextoToolStripMenuItem
            // 
            editorDeTextoToolStripMenuItem.Name = "editorDeTextoToolStripMenuItem";
            editorDeTextoToolStripMenuItem.Size = new Size(205, 22);
            editorDeTextoToolStripMenuItem.Text = "Editor de texto";
            editorDeTextoToolStripMenuItem.Click += editorDeTextoToolStripMenuItem_Click;
            // 
            // temporizador2ToolStripMenuItem
            // 
            temporizador2ToolStripMenuItem.Name = "temporizador2ToolStripMenuItem";
            temporizador2ToolStripMenuItem.Size = new Size(205, 22);
            temporizador2ToolStripMenuItem.Text = "Temporizador 2";
            temporizador2ToolStripMenuItem.Click += temporizador2ToolStripMenuItem_Click;
            // 
            // dataGridToolStripMenuItem
            // 
            dataGridToolStripMenuItem.Name = "dataGridToolStripMenuItem";
            dataGridToolStripMenuItem.Size = new Size(205, 22);
            dataGridToolStripMenuItem.Text = "Data Grid";
            dataGridToolStripMenuItem.Click += dataGridToolStripMenuItem_Click;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(322, 202);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmMenu";
            Text = "Menú de aplicaciones en clase";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void aplicaciónSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 AppSimple = new Form1();
            AppSimple.Show();

        }

        private void aplicacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem aplicacionesToolStripMenuItem;
        private ToolStripMenuItem aplicaciónSimpleToolStripMenuItem;
        private ToolStripMenuItem operacionesDe2ValoresToolStripMenuItem;
        private ToolStripMenuItem temporizadorToolStripMenuItem;
        private ToolStripMenuItem editorDeTextoToolStripMenuItem;
        private ToolStripMenuItem temporizador2ToolStripMenuItem;
        private ToolStripMenuItem dataGridToolStripMenuItem;
    }
}