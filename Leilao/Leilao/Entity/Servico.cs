using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leilao.Entity
{
    internal sealed class Servico : Item
    {
        public Servico() { }    
        public Servico(TimeSpan horas,  string nome, string descricao, double valor) :base(nome,descricao,valor) 
        {
            Horas = horas;
        }
        public TimeSpan Horas { get; private set; }
        public override double ValorTotal()
        {
            return double.Parse(Horas.Hours.ToString()) * Valor;
        }
    }
}
