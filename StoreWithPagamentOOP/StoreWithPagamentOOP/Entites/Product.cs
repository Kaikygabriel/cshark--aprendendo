using System.Globalization;

namespace StoreWithPagamentOOP.Entites;

public class Product
{
    public Product(){}

    public Product(string name,int quantity, decimal price)
    {
        if (price < 0 || quantity < 0 || name.Length < 1)
            throw new Exception("Error , may have zero in some of the parameters ");
        Name = name;
        Price = price;
        Quantity = quantity;
    }

    public int Quantity { get;private set; }
    public string Name { get;private set; }
    public decimal Price { get;private set; }

    public override string ToString()
        => $"{Name} -- {Price.ToString("C",CultureInfo.CreateSpecificCulture("pt-BR"))}";

    public decimal GetTotalPrice()
        => Quantity * Price;
}