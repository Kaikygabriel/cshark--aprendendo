using System;

namespace RevendoFIle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string Caminho = @"C:\Users\kaiky\Downloads\kaka\teste.txt";
                string Caminho2 = @"C:\Users\kaiky\Downloads\kaka\teste2.txt";
                FileInfo fb = new FileInfo(Caminho);
                Console.WriteLine(fb.Length);
                string[] linhas = File.ReadAllLines(fb.ToString());
                foreach(string l in linhas)
                {
                    Console.WriteLine(l);
                    Console.WriteLine(1);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("ERROR : " + ex.Message);
            }
        }
    }
}
