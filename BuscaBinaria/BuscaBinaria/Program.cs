using System;
using System.Diagnostics;

namespace BuscaBinaria
{
    internal class Program
    {
        static void Main()
        {
            BuscaBinaria(3);
        }
        static void BuscaBinaria(int num)
        {
            int[] Numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int metade = Numeros.Length / 2;
            if (Numeros[metade] == num)
            {
                Console.WriteLine($"Achou o numero {num}");
            }
            else if (Numeros[metade] > num) 
            {
                for (int i = 0; i < metade; i++) 
                {
                    if(Numeros[i] == num)
                    {
                        Console.WriteLine($"Achou o numero {num} , era maior que a matede");
                    } 
                }
            }
            else if(Numeros[metade] > num)
            {
                for (int i = metade; i < Numeros.Length; i++)
                {
                    if (Numeros[i] == num)
                    {
                        Console.WriteLine($"Achou o numero {num} , era menor que a matede");
                    }
                }
            }
            else
            {
                Console.WriteLine("Não achei");
            }
        }
    }
}
