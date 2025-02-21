using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimerApp2025C
{
    internal class Abreviaciones // Se hace un diccionario que contenga cada abreviacion y su estado correspondiente
    {
        Dictionary<string, string> estados = new();
        public Abreviaciones()
        { 
            estados.Add("AS", "Aguascalientes");
            estados.Add("BC", "Baja California");
            estados.Add("BS", "Baja California Sur");
            estados.Add("CC", "Campeche");
            estados.Add("CS", "Chiapas");
            estados.Add("CH", "Chihuahua");
            estados.Add("CL", "Coahuila");
            estados.Add("CM", "Colima");
            estados.Add("DF", "Ciudad de México");
            estados.Add("DG", "Durango");
            estados.Add("GT", "Guanajuato");
            estados.Add("GR", "Guerrero");
            estados.Add("HG", "Hidalgo");
            estados.Add("JC", "Jalisco");
            estados.Add("MC", "Estado de México");
            estados.Add("MN", "Michoacán");
            estados.Add("MS", "Morelos");
            estados.Add("NT", "Nayarit");
            estados.Add("NL", "Nuevo León");
            estados.Add("OC", "Oaxaca");
            estados.Add("PL", "Puebla");
            estados.Add("QO", "Querétaro");
            estados.Add("QR", "Quintana Roo");
            estados.Add("SP", "San Luis Potosí");
            estados.Add("SL", "Sinaloa");
            estados.Add("SR", "Sonora");
            estados.Add("TC", "Tabasco");
            estados.Add("TS", "Tamaulipas");
            estados.Add("TL", "Tlaxcala");
            estados.Add("VZ", "Veracruz");
            estados.Add("YN", "Yucatán");
            estados.Add("ZS", "Zacatecas");
        }

        public String getEstado(string clave)
        {
            try
            {
                return estados[clave];
            }
            catch (Exception e)
            {
                return null; 
            }
        }
    }
}
