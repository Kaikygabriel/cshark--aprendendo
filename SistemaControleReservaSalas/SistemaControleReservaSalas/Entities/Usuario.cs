namespace SistemaControleReservaSalas.Entities;

public class Usuario
{
    public Usuario(){}

    public Usuario(string name)
    {
        Name = name;
    }

    public  string Name{ get;private set; }
    public string Id { get; private set; } = Guid.NewGuid().ToString()[..8];

    public override string ToString()
        => $"Usuario : {Name} - {Id}";

    public void MarcaReuniao()
    {
        
    }
}