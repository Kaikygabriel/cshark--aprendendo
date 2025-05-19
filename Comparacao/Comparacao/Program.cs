using System;
using Comparacao.Entity;

namespace Comparacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client c = new Client() { Email = "Kaiky@gmail", Nome = "Kaiky" };
            Client d = new Client() { Email = "Kaiky@gmail", Nome = "Gabriel" };
            Console.WriteLine(c.Equals(d));
            Console.WriteLine(c.GetHashCode());
            Console.WriteLine(d.GetHashCode());
            Console.WriteLine(d.GetHashCode().Equals(c.GetHashCode()));
        }
    }
}
