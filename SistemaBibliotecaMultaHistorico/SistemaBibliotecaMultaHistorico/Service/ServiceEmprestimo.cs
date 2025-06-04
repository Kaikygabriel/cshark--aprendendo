using SistemaBlibiotecaMulta.Entities;
using SistemaBlibiotecaMulta.Service.Interfaces;

namespace SistemaBlibiotecaMulta.Service;

public class ServiceEmprestimo : IServiceEmprestimo
{
    public void AddEmprestimo(Livro livro,Usuario usuario,DateTime inicio,DateTime fim,Blibioteca blibioteca)
    {
        if (blibioteca.Emprestimos.Exists(x => x.LivroE.Equals(livro) && x.UsuarioE.Name.Equals(usuario.Name)))
            throw new Exception("Ja existe esse emprestimo.");
        
        blibioteca.AddEmprestimio(new Emprestimo(usuario,livro,inicio,fim));
    }
}