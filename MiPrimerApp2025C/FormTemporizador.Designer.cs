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
            timer1 = new System.Windows.Forms.Timer(components);
            RELOJ = new Label();
            ALARMA = new MaskedTextBox();
            HABILITAR = new CheckBox();
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
            // RELOJ
            // 
            RELOJ.AutoSize = true;
            RELOJ.Font = new Font("Arial", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RELOJ.Location = new Point(148, 9);
            RELOJ.Name = "RELOJ";
            RELOJ.Size = new Size(358, 93);
            RELOJ.TabIndex = 0;
            RELOJ.Text = "00:00:00";
            // 
            // ALARMA
            // 
            ALARMA.Location = new Point(254, 123);
            ALARMA.Mask = "00:00:00";
            ALARMA.Name = "ALARMA";
            ALARMA.Size = new Size(125, 27);
            ALARMA.TabIndex = 1;
            ALARMA.ValidatingType = typeof(DateTime);
            // 
            // HABILITAR
            // 
            HABILITAR.AutoSize = true;
            HABILITAR.Location = new Point(385, 126);
            HABILITAR.Name = "HABILITAR";
            HABILITAR.Size = new Size(89, 24);
            HABILITAR.TabIndex = 2;
            HABILITAR.Text = "Habilitar";
            HABILITAR.TextAlign = ContentAlignment.MiddleCenter;
            HABILITAR.UseVisualStyleBackColor = true;
            HABILITAR.CheckedChanged += HABILITAR_CheckedChanged;
            // 
            // WMP
            // 
            WMP.Enabled = true;
            WMP.Location = new Point(256, 180);
            WMP.Name = "WMP";
            WMP.OcxState = (AxHost.State)resources.GetObject("WMP.OcxState");
            WMP.Size = new Size(250, 214);
            WMP.TabIndex = 3;
            // 
            // FormTemporizador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(WMP);
            Controls.Add(HABILITAR);
            Controls.Add(ALARMA);
            Controls.Add(RELOJ);
            Name = "FormTemporizador";
            Text = "Reloj";
            Load += FormTemporizador_Load;
            ((System.ComponentModel.ISupportInitialize)WMP).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label RELOJ;
        private MaskedTextBox ALARMA;
        private CheckBox HABILITAR;
        private AxWMPLib.AxWindowsMediaPlayer WMP;
    }
}