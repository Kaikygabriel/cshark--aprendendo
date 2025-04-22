using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarefasExerciciosChat.Model.Enum;

namespace TarefasExerciciosChat.Model
{
    internal class Tarefa
    {
        public Tarefa() { }

        public Tarefa(string titulo, string descricao)
        {
            Titulo = titulo;
            Descricao = descricao;
            StatusTarefa = Status.Pendente;
        }

        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public Status StatusTarefa { get;private set; }

        public override string ToString()
        {
            return $"A tarefaf {Titulo}, tem a descrição : {Descricao}, Eo status de {StatusTarefa}";
        }
        public void ConcluirTarefa()
        {
            if (StatusTarefa == Status.Pendente)
            {
                StatusTarefa = Status.Concluida;
            }
        }
    }
}


            