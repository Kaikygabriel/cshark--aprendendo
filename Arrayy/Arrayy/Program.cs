using System;

namespace Aprendendo
{
    internal class Program
    {
        static void Main()
        {
            //string[] produtos = { "Minecraft", "GTA", "FIFA", "cs" };
            string[] produtos = new string[4]{"Minecraft", "GTA", "FIFA", "cs",};
            //tamanho(quantidade de coisa que queira salvar)
            //se definiu o tamanho não pode mais mudar o tamanho dele novamente

            produtos[2] = "FIFA25";
            //mude a informação 

            Console.WriteLine(produtos[2]);

            //outra forma de criar array

            //int[] numeros = { 2, 3, 4 };
          
            List<int> numeros = new List<int> { 2, 3, 4 };

            numeros.Add(numeros[0]);
            
            Console.WriteLine(numeros[2]);
            Console.ReadLine();
        }
    }
}