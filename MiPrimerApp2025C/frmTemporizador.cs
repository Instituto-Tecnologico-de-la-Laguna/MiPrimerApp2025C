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

        private void tmrREloj_Tick(object sender, EventArgs e)
        {
            lblTemporizador.Text = DateTime.Now.ToString("HH:mm:ss");
            if(chkHabilitar.Checked == true )
            {
                if (mktAlarma.Text == lblTemporizador.Text)
                {
                    axWindowsMediaPlayer1.URL = @"C:\Users\danar\Downloads\rooster-crowing-in-turkey-142039.mp3";
                }
            }

        }

        private void chkHabilitar_CheckedChanged(object sender, EventArgs e)
        {
            if(chkHabilitar.Checked == true)
            {
                mktAlarma.Enabled = false;
            }
            else
            {
                mktAlarma.Enabled= true;
            }
        }
    }
}
