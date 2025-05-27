using System;


namespace SistemaLojaVirtual.Entities
{
    internal abstract class  Produto
    {
        protected Produto() { }
        public Produto(string nome,double price)
        {
            Nome = nome;
            Price = price;
        }
        public string Nome { get;private set; }
        public double Price { get;private set; }

    }
}
