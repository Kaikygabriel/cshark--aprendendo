using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPagamentoID.Service
{
    internal sealed class PagarCartao : IPagamento
    {
        public PagarCartao()
        {
            Saldo = 3000;
            Limite = 10000;
        }

        public double Saldo { get; private set; }
        public double Limite { get; private set; }
        public void Pagar(double valor)
        {
            Saldo -= valor;
            Limite -= valor;
        }
        public override string ToString()
        {
            return $"LImite - R${Limite.ToString("F2")}\nSaldo Atual - R${Saldo.ToString("F2")}";
        }
    }
}

