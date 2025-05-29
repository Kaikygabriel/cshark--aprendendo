using SimuladorInvestimento.Entities;

namespace SimuladorInvestimento.Service
{
    public class OrdemCompra : IOrdem
    {

        public void Executar(Investidor investidor, Acao acao, double valor)
        {
            if (investidor.Saldo < valor)
                throw new Exception("Saldo e menor que o valor");
            investidor.AdicionarCarteira(acao, valor);  
        }
    }
}