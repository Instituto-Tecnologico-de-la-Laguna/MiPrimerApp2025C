namespace MiPrimerApp2025C
{
    partial class frmeditor
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
            aRCHIVOToolStripMenuItem = new ToolStripMenuItem();
            aBRIRToolStripMenuItem = new ToolStripMenuItem();
            nUEVOToolStripMenuItem = new ToolStripMenuItem();
            gUARDARToolStripMenuItem = new ToolStripMenuItem();
            gUARDARCOMOToolStripMenuItem = new ToolStripMenuItem();
            sALIRToolStripMenuItem = new ToolStripMenuItem();
            rtbEditor = new RichTextBox();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { aRCHIVOToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // aRCHIVOToolStripMenuItem
            // 
            aRCHIVOToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aBRIRToolStripMenuItem, nUEVOToolStripMenuItem, gUARDARToolStripMenuItem, gUARDARCOMOToolStripMenuItem, sALIRToolStripMenuItem });
            aRCHIVOToolStripMenuItem.Name = "aRCHIVOToolStripMenuItem";
            aRCHIVOToolStripMenuItem.Size = new Size(86, 24);
            aRCHIVOToolStripMenuItem.Text = "ARCHIVO";
            // 
            // aBRIRToolStripMenuItem
            // 
            aBRIRToolStripMenuItem.Name = "aBRIRToolStripMenuItem";
            aBRIRToolStripMenuItem.Size = new Size(224, 26);
            aBRIRToolStripMenuItem.Text = "ABRIR";
            aBRIRToolStripMenuItem.Click += aBRIRToolStripMenuItem_Click;
            // 
            // nUEVOToolStripMenuItem
            // 
            nUEVOToolStripMenuItem.Name = "nUEVOToolStripMenuItem";
            nUEVOToolStripMenuItem.Size = new Size(224, 26);
            nUEVOToolStripMenuItem.Text = "NUEVO";
            nUEVOToolStripMenuItem.Click += nUEVOToolStripMenuItem_Click_1;
            // 
            // gUARDARToolStripMenuItem
            // 
            gUARDARToolStripMenuItem.Name = "gUARDARToolStripMenuItem";
            gUARDARToolStripMenuItem.Size = new Size(224, 26);
            gUARDARToolStripMenuItem.Text = "GUARDAR";
            gUARDARToolStripMenuItem.Click += gUARDARToolStripMenuItem_Click;
            // 
            // gUARDARCOMOToolStripMenuItem
            // 
            gUARDARCOMOToolStripMenuItem.Name = "gUARDARCOMOToolStripMenuItem";
            gUARDARCOMOToolStripMenuItem.Size = new Size(224, 26);
            gUARDARCOMOToolStripMenuItem.Text = "GUARDAR COMO";
            gUARDARCOMOToolStripMenuItem.Click += gUARDARCOMOToolStripMenuItem_Click;
            // 
            // sALIRToolStripMenuItem
            // 
            sALIRToolStripMenuItem.Name = "sALIRToolStripMenuItem";
            sALIRToolStripMenuItem.Size = new Size(224, 26);
            sALIRToolStripMenuItem.Text = "SALIR";
            sALIRToolStripMenuItem.Click += sALIRToolStripMenuItem_Click;
            // 
            // rtbEditor
            // 
            rtbEditor.Dock = DockStyle.Fill;
            rtbEditor.Location = new Point(0, 28);
            rtbEditor.Name = "rtbEditor";
            rtbEditor.Size = new Size(800, 422);
            rtbEditor.TabIndex = 1;
            rtbEditor.Text = "rop";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmeditor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rtbEditor);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmeditor";
            Text = "frmeditor";
            Load += frmeditor_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem aRCHIVOToolStripMenuItem;
        private ToolStripMenuItem aBRIRToolStripMenuItem;
        private ToolStripMenuItem nUEVOToolStripMenuItem;
        private ToolStripMenuItem gUARDARToolStripMenuItem;
        private ToolStripMenuItem gUARDARCOMOToolStripMenuItem;
        private ToolStripMenuItem sALIRToolStripMenuItem;
        private RichTextBox rtbEditor;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}