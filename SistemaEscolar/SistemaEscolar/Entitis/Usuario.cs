using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscolar.Entitis
{
    internal class Usuario
    {
        public Usuario() { }
        public Usuario(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public string Nome { get;protected set; }
        public int Idade { get; protected set; }
        public virtual void Apresentar()
        {
            Console.Write($"Meu nome é {Nome} e tenho a idade de {Idade}");
        }
    }
}

