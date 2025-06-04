using SistemaBlibiotecaMulta.Entities;

namespace SistemaBlibiotecaMulta.Service.Interfaces;

public interface IServiceRepositoryLivro
{
    public void AddRepositoryLivro(Livro livro,string path);
}