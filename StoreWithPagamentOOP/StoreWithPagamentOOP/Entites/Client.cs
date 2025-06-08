using System.Globalization;
using StoreWithPagamentOOP.Entites.Enum;

namespace StoreWithPagamentOOP.Entites;

public class Client
{
    public Client(){}

    public Client(string name,ETypeClient typeclient,string email, decimal price)
    {
        typeclient = typeclient;
        Price= price;
        Name = name;
        Email = email;
    }

    public ETypeClient TypeClient { get;private  set; }
    public decimal Price { get;private set; }
    public string Name { get;private set; }
    public string Email { get;private set; }

    public override int GetHashCode()
        => Name.GetHashCode();

    public override bool Equals(object? obj)
    {
        if (!(obj is Client))
            throw new Exception("Error ,param not is type client");
        var other = obj as Client;
        return Name.Equals(other.Name);
    }
    
    public static implicit  operator string(Client msg)
        => $"{msg.Name} -- {msg.TypeClient}-- {msg.Price.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"))}";

}