using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Collections;

namespace MathInterpreter
{
    public class LexicalAnalysis
    {
        #region rules
        Regex numeros = new Regex(@"\d*.\d+|\d+");
        Regex suma = new Regex("[+-]");
        Regex multiplicaion = new Regex("[*/%]");
        Regex identificador = new Regex("[a-zA-Z_]+");
        Regex igual = new Regex("=");
        #endregion

        public LexicalAnalysis(string cadena)
        {
            this.Cadena = cadena;
        }

        public string Cadena { get; }

        public bool Parce()
        {
            var coliciones = numeros.Matches(this.Cadena);
            for (int i = 0; i < coliciones.Count; i++)
            {
                foreach (Capture captura in coliciones[i].Captures)
                {
                    captura.
                }
            }
            foreach (var colicion in coliciones)
            {
                var test = colicion;
            }
            return true;
        }
    }
}
