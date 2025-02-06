namespace MiPrimerApp2025C
{
    partial class FormTemporizador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTemporizador));
            tmrReloj = new System.Windows.Forms.Timer(components);
            lblReloj = new Label();
            mktAlarma = new MaskedTextBox();
            checarHabilitar = new CheckBox();
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
            lblReloj.Location = new Point(187, 38);
            lblReloj.Name = "lblReloj";
            lblReloj.Size = new Size(427, 111);
            lblReloj.TabIndex = 0;
            lblReloj.Text = "00:00:00";
            // 
            // mktAlarma
            // 
            mktAlarma.Location = new Point(151, 260);
            mktAlarma.Mask = "00:00:00";
            mktAlarma.Name = "mktAlarma";
            mktAlarma.Size = new Size(150, 31);
            mktAlarma.TabIndex = 1;
            mktAlarma.ValidatingType = typeof(DateTime);
            // 
            // checarHabilitar
            // 
            checarHabilitar.AutoSize = true;
            checarHabilitar.Location = new Point(307, 260);
            checarHabilitar.Name = "checarHabilitar";
            checarHabilitar.Size = new Size(104, 29);
            checarHabilitar.TabIndex = 2;
            checarHabilitar.Text = "Habilitar";
            checarHabilitar.UseVisualStyleBackColor = true;
            checarHabilitar.CheckedChanged += checarHabilitar_CheckedChanged;
            // 
            // axWindowsMediaPlayer1
            // 
            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Location = new Point(492, 246);
            axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            axWindowsMediaPlayer1.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
            axWindowsMediaPlayer1.Size = new Size(215, 45);
            axWindowsMediaPlayer1.TabIndex = 3;
            // 
            // FormTemporizador
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(axWindowsMediaPlayer1);
            Controls.Add(checarHabilitar);
            Controls.Add(mktAlarma);
            Controls.Add(lblReloj);
            Name = "FormTemporizador";
            Text = "Reloj";
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer tmrReloj;
        private Label lblReloj;
        private MaskedTextBox mktAlarma;
        private CheckBox checarHabilitar;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}