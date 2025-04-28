using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPessoa.Entity
{
    internal  abstract class Pessoa
    {
        public Pessoa() { }

        public Pessoa(string nome, double renda)
        {
            Nome = nome;
            Renda = renda;
        }

        public string Nome { get; set; }
        public  double Renda{ get; set; }
        public abstract double ImpostoTotal();
    }
}
