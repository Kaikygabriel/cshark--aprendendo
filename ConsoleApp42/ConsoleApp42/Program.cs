using System;
using System.Runtime.CompilerServices;

namespace ConsoleApp42
{
    internal class Program
    {
    
        
        static void Main(string[] args)
        {
            Aleatorio();
        }
        static void Aleatorio()
        {
             Random aleatorio = new Random();
            int numero = aleatorio.Next(1, 100);
            
            Console.WriteLine("Escreva num numero");
            int NumDigitado = int.Parse(Console.ReadLine());
            try
            {
                while (NumDigitado != numero)
                {         
                   Console.WriteLine("Escreva outro numero");
                   NumDigitado = int.Parse(Console.ReadLine());
                    for (int i = 1; i < 10; i++)
                    {
                        if (NumDigitado == numero - i || NumDigitado == numero + i)
                        {

                            Console.WriteLine("Esta quente");

                        }
                    }
                      
                    }
                    
                    Console.WriteLine("Parabens o numero é " + numero);
                Console.ReadLine();
            } catch(Exception e)
            {
                Console.WriteLine("ERROR");
                Console.Clear();
                Aleatorio();
            }
        }
    }
}
