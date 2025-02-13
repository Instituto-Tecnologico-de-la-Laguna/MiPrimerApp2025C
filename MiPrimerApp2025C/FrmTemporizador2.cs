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
    public partial class FrmTemporizador2 : Form
    {
        int contador = 0;
        public FrmTemporizador2()
        {
            InitializeComponent();
        }

        private void TkbTemporizador_Scroll(object sender, EventArgs e)
        {
        }

        private void TmrContador_Tick(object sender, EventArgs e)
        {
            if (TkbTemporizador.Value != 0)
            {
                //TmrContador.Enabled = true;
                TmrContador.Interval = TkbTemporizador.Value * 400;
                LblContador.Text = contador++.ToString();
            }
        }
    }
}
