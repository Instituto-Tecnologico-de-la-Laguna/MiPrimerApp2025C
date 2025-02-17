namespace MiPrimerApp2025C
{
    partial class frmTemporizador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTemporizador));
            tmrReloj = new System.Windows.Forms.Timer(components);
            lblReloj = new Label();
            mktAlarma = new MaskedTextBox();
            chkHabilitar = new CheckBox();
            axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
            SuspendLayout();
            // 
            // tmrReloj
            // 
            tmrReloj.Enabled = true;
            tmrReloj.Interval = 1000;
            tmrReloj.Tick += tmrReloj_Tick;
            // 
            // lblReloj
            // 
            lblReloj.AutoSize = true;
            lblReloj.Font = new Font("Arial", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReloj.Location = new Point(96, 21);
            lblReloj.Margin = new Padding(2, 0, 2, 0);
            lblReloj.Name = "lblReloj";
            lblReloj.Size = new Size(290, 75);
            lblReloj.TabIndex = 0;
            lblReloj.Text = "00:00:00";
            lblReloj.Click += lblReloj_Click;
            // 
            // mktAlarma
            // 
            mktAlarma.Location = new Point(18, 132);
            mktAlarma.Margin = new Padding(2);
            mktAlarma.Mask = "00:00:00";
            mktAlarma.Name = "mktAlarma";
            mktAlarma.Size = new Size(106, 23);
            mktAlarma.TabIndex = 1;
            mktAlarma.ValidatingType = typeof(DateTime);
            mktAlarma.MaskInputRejected += mktAlarma_MaskInputRejected;
            // 
            // chkHabilitar
            // 
            chkHabilitar.AutoSize = true;
            chkHabilitar.Location = new Point(136, 133);
            chkHabilitar.Margin = new Padding(2);
            chkHabilitar.Name = "chkHabilitar";
            chkHabilitar.Size = new Size(71, 19);
            chkHabilitar.TabIndex = 2;
            chkHabilitar.Text = "Habilitar";
            chkHabilitar.UseVisualStyleBackColor = true;
            chkHabilitar.CheckedChanged += chkHabilitar_CheckedChanged;
            // 
            // axWindowsMediaPlayer1
            // 
            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Location = new Point(398, 207);
            axWindowsMediaPlayer1.Margin = new Padding(2);
            axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            axWindowsMediaPlayer1.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
            axWindowsMediaPlayer1.Size = new Size(317, 62);
            axWindowsMediaPlayer1.TabIndex = 3;
            // 
            // frmTemporizador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 163);
            Controls.Add(axWindowsMediaPlayer1);
            Controls.Add(chkHabilitar);
            Controls.Add(mktAlarma);
            Controls.Add(lblReloj);
            Margin = new Padding(2);
            Name = "frmTemporizador";
            Text = "Reloj";
            Load += frmTemporizador_Load;
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer tmrReloj;
        private Label lblReloj;
        private MaskedTextBox mktAlarma;
        private CheckBox chkHabilitar;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}