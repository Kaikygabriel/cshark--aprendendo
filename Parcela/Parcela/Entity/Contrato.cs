using Parcela.Entity.Exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcela.Entity
{
    internal class Contrato
    {
        public Contrato() { }

        public Contrato(int number, DateTime data, double valor)
        {
            Number = number;
            Data = data;
            Valor = valor;
        }

        public int Number { get; private set; }
        public DateTime Data { get; private set; }
        public double Valor{ get; private set; }
        private List<Parcela> _parcelas= new List<Parcela>();
        public void AdicionarParcela(DateTime data,double valor)
        {
            if(valor <0 && data < this.Data)
            {
                throw new DominioException("Valor de data ou preço invalido");
            }
            _parcelas.Add(new Parcela(valor,data));
        }
    }
}

