using System;
using System.Collections.Generic;

namespace ListSortHash
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            //HashSet<string> setString = new HashSet<string>() { "teste" };
            //setString.Add("a");
            //Console.WriteLine(setString.Contains("a"));
            //esses conjuntos não aceitam repetição 
            SortedSet<int>a = new SortedSet<int>() { 1,2,4,5,7,3};
            SortedSet<int> b = new SortedSet<int>() { 7, 3, 6, 8 };
            Print(a);
            //coloca todos os elementos do a que não estejam no c
            // sortedSet sempre vai mostrar os elementos ordenados
            SortedSet<int> c = new SortedSet<int>(a);
            //coloca todos os elementos do b que não estejam no c
            c.UnionWith(b);
            //IEnumerable é uma interface que todas as coleções implementão
            SortedSet<int> d = new SortedSet<int>(a);
            //vai pegar os elementos que existão nos dois conjuntos 
            d.Intersect(b);
            SortedSet<int> e= new SortedSet<int>(a);
            e.ExceptWith(b);//pega os numeros que a tem de diferente do b
            
        }
        static void Print<T>(IEnumerable<T> list)
        {
            //foreach vai funcionar com base nas coleções que implementão INumerable , indica como vai listar(ler)
            foreach(T a in list)
              Console.WriteLine(a);
        }
    }
}
