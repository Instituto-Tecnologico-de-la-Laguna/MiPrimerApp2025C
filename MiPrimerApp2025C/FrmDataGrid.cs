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
            // Si no esta marcada la casilla de mayor de edad no guarda el archivo.
            DialogResult result = SfdDataGrid.ShowDialog();
            if (result == DialogResult.OK)
            {
                string filename = SfdDataGrid.FileName;
                int total = DgvDatos.Rows.Count - 1;
                string linea = "";
                for (int i = 0; i < total; i++)
                {

                    for (int j = 0; j < DgvDatos.Columns.Count; j++)
                    {
                        if (j == DgvDatos.Columns.Count - 1)
                            linea += DgvDatos.Rows[i].Cells[j].Value.ToString() + "\n";
                        else
                            linea += DgvDatos.Rows[i].Cells[j].Value.ToString() + ",";
                    }

                }

                try
                {
                    File.WriteAllText(filename, linea);
                    MessageBox.Show("Archivo guardado correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el archivo: " + ex.Message);
                }
            }
        }

        private void DgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
