using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leilao.Entity
{
    internal abstract class Item
    {
        protected Item() { }

                
        protected Item(int id, string nome, string descricao, double valor)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            Valor = valor;
        }

        protected double Valor{ get; private protected set; }
        protected int Id { get; private protected set; }
        protected string Nome { get; private protected set; }
        protected string Descricao { get; private protected set; }
        public abstract double ValorTotal();
    }
}
