using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioContratoInterface.Entity
{
    internal class Parcelamento
    {
        public Parcelamento() { }
        public Parcelamento(double valor, DateTime dataParcela)
        {
            DataParcela = dataParcela;  
            Valor = valor;
        }
        public DateTime DataParcela { get; private set; }
        public double Valor{ get; private set; }
        public override string ToString()
        {
            return $"{DataParcela.Date} - {Valor}";
        }
    }
}
