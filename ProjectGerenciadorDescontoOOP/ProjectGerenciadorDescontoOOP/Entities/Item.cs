namespace ProjectGerenciadorDescontoOOP.Entities;

public class Item
{
    public Item(){}

    public Item(int quantity, Produtos product)
    {
        Quantity = quantity;
        Product = product;
    }

    public  int Quantity { get;private set; }
    public Produtos Product { get;private set; }

    public override string ToString()
        => $"Item:\n{Product}\n Quantity {Quantity}\n======";
}