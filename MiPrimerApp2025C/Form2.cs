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
    public partial class Frm2 : Form
    {
        String filepath;
        bool archivoGuardado = false;
        public Frm2()



        {
            InitializeComponent();
        }

        private void Nu_Load(object sender, EventArgs e)
        {

        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
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
                        MessageBox.Show("Archivo Guardado exsitosamente");
                        archivoGuardado = true;



                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error en el archivo" + ex.Message);

                    }



                }
            }
            else {
                try
                 {
                    String texto = rtbEditor.Text;
                    File.WriteAllText(filepath, texto);
                    MessageBox.Show("Archivo guardado correctamente");
                    


                }
                catch (Exception ex) 
                { 
                MessageBox.Show("Error al guardar el archivo"+ex.Message);
               
                }
            
            
            }

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado;
            resultado = openFileDialogEditor.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                filepath = openFileDialogEditor.FileName;
                try
                {


                    String texto = File.ReadAllText(filepath);
                    rtbEditor.Text = texto;
                    archivoGuardado = true;

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error al abrir el archivio" + ex.Message);
                }
            }
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
