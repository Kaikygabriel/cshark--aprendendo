using SistemaBlibiotecaMulta.Entities;

namespace SistemaBlibiotecaMulta.Service.Interfaces;

public interface IServiceEmprestimo
{
    public void AddEmprestimo(Livro livro, Usuario usuario, DateTime inicio, DateTime fim, Blibioteca blibioteca);
}