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

       

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialogDataGrid.ShowDialog();
            if (result == DialogResult.OK)
            {
                string filename = saveFileDialogDataGrid.FileName;
                int total= dgvDatos.Rows.Count-1;
                string[] lineas= new string[total];
                for(int i= 0; i < total; i++)
                {
                    string linea = "";
                    for (int j = 0; j < dgvDatos.Columns.Count; j++)
                    {
                        if(j== dgvDatos.Columns.Count - 1)
                            linea += dgvDatos.Rows[i].Cells[j].Value.ToString() + "";
                        else
                            linea += dgvDatos.Rows[i].Cells[j].Value.ToString() + ",";
                    }
                    lineas[i] = linea;
                }


            }
        }
    }
}
