using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcela.Service
{
    internal interface ITaxa
    {
        double TaxaMes();
        double TaxaPagamento();
    }
}
