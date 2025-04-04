using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeBlibiotecaw
{
    internal class Blibioteca
    {
        public static List<Usuario> usuarios;
        public static  List<Livro> livros;
        public static void AdicionarLivros()
        {
            Livro.AdicionarLivro();
        }
        public static  void Removerlivro()
        {
            Livro.RemoverLivro();
        }
       
    }
}
