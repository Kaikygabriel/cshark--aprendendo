using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listanum = Range(30,60);
            foreach (int i in listanum) 
            {
                Console.WriteLine(i);
            }
        }
        static List<int> Range(int start, int end)
        {
           
            List<int> pares = new List<int>();
            for (int i = start; i <= end; i++) 
            {
                 if(i % 2 == 0)
                 {
                    pares.Add(i);
                 }
            }
            return pares;
        }
    }
}
