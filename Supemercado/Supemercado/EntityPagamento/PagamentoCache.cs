using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supemercado.EntityPagamento
{
    sealed internal class PagamentoCache : Pagamento
    {
        public PagamentoCache() { }
        public PagamentoCache(double valor) : base(valor)
        {

        }
        public override void Pagar(double valorRecebido)
        {
            Valor -= valorRecebido;
        }
    }
}
