namespace GerenciadorCinema.Entities;

public class Filme
{
     public Filme(){}

     public Filme(string titulo, TimeSpan duracao)
     {
          Titulo = titulo;
          Duracao = duracao;
     }

     public string Titulo { get;private set; }
     public TimeSpan Duracao{ get;private set; }

     public override string ToString() 
          => $"Titulo {Titulo} Duration{Duracao}";
}