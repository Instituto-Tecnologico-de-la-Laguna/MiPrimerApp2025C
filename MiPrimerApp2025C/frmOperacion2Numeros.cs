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
                valor1 = Convert.ToDouble(textValor1.Text);
                valor2 = double.Parse(textValor2.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese valores numericos");
                return;
            }

            if (rdbSuma.Checked == true)
                MessageBox.Show("La suma de los valres es: " + (valor1 + valor2));
            else if (rdbResta.Checked == true)
                MessageBox.Show("La suma de los valores es: " + (valor1 - valor2));
            else if (rdbMultiplicacion.Checked == true)
                MessageBox.Show("La multiplicacion es: " + (valor1 * valor2));
            else
                MessageBox.Show("La division es: " + (valor1 / valor2));

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            textValor1.Clear();
            textValor2.Clear();
            textValor1.Focus();
        }
    }
}
