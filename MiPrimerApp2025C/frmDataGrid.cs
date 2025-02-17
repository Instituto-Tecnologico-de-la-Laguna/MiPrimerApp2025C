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
    public partial class frmDataGrid : Form
    {
        public frmDataGrid()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void buttGuardar_Click(object sender, EventArgs e)
        {
            DialogResult resul =saveFileDialogDataGrid.ShowDialog();
            if (resul == DialogResult.OK)
            {
                string fileName =saveFileDialogDataGrid.FileName;
                int total = dgvDat.Rows.Count-1;

                string linea = " ";
                for (int i = 0; i < total; i++)
                {
                   
                    for (int j = 0; j < dgvDat.Rows.Count; j++)
                    {
                        if(j == dgvDat.Rows.Count-1)
                            linea += dgvDat.Rows[i].Cells[j].Value.ToString() + "\n";
                        else
                            linea += dgvDat.Rows[i].Cells[j].Value.ToString()+",";
                    }
                    
                    File.WriteAllText(fileName, linea);
                    MessageBox.Show("LOS DATOS FUERON GUARDADOS CON EXITO");
                }
            }
        }
    }
}
