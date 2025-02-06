namespace MiPrimerApp2025C
{
    partial class frmTemporizados
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTemporizados));
            tmrReloj = new System.Windows.Forms.Timer(components);
            lblReloj = new Label();
            mkalarma = new MaskedTextBox();
            chbhabilitar = new CheckBox();
            axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
            SuspendLayout();
            // 
            // lblReloj
            // 
            lblReloj.AutoSize = true;
            lblReloj.Font = new Font("Arial", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReloj.Location = new Point(256, 64);
            lblReloj.Name = "lblReloj";
            lblReloj.Size = new Size(290, 75);
            lblReloj.TabIndex = 0;
            lblReloj.Text = "00:00:00";
            lblReloj.Click += lblReloj_Click;
            // 
            // mkalarma
            // 
            mkalarma.Location = new Point(367, 163);
            mkalarma.Mask = "00:00";
            mkalarma.Name = "mkalarma";
            mkalarma.Size = new Size(100, 23);
            mkalarma.TabIndex = 1;
            mkalarma.ValidatingType = typeof(DateTime);
            mkalarma.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // chbhabilitar
            // 
            chbhabilitar.AutoSize = true;
            chbhabilitar.Location = new Point(292, 167);
            chbhabilitar.Name = "chbhabilitar";
            chbhabilitar.Size = new Size(69, 19);
            chbhabilitar.TabIndex = 2;
            chbhabilitar.Text = "habilitar";
            chbhabilitar.UseVisualStyleBackColor = true;
            chbhabilitar.CheckedChanged += chbhabilitar_CheckedChanged;
            // 
            // axWindowsMediaPlayer1
            // 
            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Location = new Point(538, 214);
            axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            axWindowsMediaPlayer1.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
            axWindowsMediaPlayer1.Size = new Size(75, 23);
            axWindowsMediaPlayer1.TabIndex = 3;
            // 
            // frmTemporizados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(axWindowsMediaPlayer1);
            Controls.Add(chbhabilitar);
            Controls.Add(mkalarma);
            Controls.Add(lblReloj);
            Name = "frmTemporizados";
            Text = "reloj";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer tmrReloj;
        private Label lblReloj;
        private MaskedTextBox mkalarma;
        private CheckBox chbhabilitar;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}