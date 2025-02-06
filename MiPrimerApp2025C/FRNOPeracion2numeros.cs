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
    public partial class FRNOPeracion2numeros : Form
    {
        public FRNOPeracion2numeros()
        {
            InitializeComponent();
        }

        private void BTNCalcular_Click(object sender, EventArgs e)
        {
            double val1, val2;
            try
            {
                val1 = Convert.ToDouble(TXTValor1.Text);
                val2 = double.Parse(TXTValor2.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingrese valores numericos");
                return;
            }

            if (RDBSuma.Checked == true)
            {
                MessageBox.Show("La suma de los valores es... " + (val1 + val2));
            }
            else if (RDBResta.Checked == true)
            {
                MessageBox.Show("La resta de los valores es... " + (val1 - val2));
            }
            else if (RDBMultiplicacion.Checked == true)
            {
                MessageBox.Show("La multiplicacion de los valores es... " + (val1 * val2));
            }
            else
                MessageBox.Show("La division de los valores es... " + (val1 / val2));


        }

        private void BTNBorrar_Click(object sender, EventArgs e)
        {
            TXTValor1.Clear();
            TXTValor2.Clear();
        }

        private void FRNOPeracion2numeros_Load(object sender, EventArgs e)
        {

        }
    }
}
