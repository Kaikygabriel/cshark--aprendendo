using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeEstoquE
{
  
    internal class Program
    {
        static List<Estoque> estoques = new List<Estoque>();
        static void Main(string[] args)
        {
            Carregar();
            ver();

        }
        static void Carregar()
        {
            if (File.Exists("Estoque.txt"))
            {
                BinaryFormatter converter = new BinaryFormatter();
                FileStream bin = new FileStream("Estoque.txt", FileMode.Open);
                try
                {
                     estoques = (List<Estoque>)converter.Deserialize(bin);
                     bin.Close();
                }
                catch(Exception e)
                {
                    Console.WriteLine("Erro ao tentar colocar os arquivos");
                    bin.Close();
                }
            }
        }
        static void colocar()
        {
            BinaryFormatter converter = new BinaryFormatter();
            if (File.Exists("Estoque.txt"))
            {
                Carregar();
            }
            FileStream bin = new FileStream("Estoque.txt", FileMode.OpenOrCreate);
            converter.Serialize(bin, estoques);
            bin.Close();
        }
        static void addEbook()
        {
            Console.WriteLine("nome");
            string nome = Console.ReadLine();
            Console.WriteLine("autor");
            string autro = Console.ReadLine();
            Console.WriteLine("preço");
            float preco = float.Parse(Console.ReadLine());
            estoques.Add(new Ebook(nome,autro,preco));
            colocar();
        }
        static void addProduto()
        {
            Console.WriteLine("nome");
            string nome = Console.ReadLine();
            Console.WriteLine("frete");
            float frete = float.Parse(Console.ReadLine());
            Console.WriteLine("preço");
            float preco = float.Parse(Console.ReadLine());
            estoques.Add(new ProdutoFisico(nome,preco,frete));
            colocar();
        }
        static void ver()
        {
            if(estoques.Count > 0 && estoques != null)
            {
                for (int i = 0; i < estoques.Count; i++)
                {
                    estoques[i].exibir();
                }
            }
        }
    }
}
