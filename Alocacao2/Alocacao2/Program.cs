using Alocacao2.Entity;
using Alocacao2.Service;

namespace Alocacao2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados dos carros");
            string model = Console.ReadLine();
            Console.WriteLine("Data entrada ");
            DateTime entrada = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Data entregua");
            DateTime entregua = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("preço por hora");
            double priceHours = double.Parse(Console.ReadLine());
            Console.WriteLine("preço por dia");
            double priceDays = double.Parse(Console.ReadLine());
            Console.WriteLine("Nota fiscal :");
            CarRental carRental = new CarRental(entrada,entregua,new Veiculo(model));
            RentalService service = new RentalService(priceHours,priceDays,new BrazilTaxa());
            service.ValorTotal(carRental);
            Console.WriteLine(carRental.Invoice);
        }
    }
}
