 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produto
{
    internal class Program
    {
        static void Main()
        {
            PRoduto pr = new PRoduto("Mouse",200,2);
            pr.Nome = "Mouse Multilaser";
            Console.WriteLine(pr.Nome);
        }
    }
}
