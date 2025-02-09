using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Filme transformers = new Filme("Transformers 1","Paramont");
            transformers.addator("otimus");
            transformers.exibir();
        }
    }
}
