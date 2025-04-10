using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ler();
        }
        static void Ler()
        {
            StreamWriter escrever = new StreamWriter("text.txt");
            escrever.Write("Capetalista programa em rust");
            escrever.Close();
            StreamReader ler = new StreamReader("text.txt");
            string texto = ler.ReadToEnd();
            Console.WriteLine(texto);
            ler.Close();
            string[] list = texto.Split(' ');
            int somaCaracter = 0;

            foreach (string s in list)
            {
                //Console.Write(s);
                somaCaracter += s.Length;
            }
            int palavras = list.Length - 1;
            List<string> PalavrasRepetidas = new List<string>();
            while (palavras >= 0)
            {

                foreach (string s in list)
                {


                    if (list[palavras].Equals(s, StringComparison.InvariantCultureIgnoreCase))
                    {
                        PalavrasRepetidas.Add(s);
                        
                    }
                    palavras -= 1;
                }

                Console.WriteLine($"O numero de caracters é {somaCaracter}\nEo numero de palavras são  {list.Length}");
                if (PalavrasRepetidas.Count > 0)
                {
                    foreach (string s in PalavrasRepetidas)
                    {

                        Console.WriteLine($"A palavra {s} repetiu ");

                    }
                }
            }
        }
    }
}
