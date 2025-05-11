using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_de_Pagamentok.Service;

namespace Sistema_de_Pagamentok.Entity
{
    internal class PagamentoCartaoCredito : Pagamento
    {
        PagamentoCartaoCredito() { }

        public PagamentoCartaoCredito(ITaxa taxa, double credito, double limite)
        {
            _taxa = taxa;
            Credito = credito;
            Limite = limite;
        }

        private ITaxa _taxa;
        public double Credito { get; private set; } = 1000;
        public double Limite { get; private set; }
        public double ValorMensal{ get; private set; }
        public void ProcessarPagamento(double valor)
        {
            double tax = _taxa.Taxa(valor);
            Credito -= valor;
            ValorMensal += valor + tax;
        }
    }
}
