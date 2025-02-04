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

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Double valor1, valor2;

            valor1 = Convert.ToDouble(txtValor1.Text);
            valor2 = double.Parse(txtValor2.Text);

            MessageBox.Show("La suma de los valores es: " + (valor1 + valor2));
        }
    }
}
