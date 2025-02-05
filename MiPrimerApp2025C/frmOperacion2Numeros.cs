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
            catch (Exception )
            {
                MessageBox.Show("INGRESE VALORES NUMERICOS");
                return;
            }

            if (rdbSuma.Checked == true)
                MessageBox.Show("La suma de los valores es: " + (valor1 + valor2));
            else if (rdbResta.Checked == true)
                MessageBox.Show("La resta de los valores es: " + (valor1 - valor2));
            else if (rdbMulti.Checked == true)
                MessageBox.Show("La multiplicacion de los valores es: " + (valor1 * valor2));
            else if (rdbDivi.Checked == true)
                MessageBox.Show("La division de los valores es: " + (valor1 / valor2));



        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void butBorrar_Click(object sender, EventArgs e)
        {
            txtValor1.Clear();
            txtValor2.Clear();

        }
    }
}
