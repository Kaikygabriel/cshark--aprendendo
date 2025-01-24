using System;

namespace  ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            for(int c = 1; c < 10;c++)
            {
                Mensagem();
                if (c == 1)
                {
                    break;
                }
            }
            Console.ReadLine();
        }
        
        static void Mensagem()          
        {
            Console.WriteLine("Hello World!");
        }
    }
}