using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace LOja
{
    [System.Serializable]
    internal class Estoque : Produto
    {
        public int armazeno;
        public Estoque(int armazeno, string nome, string marca, float preco) : base(nome, marca, preco)
        {
            if (armazeno > 1 && armazeno != null)
            {
                this.armazeno = armazeno;
            }
        }
        public static void adicionarArmazen()
        {
            BinaryFormatter bin = new BinaryFormatter();
            List<Estoque> guardar = new List<Estoque>();
            if (File.Exists("estoque.txt"))
            {
                FileStream enviar2 = new FileStream("estoque.txt", FileMode.Open);
                guardar = (List<Estoque>)bin.Deserialize(enviar2);
                enviar2.Close();
            }
            Console.WriteLine("ARMAZEN\nEscreva o nome do produto");
            string nome = Console.ReadLine();
            Console.WriteLine("marca do produto");
            string marca = Console.ReadLine();
            Console.WriteLine("Escreva o preço");
            float preco = float.Parse(Console.ReadLine());
            Console.WriteLine("quantidade");
            int quantia = int.Parse(Console.ReadLine());
            guardar.Add(new Estoque(quantia, nome, marca, preco));
            FileStream enviar = new FileStream("estoque.txt", FileMode.OpenOrCreate);
            bin.Serialize(enviar, guardar);
            enviar.Close();
        }
        public static void VerArmazen()
        {
            if (File.Exists("estoque.txt"))
            {
                List<Estoque> guardar = new List<Estoque>();
                BinaryFormatter bin = new BinaryFormatter();
                FileStream enviar2 = new FileStream("estoque.txt", FileMode.Open);
                guardar = (List<Estoque>)bin.Deserialize(enviar2);
                enviar2.Close();
                foreach (Estoque e in guardar)
                {
                    Console.WriteLine($"O produto {e.nome}, tem a marca {e.marca}, o preço de R${e.preco}, e tem {e.armazeno} no estoque");
                }
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("erro");
            }

        }
    
        public static void RemoveEstoque()
        {
            if(File.Exists("estoque.txt"))
            {
                 List<Estoque> produtos = new List<Estoque>();
                 BinaryFormatter converter = new BinaryFormatter();
                 Console.WriteLine("escolha um item para remover");
                 FileStream bin = new FileStream("estoque.txt", FileMode.Open);
                 produtos = (List<Estoque>)converter.Deserialize(bin);
                 bin.Close();
                foreach (Produto produto in produtos)
                {
                    Console.WriteLine(produto.nome );
                }
                Console.WriteLine("escreva o nome do item que deseja remover");         
            }
        }
    }
}
