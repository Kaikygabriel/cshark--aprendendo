using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeBlibiotecaw
{
    internal class Usuario
    {
        public string nome;
        public List<Livro> livros;

        public Usuario(string nome)
        {
            this.nome = nome;
        }

        public void AdicionarLivro()
        {
            try
            {

                if (Livro.Livros.Count >= 1)
                {
                    foreach (Livro l in Livro.Livros)
                    {
                        Console.WriteLine($"O livro {l.nome}, tem o autor {l.autor} ea disponilidade esta {l.disponilidade}");
                    }
                    Console.WriteLine("Escreva o nome do livro que deseja adicionar");
                    string LivroEscolhido = Console.ReadLine();
                   
                    foreach (Livro l in Livro.Livros)
                    {
                      if(l.nome.Equals(LivroEscolhido, StringComparison.OrdinalIgnoreCase))
                        {
                            l.Emprestar();
                            livros.Add(l);
                        }
                        else
                        {
                            Console.WriteLine("Nenhum livro encontrado");
                        }
                    }
                    
                }
                else
                {
                    Console.WriteLine("Livros não disponiveis");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Error");
            }
        }
        public void RemoverLivro()
        {
            try
            {

                if (livros.Count >= 1)
                {
                    Console.WriteLine("Qual livro deseja devolver");
                    foreach (Livro l in livros)
                    {
                        Console.WriteLine($"O livro {l.nome}, tem o autor {l.autor}.");
                    }
                    string NomeLivro = Console.ReadLine();
                    foreach(Livro l in livros)
                    {
                        if (l.nome.Equals(NomeLivro, StringComparison.OrdinalIgnoreCase))
                        {
                            l.Entregar();
                            livros.Remove(l);
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
            catch(Exception e)
            {
                Console.WriteLine("Error");
            }
        }
        public static void AdicionarCliente()
        {
            Console.WriteLine("Nome do cliente");
            string nome = Console.ReadLine();
            Blibioteca.usuarios.Add(new Usuario("kaiky"));
            Console.WriteLine(" cliente adicionar");
           Console.ReadLine();
        }
    }
}

