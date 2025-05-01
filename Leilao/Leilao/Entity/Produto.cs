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
        public Produto(int peso, int id, string nome, string descricao, double valor) : base(id, nome, descricao, valor)
        {
            Peso = peso;
        }
        public float Peso { get; private set; }
        public override double ValorTotal()
        {
            return Valor;
        }
    }
}
