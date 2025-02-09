using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorEstoque
{
    internal class Loja
    {
        [System.Serializable]
        struct produto 
        {
            public string nome;
            public float preco;
            public string marca;
            public produto(string nome, float preco,string marca)
            {
                this.nome = nome;
                this.preco = preco;
                this.marca = marca;
            }
        }
        public static void adicionar()
        {
            List<produto> loja = new List<produto>();
            if (File.Exists("estoque.txt"))
            {
                FileStream fluxo1 = new FileStream("estoque.txt", FileMode.Open);//abre sem modificalo
                BinaryFormatter converter2 = new BinaryFormatter();
                loja = (List<produto>)converter2.Deserialize(fluxo1);
                fluxo1.Close();
            }
            Console.WriteLine("Escreva o nome do produto");
            string nomeproduto = Console.ReadLine();
            Console.WriteLine("Escreva o preço do produto");
            float precoproduto = float.Parse(Console.ReadLine());
            Console.WriteLine("Escreva a marca do produto");
            string marcaproduto = Console.ReadLine();
            loja.Add(new produto(nomeproduto, precoproduto, marcaproduto));
            Console.Write("produto adicionado");
            FileStream fluxo = new FileStream("estoque.txt", FileMode.OpenOrCreate);
            BinaryFormatter converter = new BinaryFormatter();
            converter.Serialize(fluxo,loja);
            fluxo.Close();
        }
       public static void ver()
        {
            if (File.Exists("estoque.txt"))
            {
                Console.WriteLine("Produtos adicionados são");
                FileStream fluxo = new FileStream("estoque.txt", FileMode.Open); // apenas abre o arquivo sem modificalo
                BinaryFormatter converter = new BinaryFormatter();
                List<produto> loja = (List<produto>)converter.Deserialize(fluxo);
                foreach(produto l in loja)
                {
                    Console.WriteLine($"O produto: {l.nome}, tem o preço: R${l.preco}, ea marca {l.marca}");
                }
                Console.ReadLine();
                fluxo.Close();
            }
            else
            {
                Console.Write("ERROR");
            }
        }
        public static void remover()
        {
            if (File.Exists("estoque.txt"))
            {
                List<produto> loja = new List<produto>();
                FileStream flux = new FileStream("estoque.txt", FileMode.Open);
                BinaryFormatter converter = new BinaryFormatter();
                loja = (List<produto>)converter.Deserialize(flux);
                foreach(produto l in loja)
                {
                    Console.WriteLine(l.nome);
                }
                Console.WriteLine("escolha um item para remover (nome)");
                string itemRemove = Console.ReadLine();
                int index = loja.FindIndex(p => p.nome.Equals(itemRemove, StringComparison.OrdinalIgnoreCase));
                flux.Close();
                if (index != -1)
                {
                    FileStream flux1 = new FileStream("estoque.txt", FileMode.Create); // cria ou substitui arquivo
                    loja.RemoveAt(index);
                    Console.WriteLine("item removido");
                    converter.Serialize(flux1, loja);
                    flux1.Close();
                }
                else
                {
                    Console.WriteLine("item não encontrado");
                }

                Console.ReadLine();
            }
        }
    }
}
