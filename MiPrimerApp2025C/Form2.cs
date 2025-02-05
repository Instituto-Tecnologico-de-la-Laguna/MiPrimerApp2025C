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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valor1, valor2;
            try
            {
                valor1 = double.Parse(txt1.Text);
                valor2 = double.Parse(txt2.Text);
            }
            catch (Exception )
            {
                MessageBox.Show("escribe valores numericos");
                return;
            }
            // MessageBox.Show("la suma de los valores es" + (valor1 + valor2));

            if (rdbmultiplicacion.Checked == true)
            {
                MessageBox.Show("la suma de los valores es" + (valor1 * valor2));
            }
            else if (rdbdiv.Checked == true)
            {
                MessageBox.Show("la suma de los valores es" + (valor1 / valor2));
            }
            else if (suma.Checked == true)
            {
                MessageBox.Show("la suma de los valores es" + (valor1 + valor2));
            }
            else if (resta.Checked == true)
            {
                MessageBox.Show("la suma de los valores es" + (valor1 - valor2));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt1.Clear();
            txt2.Clear();
        }
    }
}
