using SimuladorInvestimento.Entities;

namespace SimuladorInvestimento.Service
{
    public interface IOrdem
    {
        void Executar(Investidor investidor, Acao acao, double valor);
    }
}