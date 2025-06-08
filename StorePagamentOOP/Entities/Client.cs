namespace StorePagamentOOP;

public class Client
{
    public Client(){}

    public Client(string name, decimal price)
    {
        Price= price;
        Name = name;
    }
    public decimal Price { get;private set; }
    public string Name { get;private set; }
    
    public override string ToString()
    => $"{Name} -- {Price.ToString()}"
}