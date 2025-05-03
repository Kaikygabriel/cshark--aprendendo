using System;
using ExercicioSaque.Entity;

namespace ExercicioSaque
{
    internal class Program
    {
        static void Main()
        {
            try
            {
                Console.Write("Nome : ");
                string nome = Console.ReadLine();
                Console.Write("Id :");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Saldo inicial :");
                double saldo = double.Parse(Console.ReadLine());
                Console.Write("LImite :");
                double saldoLimite = double.Parse(Console.ReadLine());
                Conta conta = new Conta(nome,id,saldo,saldoLimite);
                Console.WriteLine("");
                Console.Write("escreva o valor a sacar");
                double valor = double.Parse(Console.ReadLine());
                conta.Sacar(valor);
                Console.WriteLine("Se deu error não vai aparecer");
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
            }
        }
    }
}
