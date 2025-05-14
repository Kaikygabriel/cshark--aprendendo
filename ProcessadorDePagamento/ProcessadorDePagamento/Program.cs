using System;
using ProcessadorDePagamento.Entity;
using ProcessadorDePagamento.Service;

namespace ProcessadorDePagamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa kaiky = new Pessoa("kaiky",new Conta(2000));
            Console.WriteLine(kaiky.ContaBanco);
            CheckoutService check = new CheckoutService(new PagamentoPix());
            check.Checkout(1000, kaiky);
            Console.WriteLine(kaiky.ContaBanco);
            kaiky.ContaBanco.GetHistorico();
        }
    }
}
