using System;
using System.Collections.Generic;
using BlibiotecaSistemaa.Entities;

namespace BlibiotecaSistemaa.Service
{
    internal sealed class BlibiotecaService
    {
        public List<ReservaLivro> reservaLivroList { get; private set; } =new List<ReservaLivro>();
        public void Emprestar(Livros livro, Usuario usuario)
        {
            reservaLivroList.Add(new ReservaLivro(usuario,livro));
        }
        public void GetList()
        {
            foreach(var item in reservaLivroList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
