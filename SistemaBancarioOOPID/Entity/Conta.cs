using System.Diagnostics;
using SistemaBancarioOOPID.Entity.Exception;
using SistemaBancarioOOPID.Service;

namespace SistemaBancarioOOPID.Entity
{
    public class Conta : IComparable
    {
        public Conta() { }

        public Conta(string name, double saldo)
        {
            Name = name;
            Saldo = saldo;
        }

        public string Id { get; private set; } = Guid.NewGuid().ToString("N")[0..10];
        public string Name { get; private set; } = string.Empty;
        public double Saldo { get;  set; }
        public ITransacao transacao { get; private set; } = new TransacaoService();
        public int CompareTo(object? obj)
        {
            if (!(obj is Conta))
                throw new DominioException("O Objeto não e do mesmo tipo que Cliente");
            Conta other = (Conta)obj;
            return Name.CompareTo(other.Name);
        }

        public override bool Equals(object? obj)
        {
            if (!(obj is Conta))
                throw new DominioException("O Objeto não e do mesmo tipo que Cliente");
            Conta other = (Conta)obj;
            return Name.Equals(other.Name);
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
        public override string ToString()
        {
            return $"Nome - {Name}\n id - {Id}\n Saldo atual R${Saldo.ToString("F2")}";
        }
    }
}