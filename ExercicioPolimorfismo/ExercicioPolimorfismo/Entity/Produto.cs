using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPolimorfismo.Entity
{
    internal class Produto
    {

        public Produto() { }

        public Produto(string nome, double valor)
        {
            Nome = nome;
            Valor = valor;
        }

        public string Nome { get;private protected set; }
        public double Valor { get; private protected set; }
        public virtual string Etiqueta()
        {
            return $"{Nome} R${Valor}";
        }
    }
}
