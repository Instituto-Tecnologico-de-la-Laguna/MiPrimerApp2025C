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
    public partial class frmEditor : Form
    {
        //Se agrego
        bool archivoGuardado = false;
        string filePath = null;

        public frmEditor()
        {
            InitializeComponent();
        }

        private void frmEditor_Load(object sender, EventArgs e)
        {

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void abrirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult resultado;
            resultado = openFileDialogEditor.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                filePath = openFileDialogEditor.FileName;
                try
                {
                    string texto = File.ReadAllText(filePath);
                    rtbEditor.Text = texto;
                    archivoGuardado = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al abrir el archivo: " + ex.Message);
                }
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado;
            if (archivoGuardado == false)
            {
                resultado = saveFileDialogEditor.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    filePath = saveFileDialogEditor.FileName;
                    string texto = rtbEditor.Text;
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
                    string texto = rtbEditor.Text;
                    File.WriteAllText(filePath, texto);
                    MessageBox.Show("Archivo guardado correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el archivo: " + ex.Message);
                }
            }
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
