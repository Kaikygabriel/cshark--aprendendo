using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 
using System.Threading.Tasks;

namespace NumeroPerfeito
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Perfeito(6);
        }
        static void Perfeito(int num)
        {
            int soma = 0;

            int metade = num / 2;
            for (int i = 0; i <= metade; i++)
            {
                if (i != 0)
                {
                    if (num % i == 0)
                    {
                        soma = i + soma;
                    }
                }
            }

         
           if(soma == num)
            {
                Console.WriteLine($"{num} é perfeito");
            }
        }
    }
}
