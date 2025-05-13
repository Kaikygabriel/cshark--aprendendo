using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExercicioContratoInterface.Entity.Exception;

namespace ExercicioContratoInterface.Entity
{
    internal sealed class Contrato
    {
        public Contrato() { }

        public Contrato(int numero, DateTime data, double total)
        {
            Numero = numero;
            Data = data;
            Total = total;
        }

        public int Numero{ get; private set; }
        public DateTime Data{ get; private set; }
        public double Total { get;private set; }
        public List<Parcelamento> Parcela { get; private set; } = new List<Parcelamento>();

        public void AdicionarParcelamento(DateTime data,double valor)
        {
            if(valor < 0)
            {
                throw new DominioException("O valor tem que ser maior que 0");
            }
            Parcela.Add(new Parcelamento(valor, data));
        }
        public void GetParcela()
        {
            foreach (var parcela in Parcela)
            {
                Console.WriteLine(parcela);
            }
        }
    }
}
