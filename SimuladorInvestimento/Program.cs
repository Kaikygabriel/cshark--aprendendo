using SimuladorInvestimento.Entities;
using SimuladorInvestimento.Service;

namespace SimuladorInvestimento
{
    public class Program
    {
        static void Main()
        {
            Investidor kaiky = new Investidor("kaiky", 2000);
            Acao petrobras = new Acao("PETR4", 31.23);
            IOrdem ServiceCompra = new OrdemCompra();
            ServiceCompra.Executar(kaiky, petrobras, petrobras.Valor);
            System.Console.WriteLine(kaiky);
            kaiky.Carteira.ForEach(x => System.Console.WriteLine(x));
        }
    }
}
