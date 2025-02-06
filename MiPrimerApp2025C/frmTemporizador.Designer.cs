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
            mTBAlarma = new MaskedTextBox();
            ckBHabilitar = new CheckBox();
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
            lblReloj.Font = new Font("Ravie", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblReloj.Location = new Point(30, 51);
            lblReloj.Name = "lblReloj";
            lblReloj.Size = new Size(569, 129);
            lblReloj.TabIndex = 0;
            lblReloj.Text = "00:00:00";
            // 
            // mTBAlarma
            // 
            mTBAlarma.Location = new Point(95, 195);
            mTBAlarma.Mask = "00:00:00";
            mTBAlarma.Name = "mTBAlarma";
            mTBAlarma.Size = new Size(150, 31);
            mTBAlarma.TabIndex = 1;
            mTBAlarma.ValidatingType = typeof(DateTime);
            // 
            // ckBHabilitar
            // 
            ckBHabilitar.AutoSize = true;
            ckBHabilitar.Location = new Point(251, 195);
            ckBHabilitar.Name = "ckBHabilitar";
            ckBHabilitar.Size = new Size(104, 29);
            ckBHabilitar.TabIndex = 2;
            ckBHabilitar.Text = "Habilitar";
            ckBHabilitar.UseVisualStyleBackColor = true;
            ckBHabilitar.CheckedChanged += ckBHabilitar_CheckedChanged;
            // 
            // axWindowsMediaPlayer1
            // 
            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Location = new Point(459, 195);
            axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            axWindowsMediaPlayer1.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
            axWindowsMediaPlayer1.Size = new Size(140, 63);
            axWindowsMediaPlayer1.TabIndex = 3;
            // 
            // frmTemporizador
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 270);
            Controls.Add(axWindowsMediaPlayer1);
            Controls.Add(ckBHabilitar);
            Controls.Add(mTBAlarma);
            Controls.Add(lblReloj);
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
        private MaskedTextBox mTBAlarma;
        private CheckBox ckBHabilitar;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}