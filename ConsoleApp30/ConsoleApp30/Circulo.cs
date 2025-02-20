using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    internal class Circulo : Formula,Icores
    {
        public void exibir()
        {
            Console.WriteLine($"circulo da cor {cor1}");
        }
        public Circulo(string formula, string cor, int area):base(formula, cor, area) { }
    }
}
