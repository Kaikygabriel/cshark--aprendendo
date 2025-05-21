using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListSortHash.Entities
{
    internal sealed class Produto
    {
        public string Name { get; private set; } = string.Empty;
        public double Price { get; private set; }

        public Produto(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public override string ToString()
        {
            return $"{Name} - R${Price.ToString("F2", CultureInfo.InvariantCulture)}";
        }
        public override bool Equals(object? obj)
        {
            if (!(obj is Produto))
                throw new Exception("ERROR");
            Produto outro = (Produto)obj;
            return Name.Equals(outro.Name) && Price.Equals(outro.Price);
        }
        public override int GetHashCode()
        {
            return Name.GetHashCode() + Price.GetHashCode();
        }
    }
}
