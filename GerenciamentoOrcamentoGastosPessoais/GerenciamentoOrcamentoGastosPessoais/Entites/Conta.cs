using System.Globalization;
using GerenciamentoOrcamentoGastosPessoais.Entites.Exceptions;

namespace GerenciamentoOrcamentoGastosPessoais.Entites;

public class Conta
{
    public Conta(){}

    public Conta(decimal price, string name)
    {
        Price = price;
        Name = name;
    }

    public decimal Price { get;private set; }
    public string Id { get; private set; } = Guid.NewGuid().ToString("N")[..8];
    public string Name { get;private set; }

    public void AddPrice(decimal value)
    {
        if (!TestValue(value))
            throw new DominioException("Error ao adicionar valor ao price, value não atende as condições");
        Price += value;
    }
    public void RemovePrice(decimal value)
    {
        if (!TestValue(value))
            throw new DominioException("Error ao retirar valor do price, value não atende as condições");
        Price -= value;
    }

    bool TestValue(decimal value)
    {
        if (value > Price || value < 0)
            return false;
        return true;
    }
    public override string ToString()
        => $"{Name},{Id},{Price.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"))}";
}