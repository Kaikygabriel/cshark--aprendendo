using SistemaBlibiotecaMulta.Entities;
using SistemaBlibiotecaMulta.Service.Interfaces;

namespace SistemaBlibiotecaMulta.Service;

public class ServiceRepositoryLivroTxt : IServiceRepositoryLivro
{
    public void AddRepositoryLivro(Livro livro,string path)
    {
        using (StreamWriter sw = File.AppendText(path))
        {
            sw.WriteLine($"{livro.Titulo},{livro.Autor},{livro.Disponivel}");
        }
    }
}