using System;
using System.Collections.Generic;
using SistemaLojaVirtual.Service;
using SistemaLojaVirtual.Service.Interface;

namespace SistemaLojaVirtual.Entities
{
    internal class Carrinho
    {
        public List<Produto> Produtos { get; private set; } = new List<Produto>();
        public List<IDesconto> Descontos { get; private set; } = new List<IDesconto>();
        public double Total { get; set; }

        public void AdicionarProduto(Produto produto)
        {
            Produtos.Add(produto);
        }
        public void CalcularTotal()
        {

            double total = 0;
            foreach (var produto in Produtos)
            {
                if(produto)
                total += produto.Price;
            }
            
        }

    }
}
