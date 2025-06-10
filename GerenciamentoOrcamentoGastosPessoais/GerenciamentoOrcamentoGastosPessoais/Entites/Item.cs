namespace GerenciamentoOrcamentoGastosPessoais.Entites;

public class Item
{
    public Item() { }

    public Item(Conta conta)
    {
        if (conta is null)
            throw new Exception("Error, conta is null");
        _conta = conta;
    }

    private Conta _conta;
    private List<Gasto> _gastos = new();

    public void AddGasto(Gasto gasto)
    {
        if (_gastos.Exists(x => x.Nome == gasto.Nome))
            throw new Exception("Error, exists gasto in list gastos");
        _conta.RemovePrice(gasto.Price);
        _gastos.Add(gasto);
    }

    public List<Gasto> GetGasto()
        => _gastos;
}