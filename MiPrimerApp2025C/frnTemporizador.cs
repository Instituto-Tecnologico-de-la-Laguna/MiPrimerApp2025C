using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimerApp2025C
{
    public partial class frnTemporizador : Form
    {
        public frnTemporizador()
        {
            InitializeComponent();
        }

        private void timerReloj_Tick(object sender, EventArgs e)
        {
            lblReloj.Text = DateTime.Now.ToShortDateString();
            if (chkHabilitar.Checked ==true)
            {
                if (this.mktAlarma.Text == lblReloj.Text)
                {
                    axWindowsMediaPlayer1.URL =
                        @"C:\Users\jared\Downloads\sfx-animal-cock";
                }
            }
        }

        private void chkHabilitar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHabilitar.Checked == true)
            {
                if (!chkHabilitar.Checked) 
                {
                    
                }
            }
            else
            {

            }
        }

        private void frnTemporizador_Load(object sender, EventArgs e)
        {

        }
    }
}
