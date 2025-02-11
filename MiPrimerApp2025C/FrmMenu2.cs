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
    public partial class FrmMenu2 : Form
    {
        public FrmMenu2()
        {
            InitializeComponent();
        }

        private void FrmMenu2_Load(object sender, EventArgs e)
        {

        }

        private void aplicacionesSimplesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 AppSimple = new Form1();
            AppSimple.Show();
        }

        private void operaciones2NumerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOperacion2Numeros AppSimple = new frmOperacion2Numeros();
            AppSimple.Show();
        }

        private void temporizadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTemporizador temporizador = new frmTemporizador();
            temporizador.Show();
        }

        private void editorDeTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm2 editor= new Frm2();
            editor.Show();
        }
    }
}
