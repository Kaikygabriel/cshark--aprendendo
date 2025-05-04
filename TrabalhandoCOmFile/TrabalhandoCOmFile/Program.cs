using System;
using System.IO;

namespace TrabalhandoCOmFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string caminho = @"C:\Users\kaiky\texto.txt";
            string caminho2 = @"C:\Users\kaiky\texto2.txt";
            try
            {
                FileInfo fileInfo = new FileInfo(caminho2);
                Console.WriteLine(fileInfo.Length);
                string solo = File.ReadAllText(caminho);
                DateTime modificacao = fileInfo.LastWriteTime;
                Console.WriteLine(modificacao );
                string[] linhas = File.ReadAllLines(caminho2);
                foreach (string line in linhas)
                {
                    Console.WriteLine(line);
                }
            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
