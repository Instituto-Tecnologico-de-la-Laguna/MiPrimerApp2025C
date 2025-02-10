namespace Practica1_23130600
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
            buttIniciar = new Button();
            buttDetener = new Button();
            buttReiniciar = new Button();
            labCronometro = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            SuspendLayout();
            // 
            // buttIniciar
            // 
            buttIniciar.BackColor = SystemColors.GradientInactiveCaption;
            buttIniciar.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttIniciar.Location = new Point(60, 344);
            buttIniciar.Name = "buttIniciar";
            buttIniciar.Size = new Size(132, 46);
            buttIniciar.TabIndex = 0;
            buttIniciar.Text = "Iniciar";
            buttIniciar.UseVisualStyleBackColor = false;
            buttIniciar.Click += buttIniciar_Click;
            // 
            // buttDetener
            // 
            buttDetener.BackColor = SystemColors.GradientInactiveCaption;
            buttDetener.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttDetener.Location = new Point(316, 344);
            buttDetener.Name = "buttDetener";
            buttDetener.Size = new Size(155, 46);
            buttDetener.TabIndex = 1;
            buttDetener.Text = "Detener";
            buttDetener.UseVisualStyleBackColor = false;
            buttDetener.Click += buttDetener_Click;
            // 
            // buttReiniciar
            // 
            buttReiniciar.BackColor = SystemColors.GradientInactiveCaption;
            buttReiniciar.BackgroundImageLayout = ImageLayout.None;
            buttReiniciar.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttReiniciar.Location = new Point(593, 342);
            buttReiniciar.Name = "buttReiniciar";
            buttReiniciar.Size = new Size(150, 48);
            buttReiniciar.TabIndex = 2;
            buttReiniciar.Text = "Reiniciar ";
            buttReiniciar.UseVisualStyleBackColor = false;
            buttReiniciar.Click += buttReiniciar_Click;
            // 
            // labCronometro
            // 
            labCronometro.AutoSize = true;
            labCronometro.Font = new Font("Showcard Gothic", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labCronometro.ForeColor = Color.Black;
            labCronometro.Location = new Point(60, 116);
            labCronometro.Name = "labCronometro";
            labCronometro.Size = new Size(683, 177);
            labCronometro.TabIndex = 3;
            labCronometro.Text = "00:00:00";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Elephant", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(127, 44);
            label1.Name = "label1";
            label1.Size = new Size(544, 72);
            label1.TabIndex = 4;
            label1.Text = "CRONOMETRO";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(labCronometro);
            Controls.Add(buttReiniciar);
            Controls.Add(buttDetener);
            Controls.Add(buttIniciar);
            Name = "Form1";
            Text = "RELOJ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttIniciar;
        private Button buttDetener;
        private Button buttReiniciar;
        private Label labCronometro;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
    }
}
