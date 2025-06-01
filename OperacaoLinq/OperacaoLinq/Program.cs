using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using OperacaoLinq.Entities;
using OperacaoLinq.MethodsEstends;

namespace OperacaoLinq
{
    internal class Program
    {
        static void Main()
        {
            Category c1 = new Category(1, "Brinquedos", 3);
            Category c2 = new Category(2, "Computers", 1);
            Category c3 = new Category(3, "Eletronics", 1);

            List<Produto> produtos = new List<Produto>();
            produtos.Add(new Produto("Transformers", 1, 40, c1));
            produtos.Add(new Produto("RX580", 2, 400, c2));
            produtos.Add(new Produto("XboxOne", 10, 1000, c3));
            produtos.Add(new Produto("Ps4", 10, 1100, c3));
            produtos.Add(new Produto("Xbox360", 10, 400, c3));


            //var r1 = produtos.Where(x => x.Categoria.Tier == 1 && x.Price < 900);
            var r1 =
                from p in produtos
                where p.Categoria.Tier == 1 && p.Price < 900
                select p;
            r1.GetList("where tier1 and price < 900");

            //var r2 = produtos.Where(x => x.Categoria.Nome == "Brinquedos").Select(x => x.Nome).ToList();
            var r2 =
                from p in produtos
                where p.Categoria.Nome == "Brinquedos"
                select p.Nome;
            r2.GetList("Where Names Brinquedos");

            //var r3 = produtos.Where(x => x.Nome[0] == 'X').Select(x => new { x.Nome, NameCategory = x.Categoria.Nome, x.Price });
            var r3 =
                from p in produtos
                where p.Nome[0] == 'x'
                select new { p.Nome, NameCategory = p.Categoria.Nome, p.Price };
            r3.GetList("where Names one x");

            //var r4 = produtos.Where(x => x.Categoria.Tier == 1).OrderBy(x => x.Price);
            var r4 =
                from p in produtos
                where p.Categoria.Tier == 1
                orderby p.Price
                select p;
            r4.GetList("Where Tier be 1");

            //var r5 = produtos.Skip(2).Take(4);
            var r5 =
                (from p in r4
                 select p).Take(2).Skip(4);
            r5.GetList("Take 4 skip 2");

            var r6 = produtos.SingleOrDefault(x => x.Id == 2);
            Console.WriteLine("Single product id 1 " + r6);

            var r7 = produtos.Max(x => x.Price);
            Console.WriteLine(r7);

            var r8 = produtos.Min(x => x.Price);
            Console.WriteLine(r8);

            var r9 = produtos.Where(x => x.Categoria.Id == 2).Sum(x => x.Price);
            Console.WriteLine(r9);

            var r10 = produtos.Where(x => x.Categoria.Id == 3).Average(x => x.Price);
            Console.WriteLine(r10);

            var r11 = produtos.Where(x => x.Categoria.Id == 2).Select(x => x.Price).Aggregate(0.0, (x, y) => x + y);
            Console.WriteLine(r11);

            var r12 = produtos.GroupBy(x => x.Categoria);
            foreach (IGrouping<Category, Produto> a in r12)
            {
                Console.WriteLine("key " + a.Key.Nome);
                a.GetList("produtos");
            }
        }
    }
}
