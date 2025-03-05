using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasa
{
    internal class Dia
    {
        public string date;
        public string explanation;
        public void exibir()
        {
            Console.WriteLine($"O dia é {date}");
            Console.WriteLine("");
            Console.WriteLine(explanation);
        }
    }
}
