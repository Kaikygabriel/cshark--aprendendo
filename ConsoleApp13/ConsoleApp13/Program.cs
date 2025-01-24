using System;

namespace ConsoleApp13
{   
    public class Aleatorio
    {
        public static void Palavra()
        {
            Console.Clear();
            List<string> palavra = new List<string>();
            Console.WriteLine("Escreva a primeira palavra aleatoria");
            palavra.Add(Console.ReadLine());
            Console.WriteLine("Escreva a segunda palavra aleatoria");
            palavra.Add(Console.ReadLine());
            Random random = new Random();
            Console.WriteLine("A palavra escolhida foi !?!?!?!?!?!");
            Console.WriteLine(palavra[random.Next(2)]);
            Console.ReadKey();
            Console.Clear();
        }
    }


    internal class Program
    {
        enum opcao {sair = 1,roleta2}
        static void Main()
        {
            bool sair = false;
            while (!sair) 
            {
                
                Console.WriteLine("Escolha uma das opçoes abaixo\n 1- sair \n 2-palavra aleatoria");
                opcao sele = (opcao)int.Parse(Console.ReadLine());
                switch (sele) 
                {
                    case opcao.sair:
                        sair = true;
                        break;
                    case opcao.roleta2:
                        Aleatorio.Palavra();
                        break;
                    default:
                        Console.WriteLine("ERRORRRRRRRRRRRRRRRRRRRRRRRRR");
                        break;
                }

            }
        }

    }

}
