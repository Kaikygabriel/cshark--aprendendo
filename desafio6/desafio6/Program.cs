using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo();
        }
        static void Triangulo()
        {
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("*");
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("*");
                }
            }
        }
    }

}
