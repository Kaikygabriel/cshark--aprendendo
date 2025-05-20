using SistemaBancarioOOPID.Entity;
using SistemaBancarioOOPID.Service;

namespace SistemaBancarioOOPID
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Banco nubank = new Banco();
            Conta kaiky = new Conta("kaiky", 2500);
            Conta gabriel = new Conta("gabriel", 0);
            Conta alves= new Conta("Alves", 1200);
            nubank.CriarUsuario(kaiky);
            nubank.CriarUsuario(gabriel);
            nubank.CriarUsuario(alves);
            kaiky.transacao.Registrar(1000, kaiky, gabriel, nubank);
            // kaiky.transacao.ListaTransacao();
           
            nubank.GetConta();
        }
    }
}