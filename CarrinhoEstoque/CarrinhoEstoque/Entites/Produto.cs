namespace CarrinhoEstoque.Entites;

public class Produto
{
    public Produto(){}

    public Produto(string name, double price, int quantidade)
    {
        Name = name;
        Price = price;
        Quantidade = quantidade;
    }

    public string Name { get;private set; }
    public double Price { get;private set; }
    public int Quantidade { get;private set; }

    public override string ToString()
        => $"{Name} - R${Price.ToString("F2")} - Quantidade {Quantidade}";

    public override int GetHashCode()
        => Name.GetHashCode();
    
}