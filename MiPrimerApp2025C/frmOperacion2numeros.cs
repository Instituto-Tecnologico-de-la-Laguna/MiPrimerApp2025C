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
    public partial class frmOperacion2numeros : Form
    {
        public frmOperacion2numeros()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            Double valor1, valor2;

            try
            {
               

                valor1 = Convert.ToDouble(txtValor1.Text);
                valor2 = Double.Parse(txtValor2.Text);
                //double resultado = valor1 + valor2;

                if (rdbsuma.Checked)
                {
                    //MessageBox.Show("La suma de los valores es: " + (valor1 + valor2) );
                }
                else if (rdbresta.Checked)
                {
                    MessageBox.Show("La resta de los valores es: " + (valor1 - valor2));
                }
                else if (rdbmult.Checked)
                {
                    MessageBox.Show("La multiplicacion de los valores es: " + (valor1 * valor2));
                }
                else if (rdbdiv.Checked)
                {
                    MessageBox.Show("La divicion de los valores es: " + (valor1 / valor2));
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ingrese un valor valido" + ex.Message);
            }
           

            



            // MessageBox.Show("La suma de los valores es de: " + resultado);
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            txtValor1.Clear();
            txtValor2.Clear();
        }
    }
}
