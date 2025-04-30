using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel.Entity.Enums;

namespace Hotel.Entity.Entity2
{
    internal sealed  class QuartoLuxo : Quarto
    {
        public QuartoLuxo() { }
        public QuartoLuxo( double valor,int id) : base(, valor, id) { }
        public override double GetValor()
        {
            return Valor * 0.1;
        }
        public override string Descricao()
        {
            return $"O quarto {Id} de luxo , tem o valor de  R${Valor.ToString("F2",CultureInfo.InvariantCulture)}, eo status de {StatusQuarto}";
        }
    }
}
