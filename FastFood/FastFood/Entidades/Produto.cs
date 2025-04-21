using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood.Entidades
{
    internal class Produto
    {
        public Produto(string nome, float preco, int estoque)
        {
            Nome = nome;
            Preco = preco;
            Estoque = estoque;
        }

        public string Nome { get; private set; }
        public float Preco { get; private set; }
        public int Estoque { get; private set; }
        public override string ToString()
        {
            return $"O produto {Nome} tem o preço R${Preco} ea quantidade no estoque de {Estoque}";
        }
    }
}
