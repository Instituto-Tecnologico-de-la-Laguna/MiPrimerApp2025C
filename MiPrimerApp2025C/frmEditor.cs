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
        bool archivoGuardado = false;
        string filePath = null;
        public frmEditor()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado;
            if (archivoGuardado)
            {
                resultado = saveFileDialogEditor.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    filePath = saveFileDialogEditor.FileName;
                    string texto = richTextBox1.Text;
                    try
                    {
                        File.WriteAllText(filePath, texto);
                        MessageBox.Show("Archivo guardado correctamente");
                        archivoGuardado = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al guardar el archivo: " + ex.Message);
                    }

                }
            }
            else
            {
                try
                {
                    string texto = richTextBox1.Text;
                    File.WriteAllText(filePath, texto);
                    MessageBox.Show("Archivo guardado correctamente");
                    archivoGuardado = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el archivo: " + ex.Message);

                }
            }
        }

        private void openFileDialogEditor_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado;
            resultado = openFileDialogEditor.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                filePath = saveFileDialogEditor.FileName;
                try
                {
                    string texto = File.ReadAllText(filePath);
                    richTextBox1.Text = texto;
                    archivoGuardado = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al abrir el archivo: " + ex.Message);
                }
            }
        }
    }
}
