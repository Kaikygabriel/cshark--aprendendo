using System;  
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supemercado.Entity.Exceptions;

namespace Supemercado.EntityPagamento
{
    internal sealed class PagamentoCartao : Pagamento
    {
        public PagamentoCartao() { }
        public PagamentoCartao(double limite, double valor) : base(valor)
        {
            Limite = limite;
        }
        public double Limite { get; private set; }
        public override void Pagar(double valorRecebido)
        {
            if (valorRecebido > Limite)
            {
                throw new PagamentoException("Valor recebido e maior que o limite do cartão");
            }
            Valor -= valorRecebido;
        }
    }
}
