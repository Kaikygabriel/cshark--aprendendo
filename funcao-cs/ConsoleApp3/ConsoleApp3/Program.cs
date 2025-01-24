using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main()
        {
            string[] nome = { "kaiky", "gabriel" };
            Console.WriteLine(nome[0]);
           
            Msg();

            Imposto(100, "icms");
            Imposto(-200, "Imposto de renda");
            Console.ReadLine();
        }
        static void Msg()
        {
            Console.WriteLine("Fiz uma função");
        }
        static void Imposto(int preco, string nome)
        {
            //função abs transforma um numero negativo em positivo ex(se ela receber -100, ela transforma em 100, se receber -200, transforma em 200)
            int precoabs = Math.Abs(preco);

            if(preco < -1)
            {
                Console.WriteLine("o imposto " + nome + ", tem a taxa de abs em " + precoabs);
            }
            else
            {
            Console.WriteLine("o imposto " +nome+ ", tem a taxa de "+preco );
            }
        }

    }
}