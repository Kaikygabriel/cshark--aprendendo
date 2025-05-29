using System.Globalization;

namespace SimuladorInvestimento.Entities
{
    public class Investidor
    {
        public Investidor() { }
        public Investidor(string nome, double saldo)
        {
            Nome = nome;
            Saldo = saldo;
        }

        public string Nome { get; private set; }
        public double Saldo { get; private set; }
        public List<Acao> Carteira { get; private set; } = new List<Acao>();

        public void AdicionarCarteira(Acao acao, double valor)
        {
            Saldo -= valor;
            Carteira.Add(acao);
        }
        public override string ToString()
        {
            return $"Nome : {Nome}\nSaldo: R${Saldo.ToString("F2", CultureInfo.InvariantCulture)} ";
        }
    }
}