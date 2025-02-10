namespace Practica1_Crono
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            buttReiniciar = new Button();
            buttDetener = new Button();
            buttIniciar = new Button();
            labCronometro = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // buttReiniciar
            // 
            buttReiniciar.Location = new Point(49, 299);
            buttReiniciar.Name = "buttReiniciar";
            buttReiniciar.Size = new Size(112, 34);
            buttReiniciar.TabIndex = 0;
            buttReiniciar.Text = "Reiniciar";
            buttReiniciar.UseVisualStyleBackColor = true;
            buttReiniciar.Click += buttReiniciar_Click;
            // 
            // buttDetener
            // 
            buttDetener.Location = new Point(221, 299);
            buttDetener.Name = "buttDetener";
            buttDetener.Size = new Size(112, 34);
            buttDetener.TabIndex = 1;
            buttDetener.Text = "Detener";
            buttDetener.UseVisualStyleBackColor = true;
            buttDetener.Click += button2_Click;
            // 
            // buttIniciar
            // 
            buttIniciar.Location = new Point(381, 306);
            buttIniciar.Name = "buttIniciar";
            buttIniciar.Size = new Size(112, 34);
            buttIniciar.TabIndex = 2;
            buttIniciar.Text = "Iniciar";
            buttIniciar.UseVisualStyleBackColor = true;
            buttIniciar.Click += buttIniciar_Click;
            // 
            // labCronometro
            // 
            labCronometro.AutoSize = true;
            labCronometro.Location = new Point(191, 183);
            labCronometro.Name = "labCronometro";
            labCronometro.Size = new Size(80, 25);
            labCronometro.TabIndex = 3;
            labCronometro.Text = "00:00:00";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labCronometro);
            Controls.Add(buttIniciar);
            Controls.Add(buttDetener);
            Controls.Add(buttReiniciar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttReiniciar;
        private Button buttDetener;
        private Button buttIniciar;
        private Label labCronometro;
        private System.Windows.Forms.Timer timer1;
    }
}
