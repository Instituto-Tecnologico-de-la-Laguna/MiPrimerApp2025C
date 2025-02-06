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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AplicacionSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 AppSimple = new Form1();
            AppSimple.Show();
        }

        private void operacionCon2ValoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOperacion2Numeros AppOperaciones = new FrmOperacion2Numeros();
            AppOperaciones.Show();
        }

        private void TemporizadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTemporizador AppOperaciones = new FormTemporizador();
            AppOperaciones.Show();
        }
    }
}
