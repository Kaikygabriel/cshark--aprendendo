using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcela.Entity
{
    internal sealed class Parcela
    {
        public Parcela() { }

        public Parcela(double valorParcela, DateTime dataParcela)
        {
            ValorParcela = valorParcela;
            DataParcela = dataParcela;
        }

        public double ValorParcela { get; private set; }
        public DateTime DataParcela { get; private set; }
        public override string ToString()
        {
            return $"{DataParcela.ToString("dd/MM/yyyy")} - R${ValorParcela}";
        }
    }
}
