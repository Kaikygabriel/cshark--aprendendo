using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProcessadorDePagamento.Entity;

namespace ProcessadorDePagamento.Service
{
    internal class PagamentoCartao : IPagamento
    {
        public void Pagar(double amount, Pessoa pessoa)
        {
            if (amount > pessoa.ContaBanco.Valor)
            {
                throw new Exception("ERROR");
            }
            Console.WriteLine("Pago cartão");
        }
    }
}
