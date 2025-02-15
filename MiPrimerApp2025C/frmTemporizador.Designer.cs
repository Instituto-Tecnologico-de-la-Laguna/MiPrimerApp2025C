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
            lblReloj = new Label();
            mktAlarma = new MaskedTextBox();
            chkHabilitar = new CheckBox();
            axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            tmrReloj = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
            SuspendLayout();
            // 
            // lblReloj
            // 
            lblReloj.AutoSize = true;
            lblReloj.Font = new Font("Arial", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReloj.Location = new Point(90, 41);
            lblReloj.Margin = new Padding(2, 0, 2, 0);
            lblReloj.Name = "lblReloj";
            lblReloj.Size = new Size(358, 93);
            lblReloj.TabIndex = 1;
            lblReloj.Text = "00:00:00";
            // 
            // mktAlarma
            // 
            mktAlarma.Location = new Point(11, 177);
            mktAlarma.Margin = new Padding(2);
            mktAlarma.Mask = "00:00:00";
            mktAlarma.Name = "mktAlarma";
            mktAlarma.Size = new Size(121, 27);
            mktAlarma.TabIndex = 2;
            mktAlarma.ValidatingType = typeof(DateTime);
            // 
            // chkHabilitar
            // 
            chkHabilitar.AutoSize = true;
            chkHabilitar.Location = new Point(153, 180);
            chkHabilitar.Margin = new Padding(2);
            chkHabilitar.Name = "chkHabilitar";
            chkHabilitar.Size = new Size(89, 24);
            chkHabilitar.TabIndex = 3;
            chkHabilitar.Text = "Habilitar";
            chkHabilitar.UseVisualStyleBackColor = true;
            chkHabilitar.CheckedChanged += chkHabilitar_CheckedChanged;
            // 
            // axWindowsMediaPlayer1
            // 
            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Location = new Point(260, 172);
            axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            axWindowsMediaPlayer1.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
            axWindowsMediaPlayer1.Size = new Size(274, 41);
            axWindowsMediaPlayer1.TabIndex = 4;
            // 
            // tmrReloj
            // 
            tmrReloj.Enabled = true;
            tmrReloj.Interval = 1000;
            tmrReloj.Tick += tmrReloj_Tick;
            // 
            // frmTemporizador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 225);
            Controls.Add(axWindowsMediaPlayer1);
            Controls.Add(chkHabilitar);
            Controls.Add(mktAlarma);
            Controls.Add(lblReloj);
            Name = "frmTemporizador";
            Text = "frmTemporizador";
            Load += frmTemporizador_Load;
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblReloj;
        private MaskedTextBox mktAlarma;
        private CheckBox chkHabilitar;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Timer tmrReloj;
    }
}