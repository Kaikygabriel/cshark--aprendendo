using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeLogs.Entity
{
    internal class Usuario
    {
        public Usuario() { }
        public Usuario(string nome) 
        {
            Nome = nome;
            Id = Guid.NewGuid().ToString().Substring(0,8);
        }
        public string Nome { get; private set; }
        public string Id { get; private set; }

        public override string ToString()
        {
            return $"{Nome} -- {Id}"; 
        }
    }
}
