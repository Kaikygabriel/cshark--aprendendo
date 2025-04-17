using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransformandoNumeroEmBinario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Converter(13);
        }
        static void Converter(int num)
        {
            List<int> list = new List<int>();
            while(num != 0)
            {
                int resto = num % 2;
                num = num / 2;
                list.Add(resto);
            }
            foreach (int i in list)
            {
                Console.Write(i);
            }
            Console.WriteLine("\n numero binario de " +num);    
        }
    }
}
