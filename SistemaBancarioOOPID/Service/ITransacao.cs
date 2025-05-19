using SistemaBancarioOOPID.Entity;

namespace SistemaBancarioOOPID.Service
{
    public interface ITransacao
    {
        void Registrar(double valor, Conta contaOrigem, Conta contaDestino,Banco banco);
        void ListaTransacao();
    }
}