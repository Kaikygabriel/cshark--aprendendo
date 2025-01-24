using System;

namespace Projeto_2
{
    internal class Program
{
        static void Main()
        {
            string[] Aleatorio = { "kaiky", "aviao", "cachorro", "kg", "ks" };
            Random random = new Random();
            Console.WriteLine(Aleatorio[random.Next(Aleatorio.Length)]);


            Console.Write("qual seu  nome ");
            string kk = Console.ReadLine();

            if (kk.Length <= 20)
            {
                Console.WriteLine("Olá " + kk);

            }
            else if (kk.Length == 0)
            {
                Console.WriteLine("Escreva algo");
            }
            else
            {
                Console.WriteLine("Insira menos de 20 caracteres (Apenas o primeiro nome)");
            }


            var numero = 0;
            string resultado = Verificar(numero);
            Console.WriteLine(resultado);


        }
        static string Verificar(int numero)
        {
            if (numero > 0)
            {
                return "numero positivo";
            }
            else if (numero < 0)
            {
                return "numero negativo";
            }
            else
            {
                return "numero 0";
            }
        }
}
}