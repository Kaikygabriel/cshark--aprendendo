using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Linq;
using System.Text;
using System.Runtime.CompilerServices;
using System.Data;
using System.Diagnostics.Eventing.Reader;

namespace Livro
{
    [System.Serializable ]
    internal class livro
    {
        public string nome;
        public int pagina;
        public string produtora;

        public livro(string nome, int pagina, string produtora)
        {
            this.nome = nome;
            this.pagina = pagina;
            this.produtora = produtora;
        }
        public static void LivroAdd()
        {
            List<livro> livros = new List<livro>();
            BinaryFormatter bf = new BinaryFormatter();
            if (File.Exists("livro.txt"))
            {
                FileStream bin1 = new FileStream("livro.txt", FileMode.Open);
                livros = (List<livro>)bf.Deserialize(bin1);
                bin1.Close();
            }
            Console.WriteLine("Escreva o nome do Livro");
            string nome = Console.ReadLine();
            Console.WriteLine("Escreva a quantidade  de padina do  Livro");
            int pagina = int.Parse(Console.ReadLine());
            Console.WriteLine("Escreva a produtora do Livro");
            string produtora = Console.ReadLine();
            livros.Add(new livro(nome, pagina, produtora));
            FileStream bin = new FileStream("livro.txt", FileMode.OpenOrCreate);
            bf.Serialize(bin, livros);
            bin.Close();
          
        }
        public static void CalcularLer()
        {
            
            Console.WriteLine("numero de paginas lida por dia");
            int pagina = int.Parse(Console.ReadLine());
            Console.WriteLine("numero de paginas do livro");
            int livroP = int.Parse(Console.ReadLine());
            
            if (pagina != null && pagina > 0 && livroP != null && livroP > 0)
            {
                int mes = pagina * 30;
                int mes2 = pagina * 60;
                Console.WriteLine($"o numero de paginas lida em um mes é{mes}");
                Console.WriteLine($"o numero de paginas lida em dois mes é{mes2}");
                if (mes >= livroP)
                { 
                    int resu1 = mes - livroP;
                    if (resu1 > 0)
                    {
                        Console.WriteLine($" leu o livro em um mes, sobrou  {resu1} paginas");
                    }
                    else
                    {
                        Console.WriteLine($" leu o livro em um mes");
                    }
                }
                else if (mes2 >= livroP && mes < livroP)
                {
                    int resu = mes2 - livroP;
                    if(resu > 0)
                    {
                        Console.WriteLine($" leu o livro em dois mes, sobrou {resu} paginas");
                    }
                    else
                    {
                        Console.WriteLine($" leu o livro em dois mes");
                    }
                    
                }
                else
                {
                    Console.WriteLine($"Não conseguiu ler o livro");
                }
            }
            else
            {
                Console.WriteLine("ERROR");
            }
        }

        public static void VerLivro()
        {
            if(File.Exists("livro.txt"))
            {
                List<livro> livros = new List<livro>();
                BinaryFormatter converter = new BinaryFormatter();
                FileStream bin = new FileStream("livro.txt", FileMode.Open);
                 livros = (List<livro>)converter.Deserialize(bin);
                bin.Close();
                if(livros.Count > 0)
                {
                    foreach (livro liv in livros)
                    {
                        Console.WriteLine($" o livro {liv.nome}, tem a quantidade de pag {liv.pagina} ea produtora {liv.produtora}.");
                    }
                }
                else
                {
                    Console.Write("NADA ENCONTRADO");
                }
            }
            else
            {
                Console.Write("Error");
            }
        }
    }
}



