using System;
using System.Runtime.InteropServices;

namespace ConsoleApp6;

class Program
{

    static void Main()
    {

        for (int a = 0; a < 10; a++)
        {
            Console.WriteLine(a);
        }

        string[] nomes = { "Kaiky", "gabriel", "Alves", "KG" };
        //a variavel tem que ser do mesmo tipo doq o da array
        // ela repete a quantidade de items que tem uma array
        //a cada repetição a variavel nome muda ex(primeira repetição vai para "kaiky", a segunda para "gabriel" e etc...
        foreach (string nome in nomes)
        {
            Console.WriteLine(nome);
        }

        float[] numerinho = { 1.1f, 1.5f, 1.22f };
        foreach (float numer in numerinho)
        { Console.WriteLine(numer); 
        
        }

        List<int> valores = new List<int>() { 1, 2,3, 4, };
        Console.WriteLine("acresente mais um item a uma estrutura ");
        int AdicionarValores = int.Parse(Console.ReadLine());

        valores.Add(AdicionarValores);
        Console.WriteLine(""); //acresentar um espaço entre o valor adicionado
        foreach (int valor in valores)
        {
            Console.WriteLine(valor);
           
        }
        
        Console.WriteLine("Remova um dos valores");
        int remove = int.Parse(Console.ReadLine());
        valores.Remove(remove);

        Console.WriteLine("");//acresentar um espaço entre o valor adicionado
        foreach (int valor in valores)
        {
            Console.WriteLine(valor);

        }
    }
}