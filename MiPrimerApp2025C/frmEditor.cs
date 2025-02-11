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
    public partial class frmEditor : Form
    {
        public frmEditor()
        {
            InitializeComponent();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado;
            resultado = saveFileDialogEditor.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                string filePath = saveFileDialogEditor.FileName;
                string texto = rtbEditor.Text;
                try
                {
                    File.WriteAllText(filePath, texto);
                    MessageBox.Show("Archivo guardado correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el archivo: " + ex.Message);
                }
            }
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado;
            resultado = openFileDialogEditor.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                string filePath = openFileDialogEditor.FileName;
                try
                {
                    string texto = File.ReadAllText(filePath);
                    rtbEditor.Text = texto;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al abrir el archivo: " + ex.Message);
                }
            }

        }
    }
}
