using System;

namespace EscadaMario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Escada();
            
            
        }
        static void Escada()
        {
            int um = 1;
            for (int i = 1; i <= 6; i++)
            {
                for (int b = 1; b <= i; b++)
                {
                    if (um == 1)
                    {
                        int espaco = 6 - i;
                        while (espaco != 0)
                        {
                            Console.Write(" ");
                            espaco--;
                        }
                    }
                    Console.Write("#");
                    
                    um = 2;
                }
                Console.Write("  ");
                for (int d = 1; d <= i; d++)
                {

                    Console.Write("#");

                }

                um = 1;
                Console.WriteLine();
            }
        }
   
    }
}
