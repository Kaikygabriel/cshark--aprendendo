using SistemaBancarioOOPID.Service;
using System.Diagnostics.CodeAnalysis;

namespace SistemaBancarioOOPID.Entity
{
    public sealed class Banco
    {
        public Banco() { }
        public List<Conta> Usuarios { get; private set; } = new List<Conta>();
        public List<Transacao> Transacaos { get; private set; } = new List<Transacao>();
        public void CriarUsuario(Conta usuario)
        {
            Usuarios.Add(usuario);
        }
        public void GetConta()
        {
            foreach (var conta in Usuarios)
            {
                Console.WriteLine(conta);
            }
        }        
    }
}