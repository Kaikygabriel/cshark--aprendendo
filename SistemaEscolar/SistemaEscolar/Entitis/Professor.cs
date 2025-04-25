using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscolar.Entitis
{
    internal class Professor : Usuario 
    {
        public Professor() { }

        public Professor(string rg,string nome, int idade):base(nome, idade) 
        {
            Rg = rg;
        }

        public string Rg { get;protected set; }
        public override void Apresentar()
        {
            base.Apresentar();
            Console.WriteLine($", eo rg do professor é {Rg}");
        }
    }
}
