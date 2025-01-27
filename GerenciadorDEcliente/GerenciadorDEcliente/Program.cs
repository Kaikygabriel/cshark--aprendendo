using System;
using System.IO;

namespace GerenciadorDEcliente
{
    internal class Program
    {
        enum op {add =1 ,ver,sair}
        static void Main(string[] args)
        {
            bool sair = false;
              while(!sair)
              {
                Console.WriteLine("GERENCIADOR DE CLIENTES");
                Console.WriteLine("Escolha uma das opçoes abaixo \n 1-add \n 2-ver cliente \n 3-sair");
                op sele = (op)int.Parse(Console.ReadLine());
                switch (sele)
                {
                    case op.add:
                        add();
                        break;
                    case op.sair:
                        sair = true;
                        break;
                    case op.ver:
                        ver();
                        break;
                }
                Console.Clear();
              }
        }  
  
        static void add()
        {
            List<string> lista = new List<string>();
            
            Console.Clear();
            Console.WriteLine("escreva o nome do cliente");
            string cliente = Console.ReadLine();    

            lista.Add(cliente);
            StreamWriter escritor = File.AppendText("cliente.txt");
            foreach(string c in lista)
            {
                escritor.WriteLine(c);
            }
            escritor.Close();


            Console.WriteLine("Cliente adicionado");
            Console.ReadLine();
        }
            
        static void ver()
        {
            Console.Clear();
            List<string> linhas = new List<string>();
            Console.WriteLine("ver clientes");
            StreamReader leitor = new StreamReader("cliente.txt");
            string linha = "";
            while (linha != null)
            {
                linha = leitor.ReadLine();
                if(linha != null)
                {
                    linhas.Add(linha);
                }
            }
            foreach(string c in linhas)
            {
                Console.WriteLine(c);

            }
            leitor.Close();
            Console.ReadLine();
        }
       

    }
}
