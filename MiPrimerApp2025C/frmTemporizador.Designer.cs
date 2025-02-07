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
            chkHabilitar = new CheckBox();
            tmrReloj = new System.Windows.Forms.Timer(components);
            axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            lblReloj = new Label();
            mktAlarma = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
            SuspendLayout();
            // 
            // chkHabilitar
            // 
            chkHabilitar.AutoSize = true;
            chkHabilitar.Location = new Point(152, 237);
            chkHabilitar.Name = "chkHabilitar";
            chkHabilitar.Size = new Size(89, 24);
            chkHabilitar.TabIndex = 0;
            chkHabilitar.Text = "Habilitar";
            chkHabilitar.UseVisualStyleBackColor = true;
            chkHabilitar.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // tmrReloj
            // 
            tmrReloj.Enabled = true;
            tmrReloj.Interval = 1000;
            tmrReloj.Tick += tmrReloj_Tick;
            // 
            // axWindowsMediaPlayer1
            // 
            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Location = new Point(467, 234);
            axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            axWindowsMediaPlayer1.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
            axWindowsMediaPlayer1.Size = new Size(195, 53);
            axWindowsMediaPlayer1.TabIndex = 1;
            // 
            // lblReloj
            // 
            lblReloj.AutoSize = true;
            lblReloj.Font = new Font("Arial", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReloj.Location = new Point(239, 58);
            lblReloj.Name = "lblReloj";
            lblReloj.Size = new Size(358, 93);
            lblReloj.TabIndex = 2;
            lblReloj.Text = "00:00:00";
            lblReloj.Click += label1_Click;
            // 
            // mktAlarma
            // 
            mktAlarma.Location = new Point(272, 234);
            mktAlarma.Mask = "00:00:00";
            mktAlarma.Name = "mktAlarma";
            mktAlarma.Size = new Size(125, 27);
            mktAlarma.TabIndex = 3;
            mktAlarma.ValidatingType = typeof(DateTime);
            mktAlarma.MaskInputRejected += mktAlarma_MaskInputRejected;
            // 
            // frmTemporizador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mktAlarma);
            Controls.Add(lblReloj);
            Controls.Add(axWindowsMediaPlayer1);
            Controls.Add(chkHabilitar);
            Name = "frmTemporizador";
            Text = "frmTemporizador";
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkHabilitar;
        private System.Windows.Forms.Timer tmrReloj;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private Label lblReloj;
        private MaskedTextBox mktAlarma;
    }
}