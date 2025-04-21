using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contrato.Entidade
{
    internal class Contrato
    {
        
        public DateTime Momento;
        public float ValorPorHora;
        public int Horas;
       
        public Contrato(DateTime momento, float valorPorHora, int horas)
        {
            Momento = momento;
            ValorPorHora = valorPorHora;
            Horas = horas;
        }
        public float ValorTotal()
        {
            return Horas * ValorPorHora;
        }
    }
}
