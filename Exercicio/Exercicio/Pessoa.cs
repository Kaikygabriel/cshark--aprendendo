using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    internal class Pessoa
    {
        public string nome;
        public int idade;
        public Pessoa(string nome,  int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }
        public static void Contar(Pessoa p1, Pessoa p2)
        {
            if(p1.idade > p2.idade)
            {
                Console.WriteLine($"A {p1.nome} e mais velha");
            }
            else
            {
                Console.WriteLine($"A {p2.nome} e mais velha");

            }

        }
    }
}
