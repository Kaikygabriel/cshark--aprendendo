

using ClienteProduto.Entidade;
using ClienteProduto.Entidade.Enum;

namespace ClienteProduto
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Nome cliente");
            string nomec = Console.ReadLine();
            Console.WriteLine("Email");
            string email = Console.ReadLine();
            Cliente client = new Cliente(nomec,email);
            Console.WriteLine("Status do produto (  PagamentoPendente,Processando,Saida,Entregue):");
            Status statusP = Enum.Parse<Status>(Console.ReadLine());
            Console.WriteLine("Quantos produtos deseja adicionar");
            int quanti = int.Parse(Console.ReadLine());
            client.AdicionarPedido(statusP);
            for (int i = 1; i <= quanti; i++)
            {
                Console.WriteLine($"Produto #{i}");
                client.pedido.AdicionarProduto();
            }
            Console.WriteLine("");
            Console.WriteLine(client);
            Console.WriteLine(client.pedido);
            Console.WriteLine();
        }
    }
}
