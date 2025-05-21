using System;
using System.Collections.Generic;
using ListSortHash.Entities;

namespace ListSortHash
{
    internal class Program
    {
        public static void Main()
        { 
            HashSet<Produto> list = new HashSet<Produto>();
            list.Add(new Produto("Mouse",200));
            list.Add(new Produto("Notebook", 2200));
            Produto prod = new Produto("Notebook", 2200);
            Console.WriteLine(list.Contains(prod));

        }
    }
}
