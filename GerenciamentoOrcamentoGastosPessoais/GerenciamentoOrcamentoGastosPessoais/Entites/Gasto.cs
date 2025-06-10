using GerenciamentoOrcamentoGastosPessoais.Entites.CategoriaGasto;

namespace GerenciamentoOrcamentoGastosPessoais.Entites;

public class Gasto
{
    public Gasto(){}

    public Gasto(string nome, decimal price, EGastoType typeGasto)
    {
        Nome = nome;
        Price = price;
        TypeGasto = typeGasto;
    }

    public string Nome { get;private set; }
    public decimal Price{ get;private set; }
    public EGastoType TypeGasto { get;private set; }

    public override string ToString()
        => $"{Nome},{Price},{TypeGasto}";
}