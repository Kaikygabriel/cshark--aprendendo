using System;
using GerenciadorCinema.Entities.Exceptions;

namespace GerenciadorCinema.Entities;

public class Sessao
{
    public Sessao()
    {
    }

    public Sessao(Filme filme, Sala sala, DateTime horario)
    {
        if (horario < DateTime.Now)
            throw new DominioException("Error horario é menor que horario atual");
        Filme = filme;
        Sala = sala;
        Horario = horario;
    }

    public Filme Filme { get; private set; }
    public Sala Sala { get; private set; }
    public DateTime Horario { get; private set; }
    public List<Client> Clients { get; private set; } = new List<Client>();

    public void AddClients(Client client)
        => Clients.Add(client);

    public void RemoveClients(Client client)
    {
        if (!Clients.Exists(x => x.Nome == client.Nome))
            throw new DominioException("Não existe o cliente");
        Clients.Remove(client);
    }
}