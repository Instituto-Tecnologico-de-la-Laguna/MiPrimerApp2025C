namespace Practica1_Crono
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int s = 0;
        int m = 0;
        int h = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void buttReiniciar_Click(object sender, EventArgs e)
        {
            s = 0;
            m = 0;
            h = 0;
            timer1.Enabled = false;
            labCronometro.Text = "00:00:00";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            s++;
            if (s == 60)
            {
                s = 0;
                m++;

                if (m == 60)
                {
                    m = 0;
                    h++;
                }
            }
            DateTime hora = new DateTime(2025, 1, 1, h, m, s);

            labCronometro.Text = hora.ToString("HH:mm:ss");
        }

        private void buttIniciar_Click(object sender, EventArgs e)
        {
            timer1.Enabled=true;
        }
    }
}
