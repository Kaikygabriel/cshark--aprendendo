using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    [System.Serializable]
    internal class Estoque : Produto
    {
        public int quantidade;
        public Estoque(string nome,string marca,int quantidade,float preco) : base(nome, marca,preco)
        {
            this.quantidade = quantidade;
        }
        public static void Adicionar()
        {
            List<Estoque> estoque = new List<Estoque>();
            BinaryFormatter bf = new BinaryFormatter();
            if (File.Exists("estoque.txt"))
            {
                FileStream bin1 = new FileStream("estoque.txt", FileMode.Open);
                estoque = (List<Estoque>)bf.Deserialize(bin1);
                bin1.Close();
            }
            Console.WriteLine("Escreva o nome do produto");
            string nome = Console.ReadLine();
            Console.WriteLine("Escreva a marca do produto");
            string marca = Console.ReadLine();
            Console.WriteLine("Escreva a quantidade de produto");
            int quantidade = int.Parse( Console.ReadLine());
            Console.WriteLine("Escreva a preço de produto");
            float preco = float.Parse(Console.ReadLine());
            estoque.Add(new Estoque(nome, marca, quantidade,preco));
            FileStream bin = new FileStream("estoque.txt", FileMode.OpenOrCreate);
            bf.Serialize(bin, estoque);
            bin.Close();
        }
        public static void VerProduto()
        {
            if (File.Exists("estoque.txt"))
            {
                BinaryFormatter converter = new BinaryFormatter();
                FileStream bin = new FileStream("estoque.txt", FileMode.Open);
                List<Estoque> estoque = new List<Estoque>();
                estoque = (List<Estoque>)converter.Deserialize(bin);
                bin.Close();
                foreach(Estoque p in estoque)
                {
                    Console.WriteLine($"O produto : {p.nome}, tem a marca : {p.marca}, a quantidade : {p.quantidade}, eo preço {p.preco} ");
                }
            }
            else
            {
                Console.WriteLine("ERRO ");
            }
        }
        public static void remove()
        {
            if (File.Exists("estoque.txt"))
            {
                BinaryFormatter converter = new BinaryFormatter();
                FileStream bin = new FileStream("estoque.txt", FileMode.Open);
                List<Estoque> estoque = new List<Estoque>();
                estoque = (List<Estoque>)converter.Deserialize(bin);
                bin.Close();
                foreach (Estoque p in estoque)
                {
                    Console.WriteLine($"O produto : {p.nome} ");
                }
                Console.WriteLine("Escreva o nome do produto que deseja remover ");
                string nome = Console.ReadLine();
                int index = -1;
                for (int a = 1; a < estoque.Count; a++)
                {
                    if (estoque[a].nome == nome)
                    {
                        index = a;
                        estoque.RemoveAt(index);
                        Console.WriteLine("PRoduto removido");
                        foreach (Estoque p in estoque)
                        {
                            Console.WriteLine($"O produto : {p.nome} ");
                        }
                        FileStream bin1 = new FileStream("estoque.txt", FileMode.Create);
                        converter.Serialize(bin1, estoque);
                        break;
                    }

                }
                if (index == -1)
                {
                    Console.WriteLine("Não foi possivel encontrar");
                }
            }
            else
            {
                Console.WriteLine("Nada criado");
            }
        }
    }

}
