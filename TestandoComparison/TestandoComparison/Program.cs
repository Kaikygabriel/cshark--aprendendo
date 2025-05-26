using System;
using System.Security.Cryptography.X509Certificates;
using TestandoComparison.Entities;

namespace TestandoComparison
{
    internal class Program
    {
        static void Main()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product("Nootebok", 1000));
            products.Add(new Product("Celular", 700));
            products.Add(new Product("tablet", 500));

            //lambda são funções anonimas
            // Comparison<Product> comp = (p1,  p2) => p1.Nome.ToUpper().CompareTo(p2.Nome.ToUpper()); 

            products.Sort((p1, p2) => p1.Nome.ToUpper().CompareTo(p2.Nome.ToUpper()));
            

            Func<Product, bool> sla = x => x.Nome.Equals("Celular");
            foreach (var a in products)
                Console.WriteLine(sla(a));
            
            List<Product> resultado = products.Where(p => p.Price > 500).ToList();
            foreach (var a in resultado)
                Console.WriteLine(a);
          
            
        }
        //
        //static int ComparisonProducts(Product p1, Product p2)
        //{
        //    return p1.Nome.ToUpper().CompareTo(p2.Nome.ToUpper());
        //}
    }
}
