using CarrinhoEstoque.Entites.ExcptionsEntities;

namespace CarrinhoEstoque.Entites;

public class Cliente
{
    public Cliente(){}

    public Cliente(string name)
    {
        if(name.Length < 0)
            throw new DominioException("Error name lenght  not equals zero");
        Name = name;
    }

    public string Name { get;private set; }
    public string Id { get; private set; } = Guid.NewGuid().ToString()[..8];

    public override string ToString()
        => $"Client name : {Name} - Id : {Id}";
}