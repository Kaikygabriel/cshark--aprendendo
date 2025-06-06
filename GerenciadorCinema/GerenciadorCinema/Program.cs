using GerenciadorCinema.Entities;

namespace  GerenciadorCinema;

public class Program
{
    static void Main()
    {
        
        Sessao transformers = new Sessao();
        Client kaiky = new Client("Kaiky");
        Client alves = new Client("alves");
        Client gabriel = new Client("gabriel");
        Client bob = new Client("Bob");

        transformers.AddClients(kaiky);
        transformers.AddClients(gabriel);
        transformers.AddClients(alves);
        transformers.RemoveClients(gabriel);
        foreach (var t in transformers.Clients)
        {
            Console.WriteLine(t);
        }
    }
}