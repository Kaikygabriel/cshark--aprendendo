using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leilao.Entity
{
    internal sealed class Produto : Item
    {
        public Produto() { }
        public Produto(double peso, string nome, string descricao, double valor) : base( nome, descricao, valor)
        {
            Peso = peso;
        }
        public double Peso { get; private set; }
        public override double ValorTotal()
        {
            return Valor;
        }
    }
}
