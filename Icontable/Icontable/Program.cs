using System;
using System.IO;
using Icontable.Entity;

namespace Icontable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\kaiky\Downloads\Funcionarios.csv";
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Funcionario> funcionario = new List<Funcionario>();
                    while (!sr.EndOfStream)
                    {
                        funcionario.Add(new Funcionario(sr.ReadLine()));
                    }
                    funcionario.Sort();
                    foreach (var f in funcionario)
                    {
                        Console.WriteLine(f);
                    }
                }
            }
            catch (IOException e) 
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
