using System;
using System.ComponentModel;

namespace OperacaoLinq.Entities
{
    internal class Produto
    {
        public Produto() { }

        public Produto(string nome, int id, double price, Category categoria)
        {
            Nome = nome;
            Id = id;
            Price = price;
            Categoria = categoria;
        }

        public string Nome { get;set; }
        public int Id { get; set; }
        public  double Price{ get; set; }
        public Category Categoria{ get; set; }

        public override string ToString()
        {
            return $"Produto \n NOme {Nome},Id {Id}, Price R${Price.ToString("F2")}";
        }
    }
}
