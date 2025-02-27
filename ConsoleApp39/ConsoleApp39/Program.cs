using System.Numerics;

namespace ConsoleApp39
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fatorial1(7));
            Console.WriteLine(Fatorial1(7));
        }
        //Meu Fa   torial
        static int Fatorial(int num)
        {
            int total = 0;
            for (int i = 1; i <= num; i++)
            {          
                int resu = num - i;

                if(total == 0)
                {
                total = num * resu;             
                }
                else
                {
                    total = resu * total;
                }
            }
            return total;
        }
        //fatorial que o ChatGpt sugerio
        static int Fatorial1(int num)
        {
            int total = 1;  // O fatorial de 0 e 1 é 1, então começamos com 1.
            for (int i = 1; i <= num; i++)  // O loop deve ir até num, não até num-1
            {
                total *= i;  // Multiplicamos total por i a cada iteração
            }
            return total;
        }
    }
}

