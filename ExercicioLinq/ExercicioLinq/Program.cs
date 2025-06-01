using ExercicioLinq.Entities;
using ExercicioLinq.Service;

namespace ExercicioLinq
{
    internal class Program
    {
        static void Main()
        {
            IPath service = new ServicePath();
            List<string> list = service.Pegar(@"C:\Users\kaiky\Downloads\Produtos.csv");
            List<Product> Produtos = new List<Product>();
           
            foreach (string item in list)
                Produtos.Add(new Product(item));

            double media = 
                (from p in Produtos 
                    select p.Price)
                .Average();
            Console.WriteLine($"Average price : R${media.ToString("F2")}");
            var nameProducts = Produtos.Select(x => x.Name).ToList();
            nameProducts.ForEach(x => Console.WriteLine(x));
        }
    }
}
