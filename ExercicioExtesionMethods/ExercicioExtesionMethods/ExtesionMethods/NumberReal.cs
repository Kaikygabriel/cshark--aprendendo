using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioExtesionMethods.ExtesionMethods
{
    internal static class NumberReal
    {
        public static string ToReal(this double valor)
        {
            return "R$"+valor.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
