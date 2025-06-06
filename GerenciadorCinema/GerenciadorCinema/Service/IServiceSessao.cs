using GerenciadorCinema.Entities;

namespace GerenciadorCinema.Service;

public interface IServiceSessao
{
    void IniciarSessao(Sessao sesao, Client client);
}