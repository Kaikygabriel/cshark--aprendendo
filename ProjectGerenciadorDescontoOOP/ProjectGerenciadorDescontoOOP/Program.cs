using ProjectGerenciadorDescontoOOP.Entities;
using ProjectGerenciadorDescontoOOP.Entities.Enum;
using ProjectGerenciadorDescontoOOP.Service;

namespace ProjectGerenciadorDescontoOOP;

public class Program
{
    public static void Main()
    {
        Item items = new Item(1, new Produtos(20, "Caderno Fibra"));
        Client kaiky = new Client(ETypeClient.Vip, "kaiky");
        Pedido pedidoCaderno = new Pedido(kaiky);
        
        pedidoCaderno.Items.Add(items);
        
        var totalprice =pedidoCaderno.GetTotalItems(new ClientDiscountService(), new PriceDiscountService());
        
        Console.WriteLine(totalprice);
    }
}

