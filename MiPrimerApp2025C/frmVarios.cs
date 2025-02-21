using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MiPrimerApp2025C
{
    public partial class frmVarios : Form
    {
        public string estados(string text)
        {
            string[] estados = { "Aguascalientes", "Baja California",
                "Baja California Sur", "Campeche", "Coahuila",
                "Colima", "Chiapas", "Chihuahua", "Ciudad de México",
                "Durango", "Guanajuato", "Guerrero", "Hidalgo", "Jalisco",
                "México", "Michoacán", "Morelos", "Nayarit", "Nuevo León",
                "Oaxaca", "Puebla", "Querétaro", "Quintana Roo", "San Luis Potosí",
                "Sinaloa", "Sonora", "Tabasco", "Tamaulipas", "Tlaxcala", "Veracruz",
                "Yucatán", "Zacatecas" };
            string[] abEstados = { "AG", "BC", "BS", "CC", "CL", "CM", "CS", "CH", "DF",
                "DG", "GT", "GR", "HG", "JC", "MC", "MN", "MS", "NT", "NL", "OC", "PL",
                "QT", "QR", "SP", "SL", "SR", "TC", "TS", "TL", "VZ", "YN", "ZS" };

            int cont = 0;

            for (int i = 0; i < 32; i++)
            {
                if (text == abEstados[i])
                {
                    cont = i;
                }
            }
            string estado = estados[cont];
            return estado;

        }
        public string genero(string text)
        {
            if (text == "M")
            {
                return "MUJER";
            }
            return "HOMBRE";
        }

        public string fechas(string text)
        {
            string dia = text.Substring(4, 2);
            string mes = text.Substring(2, 2);
            string año = text.Substring(0, 2);
            string[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo",
                "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre",
                "Diciembre" };

            if (Convert.ToInt16(año) >= 0 || Convert.ToInt16(año) <= 25)
            {

                string FechaNac = dia + "de " + meses[Convert.ToInt16(mes) - 1] + " del año 20" + año;
                return FechaNac;
            }
            else
            {
                string FechaNac = dia + " de " + meses[Convert.ToInt16(mes) - 1] + "del año 19" + año;
                return FechaNac;
            }

        }
        public frmVarios()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            DateTime nacimiento = dtpFechaNacimiento.Value;
            DateTime calculo = dtpFechaCalculo.Value;

            int edad;
            int meses;
            int dias;

            if (nacimiento.Month > calculo.Month)
            {
                edad = (calculo.Year - nacimiento.Year) - 1;
                meses = 12 - (nacimiento.Month - calculo.Month);

                if (nacimiento.Day > calculo.Day)
                {
                    meses--;
                    dias = DateTime.DaysInMonth(calculo.Year, calculo.Month) - (nacimiento.Day - calculo.Day);

                }

                else
                {
                    dias = calculo.Day - nacimiento.Day;
                }
            }
            else
            {
                edad = (calculo.Year - nacimiento.Year);
                meses = calculo.Month - nacimiento.Month;

                if (nacimiento.Day > calculo.Day)
                {
                    meses--;
                    dias = DateTime.DaysInMonth(calculo.Year, calculo.Month) - (nacimiento.Day - calculo.Day);

                }

                else
                {
                    dias = calculo.Day - nacimiento.Day;
                }
            }

            MessageBox.Show("Años: " + edad + " Meses: " + meses + " Dias: " + dias, "Resultado",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCurp_Click(object sender, EventArgs e)
        {
            string fecha = txtCurp.Text.Substring(4, 6);
            string sexo = txtCurp.Text.Substring(10, 1);
            string estado = txtCurp.Text.Substring(11, 2);

            cbxDatos.Items.Add(fechas(fecha));
            cbxDatos.Items.Add(genero(sexo));
            cbxDatos.Items.Add(estados(estado));
        }

        private void dtpFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            dtpFechaCalculo.Enabled = true;
            dtpFechaCalculo.MinDate = dtpFechaNacimiento.Value;
        }

        private void cbxDatos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
