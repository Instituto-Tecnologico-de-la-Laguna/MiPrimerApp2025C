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
    public partial class FRNMenu : Form
    {
        public FRNMenu()
        {
            InitializeComponent();
        }

        private void abToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void operacion2ValoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRNOPeracion2numeros op2num = new FRNOPeracion2numeros();
            op2num.Show();
        }

        private void nombreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }

        private void temporizadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TNRReloj reloj = new TNRReloj();
            reloj.Show();
        }

        private void archivoDeTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArchivoToolStrip archivo = new ArchivoToolStrip();
            archivo.Show();
        }
    }
}