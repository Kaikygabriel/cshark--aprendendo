using System;

namespace ConsoleApp7
{
    public class Contador
    {
        
        public static int contador = Program.valor;
        public static void Incrementar()
        {
            contador++;
        }
        public static void ExibirContador()
        {
            Console.WriteLine(Program.nome);
            Console.WriteLine(contador);
        }
    }

     public class Program
    {
        public static int valor = int.Parse(Console.ReadLine());
        public static string nome = "kaiky";
        static void Main()
        {
            Console.WriteLine($"o valor inicial do contador é {Contador.contador}");
            Contador.Incrementar();
            Contador.ExibirContador();

            Contador.Incrementar();
            Contador.ExibirContador();

            Contador.Incrementar();
            Contador.ExibirContador();
        }
        
    }
}
