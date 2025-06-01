using System;

namespace OperacaoLinq.Entities
{
    internal class Category
    {
        public Category() { }

        public Category(int id, string nome, int tier)
        {
            Id = id;
            Nome = nome;
            Tier = tier;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public int Tier { get; set; }

        public override string ToString()
        {
            return $"CAtegory\nNome : {Nome} , id : {Id} , Tier {Tier}";
        }
    }
}
