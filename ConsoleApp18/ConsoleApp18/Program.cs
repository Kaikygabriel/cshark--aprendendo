using System;
using System.IO;
using System.Linq;  

namespace ConsoleApp18
{
    internal class Program
    {
        enum op { adicionar = 1, excluir, sair }
        static void Main()
        {
            bool sair = false;
            while (!sair)
            {
                
                Console.WriteLine("1-Adicionar 2-exluir 3-sair");
                op sele = (op)int.Parse(Console.ReadLine());
                switch (sele)
                {
                    case op.adicionar:
                        adicionar();
                        Console.Clear();
                        break;
                    case op.sair:
                        sair = true;
                        break;
                }
            }


        }

        static void adicionar()
        {
            List<string> clientes = new List<string>();
            Console.Clear();
            Console.WriteLine("escreva o nome do cliente");
            string cliente = Console.ReadLine();
            clientes.Add(cliente);
            StreamWriter escritor2 = File.AppendText("cliente2.txt");
            foreach (string c in clientes)
            {
                escritor2.WriteLine(c);
            }
             escritor2.Close();
        }
    }
}
