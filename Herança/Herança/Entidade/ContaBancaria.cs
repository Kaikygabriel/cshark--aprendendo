using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança.Entidade
{
    abstract class ContaBancaria
    {
        public ContaBancaria() { }
        public ContaBancaria(int id, string titular, double saldo)
        {
            Id = id;
            Titular = titular;
            Saldo = saldo;
        }

        public int Id { get; protected set; }
        public string Titular { get;protected set; }
        public double Saldo { get; protected set; }
        public virtual void Sacar(double valor)
        {
            Saldo = (Saldo - valor) - 5;
        }
        public void Deposito(double valor)
        {
            Saldo = Saldo + valor;
        }
    }
}
