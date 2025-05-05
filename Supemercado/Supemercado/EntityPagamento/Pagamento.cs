using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supemercado.EntityPagamento
{
    internal abstract class Pagamento
    {
        protected Pagamento() { }
        protected Pagamento(double valor)
        {
            Valor = valor;
        }
        public double Valor { get;private protected set; }
        public abstract void Pagar(double valorRecebido);
    }
}
