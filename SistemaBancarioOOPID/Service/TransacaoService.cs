using SistemaBancarioOOPID.Entity;

namespace SistemaBancarioOOPID.Service
{
    public class TransacaoService : ITransacao
    {
        public List<Transacao> Transacaos = new List<Transacao>();
        public void Registrar(double valor, Conta contaOrigem, Conta contaDestino,Banco banco)
        {
            Transacao transacao= new Transacao(valor, contaOrigem, contaDestino);
            Transacaos.Add(transacao);
            banco.Transacaos.Add(transacao);
        }
        public void ListaTransacao()
        {
            foreach (Transacao transacao in Transacaos)
            {
                Console.WriteLine(transacao);
            }
        }
    }
}
        