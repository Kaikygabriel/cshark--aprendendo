
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvertendoStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva algo para inverter");
            string algo = Console.ReadLine();
            Inverter(algo);
        }
        static void Inverter(string nome)
        {
            List<char> list = new List<char>();
            int total = nome.Length;
            for (int i = 1; i < nome.Length + 1; i++)
            {
              int iv = Math.Abs(i - total);
              list.Add(nome[iv]);
            }
            foreach (char c in list)
            {
                Console.Write(c);
            }
            Console.ReadLine();
        }

    }
}
 