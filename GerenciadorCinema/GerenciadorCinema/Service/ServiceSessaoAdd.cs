using GerenciadorCinema.Entities;

namespace GerenciadorCinema.Service;

public class ServiceSessaoAdd : IServiceSessao
{
    public void IniciarSessao(Sessao sesao, Client client)
    {
        sesao.AddClients(client);
        client.Sessoes.Add(sesao);
    }
}