using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace LogicaEstoque
{
    
    internal class Produto
    {
        public string Nome { get; set; }
        public float Valor { get; set; }
        public int Estoque { get; set; }
        [JsonConstructor]
        public Produto(string nome, float valor,int estoque)
        {
            Nome = nome;
            Valor = valor;
            Estoque = estoque;
        }
  
        static List<Produto> listProdutos = new List<Produto>(); 
        public static void Carregar()
        {
           
                if (File.Exists("Produto.txt"))
                {
                using (FileStream bin = new FileStream("Produto.txt", FileMode.Open))
                {



                    listProdutos = JsonSerializer.Deserialize<List<Produto>>(bin);
                }
               
                }
                else
                {
                    Console.WriteLine("Arquivo não encontrado");
                }
         
        }
        public static void Adicionar()
        {
            
            Carregar();
            using (FileStream bin = new FileStream("Produto.txt", FileMode.Create))
            {
                foreach (var item in listProdutos)
                {
                    JsonSerializer.Serialize(bin, item.Nome);
                  
                }
               
                
            }
            

        }
        public static void AdicionarProduto()
        {
            if (File.Exists("Produto.txt"))
            {
                Carregar();
            }
            Console.WriteLine("Adicionando Produtos \n Escreva o nome do produto :");
            string nome = Console.ReadLine();
            Console.WriteLine("Escreva o Valor :");
            float valor = float.Parse(Console.ReadLine());
            Console.WriteLine("Escreva a Quantidade de Produtos " + nome);
            int estoque = int.Parse(Console.ReadLine());
            listProdutos.Add(new Produto(nome,valor,estoque));
            Adicionar();
        }
        public static void LerProdutos()
        {
            Carregar();
            foreach (var item in listProdutos)
            {
                Console.WriteLine($"O produto {item.Nome} tem o valor de R${item.Valor}");
            }
        }
    }
}
