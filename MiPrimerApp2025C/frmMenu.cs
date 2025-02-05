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

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            


        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void aplicaciónSimpleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 AppSimple = new Form1();
            AppSimple.Show();
        }

        private void operacionesDe2ValoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOperacion2Numeros operaciones = new frmOperacion2Numeros();
            operaciones.Show();
        }
    }
}
