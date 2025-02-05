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

        private void frmOperacion2Numeros_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Double v1, v2;

            try
            {
                v1 = Convert.ToDouble(txtValor1.Text);
                v2 = double.Parse(txtBox2.Text);
            }
            catch (Exception) {
                MessageBox.Show("Ingrese valores numericos");
                return;
            }


            if (rdBSum.Checked == true)
            {
                MessageBox.Show("Resultado: " + (v1 + v2));
            }
            else if (rdBRes.Checked == true)
            {
                MessageBox.Show("Resultado: " + (v1 - v2));
            }
            else if (rdBMul.Checked == true)
            {
                MessageBox.Show("Resultado: " + (v1 * v2));
            }
            else if (rdBDiv.Checked == true)
            {
                MessageBox.Show("Resultado: " + (v1 / v2));
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtValor1.Clear();
            txtBox2.Clear();
        }
    }
}
