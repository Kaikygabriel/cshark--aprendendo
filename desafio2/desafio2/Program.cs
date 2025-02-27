using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> a =  Receba("4321");
            foreach (int i in a) 
            {
                Console.WriteLine(i);
            }
        }
        static List<int> Receba(string num)
        {
            List<int> resultado = new List<int>();
           
            for (int a = 0; a < num.Length; a++)
            {
                resultado.Add(int.Parse(num[a].ToString()));

            }
            resultado.Sort();
            return resultado;

        }
    }
}
