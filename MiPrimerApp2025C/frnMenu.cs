using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32.SafeHandles;

namespace MiPrimerApp2025C
{
    public partial class frnMenu : Form
    {
        public frnMenu()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void arrchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aplicacionSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 AppSimple = new Form1();
            AppSimple.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void operacionesConDosValoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOperacion2Numeros operaciones = new frmOperacion2Numeros();
            operaciones.Show();
        }

        private void temporizadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTemporizador temporizador = new FormTemporizador();
            temporizador.Show();
        }
    }
}
