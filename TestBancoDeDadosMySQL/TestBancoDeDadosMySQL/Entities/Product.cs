using System.Globalization;

namespace TestBancoDeDadosMySQL.Entities;

public class Product
{
    public Product(){}

    public Product(string name, decimal price,int id)
    {
        Name = name;
        Price = price;
        Id = Id;
    }
    public int Id { get; set; }              // 🔑 EF reconhece isso como chave primária automaticamente

    public string Name { get;private set; }
    public decimal Price { get;private set; }
    public override string ToString()
        => $"Product : {Name} -- {Price.ToString("c",CultureInfo.CreateSpecificCulture("pt-BR"))}";
    
}