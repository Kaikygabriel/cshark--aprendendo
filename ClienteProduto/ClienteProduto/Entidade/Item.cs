using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteProduto.Entidade
{
    internal class Item
    {
        public string Nome;
        public float Preco;

        public Item()
        {
        }

        public Item(string nome, float preco)
        {
            Nome = nome;
            Preco = preco;
        }
        
    }
}
