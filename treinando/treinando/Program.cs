using System;
class Program
{
    static void Main()
    {
        Console.WriteLine(Imposto("icms", 18));
        string[] nomes = new string[2] { "kaiky", "kg" };
        Random rand = new Random();
        Console.Write(nomes[rand.Next(nomes.Length)]);
        Console.ReadLine();
    }

     static string Imposto(string nome, int preço)
    {
        return $"O imposto {nome}, tem a quantia {preço}";
    }
}