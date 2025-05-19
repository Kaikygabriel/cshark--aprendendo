namespace SistemaBancarioOOPID.Entity
{
    public sealed class Transacao
    {
        public Transacao() { }

        public Transacao(double valor, Conta contaOrigem, Conta contaDestino)
        {
            Valor = valor;
            Data = DateTime.Now;
            ContaOrigem = contaOrigem;
            ContaDestino = contaDestino;
            Fazer();
        }

        public string Id { get; private set; } = Guid.NewGuid().ToString()[0..14];
        public double Valor { get; private set; }
        public DateTime Data { get; private set; }
        public Conta ContaOrigem { get; private set; }
        public Conta ContaDestino { get; private set; }
        public void Fazer()
        {
            ContaOrigem.Saldo -= Valor;
            ContaDestino.Saldo += Valor;
        }
        public override string ToString()
        {
            return $"{ContaOrigem.Name} enviou R${Valor.ToString("F2")}\nO usuario\n {ContaOrigem} \n para o usuario {ContaDestino}\n as {Data}";
        }
    }
}