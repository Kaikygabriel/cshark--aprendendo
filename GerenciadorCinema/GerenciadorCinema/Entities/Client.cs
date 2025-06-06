using System.Net.Http.Json;
using GerenciadorCinema.Entities.Exceptions;

namespace GerenciadorCinema.Entities;

public class Client 
{
     public Client(){}

     public Client(string nome)
     {
          Nome = nome;
     }

     public string Nome { get; set; }
     public string Id { get; private set; } = Guid.NewGuid().ToString()[..8];
     public List<Sessao> Sessoes { get; set; } = new List<Sessao>();

     public override int GetHashCode()
     {
          return Nome.GetHashCode();
     }

     public override bool Equals(object? obj)
     {
          if (!(obj is Client))
               throw new DominioException("error");
          Client other = obj as Client;
          return Nome.Equals(other.Nome);
     }

     public override string ToString()
          => $"{Nome} -- id {Id}";
}