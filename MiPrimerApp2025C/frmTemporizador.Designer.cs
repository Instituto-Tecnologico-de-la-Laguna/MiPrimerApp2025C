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
            tmrREloj = new System.Windows.Forms.Timer(components);
            lblTemporizador = new Label();
            mktAlarma = new MaskedTextBox();
            chkHabilitar = new CheckBox();
            axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
            SuspendLayout();
            // 
            // tmrREloj
            // 
            tmrREloj.Enabled = true;
            tmrREloj.Tick += tmrREloj_Tick;
            // 
            // lblTemporizador
            // 
            lblTemporizador.AutoSize = true;
            lblTemporizador.Font = new Font("Arial", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTemporizador.Location = new Point(149, 28);
            lblTemporizador.Name = "lblTemporizador";
            lblTemporizador.Size = new Size(358, 93);
            lblTemporizador.TabIndex = 0;
            lblTemporizador.Text = "00:00:00";
            // 
            // mktAlarma
            // 
            mktAlarma.Location = new Point(65, 196);
            mktAlarma.Mask = "00:00:00";
            mktAlarma.Name = "mktAlarma";
            mktAlarma.Size = new Size(125, 27);
            mktAlarma.TabIndex = 1;
            mktAlarma.ValidatingType = typeof(DateTime);
            // 
            // chkHabilitar
            // 
            chkHabilitar.AutoSize = true;
            chkHabilitar.Location = new Point(230, 200);
            chkHabilitar.Name = "chkHabilitar";
            chkHabilitar.Size = new Size(89, 24);
            chkHabilitar.TabIndex = 2;
            chkHabilitar.Text = "Habilitar";
            chkHabilitar.UseVisualStyleBackColor = true;
            chkHabilitar.CheckedChanged += chkHabilitar_CheckedChanged;
            // 
            // axWindowsMediaPlayer1
            // 
            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Location = new Point(554, 196);
            axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            axWindowsMediaPlayer1.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
            axWindowsMediaPlayer1.Size = new Size(224, 46);
            axWindowsMediaPlayer1.TabIndex = 3;
            // 
            // frmTemporizador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 317);
            Controls.Add(axWindowsMediaPlayer1);
            Controls.Add(chkHabilitar);
            Controls.Add(mktAlarma);
            Controls.Add(lblTemporizador);
            Name = "frmTemporizador";
            Text = "REloj";
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer tmrREloj;
        private Label lblTemporizador;
        private MaskedTextBox mktAlarma;
        private CheckBox chkHabilitar;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}