using StoreWithPagamentOOP.Service;

namespace StoreWithPagamentOOP.Entites;

public class Carrinho
{
    public Carrinho(){}

    public Carrinho(Client cliente)
    {
        Cliente = cliente;
    }
    private List<Product> _products = new List<Product>();
    public Client Cliente { get;private set; }
    public decimal TotalsProducts => _products.Sum(x => x.GetTotalPrice());

    public void AddProducts(Product product)
        => _products.Add(product);

    public void Pagar(IPagamentService pagament,IEmailService emailService)
        => pagament.Pagar(TotalsProducts,Cliente,emailService);
    
}