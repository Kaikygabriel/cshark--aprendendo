using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blibioteca
{
    internal class Blibioteca
    {
        public string Nome;
        public List<Livro> livros = new List<Livro>();
        public Blibioteca(string nome)
        {
            Nome = nome;
        }
        public void AdicionarLivro()
        {
            try
            {
                Console.WriteLine("Nome do livro");
                string nome = Console.ReadLine();
                Console.WriteLine("Autor do livro");
                string autor = Console.ReadLine();
                livros.Add(new Livro(nome, autor));
            }
            catch(Exception e)
            {
                Console.Clear();
                AdicionarLivro();
            }
     
        }
        public void ExibirLivros()
        {
           if(livros.Count > 0)
            {
                foreach(Livro l in livros)
                {
                    Console.WriteLine($"O livro {l.nome} tem o auto{l.autor}");
                }
            }
            else
            {
                Console.WriteLine($"Não tem livros");

            }
        }
        public static void AddBlibioteca()
        {
            Console.WriteLine("Nome do livro");
            string nome = Console.ReadLine();
            Program.listb.Add(new Blibioteca(nome));
        }
    }
}
