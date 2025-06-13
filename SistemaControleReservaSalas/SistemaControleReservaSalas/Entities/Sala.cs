namespace SistemaControleReservaSalas.Entities;

public class Sala
{
    public Sala(){}

    public Sala(int numero, int capacidade)
    {
        Numero = numero;
        Capacidade = capacidade;
    }

    public int Numero { get;private set; }
    public int Capacidade { get;private set; }

    public string GetSala()
        => $"Sala numero {Numero} - capacidade {Capacidade}";
}