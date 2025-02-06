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

        private void tmrReloj_Tick(object sender, EventArgs e)
        {
            lblReloj.Text = DateTime.Now.ToString("hh:mm:ss");
            if (chbHabil.Checked == true)
            {
                if (mktAlarma.Text == lblReloj.Text)
                {
                    axWindowsMediaPlayer1.URL = @"C:\Users\bjaco\Downloads\ringtones-militar-trompeta.mp3";
                }
            }
        }

        private void lblReloj_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void chbHabil_CheckedChanged(object sender, EventArgs e)
        {
            if ( chbHabil.Checked==true)
            {
                mktAlarma.Enabled = true;
            }
            else
            {
                mktAlarma.Enabled= true;
            }
        }
    }
}
