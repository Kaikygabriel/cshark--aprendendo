using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteProduto.Entidade
{
    internal class PedidoItem
    {
        public int Quantidade;
        public float Total;
        public Item item = new Item();
        public PedidoItem() { }
        public PedidoItem(int quantidade, float preco, string nome)
        {
            Quantidade = quantidade;
            Total = preco;
            item.Preco = preco;
            item.Nome = nome;
        }
        public float TotalPreco()
        {
            return Quantidade * Total;
        }
        public override string ToString()
        {
            return $"{item.Nome}, quantidade {Quantidade} Total R${TotalPreco()}";
        }
    }
}
