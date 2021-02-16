using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Operatii
    {
        public double Valoare01 { get; set; }
        public double Valoare02 { get; set; }
        public string Operatori { get; set; }
        public bool EsteOperatii { get; set; }
        public bool EsteZecimal { get; set; }
        public static double Adunare(Double Valoare01, double Valoare02)
    {
        return Valoare01 + Valoare02;
    
    }
        public static double Scadere(Double Valoare01, double Valoare02)
        {
            return  Valoare01 - Valoare02;
          
        }
        public static double Inmultire(Double Valoare01, double Valoare02)
        {
            return Valoare01 * Valoare02;

        }
        public static double Impartire(Double Valoare01, double Valoare02)
        {
            return Valoare01 / Valoare02;

        }
    }
}
