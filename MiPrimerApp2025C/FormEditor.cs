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
    public partial class FormEditor : Form
    {
        string filePath;
        bool archivoGuardado = false;
        public FormEditor()
        {
            InitializeComponent();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado;
            if (archivoGuardado == false)
            {
                resultado = saveFileDialog1.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    filePath = saveFileDialog1.FileName;
                    string texto = rtb.Text;
                    try
                    {
                        File.WriteAllText(filePath, texto);
                        MessageBox.Show("Archivo guardado exitosamente");
                        archivoGuardado = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al guardar" + ex.Message);
                    }
                }
            }
            else
            {
                try
                {
                    string texto = rtb.Text;
                    File.WriteAllText(filePath, texto);
                    MessageBox.Show("Archivo guardado exitosamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar" + ex.Message);
                }
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado;
            resultado = openFileDialog1.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;
                try
                {
                    string texto = File.ReadAllText(filePath);
                    rtb.Text = texto;
                    archivoGuardado = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al abrir" + ex.Message);
                }
            }
        }
    }
}
