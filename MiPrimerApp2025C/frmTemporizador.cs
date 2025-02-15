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
    public partial class frmTemporizador : Form
    {
        public frmTemporizador()
        {
            InitializeComponent();
        }

        private void frmTemporizador_Load(object sender, EventArgs e)
        {

        }

        private void chkHabilitar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHabilitar.Checked == true)
            {
                mktAlarma.Enabled = false;

            }
            else
            {
                mktAlarma.Enabled = true;
            }
        }

        private void tmrReloj_Tick(object sender, EventArgs e)
        {
            lblReloj.Text = DateTime.Now.ToString("hh:mm:ss");
            if (chkHabilitar.Checked == true)
            {
                if (mktAlarma.Text == lblReloj.Text)
                {
                    axWindowsMediaPlayer1.URL =
                        @"C:\Users\sams\Downloads\club-alarma-145490.mp3";
                }
            }
        }
    }
}
