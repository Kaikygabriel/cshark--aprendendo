using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaReservaCancelamento.Entities
{
    internal class Usuario
    {
        public Usuario() { }

        public Usuario(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; private set; }
        public string Id { get; private set; } = Guid.NewGuid().ToString().ToUpper().ToLower()[..8];

        public override string ToString()
        {
            return $"{Nome} -- {Id}";
        }

    }
}
