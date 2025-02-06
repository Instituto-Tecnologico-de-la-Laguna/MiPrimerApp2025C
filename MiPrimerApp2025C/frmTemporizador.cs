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
            axWindowsMediaPlayer1.Visible = false;
        }

        private void tmrReloj_Tick(object sender, EventArgs e)
        {
            lblReloj.Text = DateTime.Now.ToString("hh:mm:ss");
            if (ckBHabilitar.Checked==true && mTBAlarma.Text == DateTime.Now.ToString("hh:mm:ss")) {
                axWindowsMediaPlayer1.URL = @"C:\Users\Juan Chavez\Downloads\rooster-233738.mp3";
            }
        }

        private void frmTemporizador_Load(object sender, EventArgs e)
        {

        }

        private void ckBHabilitar_CheckedChanged(object sender, EventArgs e)
        {
            if (ckBHabilitar.Checked)
            {
                mTBAlarma.Enabled = false;
            }
            else {
                mTBAlarma.Enabled = true;
            }    
        }   
    }
}
