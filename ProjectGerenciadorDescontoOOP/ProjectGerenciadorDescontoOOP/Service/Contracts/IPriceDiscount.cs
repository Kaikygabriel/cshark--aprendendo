using ProjectGerenciadorDescontoOOP.Entities;

namespace ProjectGerenciadorDescontoOOP.Service.Contracts;

public interface IDiscount
{
    public double AplicarDesconto(Client client,double priceTotals);
}