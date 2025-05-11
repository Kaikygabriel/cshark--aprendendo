using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alocacao2.Entity
{
    internal sealed class Invoice
    {
        public Invoice() { }

        public Invoice(double pagamentoBasico, double taxa)
        {
            PagamentoBasico = pagamentoBasico;
            Taxa = taxa;
        }

        public double PagamentoBasico { get; private set; }
        public double Taxa { get; set; }
        public double GetTotal
        {
            get { return PagamentoBasico + Taxa;}
        }
        public override string ToString()
        {
            return $"Pagamento basico : R${PagamentoBasico.ToString("F2",CultureInfo.InvariantCulture)}\n Taxa : {Taxa}\n Total pagamento : {GetTotal}";
        }
    }
}
