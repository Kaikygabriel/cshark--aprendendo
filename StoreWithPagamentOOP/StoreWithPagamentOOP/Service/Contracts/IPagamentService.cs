using StoreWithPagamentOOP.Entites;

namespace StoreWithPagamentOOP.Service;

public interface IPagamentService
{
    void Pagar(decimal value, Client client, IEmailService emailService);
}