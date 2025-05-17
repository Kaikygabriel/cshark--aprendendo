using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Generics2.Entity
{
    internal sealed class Produto : IComparable
    {
        public Produto() { }

        public Produto(double price, string nome)
        {
            Price = price;
            Nome = nome;
        }

        public double Price { get;private  set; }
        public string Nome{ get; private set; } = string.Empty;

        public int CompareTo(object? obj)
        {
            if(!(obj is Produto))
            {
                throw new Exception("ERROR não e do mesmo tipo");
            }
            Produto produto = (Produto)obj;
            return Price.CompareTo(produto.Price);
        }
        
        public override string ToString()
        {
            return $"{Nome} -- R${Price}";
        }
    }
}
