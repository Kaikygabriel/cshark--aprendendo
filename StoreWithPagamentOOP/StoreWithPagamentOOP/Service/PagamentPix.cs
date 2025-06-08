using System.Globalization;
using StoreWithPagamentOOP.Entites;

namespace StoreWithPagamentOOP.Service;

public class PagamentPix : IPagamentService
{
    public void Pagar(decimal value,Client client,IEmailService emailService)
    {
        Console.WriteLine($"Pagou valor no pix --- {value.ToString("C",CultureInfo.CreateSpecificCulture("pt-BR"))}");
        emailService.EnviarEmail(client);
    }
}