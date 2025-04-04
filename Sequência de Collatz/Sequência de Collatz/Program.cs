using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sequência_de_Collatz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Collatz(6);
        }
        static void Collatz(int num)
        {
            while (num != 1)
            {
                if (num % 2 == 0)
                {
                    num = num / 2;

                }
                else
                {
                    num = 3 * num + 1;
                }
                Console.WriteLine(num);
            }
        }
    }
}
