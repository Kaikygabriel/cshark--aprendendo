using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaLojaVirtual.Entities.EnumProdutos;

namespace SistemaLojaVirtual.Entities
{
    internal class ProdutoDigital : Produto
    {
        public ProdutoDigital() { }
        public ProdutoDigital(string nome,double price): base(nome,price)
        {
            Tipo = EProduto.Digital;
        }

        public EProduto Tipo { get; set; }
        public string Id { get; private set; }= Guid.NewGuid().ToString().ToUpper().ToLower()[..8];

        public override string ToString()
        {
            return $"Produto :{Nome} -- Id:{Id}";
        }
    }
}
