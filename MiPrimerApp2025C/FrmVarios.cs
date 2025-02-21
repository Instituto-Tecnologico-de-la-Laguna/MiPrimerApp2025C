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
    public partial class FrmVarios : Form
    {
        public FrmVarios()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            DateTime nacimiento = DtpFechaNacimiento.Value;
            DateTime calculo = DtpFechaCalculo.Value;


            int[] edad = new int[3];
            
            int añoNacimiento = nacimiento.Year;
            int mesNacimiento = nacimiento.Month;
            int diaNacimiento = nacimiento.Day;

            edad[0] = calculo.Year - añoNacimiento - 1;
            edad[1] = (calculo.Month + 12) - mesNacimiento;
            edad[2] = calculo.Day - diaNacimiento;

            // Por si la fecha actual aun no pasa la fecha de nacimiento
            if (calculo.Month > mesNacimiento)
            {
                edad[0] = calculo.Year - añoNacimiento;
                edad[1] = calculo.Month - mesNacimiento;
            }

            MessageBox.Show("Años: " + edad[0] + "\nMeses: " + edad[1] + "\nDías:" + edad[2], "Resultado:",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DtpFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            DtpFechaCalculo.Enabled = true;
            BtnCalcular.Enabled = true;
            DtpFechaCalculo.MinDate = DtpFechaNacimiento.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Abreviaciones a = new Abreviaciones();
            DateTime calculo = DtpFechaCalculo.Value;

            // El método especifica la edad con años meses y días, en este caso solo los años son requeridos
            int edad = EdadCompleta(TxtBoxCurp.Text.Substring(4, 6), calculo)[0];

            // Del diccionario se extrae el estado correspondiente a la clave dada en la CURP
            string estado = a.getEstado(TxtBoxCurp.Text.Substring(11, 2));
            if (estado == null)
            {
                MessageBox.Show("Clave inválida");
                return;
            }
            string sexo = TxtBoxCurp.Text.Substring(10, 1);
            
            if (sexo.Equals("H"))
                sexo = "Hombre";
            else if (sexo.Equals("M"))
                sexo = "Mujer";

            MessageBox.Show("Edad: " + edad + " años\n" + "Estado de nacimiento: " + estado + "\nSexo: " + sexo, "Información!",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private int[] EdadCompleta(string fechaNacimiento, DateTime fechaActual)
        {
            int[] edad = new int[3];
            // Se obtienen los datos del substring del curp correspondiente a la fecha de nacimiento
            int añoNacimiento = Int16.Parse(fechaNacimiento.Substring(0, 2));

            // Se asume un rango de 100 años, si la fecha indica un año mayor al actual, se asume que es del siglo anterior
            if (añoNacimiento > (fechaActual.Year - 2000))
                añoNacimiento = añoNacimiento + 1900;
            else
                añoNacimiento = añoNacimiento + 2000;

            int mesNacimiento = Int16.Parse(fechaNacimiento.Substring(2, 2));
            int diaNacimiento = Int16.Parse(fechaNacimiento.Substring(4, 2));

            edad[0] = fechaActual.Year - añoNacimiento - 1;
            edad[1] = (fechaActual.Month + 12) - mesNacimiento;
            edad[2] = fechaActual.Day - diaNacimiento;

            // Por si la fecha actual aun no pasa la fecha de nacimiento
            if (fechaActual.Month > mesNacimiento)
            {
                edad[0] = fechaActual.Year - añoNacimiento;
                edad[1] = fechaActual.Month - mesNacimiento;
            }

            return edad;
        }
    }
}
