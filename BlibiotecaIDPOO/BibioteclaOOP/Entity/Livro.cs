using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System;
using BibioteclaOOP.Entity.InterfaceEntity;

namespace BibioteclaOOP.Entity
{
    internal sealed class Livro : IComparable,Ilivro
    {
        public Livro() { }

        public Livro(string autor, string titulo)
        {
            Autor = autor;
            Titulo = titulo;
        }

        public string Autor { get;  set; } = string.Empty;
        public string Titulo { get;  set; } = string.Empty;
        public string Id { get; private set; } = Guid.NewGuid().ToString()[0..8].ToUpper();

        public int CompareTo(object? obj)
        {
            if (!(obj is Livro))
            {
                throw new ArgumentException("O objeto de comparação não é do mesmo  tipo que livro");
            }
            Livro livro = (Livro)obj;
            return Titulo.CompareTo(livro.Titulo);
        }
        public override string ToString()
        {
            return $"Autor -{Autor}\nLivro -{Titulo}\nId - {Id}";
        }
    }
}