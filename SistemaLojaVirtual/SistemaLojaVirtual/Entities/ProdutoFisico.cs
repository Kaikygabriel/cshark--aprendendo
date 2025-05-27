using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using SistemaLojaVirtual.Entities.EnumProdutos;

namespace SistemaLojaVirtual.Entities
{
    internal class ProdutoFisico : Produto
    {
        public ProdutoFisico() { }
        public EProduto Tipo { get;private set; }
        public ProdutoFisico(string nome,double price,double peso):base(nome,price)
        {
            Tipo = EProduto.Fisico;
        }
        public double Peso { get; private set; }
        public override string ToString()
        {
            return $"()Produto {Nome} -- R${Price.ToString("F2",CultureInfo.InvariantCulture)}";
        }
    }
}
