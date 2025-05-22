using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanchonete.Entities
{
    internal class Cliente
    {
        public Cliente() { }

        public Cliente(string nome)
        {
            Nome = nome;
        }

        public string Nome{ get; private set; } = string.Empty;
        public string Id { get; private set; } = Guid.NewGuid().ToString()[..8];
    }
}
