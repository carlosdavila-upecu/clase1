using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosRomanos
{
    public class Convertidor
    {
        public static string ConvertirArabicoARomano(int numeroArabico)
        {
            var resultado = new StringBuilder();
            var restante = numeroArabico;
            if (restante >= 9)
            {
                resultado.Append("IX");
                restante -= 9;
            }
            if (restante >= 5)
            {
                resultado.Append("V");
                restante -= 5;
            }
            if (restante >= 4)
            {
                resultado.Append("IV");
                restante -= 4;
            }
            for (int i = 0; i < restante; i++)
            {
                resultado.Append("I");
            }

            return resultado.ToString();
        }
    }
}
