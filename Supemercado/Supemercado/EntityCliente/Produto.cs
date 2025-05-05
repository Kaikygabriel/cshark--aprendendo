using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supemercado.EntityCliente
{
    internal class Produto
    {
        public Produto() { }

        public Produto(string nome, double valor)
        {
            Nome = nome;
            Valor = valor;
        }

        public string Nome { get; private set; }
        public  double Valor{ get; private set; }
        public override string ToString()
        {
            return $"O produto {Nome} tem o preço de R${Valor.ToString("F2",CultureInfo.InvariantCulture)}";
        }
    }
}
