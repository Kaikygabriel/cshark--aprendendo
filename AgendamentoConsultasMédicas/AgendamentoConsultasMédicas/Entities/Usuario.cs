using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlibiotecaSistemaa.Entities.Exception;

namespace BlibiotecaSistemaa.Entities
{
    internal sealed class Usuario
    {
        public Usuario() { }
        public Usuario(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; private set; }
        public string Id { get; private set; } = Guid.NewGuid().ToString()[..8];
        public override string ToString()
        {
            return $"{Nome} -- {Id}";
        }
        public override bool Equals(object? obj)
        {
            if (!(obj is Usuario))
                throw new DominoException("ERROR");
            Usuario other = (Usuario)obj;
            return Nome.Equals(other.Nome);
        }
        public override int GetHashCode()
        {
            return Nome.GetHashCode();
        }
    }
}
