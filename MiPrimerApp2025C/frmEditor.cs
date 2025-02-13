using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //libreira agg
namespace MiPrimerApp2025C
   
{
    public partial class frmEditor : Form
    {
       // DialogResult res =MessageBox.Show("deseas salir?","sistemas",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);

        bool archivoGuardado = false;
        string filePatch = null;
        public frmEditor()
        {
            InitializeComponent();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado;
            if (archivoGuardado==false)
            {

                resultado = saveFileDialogEditor.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    filePatch = saveFileDialogEditor.FileName;
                    String texto = rtbEditor.Text;
                    try
                    {
                        File.WriteAllText(filePatch, texto);
                        MessageBox.Show("El archivo se guardo correctamente");
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
                    File.WriteAllText(filePatch, texto);
                    MessageBox.Show("El archivo se guardo correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el archivo" + ex.Message);
                }
            }
        }

        private void guardarToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado;

            resultado = openFileDialogEditor.ShowDialog();
            
            if (resultado == DialogResult.OK)
            {
                string filePatch = openFileDialogEditor.FileName;
                try
                {
                    string texto =File.ReadAllText(filePatch);
                    rtbEditor.Text = texto;
                    archivoGuardado = true;
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al abrir el archivo" + ex.Message);
                }
            }
        }
        
    }
}
