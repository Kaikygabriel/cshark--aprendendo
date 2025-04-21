using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood.Entidades
{
    internal class Cliente
    {
        public string Nome { get; private set; }
        public Carrinho carrinho;
        public string Senha { get; private set; }
        public Cliente(string nome, string senha)
        {
            Nome = Nome;
            Senha = Senha;
        }
    }
}
