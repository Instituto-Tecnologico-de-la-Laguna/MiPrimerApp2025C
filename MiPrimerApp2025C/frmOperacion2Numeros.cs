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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Btncalcular_Click(object sender, EventArgs e)
        {
            Double valor1, valor2;
      

            try
            {
                valor1 = Convert.ToDouble(Txtvalor1.Text);
                valor2 = double.Parse(Txtvalor2.Text);

            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese valores numericos");
                return;
            }

            if (rdbsuma.Checked == true)
                MessageBox.Show("La suma de los valores es   " + (valor1 + valor2).ToString());
            else if (rdbresta.Checked == true)
                MessageBox.Show("La resta de los valores es   " + (valor1 - valor2).ToString());

            else if (rdbmultiplicacion.Checked == true)

                MessageBox.Show("La multiplicacion de los valores es   " + (valor1 * valor2).ToString());
            else
                MessageBox.Show("La division de los valores es   " + (valor1 / valor2).ToString());

        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            Txtvalor1.Clear();
            Txtvalor2.Clear();
        }
    }
}
