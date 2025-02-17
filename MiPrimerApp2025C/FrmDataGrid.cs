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
    public partial class FrmDataGrid : Form
    {
        public FrmDataGrid()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult result = SfdDataGrid.ShowDialog();
            if (result == DialogResult.OK)
            {
                string filename = SfdDataGrid.FileName;
                int total = DgvDatos.Rows.Count - 1;
                string[] lineas = new string[total];

                for (int i = 0; i < total; i++)
                {
                    string linea = "";
                    // No me guarda los archivos, los borra
                    for (int j = 0; j < DgvDatos.Columns.Count; j++)
                    {
                        if (j == DgvDatos.Columns.Count - 1)
                            linea += DgvDatos.Rows[i].Cells[j].Value.ToString() + "";
                        else
                            linea += DgvDatos.Rows[i].Cells[j].Value.ToString() + "";
                    }

                    lineas[i] = linea;
                }
            }
        }
    }
}
