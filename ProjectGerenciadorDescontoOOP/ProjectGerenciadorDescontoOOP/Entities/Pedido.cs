using ProjectGerenciadorDescontoOOP.Entities.Exceptions;
using ProjectGerenciadorDescontoOOP.Service.Contracts;

namespace ProjectGerenciadorDescontoOOP.Entities;

public class Pedido
{
    public Pedido(Client client)
        => Cliente = client;
    public List<Item> Items { get; set; } = new List<Item>();
    public Client Cliente{ get;private set; }

    public double GetTotalItems(params IDiscount[] descount)
    {
        
        if (Items.Count < 0)
            throw new DominioException("Error, items collection count is zero");
        var totalPriceItems = Items.Sum(x => x.Product.Price * x.Quantity);
        foreach (var d in descount)
        {
            totalPriceItems = totalPriceItems -(totalPriceItems * d.AplicarDesconto(Cliente,totalPriceItems));
        }
        return totalPriceItems;
    }
    
}