using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace AgendamentoConsultas.Entity
{
    internal abstract class Pessoa
    {
        public Pessoa() { }

        public Pessoa(string nome)
        {
            Nome = nome;
          
        }

        public string Nome { get; private protected set; }
        public abstract void Exibir();
    }
}
