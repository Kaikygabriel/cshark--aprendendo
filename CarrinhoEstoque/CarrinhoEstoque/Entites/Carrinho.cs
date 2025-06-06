using System.Globalization;
using CarrinhoEstoque.Entites.ExcptionsEntities;

namespace CarrinhoEstoque.Entites;

public class Carrinho
{
    private List<Pedido> _pedidos = new List<Pedido>();

    public void AddPedido(Pedido pedido)
    {
        if (_pedidos.Exists(x => x.Equals(pedido)))
            throw new DominioException("Error pedido ja existe");
        _pedidos.Add(pedido);
    }

    public void RemovePedido(Pedido pedido)
    {
        if (!_pedidos.Exists(x => x.Equals(pedido)))
            throw new DominioException("Error pedido não existe");
        _pedidos.Remove(pedido);
    }

    public void GetListPedidos()
        => _pedidos.ForEach(x => Console.WriteLine(x));
}