using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Double valor1, valor2;
        try { 
            valor1 = Convert.ToDouble(txtValor1.Text);
            valor2 = double.Parse(txtValor2.Text);
        }
        catch(Exception)
        {
            MessageBox.Show("Ingrese valores numericos");
            return;
        }
            if (rdbSuma.Checked == true)
            {
                MessageBox.Show("La suma de los valores es: " + (valor1 + valor2));
            }
            else if (rdbResta.Checked == true)
            {
                MessageBox.Show("La resta de los valores es: " + (valor1 - valor2));
            }
            else if (rdbMultiplicacion.Checked == true)
            {
                MessageBox.Show("La multiplicacion de los valores es: " + (valor1 * valor2));
            }
            else if (rdbDivision.Checked == true)
            {
                MessageBox.Show("La division de los valores es: " + (valor1 / valor2));
            }



        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            txtValor1.Clear();
            txtValor2.Clear();
        }
    }
}
