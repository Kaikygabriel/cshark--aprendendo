using System;
using Generics2.Entity;
using Generics2.Service;

namespace Generics2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Produto> list = new List<Produto>();
            list.Add(new Produto(890, "Computer"));
            list.Add(new Produto(910, "Iphone X"));
            list.Add(new Produto(550, "Tablet"));
            list.Add(new Produto(2000, "RX5060"));
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            List<int> list2 = new List<int>();
            Console.WriteLine("");
            ServiceList serviceList = new ServiceList();

            Console.WriteLine(serviceList.CalculationService(list));
        }
    }
}
