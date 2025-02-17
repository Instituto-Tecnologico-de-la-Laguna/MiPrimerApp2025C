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
            trmReloj = new System.Windows.Forms.Timer(components);
            lblReloj = new Label();
            mkbAlarma = new MaskedTextBox();
            chkHabilitar = new CheckBox();
            axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
            SuspendLayout();
            // 
            // trmReloj
            // 
            trmReloj.Enabled = true;
            trmReloj.Interval = 1000;
            trmReloj.Tick += trmReloj_Tick;
            // 
            // lblReloj
            // 
            lblReloj.AutoSize = true;
            lblReloj.Font = new Font("Showcard Gothic", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblReloj.Location = new Point(58, 52);
            lblReloj.Name = "lblReloj";
            lblReloj.Size = new Size(683, 177);
            lblReloj.TabIndex = 0;
            lblReloj.Text = "00:00:00";
            // 
            // mkbAlarma
            // 
            mkbAlarma.Location = new Point(58, 260);
            mkbAlarma.Mask = "00:00:00";
            mkbAlarma.Name = "mkbAlarma";
            mkbAlarma.Size = new Size(191, 31);
            mkbAlarma.TabIndex = 1;
            mkbAlarma.ValidatingType = typeof(DateTime);
            mkbAlarma.MaskInputRejected += mkbAlarma_MaskInputRejected;
            // 
            // chkHabilitar
            // 
            chkHabilitar.AutoSize = true;
            chkHabilitar.Location = new Point(285, 262);
            chkHabilitar.Name = "chkHabilitar";
            chkHabilitar.Size = new Size(104, 29);
            chkHabilitar.TabIndex = 2;
            chkHabilitar.Text = "Habilitar";
            chkHabilitar.UseVisualStyleBackColor = true;
            chkHabilitar.CheckedChanged += chkHabilitar_CheckedChanged;
            // 
            // axWindowsMediaPlayer1
            // 
            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Location = new Point(479, 262);
            axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            axWindowsMediaPlayer1.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
            axWindowsMediaPlayer1.Size = new Size(309, 68);
            axWindowsMediaPlayer1.TabIndex = 3;
            // 
            // frmTemporizador
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 343);
            Controls.Add(axWindowsMediaPlayer1);
            Controls.Add(chkHabilitar);
            Controls.Add(mkbAlarma);
            Controls.Add(lblReloj);
            Name = "frmTemporizador";
            Text = "Reloj";
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer trmReloj;
        private Label lblReloj;
        private MaskedTextBox mkbAlarma;
        private CheckBox chkHabilitar;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}