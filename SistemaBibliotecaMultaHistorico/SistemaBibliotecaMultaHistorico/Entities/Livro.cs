namespace SistemaBlibiotecaMulta.Entities;

public class Livro
{
    public Livro(){}
    public Livro(string titulo, string autor,bool disponivel)
    {
        Titulo = titulo;
        Autor = autor;
        Disponivel = disponivel;
    }
    public string Titulo { get;private set; }
    public string Autor { get;private set; }
    public bool Disponivel { get;private set; }

    public override string ToString()
        => $"Titulo : {Titulo} , Autor: {Autor},{(Disponivel?"Disponivel" : "não esta Disponivel")}";

    public override int GetHashCode()
        => Titulo.GetHashCode();

    
    public void DeixarDisponivel()
        => Disponivel = true;
    
    public void Emprestar()
        => Disponivel = false;
}