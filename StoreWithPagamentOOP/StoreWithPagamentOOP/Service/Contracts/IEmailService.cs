using StoreWithPagamentOOP.Entites;

namespace StoreWithPagamentOOP.Service;

public interface IEmailService
{
    void EnviarEmail(Client client);
}