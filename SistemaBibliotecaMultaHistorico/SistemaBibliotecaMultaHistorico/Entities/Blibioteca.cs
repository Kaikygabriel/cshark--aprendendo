using SistemaBlibiotecaMulta.Entities.ExceptionEntities;
using SistemaBlibiotecaMulta.Service;
using SistemaBlibiotecaMulta.Service.Interfaces;

namespace SistemaBlibiotecaMulta.Entities;

public class Blibioteca
{
    public Blibioteca(){}

    public Blibioteca(IServiceRepositoryLivro serviceRepositoryLivro)
    {
        RepositoryLivro = serviceRepositoryLivro;
    }
    public IServiceRepositoryLivro RepositoryLivro { get; set; }
    public List<Livro> Livros { get; set; }= new List<Livro>();
    public List<Emprestimo> Emprestimos { get;private set; }= new List<Emprestimo>();

    public void AddEmprestimio(Emprestimo emprestimo)
    {
        Emprestimos.Add(emprestimo);
    }

    public void AddLivro(Livro livro)
    {
        Livros.Add(livro);
        RepositoryLivro.AddRepositoryLivro(livro,@"C:\Users\kaiky\Downloads\Livros.csv");
    }
   
}