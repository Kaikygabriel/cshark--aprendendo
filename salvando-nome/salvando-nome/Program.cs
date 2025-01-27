using System.Collections.Generic;
using System;
using System.IO;

namespace salvando_nome
{
    internal class Program
    {
        enum op {rese = 1,sair}
        static void Main()
        {
            bool sair = false;
            while (!sair)
            {
                if (File.Exists("nome.txt"))
            {
             
                    StreamReader ler = new StreamReader("nome.txt");
                    string nome = ler.ReadToEnd();
                    Console.WriteLine($"ola {nome}");
                    ler.Close();

                    Console.WriteLine("menu de opção \n 1-trocar nome  \n 2-sair");
                    op sele = (op)int.Parse(Console.ReadLine());
                    switch (sele) 
                    {
                        case op.rese:
                            mudar();
                            break;
                        case op.sair:
                            sair = true;
                            break;
                    }
                    Console.Clear();
               
            }
            else
            {
                Console.WriteLine("Escreva seu Nome");
                StreamWriter escrever = new StreamWriter("nome.txt");
                string salvarNome = Console.ReadLine();
                escrever.WriteLine(salvarNome); 
                escrever.Close();
            }
            }
        }
        static void mudar()
        {
            Console.Clear();
            Console.WriteLine("Escreva seu Nome");
            StreamWriter escrever = new StreamWriter("nome.txt");
            string salvarNome = Console.ReadLine();
            escrever.WriteLine(salvarNome);
            escrever.Close();

        }
    }
}
