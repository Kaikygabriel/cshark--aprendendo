using Locacao.Entity;
using System;

namespace Locacao
{
    public class Program
    {
        static void Main()
        {
            System.Console.WriteLine("Enter Car Model ");
            string nome = Console.ReadLine();
            System.Console.WriteLine("Entrada (dd/MM/yyyy) ");
            DateTime entrada = DateTime.Parse(Console.ReadLine());
            System.Console.WriteLine("Saida (dd/MM/yyyy) ");
            DateTime saida = DateTime.Parse(Console.ReadLine());
            System.Console.WriteLine("Preço por hora ");
            double priceHours = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Preço por Dia ");
            double priceDays = double.Parse(Console.ReadLine());
            Alugar alugar = new Alugar(nome, entrada, saida, priceHours, priceDays);
            System.Console.WriteLine(alugar);
        } 
    }
}
    