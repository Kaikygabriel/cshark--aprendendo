namespace ProjectGerenciadorDescontoOOP.Entities;

public class Produtos
{
    public Produtos(){}

    public Produtos(double price, string name)
    {
        Price = price;
        Name = name;
    }

    public double Price { get;private set; }
    public string Name { get;private set; }

    public override string ToString()
        => $"Produto : Name {Name} , price R${Price.ToString("F2")}";

    public override int GetHashCode()
        => Name.GetHashCode();
}