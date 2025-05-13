using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioContratoInterface.Service
{
    internal class PayPal : Taxa
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
