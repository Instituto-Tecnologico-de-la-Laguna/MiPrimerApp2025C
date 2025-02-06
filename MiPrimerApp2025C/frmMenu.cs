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

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aplicacionSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 AppSimple = new Form1();
            AppSimple.Show();
        }

        private void operacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOperacion2Numeros operaciones = new frmOperacion2Numeros();
            operaciones.Show();
        }

        private void operacionesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmOperacion2Numeros operaciones = new frmOperacion2Numeros();
            operaciones.Show();
        }

        private void relojToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTemporizador tem = new frmTemporizador();
            tem.Show();
        }
    }
}
