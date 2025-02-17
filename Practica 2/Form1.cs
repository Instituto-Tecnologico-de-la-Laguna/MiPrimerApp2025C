using System;
using System.IO;
using System.Windows.Forms;

namespace EditorDeTexto
{
    public partial class Form1 : Form
    {
        private string archivoActual = string.Empty; 

        public Form1()
        {
            InitializeComponent();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!ConfirmarCambios())
            {
                return;
            }
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*",
                Title = "Abrir archivo"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    archivoActual = openFileDialog.FileName;
                    textBox1.Text = File.ReadAllText(archivoActual);
                    this.Text = $"Editor de Texto - {Path.GetFileName(archivoActual)}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al abrir el archivo: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ConfirmarCambios()
        {
            throw new NotImplementedException();
        }

        // Evento para Guardar archivo
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(archivoActual))
            {
                guardarComoToolStripMenuItem_Click(sender, e);
            }
            else
            {
                try
                {
                    File.WriteAllText(archivoActual, textBox1.Text);
                    MessageBox.Show("Archivo guardado con éxito.", "Guardar",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar el archivo: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*",
                Title = "Guardar como..."
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    archivoActual = saveFileDialog.FileName;
                    File.WriteAllText(archivoActual, textBox1.Text);
                    this.Text = $"Editor de Texto - {Path.GetFileName(archivoActual)}";
                    MessageBox.Show("Archivo guardado con éxito.", "Guardar como",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar el archivo: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ConfirmarCambios())
            {
                textBox1.Clear();
                archivoActual = string.Empty;
                this.Text = "Editor de Texto";
            }
        }
    }
}

