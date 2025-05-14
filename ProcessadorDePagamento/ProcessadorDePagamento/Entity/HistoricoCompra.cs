using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessadorDePagamento.Entity
{
    internal class HistoricoCompra
    {
        HistoricoCompra() { }

        public HistoricoCompra(double valor, DateTime data)
        {
            Valor = valor;
            Data = data;
        }

        public double Valor { get;private set; }
        public DateTime Data { get;private set; }
        public override string ToString()
        {
            return $"{Data.ToString("dd/MM/yyyy")} - R${Valor.ToString("F2",CultureInfo.InvariantCulture)}";
        }
    }
}
