using Locacao.Entity;
using System;

namespace Locacao
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter Car Model ");
            string nome = Console.ReadLine();
            Console.WriteLine("Entrada (dd/MM/yyyy) ");
            DateTime entrada = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Saida (dd/MM/yyyy) ");
            DateTime saida = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Preço por hora ");
            double priceHours = double.Parse(Console.ReadLine());
            Console.WriteLine("Preço por Dia ");
            double priceDays = double.Parse(Console.ReadLine());
            Alugar alugar = new Alugar(nome, entrada, saida, priceHours, priceDays);
            Console.WriteLine(alugar);
        } 
    }
}
    