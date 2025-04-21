using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using ClienteProduto.Entidade.Enum;

namespace ClienteProduto.Entidade
{
    internal class Pedido
    {
        public DateTime Momento;
        public Status StatusPedido;
        public Pedido() { }

        public Pedido( Status statusPedido)
        {
            Momento = DateTime.Now;
            StatusPedido = statusPedido;
        }
        List<PedidoItem> Produtos { get; set; } = new List<PedidoItem>();
        public void AdicionarProduto()
        {
            Console.WriteLine("Nome do Produto");
            string nome = Console.ReadLine();
            Console.WriteLine("Preço do Produto");
            float preco = float.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade");
            int quantidade = int.Parse(Console.ReadLine());
            Produtos.Add(new PedidoItem(quantidade,preco,nome));
        }
        public override string ToString()
        {
            float soma = 0;
            StringBuilder sb = new StringBuilder();
            string texto = $"Sumario Do Pedido \n Pedido Status : {StatusPedido}\n Pedido Momento {Momento}";
            sb.AppendLine(texto);
            foreach(PedidoItem item in Produtos)
            {
                soma += item.Total;
                sb.AppendLine(item.ToString());
            }
            string texto2 = $"Total : R${soma}";
            sb.AppendLine(texto2);
            return sb.ToString();
        }
    }
}

