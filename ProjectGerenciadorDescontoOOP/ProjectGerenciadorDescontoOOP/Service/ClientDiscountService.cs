using ProjectGerenciadorDescontoOOP.Entities;
using ProjectGerenciadorDescontoOOP.Entities.Enum;
using ProjectGerenciadorDescontoOOP.Service.Contracts;

namespace ProjectGerenciadorDescontoOOP.Service;

public class ClientDiscountService : IDiscount
{
    public double AplicarDesconto(Client client, double priceTotals)
    {
        if(client.Type == ETypeClient.Vip)
            return 0.15;
        return 0;
    }
}