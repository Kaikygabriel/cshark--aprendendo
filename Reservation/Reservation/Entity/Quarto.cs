using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservation.Entity.Exceptions;

namespace Reservation.Entity
{
    internal class Quarto
    {
        public Quarto() { }

        public Quarto(int id, DateTime entrada, DateTime saida)
        {
            if (entrada > saida)
            {
                throw new DominioException("ERROR , entrada e maior que saida");
            }
            Id = id;
            Entrada = entrada;
            Saida = saida;
        }

        public int Id { get; private set; }
        public DateTime Entrada { get; private set; }
        public DateTime Saida{ get; private set; }
        public int Duracao()
        {
            TimeSpan duracao = Saida.Subtract(Entrada);
            return duracao.Days;
        }
        public void UpadateDates(DateTime entrada,DateTime saida)
        {
            DateTime now = DateTime.Now;
            if(entrada < now || saida < now)
            {
                throw new DominioException("ERROR :A entrada ou saida e menor que a hora atual");
            }
            if (entrada > saida)
            {
                throw new DominioException("ERROR , entrada e maior que saida");
            }
            Entrada = entrada;
            Saida = saida;
        }
        public override string ToString()
        {
            return $"O quarto {Id}, teve a entrada :{Entrada.ToString("dd/MM/yyyy")}, ea saida :{Saida.ToString("dd/MM/yyyy")}, {Duracao()} dias totais.";
        } 
    }
}
