using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanchonete.Entities
{
    internal sealed class Produto
    {
        public Produto() { }

        public Produto(string nome, double price)
        {
            Nome = nome;
            Price = price;
        }

        public string Nome { get; private set; } = string.Empty;
        public double Price { get; private set; }
        public override string ToString()
        {
            return $"{Nome} -- R${Price.ToString("F2",CultureInfo.InvariantCulture)}";
        }
    }
}
