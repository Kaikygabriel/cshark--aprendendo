using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaAdivinhacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Adivinhacao();
        }
        static void Adivinhacao()
        {
            Random aleatorio = new Random();
            int NumAleatorio = aleatorio.Next(1,10);
            bool sair = true;
            int total = 1;
            try
            {


                while (sair)
                {

                    Console.Clear();
                    if (total == 1)
                    {
                        Console.WriteLine("Tente adivinhar o numero entre 1 a 10");
                        int num = int.Parse(Console.ReadLine());
                        if (num != null && num > 0 && num < 11)
                        {
                            if (num == NumAleatorio)
                            {
                                Console.WriteLine($"Parabens voce acerto na {total} tentativa, o numero era {NumAleatorio} !!!!");
                                sair = false;
                            }
                        }

                    }
                    else
                    {
                        Console.WriteLine("Escreva outro");
                        int num = int.Parse(Console.ReadLine());
                        if (num != null && num > 0 && num < 11)
                        {
                            if (num == NumAleatorio)
                            {
                                Console.WriteLine($"Parabens voce acerto na {total} tentativa, o numero era {NumAleatorio} !!!!");
                                sair = false;

                            }
                        }
                    }
                    total += 1;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("ERROR TENTE NOVAMENTE");
                Console.Clear();
                Adivinhacao();
            }
        }
    }
}

