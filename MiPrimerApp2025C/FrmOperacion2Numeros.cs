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
    public partial class FrmOperacion2Numeros : Form
    {
        public FrmOperacion2Numeros()
        {
            InitializeComponent();
        }

        private void FrmOperacion2Numeros_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Double valor1, valor2;
            try
            {
                valor1 = Convert.ToDouble(txtValor1.Text);
                valor2 = double.Parse(txtValor2.Text);
            }
            catch(Exception)
            {
                MessageBox.Show("Ingrese valores correctos");
                return;
            }
            
            if (rdbSuma.Checked == true)
                MessageBox.Show("La suma de los valores es: " + (valor1 + valor2));
            else if (rdbResta.Checked == true)
                MessageBox.Show("La resta de los valores es: " + (valor1 - valor2));
            else if (rdbMultiplicacion.Checked == true)
                MessageBox.Show("La multiplicacion de los valores es: " + (valor1 * valor2));
            else
                MessageBox.Show("La division de los valores es: " + (valor1 / valor2));
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtValor1.Clear();
            txtValor2.Clear();
        }
    }
}
