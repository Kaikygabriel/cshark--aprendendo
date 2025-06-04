using SistemaBlibiotecaMulta.Entities.ExceptionEntities;

namespace SistemaBlibiotecaMulta.Entities;

public class Usuario
{
    public Usuario(){}

    public Usuario(string name)
    {
        Name = name;
    }
    public string Name { get; private set; }
    public string Id { get; private set; } = Guid.NewGuid().ToString()[..8];

    public override string ToString()
        => $"{Name} -- Id {Id}";

    public override int GetHashCode()
        => Id.GetHashCode();

    public override bool Equals(object? obj)
    {
        if (!(obj is Usuario))
            throw new DominioException("Error obj is no type usuario");
        var other = obj as Usuario;
        return Name.Equals(other.Name);
    }
}