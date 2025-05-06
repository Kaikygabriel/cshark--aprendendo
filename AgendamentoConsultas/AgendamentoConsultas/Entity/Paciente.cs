using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendamentoConsultas.Entity
{
    internal sealed class Paciente : Pessoa
    {
        public Paciente() { }
        public Paciente(int myProperty, int id, string nome)
            : base(nome)
        {
            MyProperty = myProperty;
            Id = id;
        }

        public int MyProperty { get; set; }
        public int Id { get; private set; }
        public List<Agenda> agendas { get; set; } = new List<Agenda>();
        public override void Exibir()
        {
            Console.WriteLine($"O paciente {Nome} tem o id de {Id}");
        }
        public void AdicionarAgenda()
        {
            //colocar algo
        }
        public void RemoverAgenda()
        {
            //colocar algo
        }
    }
}
