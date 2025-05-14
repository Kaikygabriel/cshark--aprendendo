using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ProcessadorDePagamento.Entity
{
    internal class Pessoa
    {
        public Pessoa() { }

        public Pessoa(string nome, Conta contaBanco)
        {
            Nome = nome;
            ContaBanco = contaBanco;
        }

        public string Nome { get;private set; }
        public Conta ContaBanco { get; private set; }

        
    }
}
