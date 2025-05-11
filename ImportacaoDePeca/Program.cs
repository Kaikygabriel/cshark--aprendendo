using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ImportacaoDePeca.Entity;

namespace ImportacaoDePeca
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Part mouse = new ImportPart(0.13, "mouse Multilaser Verde", 100);
            System.Console.WriteLine(mouse.GetPart());
            Console.ReadLine();
        }
    }
}