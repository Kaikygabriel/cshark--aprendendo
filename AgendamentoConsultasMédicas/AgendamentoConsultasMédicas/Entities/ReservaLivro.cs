using System;
using System.Collections.Generic;
using System.Text;
using BlibiotecaSistemaa.Entities.Exception;

namespace BlibiotecaSistemaa.Entities
{
    internal sealed class ReservaLivro
    {
        public ReservaLivro() { }

        public ReservaLivro(Usuario usuario, Livros livro)
        {
            if (!livro.Disponilidade)
                throw new DominoException("error , livro não disponivel");
            Usuario = usuario;
            Livro = livro;
            livro.Disponilidade = false;
        }

        public Usuario Usuario { get;private set; }
        public Livros Livro { get; private set; } 
        public override string ToString()
        {
            return $"O usuario : {Usuario}\nPegou emprestado o livro :\n{Livro}";
        }
    }
}
