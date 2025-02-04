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

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aplicacionSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trabajo1 appsimple = new trabajo1();
            appsimple.Show();
        }

        private void aplicacion2ValoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOperacion2numeros operaciones = new frmOperacion2numeros();
            operaciones.Show();
        }
    }
}
