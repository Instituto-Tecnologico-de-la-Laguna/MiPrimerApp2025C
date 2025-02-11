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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void appSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAppSimple nombre = new FormAppSimple();
            nombre.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void operacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOperaciones operaciones = new FormOperaciones();
            operaciones.Show();
        }

        private void relojToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTemporizador reloj = new FormTemporizador();
            reloj.Show();
        }

        private void editorDeTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditor Editor = new FormEditor();
            Editor.Show();

        }
    }
}
