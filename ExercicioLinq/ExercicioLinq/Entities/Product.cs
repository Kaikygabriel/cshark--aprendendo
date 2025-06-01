using System;

namespace ExercicioLinq.Entities
{
    internal class Product
    {
        public Product() { }

        public Product(string Line)
        {
            string[]vect= Line.Split(',');
            if (vect.Length < 0)
                throw new ArgumentException("Error constructor product");
            Name = vect[0];
            Price = double.Parse(vect[1]);
        }

        public string Name { get; protected set; }
        public double Price{ get; protected set; }

        public override string ToString() => $"{Name} -- R${Price.ToString("F2")}";

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
}
