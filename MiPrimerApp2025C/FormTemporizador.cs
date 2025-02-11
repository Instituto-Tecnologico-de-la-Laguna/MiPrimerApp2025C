using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxWMPLib;

namespace MiPrimerApp2025C
{
    public partial class FormTemporizador : Form
    {
        public FormTemporizador()
        {
            InitializeComponent();
        }

        private void FormTemporizador_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
                        //@"C:\Users\Jose Luis\Downloads\ringtones-militar-trompeta.mp3";
            RELOJ.Text = DateTime.Now.ToString("hh:mm:ss");
            if (HABILITAR.Checked==true)
            {
                if(ALARMA.Text == RELOJ.Text)
                {
                    WMP.URL = @"C:\Users\MIGUELONCHES\source\repos\MiPrimerApp2025C(Profe)\alarma.mp3";
                }
            }
        }

        private void HABILITAR_CheckedChanged(object sender, EventArgs e)
        {
            if (HABILITAR.Checked==true)
            {
                ALARMA.Enabled = false;
            }
            else
            {
                ALARMA.Enabled = true;
            }
        }
    }
}
