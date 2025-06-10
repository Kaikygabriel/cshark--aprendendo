using GerenciamentoOrcamentoGastosPessoais.Entites;
using GerenciamentoOrcamentoGastosPessoais.Entites.CategoriaGasto;

var kaiky  = new Conta(200,"kaiky");
var gastoPc = new Gasto("Gasto com pc", 200, EGastoType.Util);
var itemKaikyControle = new Item(kaiky);

itemKaikyControle.AddGasto(gastoPc);

itemKaikyControle.GetGasto().ForEach(x=>Console.WriteLine(x));
