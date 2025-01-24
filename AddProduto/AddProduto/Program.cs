using System;
using System.Security.Cryptography.X509Certificates;

namespace AddProduto
{
 
  
    
    internal class Program
    {
        struct produto
        {
            public string nome;
            public float valor;

            public produto(string nome, float valor)
            {
                this.nome = nome;
                this.valor = valor;

            }
            public void exibir()
            {
                Console.WriteLine($"O nome do Produto é :{this.nome}");
                Console.WriteLine($"O valor do Produto é :R${this.valor}");
            }
        }
        enum opcao{add = 1,sair}
        static void Main()
        {
            bool sair = false;
            while (!sair) 
            {
                Console.WriteLine("Digite uma das opçoes abaixo \n 1-adicionar produto \n2-sair");
                opcao sele = (opcao)int.Parse(Console.ReadLine());
                switch (sele)
                { 
                    case opcao.add:
                        Console.Clear();
                        Console.WriteLine("escreva o nome do produto");
                        string nomep = Console.ReadLine();
                        Console.WriteLine("escreva o valor do produto");
                        int valorp = int.Parse(Console.ReadLine());
                        produto produto1 = new produto(nomep, valorp);
                        Console.WriteLine("PRoduto adicionado");
                        produto1.exibir();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case opcao.sair:
                        sair = true;
                        break;
                    default:
                        
                        Console.Clear();
                        break;
                }
            }
        }
    }
}
