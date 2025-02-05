using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimerApp2025C
{
    public partial class FrmOperacion2Numeros : Form
    {
        public FrmOperacion2Numeros()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Se definen las variables
            Double valor1, valor2;

            // Se valida que se introdujeron números
            try 
            {
                valor1 = Convert.ToDouble(txtValor1.Text);
                valor2 = double.Parse(txtValor2.Text);
            } catch (Exception) 
            {
                MessageBox.Show("Ingrese valores númericos");
                return;
            }

            // Se ejecuta la operacion elejida por el usuario
            if (rdbSuma.Checked)
                MessageBox.Show("La suma de los valores es: " + (valor1 + valor2));
            else if (rdbResta.Checked)
                MessageBox.Show("La resta de los valores es: " + (valor1 - valor2));
            else if (rdbMultiplicación.Checked)
                MessageBox.Show("La multiplicación de los valores es: " + (valor1 * valor2));
            else
                MessageBox.Show("La división de " + valor1 + " entre " + valor2 + "es: " + (valor1 / valor2));
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtValor1.Clear();
            txtValor2.Clear();

            txtValor1.Focus();
        }
    }
}
