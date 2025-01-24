using System;

namespace ConsoleApp14
{
    internal class Program
    {
        struct Produto
        {
            public string nome;
            public float preco;
        }
        static void Main()
        {
            Produto camisa = new Produto();
            camisa.nome = "Nike";
            camisa.preco = 13f;
            Console.WriteLine(camisa.nome); 
            Console.WriteLine(camisa.preco);
            Console.ReadLine();
        }
    }
}