using ExercicioExce__o.Entity.Exceptions.Entity.Exceptions;

namespace ExercicioExce__o.Entity.Entity
{
    sealed internal class Conta
    {
        public Conta() { }

        public Conta(int numero, string nome, double saldo, double saldoLimite)
        {
            if (saldo < 0)
            {
                throw new DominioException("Saldo tem que ser acima de zero");
            }
            Numero = numero;
            Nome = nome;
            Saldo = saldo;
            SaldoLimite = saldoLimite;
        }

        public int Numero { get; private set; }
        public string Nome { get; private set; }
        public double Saldo { get; private set; }
        public double SaldoLimite { get; private set; }
        public void Sacar(double valor)
        {
            if (valor > SaldoLimite)
            {
                throw new DominioException("O valor é maior  que limite");
            }
            if (valor > Saldo)
            {
                throw new DominioException("O valor é maior saldo atual");
            }
            Saldo -= valor;
        }
        public void AdicionarSaldo(double valor)
        {
            if (valor < 0)
            {
                throw new DominioException("Valor de deposito abaixo de zero");
            }
            Saldo += valor;
        }
    }
}