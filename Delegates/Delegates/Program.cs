using System.Linq;
using Delegates.Entities;

namespace Delegates
{
    internal class Program
    {
        internal delegate void Sla<T>(T t);
        static void Main()
        {
            List<Produtos> produtos = new List<Produtos>();
            produtos.Add(new Produtos("Microondas", 700));
            produtos.Add(new Produtos("Suco", 10));
            produtos.Add(new Produtos("ARRoz", 30));
            produtos.Add(new Produtos("Roupa", 100));
            produtos.Add(new Produtos("Celular", 1000));


            List<string> alto = produtos.Select(x => x.Nome.ToUpper()).ToList();
            alto.ForEach(x =>  Console.WriteLine(x));

            var list2 = produtos.FindAll(x => x.Valor > 100);
            list2.ForEach(x => Console.WriteLine(x));
            Sla<Produtos> sla = e =>
            {
                e.Valor += e.Valor * 0.1;
            };
            List<string> nomes = new List<string> { "kaiky", "joão", "gabriel" };
            nomes.ForEach(x => Console.WriteLine($"Ola {x}"));
            
            produtos.ForEach(x => x.Valor += x.Valor * 0.1);

            produtos.ForEach(x => Console.WriteLine(x));
            foreach(Produtos p in produtos)
                Console.WriteLine(p);
        }
    }
}
