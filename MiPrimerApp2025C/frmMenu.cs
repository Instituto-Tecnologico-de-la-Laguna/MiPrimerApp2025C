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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aplicacionSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 AppSimple = new Form1();
            AppSimple.Show();
        }

        private void operaciones2NumerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOperacion2Numeros frmOperacion2Numeros = new frmOperacion2Numeros();
            frmOperacion2Numeros.Show();
        }

        private void temporizadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTemporizador frmReloj = new frmTemporizador();
            frmReloj.Show();
        }
    }
}
