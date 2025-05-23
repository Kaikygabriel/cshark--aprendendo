using System;
using System.Collections.Generic;
using System.Text;

namespace BlibiotecaSistemaa.Entities
{
    internal sealed class Livros
    {
        public Livros() { }

        public Livros(string titulo, string autor)
        {
            Titulo = titulo;
            Autor = autor;
        }

        public string Titulo { get; private set; }
        public string Autor { get; private set; }
        public bool Disponilidade { get; set; } = true;
        public override string ToString()
        {
            return $"Autor :{Autor} -- Obra :{Titulo}";
        }
    }
}
