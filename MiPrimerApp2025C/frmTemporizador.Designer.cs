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
            timer1 = new System.Windows.Forms.Timer(components);
            lblReloj = new Label();
            MktAlarma = new MaskedTextBox();
            ChkHabilitar = new CheckBox();
            WMP = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)WMP).BeginInit();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // lblReloj
            // 
            lblReloj.AutoSize = true;
            lblReloj.Font = new Font("Arial", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReloj.Location = new Point(38, 24);
            lblReloj.Name = "lblReloj";
            lblReloj.Size = new Size(358, 93);
            lblReloj.TabIndex = 0;
            lblReloj.Text = "00:00:00";
            lblReloj.Click += lblReloj_Click;
            // 
            // MktAlarma
            // 
            MktAlarma.Location = new Point(158, 305);
            MktAlarma.Mask = "00:00:00";
            MktAlarma.Name = "MktAlarma";
            MktAlarma.Size = new Size(125, 27);
            MktAlarma.TabIndex = 1;
            MktAlarma.ValidatingType = typeof(DateTime);
            // 
            // ChkHabilitar
            // 
            ChkHabilitar.AutoSize = true;
            ChkHabilitar.Location = new Point(374, 305);
            ChkHabilitar.Name = "ChkHabilitar";
            ChkHabilitar.Size = new Size(89, 24);
            ChkHabilitar.TabIndex = 2;
            ChkHabilitar.Text = "Habilitar";
            ChkHabilitar.UseVisualStyleBackColor = true;
            ChkHabilitar.CheckedChanged += ChkHabilitar_CheckedChanged;
            // 
            // WMP
            // 
            WMP.Enabled = true;
            WMP.Location = new Point(495, 331);
            WMP.Name = "WMP";
            WMP.OcxState = (AxHost.State)resources.GetObject("WMP.OcxState");
            WMP.Size = new Size(277, 95);
            WMP.TabIndex = 3;
            // 
            // frmTemporizador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(WMP);
            Controls.Add(ChkHabilitar);
            Controls.Add(MktAlarma);
            Controls.Add(lblReloj);
            Name = "frmTemporizador";
            Text = "Reloj";
            Load += frmTemporizador_Load;
            ((System.ComponentModel.ISupportInitialize)WMP).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label lblReloj;
        private MaskedTextBox MktAlarma;
        private CheckBox ChkHabilitar;
        private AxWMPLib.AxWindowsMediaPlayer WMP;
    }
}