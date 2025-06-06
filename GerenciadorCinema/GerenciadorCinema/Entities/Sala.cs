namespace GerenciadorCinema.Entities;

public class Sala
{
    public Sala(){}

    public Sala(int number, int capacidade)
    {
        Number = number;
        Capacidade = capacidade;
    }

    public int Number { get; private set; }
    public int Capacidade { get; private set; }

    public override string ToString()
        => $"Sala Number {Number} -- Capacidade {Capacidade}";
}