namespace MiPrimerApp2025C
{
    partial class frmTemporizador2
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
            lblContador = new Label();
            tkbTemporizador = new TrackBar();
            tmrContador = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)tkbTemporizador).BeginInit();
            SuspendLayout();
            // 
            // lblContador
            // 
            lblContador.AutoSize = true;
            lblContador.Font = new Font("Arial Narrow", 28F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContador.Location = new Point(193, 55);
            lblContador.Name = "lblContador";
            lblContador.Size = new Size(54, 66);
            lblContador.TabIndex = 0;
            lblContador.Text = "0";
            // 
            // tkbTemporizador
            // 
            tkbTemporizador.Location = new Point(25, 160);
            tkbTemporizador.Maximum = 5;
            tkbTemporizador.Name = "tkbTemporizador";
            tkbTemporizador.Size = new Size(393, 69);
            tkbTemporizador.TabIndex = 1;
            tkbTemporizador.Scroll += tkbTemporizador_Scroll;
            // 
            // tmrContador
            // 
            tmrContador.Enabled = true;
            tmrContador.Tick += tmrContador_Tick;
            // 
            // frmTemporizador2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 251);
            Controls.Add(tkbTemporizador);
            Controls.Add(lblContador);
            Name = "frmTemporizador2";
            Text = "Temporizador";
            ((System.ComponentModel.ISupportInitialize)tkbTemporizador).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblContador;
        private TrackBar tkbTemporizador;
        private System.Windows.Forms.Timer tmrContador;
    }
}