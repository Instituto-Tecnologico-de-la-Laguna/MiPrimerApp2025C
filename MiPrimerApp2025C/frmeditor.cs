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
    public partial class frmeditor : Form
    {
        bool archivoGuardado = false;
        string filepath;
        public frmeditor()
        {
            InitializeComponent();
        }


 
        private void aBRIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado;
            resultado = openFileDialog1.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                string filepath = openFileDialog1.FileName;
                try
                {
                    string texto = File.ReadAllText(filepath);
                    rtbEditor.Text = texto;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el archivo" + ex.Message);
                }

            }
        }

        private void gUARDARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                DialogResult resultado;
                if (archivoGuardado == false)
                {
                    resultado = saveFileDialog1.ShowDialog();
                    if (resultado == DialogResult.OK)
                    {
                        filepath = saveFileDialog1.FileName;
                        string texto = rtbEditor.Text;
                        try
                        {
                            File.WriteAllText(filepath, texto);
                            MessageBox.Show("Archivo guardado");
                            archivoGuardado = true;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al guardar el archivo" + ex.Message);
                        }

                    }
                }
                else
                {
                    try
                    {
                        string texto = rtbEditor.Text;
                        File.WriteAllText(filepath, texto);
                        MessageBox.Show("Archivo guardado");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al guardar" + ex.Message);
                    }

                }
            }
        }

        private void frmeditor_Load(object sender, EventArgs e)
        {

        }

        private void nUEVOToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (archivoGuardado == false)
            {
                if (MessageBox.Show("Desea crear un nuevo archivo?", "lo siento, no ha sido guardado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)


                {
                    rtbEditor.Text = "";

                }
                else
                {
                    gUARDARCOMOToolStripMenuItem_Click(sender, e);
                    rtbEditor.Text = "";
                }
            }


            else
            {
                rtbEditor.Text = "";
            }
        }




private void gUARDARCOMOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado;
            resultado = saveFileDialog1.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                filepath = saveFileDialog1.FileName;
                string texto = rtbEditor.Text;
                try
                {
                    File.WriteAllText(filepath, texto);
                    MessageBox.Show("Archivo guardado");
                    archivoGuardado = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el archivo" + ex.Message);
                }

            }
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (archivoGuardado == false)
            {
                if (MessageBox.Show("Desea salir sin guardar el archivo?", "lo siento, no ha sido guardado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)


                {

                    this.Close();
                }
                else
                {
                    gUARDARCOMOToolStripMenuItem_Click(sender, e);
                    this.Close();
                }

            }

        }
    }
}
 
