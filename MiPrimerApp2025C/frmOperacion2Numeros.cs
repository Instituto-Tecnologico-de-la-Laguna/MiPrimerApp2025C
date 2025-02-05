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

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Double valor1, valor2;
            try
            {
                valor1 = Convert.ToDouble(txtValor1.Text);
                valor2 = double.Parse(txtValor2.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese valores numericos");
                return;
            }

            if (rbdSuma.Checked == true)
                MessageBox.Show("La suma de los valores es: " + (valor1 + valor2));
            else if (rbdResta.Checked == true)
                MessageBox.Show("La resta de los valores es: " + (valor1 - valor2));
            else if (rbdMultiplicacion.Checked == true)
                MessageBox.Show("La multiplicacion de los valores es: " + (valor1 * valor2));
            else
                MessageBox.Show("La division de los valores es: " + (valor1 / valor2));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtValor1.Clear();
            txtValor2.Clear();

        }
    }
}
