namespace SistemaControleProjetos1.Entities;

public class Usuario
{
    public Usuario(){}

    public Usuario(string nome, string email)
    {
        Nome = nome;
        Email = email;
    }
    
    public  string Nome{ get;private set; }
    public string Email { get;private set; }

    public override string ToString()
        => $"{Nome} -- {Email}";
    
}