namespace SistemaBlibiotecaMulta.Entities;

public class Emprestimo
{
    public Emprestimo(){}

    public Emprestimo(Usuario usuarioE, Livro livroE, DateTime dataEmprestimo, DateTime dataDevolucao)
    {
        LivroE = livroE;
        LivroE.Emprestar();
        
        UsuarioE = usuarioE;
        DataEmprestimo = dataEmprestimo;
        DataDevolucao = dataDevolucao;
    }

    public Usuario UsuarioE { get;private set; }
    public Livro LivroE { get;private set; }
    public DateTime DataEmprestimo { get;private set; }
    public DateTime DataDevolucao{ get;private set; }

    public override string ToString()
        => $"{UsuarioE}\n{LivroE}\nInicio {DataEmprestimo.ToString("dd/MM/yyyy")}, Devolução {DataDevolucao.ToString("dd/MM/yyyy")}";
}