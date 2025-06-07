using ProjectGerenciadorDescontoOOP.Entities;
using ProjectGerenciadorDescontoOOP.Service.Contracts;

namespace ProjectGerenciadorDescontoOOP.Service;

public class PriceDiscountService : IDiscount
{
    public double AplicarDesconto(Client client, double priceTotals)
    {
        if (priceTotals >= 200)
            return 0.10;
        return 0;
    }
}