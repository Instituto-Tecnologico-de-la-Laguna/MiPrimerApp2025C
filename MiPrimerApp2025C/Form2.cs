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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void appSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 nombre = new Form1();
            nombre.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void operacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 operaciones = new Form3();
            operaciones.Show();
        }
    }
}
