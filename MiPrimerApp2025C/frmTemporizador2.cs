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
    public partial class frmTemporizador2 : Form
    {
        int contador = 0;
        public frmTemporizador2()
        {
            InitializeComponent();
        }

        private void tkbTemporizador_Scroll(object sender, EventArgs e)
        {
            
        }

        private void tmrContador_Tick(object sender, EventArgs e)
        {
            if (tkbTemporizador.Value != 0)
            {
                   
            }
        }
    }
}
