using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    [System.Serializable ]
    internal class Estoque : Produtos
    {
        public Estoque(string nome, string marca, float preco):base(nome,marca,preco) { }
        public static void Adicionar()
        {
            BinaryFormatter converter = new BinaryFormatter();
            List<Estoque> estoque=new List<Estoque>();
            if (File.Exists("estoque.txt"))
            {
                FileStream bin2 = new FileStream("estoque.txt", FileMode.Open);
                estoque = (List<Estoque>)converter.Deserialize(bin2);
                bin2.Close();
            }
            Console.WriteLine("escreva o nome do produto");
            string nome = Console.ReadLine();
            Console.WriteLine("escreva o marca do produto");
            string marca = Console.ReadLine();
            Console.WriteLine("escreva o preco do produto");
            float preco = float.Parse(Console.ReadLine());
            estoque.Add(new Estoque(nome, marca, preco));
            FileStream bin = new FileStream("estoque.txt", FileMode.OpenOrCreate);
            converter.Serialize(bin, estoque);
            bin.Close();
            Console.WriteLine("Arquivo enviado");
            Console.ReadLine();
        }
        public static void ver()
        {
            if (File.Exists("estoque.txt"))
            {
                BinaryFormatter converter = new BinaryFormatter();
                FileStream bin = new FileStream("estoque.txt", FileMode.Open);
                List<Estoque> estoque = new List<Estoque>();
                estoque = (List<Estoque>)converter.Deserialize(bin);
                bin.Close();
                foreach (Estoque e in estoque)
                {
                    Console.WriteLine($"O produto: {e.nome}, tem a marca : {e.marca} eo preço R${e.preco}");
                }
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("ERROR arquivo não existente");
            }
        }
    }
}
