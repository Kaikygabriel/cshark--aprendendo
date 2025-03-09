using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta
{
    internal class Contas
    {
       public static int Delta(int b, int a, int c)
        {
            int total = (b * b) * (-4 * a * c);

            return total;
        }
       public static void Resu(int delta, int b, int a)
        {
            int deltaPositivo = Math.Abs(delta);
            float deltaraiz = (float)Math.Sqrt(deltaPositivo);
            int Xbaixo = 2 * a;
            float resu2 = (b + deltaraiz) / Xbaixo;
            float resu1 = (b - deltaraiz) / Xbaixo;
            Console.WriteLine($"Primeiro resultado é {resu1} eo segundo resultado é {resu2}");
        }
    }
}
