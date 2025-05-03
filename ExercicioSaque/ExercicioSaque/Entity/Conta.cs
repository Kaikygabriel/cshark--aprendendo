using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExercicioSaque.Entity.Exception;

namespace ExercicioSaque.Entity
{
    internal sealed class Conta
    {
        public Conta() { }

        public Conta(string nome, int id, double saldo, double saldoLimite)
        {
            if(saldo < 0)
            {
                throw new DominioException("Saldo tem que ser maior que zero");
            }
            Saldo = saldo;
            Nome = nome;
            Id = id;
            SaldoLimite = saldoLimite;
        }

        public string Nome { get; private set; }
        public  int Id{ get;private set; }
        public  double Saldo { get; private set; }
        public double SaldoLimite { get; private set; }

        public void Sacar(double valor)
        {
            if(valor > SaldoLimite || valor > Saldo)
            {
                throw new DominioException("Valor a sacar e maior do que o limite da conta ou maior que o saldo da conta");
            }
            if (valor < 0)
            {
                throw new DominioException("Valor tem que ser maior que zero");
            }
            Saldo -= valor;
            Console.WriteLine($"Saldo atual é R${Saldo.ToString("F2",CultureInfo.InvariantCulture)}");
        }

    }
}
