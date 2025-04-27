using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GerenciadorTarefaPOO.Entity.EnumPasta;

namespace GerenciadorTarefaPOO.Entity
{
    internal class Tarefa
    {
        public Tarefa() { }

        public Tarefa(string descricao, string nome, Status status)
        {
            Descricao = descricao;
            Nome = nome;
            this.status = status;
        }

        public string Descricao { get; set; }
        public  string Nome { get; set; }
        public Status status { get; set; }
        public void Concluir()
        {
            status = Status.Concluida;
            Console.WriteLine($"A tarefa {Nome} foi concluida");
        }
        public virtual void Exibir()
        {
            Console.WriteLine($"A tarefa {Nome} tem a descrição de : {Descricao}, eo status {status}");
        }
    }
}
