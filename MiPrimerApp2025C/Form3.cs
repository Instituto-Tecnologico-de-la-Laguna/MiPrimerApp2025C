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
    public partial class frmTemporizados : Form
    {
        public frmTemporizados()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void lblReloj_Click(object sender, EventArgs e)
        {
            lblReloj.Text = DateTime.Now.ToString("hh:mm:ss");
            if (chbhabilitar.Checked == true) {
                if (mkalarma.Text == lblReloj.Text) { 
                axWindowsMediaPlayer1.URL = ("C:\\Users\\rouse\\Downloads\\alarma.mp3\alarma");
                }

            }

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void chbhabilitar_CheckedChanged(object sender, EventArgs e)
        {
            if (chbhabilitar.Checked == true) {

                mkalarma.Enabled = false;
            }
            else
            {
                mkalarma.Enabled=true;
            }
        }
    }
}
