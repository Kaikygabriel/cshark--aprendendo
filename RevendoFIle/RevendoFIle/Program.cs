using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace RevendoFIle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\kaiky\Downloads\TestePasta\texto";
            try
            {
                Console.WriteLine("GetDirectoryName" + Path.GetDirectoryName(path));
                Console.WriteLine("DirectorySeparatorChar" + Path.DirectorySeparatorChar);
                Console.WriteLine(Path.PathSeparator);
            }
            catch (IOException ex) 
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}


