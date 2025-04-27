using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPolimorfismo.Entity
{
    sealed class ProdutoImportado : Produto
    {
        public ProdutoImportado() { }

        public ProdutoImportado(double frete, string nome, double valor):base(nome, valor) 
        {
            Frete = frete;
        }

        public double Frete { get;private set; }
        public override string Etiqueta()
        {
            return $"{Nome} preço total é R${PrecoTotal()} (valor do frete é R${Frete})";
        }
        public double PrecoTotal()
        {
            return Frete + Valor;
        }
    }
}
