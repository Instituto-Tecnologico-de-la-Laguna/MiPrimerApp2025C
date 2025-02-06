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
    public partial class FormTemporizador : Form
    {
        public FormTemporizador()
        {
            InitializeComponent();
        }

        private void tmrReloj_Tick(object sender, EventArgs e)
        {
            lblReloj.Text = DateTime.Now.ToString("hh:mm:ss");
            if(checarHabilitar.Checked == true)
            {
                if (mktAlarma.Text == lblReloj.Text)
                {
                    axWindowsMediaPlayer1.URL = @"C:\Users\joler\Downloads\gallo-cantando-292945.mp3";
                }
            }
        }

        private void checarHabilitar_CheckedChanged(object sender, EventArgs e)
        {
            if (checarHabilitar.Checked == true) {
                mktAlarma.Enabled = false;
            }
            else
            {
                mktAlarma.Enabled = true;
            }

        }
    }
}
