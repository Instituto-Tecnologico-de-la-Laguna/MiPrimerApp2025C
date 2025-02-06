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
    public partial class frmTemporralizador : Form
    {
        public frmTemporralizador()
        {
            InitializeComponent();
        }

        private void tmrReloj_Tick(object sender, EventArgs e)
        {
            lblReloj.Text = DateTime.Now.ToString("hh:mm:ss");
            if (chkHabilitar.Checked)
            {
                if (mktAlarma.Text == lblReloj.Text)
                {
                    axWindowsMediaPlayer1.URL = "C:\\Users\\Alonso\\Downloads\\radio-illuminati-nuclear-alarm-124010.mp3";
                }
            }

        }

        private void chkHabilitar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHabilitar.Checked)
            {
                mktAlarma.Enabled = false;
            }
            else
            {
                mktAlarma.Enabled = true;
            }

        }
    }
}
