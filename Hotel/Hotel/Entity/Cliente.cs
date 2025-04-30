using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Entity
{
    internal class Cliente
    {
        public Cliente() { }

        public Cliente(string nome, string rg)
        {
            Nome = nome;
            Rg = rg;
        }

        public string Nome { get; private set; }
        public string Rg{ get; private set; }
    }
}
