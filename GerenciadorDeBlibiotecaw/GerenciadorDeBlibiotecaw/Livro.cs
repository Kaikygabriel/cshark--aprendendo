using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace GerenciadorDeBlibiotecaw
{
    [System.Serializable]
    internal class Livro
    {
        public string nome;
        public string autor;
        public bool disponilidade;

        public Livro(string nome, string autor)
        {
            this.nome = nome;
            this.autor = autor;
            this.disponilidade = true;
        }
        public void Emprestar()
        {
            disponilidade = false;
        }
        public void Entregar()
        {
            disponilidade = true;
        }
        public static void AdicionarLivro()
        {
            Console.WriteLine("Nome do livro");
            string Nome = Console.ReadLine();
            Console.WriteLine("Nome do Autor");
            string Autor = Console.ReadLine();
            Livros.Add(new Livro(Nome, Autor));
        }
        public static void RemoverLivro()
        {

            try
            {

                if (Livros.Count >= 1)
                {
                    Console.WriteLine("Qual livro deseja remover");
                    foreach (Livro l in Livros)
                    {
                        Console.WriteLine($"O livro {l.nome}, tem o autor {l.autor}.");
                    }
                    string NomeLivro = Console.ReadLine();
                    foreach (Livro l in Livros)
                    {
                        if (l.nome.Equals(NomeLivro, StringComparison.OrdinalIgnoreCase))
                        {
                       
                            Livros.Remove(l);
                            Console.WriteLine("LIVRO REMOVIDO");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("LIVRO não encontrado");
                            Console.ReadLine();
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error");
            }
        }
        public static List<Livro> Livros = new List<Livro>();
    }
}
