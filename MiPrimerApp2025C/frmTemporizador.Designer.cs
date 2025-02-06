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
            tmr = new System.Windows.Forms.Timer(components);
            lblReloj = new Label();
            mktalarma = new MaskedTextBox();
            chkhabilitar = new CheckBox();
            axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
            SuspendLayout();
            // 
            // tmr
            // 
            tmr.Enabled = true;
            tmr.Interval = 1000;
            tmr.Tick += tmr_Tick;
            // 
            // lblReloj
            // 
            lblReloj.AutoSize = true;
            lblReloj.Font = new Font("Arial", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReloj.Location = new Point(171, 22);
            lblReloj.Name = "lblReloj";
            lblReloj.Size = new Size(358, 93);
            lblReloj.TabIndex = 0;
            lblReloj.Text = "00:00:00";
            // 
            // mktalarma
            // 
            mktalarma.Location = new Point(58, 197);
            mktalarma.Mask = "00:00:00";
            mktalarma.Name = "mktalarma";
            mktalarma.Size = new Size(125, 27);
            mktalarma.TabIndex = 1;
            mktalarma.ValidatingType = typeof(DateTime);
            mktalarma.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // chkhabilitar
            // 
            chkhabilitar.AutoSize = true;
            chkhabilitar.Location = new Point(217, 200);
            chkhabilitar.Name = "chkhabilitar";
            chkhabilitar.Size = new Size(89, 24);
            chkhabilitar.TabIndex = 2;
            chkhabilitar.Text = "Habilitar";
            chkhabilitar.UseVisualStyleBackColor = true;
            chkhabilitar.CheckedChanged += chkhabilitar_CheckedChanged;
            // 
            // axWindowsMediaPlayer1
            // 
            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Location = new Point(330, 197);
            axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            axWindowsMediaPlayer1.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
            axWindowsMediaPlayer1.Size = new Size(232, 46);
            axWindowsMediaPlayer1.TabIndex = 3;
            // 
            // frmTemporizador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(751, 336);
            Controls.Add(axWindowsMediaPlayer1);
            Controls.Add(chkhabilitar);
            Controls.Add(mktalarma);
            Controls.Add(lblReloj);
            Name = "frmTemporizador";
            Text = "Relog";
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer tmr;
        private Label lblReloj;
        private MaskedTextBox mktalarma;
        private CheckBox chkhabilitar;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}