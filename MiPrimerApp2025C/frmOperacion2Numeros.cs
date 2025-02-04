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
    public partial class frmOperacion2Numeros : Form
    {
        public frmOperacion2Numeros()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Btncalcular_Click(object sender, EventArgs e)
        {
            Double valor1, valor2;
            valor1 = Convert.ToDouble(Txtvalor1.Text);
            valor2 = double.Parse(Txtvalor2.Text);
            MessageBox.Show("La suma de los valores es   " + (valor1 + valor2).ToString());
        }
    }
}
