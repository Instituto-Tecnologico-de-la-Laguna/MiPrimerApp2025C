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
    public partial class FrmOperacionDosNumeros : Form
    {
        public FrmOperacionDosNumeros()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Double valor1 = 0, valor2 = 0;
            try
            {
                valor1 = Convert.ToDouble(txtValor1.Text);
                valor2 = Convert.ToDouble(txtValor2.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese valores Numericos");
            }
            if (rdbSuma.Checked == true)
            {
                MessageBox.Show("El resultado de la suma de los dos valores es: " + (valor1 + valor2));
            }
            else if (rdbResta.Checked == true)
            {
                MessageBox.Show("El resultado de la resta de los dos valores es: " + (valor1 - valor2));
            }
            else if (rdbMultiplicacion.Checked == true)
            {
                MessageBox.Show("El resultado de la multiplicacion de los dos valores es: " + (valor1 * valor2));
            }
            else
            {
                MessageBox.Show("El resultado de la division de los dos valores es: " + (valor1 / valor2));
            }
            //else if (rdbDivision.Checked == true)
            //{
            //    MessageBox.Show("El resultado de la suma de los dos valores es: " + (valor1 - valor2));
            //}
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
