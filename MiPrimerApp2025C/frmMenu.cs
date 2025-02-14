using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

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



        private void appSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 AppSimple = new Form1();
            AppSimple.Show();
        }

        private void operacionesCon2ValoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOperacion2Numeros operaciones = new frmOperacion2Numeros();
            operaciones.Show();
        }

        private void temporizadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmrTemporizador temporizador = new fmrTemporizador();
            temporizador.Show();
        }

        private void editorDeTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmrEditorcs editor = new FmrEditorcs();
            editor.Show();

        }

        private void temporizador2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTemporizador2 temporizador2 = new FrmTemporizador2();
            temporizador2.Show();
        }

        private void dataGridViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDataGrid dataGridView = new frmDataGrid();
            dataGridView.Show();    
        }
    }
}
