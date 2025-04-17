using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCarrinhoCompras.Entidade
{
    internal class Item
    {
        public string Nome;
        public float Preco;

        public Item(string nome, float preco)
        {
            Nome = nome;
            Preco = preco;
        }
        
        public override string ToString()
        {
            return $"O item {Nome} tem o valor {Preco}";
        }
    }
}
