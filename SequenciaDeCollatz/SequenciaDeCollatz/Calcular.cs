using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenciaDeCollatz
{
    internal class Calcular
    {
        public static void Sequencia(float num)
        {
            List<float> numeros = new List<float>();
            numeros.Add(num);
            while(num != 1)
            {
                if (num % 2 == 0)
                {
                    num = num / 2;
                    numeros.Add(num);
                }
                else
                {
                    num = (3 * num) + 1;
                    numeros.Add(num);

                }
            }
            string resultado = string.Join(",", numeros);
            Console.WriteLine(resultado);
        }
    }
}
