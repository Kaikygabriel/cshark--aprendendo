using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnoBissexto
{
    internal class Program
    {
        static void Main()
        {
            AnoBissexto(2000);
        }
        static void AnoBissexto(int ano)
        {
            if(ano % 4 == 0  && testar(ano))
            {
                Console.WriteLine($"O ano {ano} é bissexto");
            }
           else if (ano % 4 == 0 && testar2(ano)&& ano % 400 == 0)
            {
                Console.WriteLine($"O ano {ano} é bissexto");

            }
            else if(ano % 4 == 0 && testar2(ano) && ano % 400 == 0)
            {
                Console.WriteLine($"O ano {ano} é bissexto");

            }
            else
            {
                Console.WriteLine($"O ano {ano} Não é bissexto");

            }
        }
        static bool testar(int ano)
        {
            if(ano % 100 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        static bool testar2(int ano)
        {
            if (ano % 100 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
