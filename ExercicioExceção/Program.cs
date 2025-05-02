using ExercicioExce__o.Entity;
using ExercicioExce__o.Entity.Entity;

namespace ExercicioExce__o
{
    internal class program
    {
        static void Main(string[] args)
        {
            try
            {
                System.Console.WriteLine("Nome");
                string nome = Console.ReadLine();
                System.Console.WriteLine("numero");
                int numero = int.Parse(Console.ReadLine());
                System.Console.WriteLine("Saldo inicial");
                double saldo = double.Parse(Console.ReadLine());
                System.Console.WriteLine("Saldo Limite");
                double limite = double.Parse(Console.ReadLine());
                Conta conta = new Conta(numero, nome, saldo, limite);
                System.Console.WriteLine("");
                System.Console.WriteLine("Valor a sacar");
                double valor = double.Parse(Console.ReadLine());
                conta.Sacar(valor);
                System.Console.WriteLine(conta.Saldo);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("ERROR :" + ex.Message);
            }
        }
    }

}