using System;
using System.Collections.Generic;

namespace CourseDictonary
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<string,int>Deputados = new Dictionary<string,int>();
            using (StreamReader rd = new StreamReader(@"C:\Users\kaiky\Downloads\Deputados.txt"))
            {
                while (!(rd.EndOfStream))
                {
                    string[] line = rd.ReadLine().Split(',');
                    if (Deputados.ContainsKey(line[0]))
                    {
                        Deputados[line[0]] += int.Parse(line[1]);
                    }
                    else
                    {
                        Deputados.Add(line[0], int.Parse(line[1]));
                    }
                }
            }
            foreach(var a in Deputados)
            {
                Console.WriteLine($"{a.Key} : {a.Value}");
            }
        }
    }
}
