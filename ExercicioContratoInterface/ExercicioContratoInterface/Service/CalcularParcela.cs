using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExercicioContratoInterface.Entity;

namespace ExercicioContratoInterface.Service
{
    internal class CalcularParcela
    {
        public CalcularParcela() { }

        public CalcularParcela(int numeroParcela, Taxa taxa)
        {
            NumeroParcela = numeroParcela;
            _taxa = taxa;
        }

        public int NumeroParcela { get; private set; }
        private Taxa _taxa;
        public void FazerParcela(Contrato contrato)
        {
            DateTime ProximoMes ;
            for (int a = 1;a <= NumeroParcela; a++)
            {
                ProximoMes = contrato.Data.AddMonths(a);
                double dividido = contrato.Total / NumeroParcela;
                double valor1 = dividido + (dividido *( _taxa.TaxaMes() * a));
                double valorFinal = valor1 +(valor1 * _taxa.TaxaPagamento());
                contrato.AdicionarParcelamento(ProximoMes,valorFinal);
            }
        }
    }
}
            
