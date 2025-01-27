using System;
using System.IO;
using System.Collections.Generic;

namespace trocandoinfo
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Escreva algum cliente");
            string coletor = Console.ReadLine();
            StreamWriter escrever = File.AppendText("texto1.txt");
            escrever.WriteLine(coletor);
            escrever.Close();

            StreamReader ler = new StreamReader("texto1.txt");
            List<string> cliente = new List<string>();
            string linha = "";
            while (linha != null) 
            {
            linha = ler.ReadLine();
                if(linha != null)
                {
                    cliente.Add(linha);
                }
            }
            ler.Close();
            StreamWriter transportar =  new StreamWriter("texto2.txt");
            foreach(string c in cliente)
            {
                transportar.WriteLine(c);
            }
            transportar.Close();
        }
        
    }
}
