using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood.Entidades
{
    internal class Carrinho
    {
        public List<Produto> listCarriho;
        public void AdicionarProduto()
        {
            Produto Hamburgue = new Produto("Hamburgue", 20f, 100);
            Produto Batata = new Produto("Batata", 10f, 100);
            List<Produto> opcao = new List<Produto>();
            opcao.Add(Batata);
            opcao.Add(Hamburgue);
            Console.WriteLine($" {Hamburgue} \n {Batata}");
            Console.WriteLine("Escolha um \n Digite o nome");
            string nome = Console.ReadLine();
            bool achou = false;
            foreach( Produto produto in opcao)
            {
                if(produto.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase))
                {
                    listCarriho.Add(produto);
                    achou = true;
                }   
            }
            if (!achou)
            {
                Console.WriteLine("Não foi possivel achar");
            }
            Console.ReadLine();
        }
        public void ListaProduto()
        {
            try
            {
                if (listCarriho.Count > 0)
                {
                    float soma = 0;
                    foreach (Produto p in listCarriho)
                    {
                        soma += p.Preco;
                        Console.WriteLine(p);
                    }
                    Console.WriteLine("O preço total é R$" + soma);
                }
            }
           catch(Exception e)
            {
                Console.WriteLine("ERROR");
                Console.ReadLine();
                Console.Clear();

            }
        }
    }
}
