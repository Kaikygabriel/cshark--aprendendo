using System.Globalization;

namespace StoreWithPagamentOOP.Service;

public class PagamentPix : IPagamentService
{
    public void Pagar(decimal value)
    {
        Console.WriteLine($"Pagou valor no pix --- {value.ToString("C",CultureInfo.CreateSpecificCulture("pt-BR"))}");
    }
}