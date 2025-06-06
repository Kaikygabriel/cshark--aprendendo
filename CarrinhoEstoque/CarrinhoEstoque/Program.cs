using CarrinhoEstoque.Entites;

var mouse = new Produto("Mouse Multilaser",200,10);
var notebook = new Produto("notebook lenovo",2000,110);
var caderno = new Produto("caderno libra",30,40);
var kaiky = new Cliente("kaiky");
var pedidoCaderno = new Pedido(caderno,kaiky);

var carinhoCompras = new Carrinho();

carinhoCompras.AddPedido(new Pedido(mouse,kaiky));
carinhoCompras.AddPedido(new Pedido(notebook,kaiky));
carinhoCompras.AddPedido(pedidoCaderno);
carinhoCompras.AddPedido(pedidoCaderno);

carinhoCompras.GetListPedidos();