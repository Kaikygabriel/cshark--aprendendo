using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProcessadorDePagamento.Entity;

namespace ProcessadorDePagamento.Service
{
    internal interface IPagamento
    {
        void Pagar(double amount,Pessoa pessoa);
    }
}
