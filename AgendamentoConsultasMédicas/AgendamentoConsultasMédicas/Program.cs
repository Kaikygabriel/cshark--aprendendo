using BlibiotecaSistemaa.Entities;
using BlibiotecaSistemaa.Service;

namespace Blibioteca
{
    internal class Program
    {
        static void Main()
        {
            Usuario kaiky = new Usuario("kaiky");
            Livros livro = new Livros("Os segredos da mente milionaria", "carl jung");
            BlibiotecaService blibioteca = new BlibiotecaService();
            blibioteca.Emprestar(livro,kaiky);
            blibioteca.GetList();
        }
    }
}
