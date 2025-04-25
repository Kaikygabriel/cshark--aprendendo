using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscolar.Entitis
{
    internal class Aluno : Usuario
    {
        public Aluno() { }
        public Aluno(int id,string nome, int idade) : base(nome, idade) 
        {
            Id= id;
        }

        public int Id{  get;protected set; }
        public override void Apresentar()
        {
            base.Apresentar();
            Console.WriteLine($", eo id do aluno é {Id}");
        }
    }
}
