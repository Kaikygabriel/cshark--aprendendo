namespace CarrinhoEstoque.Entites;

public class Pedido
{
    public Pedido(){}

    public Pedido(Produto produto, Cliente cliente)
    {
        _produto = produto;
        _cliente = cliente;
    }

    private Produto _produto;
    private Cliente _cliente;

    public override string ToString()
        => $"{_cliente} - {_produto}";

    public override int GetHashCode()
        => _cliente.GetHashCode() + _produto.GetHashCode();
}