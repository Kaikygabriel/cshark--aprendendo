using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Exerciciohash2.Entities
{
    internal sealed class Usuario
    {
        Usuario() { }

        public Usuario(string linha)
        {
            string[] vect = linha.Split(' ');
            Name = vect[0];
            Data = DateTime.Parse(vect[1]);
        }

        public string Name { get; private set; } = string.Empty;
        public DateTime Data { get; private set; }

        public override string ToString()
        {
            return $"{Name} -- {Data}";
        }
        public override bool Equals(object? obj)
        {
            if (!(obj is Usuario))
                throw new Exception("ERROR");
            Usuario other = (Usuario)obj;
            return Name.Equals(other.Name);
        }
        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
}
