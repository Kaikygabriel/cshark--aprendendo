using System;
using System.Collections.Generic;
using ExericioIComparable.Entity;

namespace ExericioIComparable
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Produto> produtos = new List<Produto>();
            produtos.Add(new Produto("mouse", 100));
            produtos.Add(new Produto("teclado", 70));
            produtos.Add(new Produto("monitor", 500));
            produtos.Add(new Produto("placa- gtx1630", 1100));
            produtos.Add(new Produto("Gabinete gamer", 150));
            produtos.Sort();
            foreach (var p in produtos)
            {
                Console.WriteLine(p);
            }
        }
    }
}
