using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioHash.Entitie
{
    internal class Usuario
    {
        public Usuario() { }
        public Usuario(string name,DateTime data)
        {
            Name = name;
            Data = data;
        }
        public Usuario(string ms)
        {
            string[]vect = ms.Split(' ');
            Name = vect[0];
            Data = DateTime.Parse(vect[1]);
        }


        public string Name { get; private set; } = string.Empty;
        public DateTime Data { get; private set; } 

        public override string ToString()
        {
            return $"{Name} -- {Data.ToString("dd-MM-yyyyThh-mm-ss")}";
        }
        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
        public override bool Equals(object? obj)
        {
            if (!(obj is Usuario))
                throw new Exception("err");
            Usuario other = (Usuario)obj;
            return Name.Equals(other.Name);
        }
    }
}
