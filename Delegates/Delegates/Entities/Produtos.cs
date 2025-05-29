using System;
using System.Collections.Generic;

namespace Delegates.Entities
{
    internal class Produtos
    {
        public Produtos() { }

        public Produtos(string nome, double valor)
        {
            Nome = nome;
            Valor = valor;
        }

        public string Nome { get; set; }
        public double Valor { get; set; }
        public override string ToString()
        {
            return $"{Nome} -- R${Valor}"; 
        }
    }
}
