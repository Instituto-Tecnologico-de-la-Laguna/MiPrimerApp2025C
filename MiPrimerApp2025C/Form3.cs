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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double v1 = double.Parse(VALOR1.Text);
                double v2 = double.Parse(VALOR2.Text);
                double x = 0;

                if (SUMA.Checked == true)
                {
                    x = v1 + v2;
                }
                else if (RESTA.Checked == true)
                {
                    x = v1 - v2;
                }
                else if (MULT.Checked == true)
                {
                    x = v1 * v2;
                }
                else if (DIV.Checked == true)
                {
                    x = v1 / v2;
                }


                MessageBox.Show("El resultado es: " + x);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingrese valores numericos!!!");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VALOR1.Clear();
            VALOR2.Clear();
        }
    }
}
