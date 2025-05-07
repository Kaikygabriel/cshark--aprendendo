using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace RevendoFIle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\kaiky\Downloads\kaka\teste.txt";
            string path2 = @"C:\Users\kaiky\Downloads\kaka\teste2.txt";
            try
            {
                using (StreamWriter sw = File.AppendText(path2))
                {
                    string[]linhas = File.ReadAllLines(path);

                    foreach(string line in linhas)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}


