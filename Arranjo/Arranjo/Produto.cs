using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arranjo
{
    internal class Produto
    {
        public string Nome;
        public double Valor { get; private set; }
        public Produto(string nome, double valor)
        {
            this.Nome = nome;
            this.Valor = valor;
        }
    }
}
