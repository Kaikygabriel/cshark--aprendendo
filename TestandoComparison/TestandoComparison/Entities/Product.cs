using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace TestandoComparison.Entities
{
    internal class Product
    {
        public Product() { }

        public Product(string nome, double price)
        {
            Nome = nome;
            Price = price;
        }

        public string Nome { get; private set; }
        public double Price { get; private set; }

        public override string ToString()
        {
            return $"{Nome} -- R${Price.ToString("F2")}";
        }
       
    }
}
