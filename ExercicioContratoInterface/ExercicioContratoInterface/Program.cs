using ExercicioContratoInterface.Entity;
using ExercicioContratoInterface.Service;

namespace ExercicioContratoInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numero contrato");
            int numero = int.Parse(Console.ReadLine().Trim());
            Console.WriteLine("Data ");
            DateTime dt = DateTime.Parse(Console.ReadLine().Trim());
            Console.WriteLine("Valor total");
            double total = double.Parse(Console.ReadLine().Trim());
            Console.WriteLine("Numero de Parcela");
            int numeroParcela = int.Parse(Console.ReadLine().Trim());
            Contrato contrato = new Contrato(numero,dt,total);
            CalcularParcela cp = new CalcularParcela(numeroParcela,new PayPal());
            cp.FazerParcela(contrato);
            Console.WriteLine("Parcelas:");
            contrato.GetParcela();
        }
    }
}
