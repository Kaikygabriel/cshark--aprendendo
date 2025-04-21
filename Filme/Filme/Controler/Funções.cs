using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Filme.Entidade;
using Filme.Entidade.Enum;

namespace Filme.Controler
{
    internal class Funções
    {
        private static List<Entidade.Filme> filmes = new List<Entidade.Filme>();
        public static void AdicionarFilme()
        {
        
            Console.WriteLine("Nome do filme");
            string nome = Console.ReadLine().Trim();
            Console.WriteLine("Categoria ( Aventura,Ação,Terror,Romance,Comedia)");
            Categoria categoria = Enum.Parse<Categoria>(Console.ReadLine().Trim());
            Console.WriteLine("Duração ");
            TimeSpan a = new TimeSpan(00, int.Parse(Console.ReadLine()), 00);
            Console.WriteLine(a.TotalMinutes);


            filmes.Add(new Entidade.Filme(nome, a,categoria));
        }
        public static void ListarFilmes()
        {
            foreach(Entidade.Filme a in filmes)
            {
                Console.WriteLine(a);
            }
        }
    }
}
