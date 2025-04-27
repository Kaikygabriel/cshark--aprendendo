using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GerenciadorTarefaPOO.Entity.EnumPasta;

namespace GerenciadorTarefaPOO.Entity
{
    sealed class TarefaPrioritaria : Tarefa
    {
        public TarefaPrioritaria() { }
       public TarefaPrioritaria(DateTime prazo,string nome,string descricao,Status status): base(descricao,nome,status)
        {
            Prazo = prazo;
        }

        public DateTime  Prazo {  get; set; }
        public override void Exibir()
        {
            Console.WriteLine($"A tarefa {Nome} tem a descrição de : {Descricao}, eo status {status}, com o prazo de {Prazo.ToString()}");
        }
    }
}
