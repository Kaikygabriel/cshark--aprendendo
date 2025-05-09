using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeContatos.Entity
{
    internal class Pessoa
    {
        public Pessoa() { } 
        public Pessoa(string nome) 
        {
            Nome = nome;
        }
        public List<Contato> Contatos { get; private set; } = new List<Contato>();
        public string Nome{ get; private set; }
        public int Cont{ get; private set; }
        public void AdicionarContato()
        {
            Console.WriteLine("Tipo");

            Console.WriteLine("");
        }
    }
}
