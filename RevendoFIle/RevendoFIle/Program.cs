using System;
using System.IO;

namespace RevendoFIle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (StreamReader rd = File.OpenText(@"C:\Users\kaiky\Downloads\kaka\teste.txt"))
                {
                    while (!rd.EndOfStream)
                    {
                        Console.WriteLine(rd.ReadLine());
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


