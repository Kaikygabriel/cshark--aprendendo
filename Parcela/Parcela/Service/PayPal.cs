using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcela.Service
{
    internal sealed class PayPal:ITaxa
    {
        public double TaxaMes()
        {
            return 0.01;
        }
        public double TaxaPagamento()
        {
            return 0.02;
        }
    }
}
