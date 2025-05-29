using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace CriarContratos.Entities
{
    internal class Parcelas
    {
        public Parcelas() { }

        public Parcelas(double valor, DateTime dataParcela)
        {
            Valor = valor;
            DataParcela = dataParcela;
        }

        public double Valor { get; private set; }
        public DateTime DataParcela { get; private set; }

        public override string ToString()
        {
            return $"R${Valor.ToString("F2")} -- {DataParcela.ToString("dd/MM/yyyy")}";
        }
    }
}
