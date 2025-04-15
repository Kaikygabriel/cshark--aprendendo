
using System.Diagnostics;

namespace DesafioDePrecisao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] letras = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k' };
            Random al = new Random();
            char aleatorio = letras[al.Next(letras.Length)];

            Console.WriteLine($"PEnsa rapido digite a letra ");
            DateTime a = new DateTime();
            Stopwatch tempo1 = new Stopwatch();
            tempo1.Start();
            while(tempo1.Elapsed.Seconds < 4)
            {
                DateTime a2 = DateTime.Parse(tempo1.ToString());
                if (a2.Second != a.Second)
                {
                    Console.WriteLine(a2.Second);
                }
                a = DateTime.Parse(tempo1.ToString());    
            }
            Console.WriteLine(aleatorio);
            tempo1.Stop();
            Stopwatch tempo = new Stopwatch();
            

            tempo.Start();

            char letraDigitada = char.Parse(Console.ReadLine().Trim());
            while (!(aleatorio.Equals(letraDigitada)))
            {
                Console.WriteLine("ERROu escreva denovo");
                letraDigitada = char.Parse(Console.ReadLine().Trim());
            }
            tempo.Stop();
            Console.WriteLine($"O seu tempo foi de {tempo}");
        }
    }
}
