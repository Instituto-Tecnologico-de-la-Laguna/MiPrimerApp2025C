namespace MiPrimerApp2025C
{
    partial class FrmTemporizador2
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
            tkbTemporizador = new TrackBar();
            label1 = new Label();
            tmrContador = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)tkbTemporizador).BeginInit();
            SuspendLayout();
            // 
            // tkbTemporizador
            // 
            tkbTemporizador.Location = new Point(55, 225);
            tkbTemporizador.Maximum = 5;
            tkbTemporizador.Name = "tkbTemporizador";
            tkbTemporizador.Size = new Size(452, 56);
            tkbTemporizador.TabIndex = 0;
            tkbTemporizador.Scroll += tkbTemporizador_Scroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(214, 69);
            label1.Name = "label1";
            label1.Size = new Size(91, 106);
            label1.TabIndex = 1;
            label1.Text = "0";
            // 
            // tmrContador
            // 
            tmrContador.Tick += tmrContador_Tick;
            // 
            // FrmTemporizador2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 359);
            Controls.Add(label1);
            Controls.Add(tkbTemporizador);
            Name = "FrmTemporizador2";
            Text = "FrmTemporizador2";
            ((System.ComponentModel.ISupportInitialize)tkbTemporizador).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar tkbTemporizador;
        private Label label1;
        private System.Windows.Forms.Timer tmrContador;
    }
}