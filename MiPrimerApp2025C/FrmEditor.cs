using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MiPrimerApp2025C
{
    public partial class FrmEditor : Form
    {
        public FrmEditor()
        {
            InitializeComponent();
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void gurardarComoToolStripMenuItem_Click(object sender, EventArgs e) // va en el guardar
        {
            //SfdEditor.ShowDialog();
            DialogResult resultado;
            resultado = SfdEditor.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                string FilePath = SfdEditor.FileName;
                string texto = RtbEditor.Text;

                try
                {
                    File.WriteAllText(FilePath, texto);
                    MessageBox.Show("Archivo guardado correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el archivo " + ex.Message);
                }
            }

        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado;
            resultado = OfdEditor.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                string FilePath = OfdEditor.FileName;

                try
                {
                    string texto = File.ReadAllText(FilePath);
                    RtbEditor.Text = texto;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al abrir el archivo: " + ex.Message);
                }
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
