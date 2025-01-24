using System;

namespace ConsoleApp10
{
    public class msg
    {
        public static void enviar(int nome)
        {
           Console.WriteLine($"OLA {nome}");
        }
    }
    internal class Program
    {
        static void Main()
        {
            double valor1 = 1; 
            float resu = (float)valor1;
            Console.WriteLine(resu);
            int num = 1;
            string letra1 = num.ToString(); // ou
            string letra2 = $"{num}";
            string nome = Console.ReadLine();
            msg.enviar(int.Parse(nome));
        }
    }
}
