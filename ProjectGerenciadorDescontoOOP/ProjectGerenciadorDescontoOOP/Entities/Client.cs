using ProjectGerenciadorDescontoOOP.Entities.Enum;
using ProjectGerenciadorDescontoOOP.Entities.Exceptions;

namespace ProjectGerenciadorDescontoOOP.Entities;

public class Client
{
    public Client(){}

    public Client(ETypeClient type, string name)
    {
        if (name.Length < 0)
            throw new DominioException("Error, name lenght is zero");
        Type = type;
        Name = name;
    }

    public ETypeClient Type { get;private set; }
    public string Name  { get;private set; }
    public string Id { get; private set; } = Guid.NewGuid().ToString("N")[..10];

    public override string ToString()
        => $"{Name} -- id {Id} -- Type {Type}";

    public override int GetHashCode()
        => Id.GetHashCode();
}