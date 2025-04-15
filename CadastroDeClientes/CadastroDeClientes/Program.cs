using System;

namespace CadastroDeClientes
{
    internal class Program
    {
        public static List<Cliente> clientes = new List<Cliente>();
        public static void Main()
        {
            try
            {
                bool executando = true;

                while (executando)
                {
                    Console.WriteLine("\n=== Menu Principal ===");
                    Console.WriteLine("1 - Cadastrar novo cliente");
                    Console.WriteLine("2 - Listar clientes cadastrados");
                    Console.WriteLine("3 - Buscar cliente cadastrados");
                    Console.WriteLine("4 - Sair");
                    Console.Write("Escolha uma opção: ");
                    string opcao = Console.ReadLine();

                    switch (opcao)
                    {
                        case "1":
                            Cliente.CadastrarCliente();
                            break;

                        case "2":
                            Cliente.ListarCliente();
                            break;
                        case "3":
                            Console.WriteLine("Cpf");
                            string cpf = Console.ReadLine();

                            Cliente.BuscarClientes(cpf);
                            break;
                        case "4":
                            executando = false;
                            Console.WriteLine("Encerrando o programa...");
                            break;

                        default:
                            Console.WriteLine(" Opção inválida, tente novamente.");
                            break;
                    }
                    Console.Clear();
                }
            }
           catch(Exception e)
            {
                Console.WriteLine(" Opção inválida, tente novamente.");
                Main();
            }

        }
    }
}
