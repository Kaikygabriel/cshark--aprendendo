using System; 
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace GERENCIADORC
{
    internal class Program
    {
        struct clientes
        {
            public string nome;
            public string email;
            public clientes(string nome, string email)
            {
                this.nome = nome;
                this.email = email;
            }
        }
        enum op {add = 1,remover,ver,sair}
        static void Main()
        {
            bool sair = false;
            while (!sair)
            {
                Console.WriteLine("Escolha umas das opções abaixo \n 1-adicionar cliente \n 2- remover \n 3 ver clientes\n 4 sair");
                op sele = (op)int.Parse(Console.ReadLine());
                switch (sele)
                {
                    case op.add:
                        Console.Clear();
                        adicionar();
                        break;
                    case op.remover:
                        Console.Clear();
                        remover();
                        break;
                    case op.ver:
                        Console.Clear();
                        vercliente();
                        break;
                    case op.sair:
                        sair = true;
                        break;
                    default:
                        Console.WriteLine("numero invalido");
                        break;
                }
                Console.Clear();
            }
        }
        static void adicionar()
        {
            List<clientes> clientes1 = new List<clientes>();
            Console.WriteLine("Escreva o nome do Cliente");
            string nomecliente = Console.ReadLine();
            Console.WriteLine("escreva o email");
            string emailcliente = Console.ReadLine();

            clientes1.Add(new clientes(nomecliente, emailcliente));
            
            StreamWriter escrever = File.AppendText("clientes1.txt");
            foreach (clientes cliente in clientes1)
            {
                escrever.WriteLine(cliente.nome);
                escrever.WriteLine(cliente.email);
            }
            escrever.Close();
            Console.WriteLine("cliente adicionado");
            Console.ReadLine();
        }
        static void remover()
        {
            if (File.Exists("clientes1.txt"))
            {
                List<clientes> clientes = new List<clientes>();
                StreamReader ler = new StreamReader("clientes1.txt");
                string linha = "";

                while (linha != null)
                {
                    linha = ler.ReadLine();
                    if (linha != null)
                    {
                        string nomecliente = linha;
                        string emailCliente = ler.ReadLine();
                        clientes.Add(new clientes(nomecliente,emailCliente));
                    }
                }
                ler.Close();
                foreach (clientes cliente in clientes)
                {
                    Console.WriteLine($"Nome: {cliente.nome}, Email: {cliente.email}");
                }
                Console.WriteLine("escreva o cliente que deseja excluir");
                string clienteSair = Console.ReadLine();

                clientes index = clientes.Find(cliente => cliente.nome == clienteSair);
                int indexcliente = clientes.IndexOf(index);
                if (indexcliente != -1)
                {
                    clientes.RemoveAt(indexcliente);
                    Console.WriteLine("cliente excluido");
                    StreamWriter escrever = new StreamWriter("clientes1.txt");
                    foreach (clientes item in clientes)
                    {
                        escrever.WriteLine(item.nome);
                        escrever.WriteLine(item.email);
                    }
                    escrever.Close();
                }
                else
                {
                    Console.WriteLine("cliente não encontrado");
                }

                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("nenhum cliente encontrado");
                Console.ReadLine();
            }
        }
        static void vercliente()
        {
            if (File.Exists("clientes1.txt"))
            {
                List<clientes> clientes = new List<clientes>();
                StreamReader ler = new StreamReader("clientes1.txt");
                string linha = "";

                while (linha != null)
                {
                    linha = ler.ReadLine();
                    if (linha != null)
                    {
                        string nomecliente = linha;
                        string emailCliente = ler.ReadLine();
                        clientes.Add(new clientes(nomecliente, emailCliente));
                    }
                }
                ler.Close();
                foreach (clientes cliente in clientes)
                {
                    Console.WriteLine($"Nome ou email: {cliente.nome}");
                }
                ler.Close();
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("nenhum cliente encontrado");
                Console.ReadLine();
            }
        }
    }
}
