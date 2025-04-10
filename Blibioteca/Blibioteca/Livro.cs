using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blibioteca
{
    internal class Livro
    {
        public string nome { get; private set; }
        public string autor { get; private set; }
        public Livro(string nome, string autor)
        {
            this.nome = nome;
            this.autor = autor;
        }
    }
}
