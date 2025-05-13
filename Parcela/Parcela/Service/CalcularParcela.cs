using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parcela.Entity;

namespace Parcela.Service
{
    internal sealed class CalcularParcela
    {
        public CalcularParcela() { }
        public CalcularParcela(int numparcela,ITaxa taxa)
        {
            NumParcela = numparcela;
            _taxa = taxa;
        }
        public int NumParcela { get; private set; }
        private ITaxa _taxa;
        public void FazerParcela(Contrato contrato)
        {
            for (int a = 1; a <= NumParcela; a++)
            {
                DateTime mesParcela = contrato.Data.AddMonths(a);
                double valor1 = contrato.Valor+(contrato.Valor * (_taxa.TaxaMes() * a));
                double valorFinal = contrato.Valor + (contrato.Valor * _taxa.TaxaPagamento());
                contrato.AdicionarParcela(mesParcela, valorFinal);
            }
        }
    }
}
