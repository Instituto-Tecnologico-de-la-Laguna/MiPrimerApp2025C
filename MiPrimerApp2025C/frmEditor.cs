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
                string filePatch = saveFileDialogEditor.FileName;
                String texto = rtbEditor.Text;
                try
                {
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
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al abrir el archivo" + ex.Message);
                }
            }
        }
        
    }
}
