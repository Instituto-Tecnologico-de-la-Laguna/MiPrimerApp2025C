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
    public partial class Formenu : Form
    {
        public Formenu()
        {
            InitializeComponent();
        }

        private void Formenu_Load(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aplicacionSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 apl1 = new Form1();
            apl1.Show();

        }

        private void operacionDe2NumerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 apl2 = new Form2();
            apl2.Show();
        }

        private void termporizadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTemporizados otmp= new frmTemporizados();
            otmp.Show();
        }
    }
}
