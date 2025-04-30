using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel.Entity.Enums;

namespace Hotel.Entity.Entity2
{
    internal sealed  class QuartoSimples : Quarto
    {
        public QuartoSimples() { }
        public QuartoSimples(double valor,int id) : base(valor,id) { }
        public override double GetValor()
        {
            return Valor;
        }
        public override string Descricao()
        {
            return $"O quarto {Id} simples , tem o valor de R${Valor.ToString("F2",CultureInfo.InvariantCulture)}, eo status de {StatusQuarto}";
        }
    }
}
