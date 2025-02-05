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
            try
            {
                //val1 = Convert.ToDouble(btnCalcular.Text);
                val1 = double.Parse(textValor1.Text);
                val2 = double.Parse(textValor2.Text);
                //val2 = Convert.ToDouble(btnCalcular.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese valores numericos");
                return;
            }
            if (rdbsuma.Checked == true)
                MessageBox.Show("La suma es : " + (val1 + val2).ToString());
            else if (rdbresta.Checked == true)
                MessageBox.Show("La resta es : " + (val1 - val2).ToString());
            else if (rdbmultiplicacion.Checked == true)
                MessageBox.Show("La multiplicacion es : " + (val1 * val2).ToString());
            else
                MessageBox.Show("La division es : " + (val1 / val2).ToString());
        }

        private void butborrar_Click(object sender, EventArgs e)
        {
            textValor1.Clear();
            textValor2.Clear();
        }
    }
}
