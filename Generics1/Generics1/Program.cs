using System;
using Generics1.Service;

namespace Generics1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintService<int> p = new PrintService<int>();
            Console.WriteLine("Quantos numeros");
            int quantidade = int.Parse(Console.ReadLine());
            for (int i = 1; i <= quantidade; i++)
            {
                int Valor = int.Parse(Console.ReadLine());
                p.AddValue(Valor);
            }
            Console.WriteLine("First :  " + p.First());
            p.Print();
        }
    }
}
