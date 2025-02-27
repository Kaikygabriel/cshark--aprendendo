using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Filme_ transformers = new Filme_("Transformers", 120f);
            Filme_ transformers2 = transformers;
            transformers.duracao = 60f;
            Console.WriteLine(transformers2.duracao);   
            //estão referenciando o mesmo objeto 
            //struct cria uma copia desse variavel(struct e variavel não objeto)
        }
    }
}
