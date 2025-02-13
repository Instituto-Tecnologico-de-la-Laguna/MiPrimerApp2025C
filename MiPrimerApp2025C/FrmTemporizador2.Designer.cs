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
            TkbTemporizador = new TrackBar();
            LblContador = new Label();
            TmrContador = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)TkbTemporizador).BeginInit();
            SuspendLayout();
            // 
            // TkbTemporizador
            // 
            TkbTemporizador.Location = new Point(12, 96);
            TkbTemporizador.Maximum = 5;
            TkbTemporizador.Name = "TkbTemporizador";
            TkbTemporizador.Size = new Size(329, 45);
            TkbTemporizador.TabIndex = 0;
            TkbTemporizador.Scroll += TkbTemporizador_Scroll;
            // 
            // LblContador
            // 
            LblContador.AutoSize = true;
            LblContador.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblContador.Location = new Point(157, 34);
            LblContador.Name = "LblContador";
            LblContador.Size = new Size(33, 40);
            LblContador.TabIndex = 1;
            LblContador.Text = "0";
            // 
            // TmrContador
            // 
            TmrContador.Enabled = true;
            TmrContador.Tick += TmrContador_Tick;
            // 
            // FrmTemporizador2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(351, 165);
            Controls.Add(LblContador);
            Controls.Add(TkbTemporizador);
            Name = "FrmTemporizador2";
            Text = "Temporizador";
            ((System.ComponentModel.ISupportInitialize)TkbTemporizador).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar TkbTemporizador;
        private Label LblContador;
        private System.Windows.Forms.Timer TmrContador;
    }
}