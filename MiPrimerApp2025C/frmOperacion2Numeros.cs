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
            v1 = Convert.ToDouble(txtValor1.Text);
            v2 = double.Parse(txtBox2.Text);

            MessageBox.Show("Resultado: " + (v1 + v2));
        }
    }
}
