using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProcessadorDePagamento.Entity;

namespace ProcessadorDePagamento.Service
{
    internal sealed class CheckoutService
    {
        public CheckoutService() { }
        public CheckoutService(IPagamento pagamento) 
        {
            _pagamento = pagamento;
        }
        private IPagamento _pagamento;
        public void Checkout(double amount,Pessoa pessoa)
        {
            _pagamento.Pagar(amount,pessoa);
            pessoa.ContaBanco.Pagar(amount);
        }
    }
}
