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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmOperacion2Numeros_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Double Valor1, Valor2;
            Valor1 = Convert.ToDouble(txtValor1.Text);
            Valor2 = Double.Parse(txtValor2.Text);
            MessageBox.Show("La suma de los valores es: " + (Valor1 + Valor2));
            
        }
    }
}
