using System.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgendamentoConsultas.Entity.EnumsMedico; 

namespace AgendamentoConsultas.Entity
{
    internal sealed class Medico : Pessoa
    {
        public Medico() { }
        public Medico(EnumMedico especialidade, int crm,string nome)
            :base(nome)
        {
            Especialidade = especialidade;
            Crm = crm;
        }

        public  EnumMedico Especialidade{ get; private set; }
        public int Crm{ get; private set; }
        public override void Exibir()
        {
            Console.WriteLine($"O medico {Nome} tem o crm de {Crm} , ea especialidade em {Especialidade}.");
        }
    }
}
