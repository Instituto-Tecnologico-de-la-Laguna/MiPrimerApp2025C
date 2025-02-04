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
    public partial class frmOperaciones2Numeros : Form
    {
        public frmOperaciones2Numeros()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Double val1, val2;
            //val1 = Convert.ToDouble(btnCalcular.Text);
            val1 = double.Parse(textValor1.Text);
            val2 = double.Parse(textValor2.Text);
            //val2 = Convert.ToDouble(btnCalcular.Text);
            MessageBox.Show("La suma es : " + (val1 + val2).ToString());
        }
    }
}
