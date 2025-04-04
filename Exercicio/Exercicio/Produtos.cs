using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 
using System.Threading.Tasks;

namespace Exercicio
{
    internal class Produtos
    {
        public string nome;
        public double preco;
        public int quantidade;
        public Produtos(string nome, double preco, int quantidade)
        {
            this.nome = nome;
            this.preco = preco;
            this.quantidade = quantidade;
        }
        public Produtos(string nome, double preco)
        {
            this.nome = nome;
            this.preco = preco;
        }
        public override string ToString()
        {
            double total = quantidade * preco;

            return nome +", R$" + preco +" unidades " + quantidade+",Valor total R$"+total;
        }
        public void ValorTotalEstoque()
        {
            double total = quantidade * preco;

            Console.WriteLine($"Dados do produto:{this}");
            //quando coloca dentro de um WriteLine o objeto, ele vai chamar o metodo ToString e vai colocar automatico o retorno do tostring
            //csharp indentifica que o this ta participando de uma concatenação de string , e automaticamente chama a função 
        }
        public void AdicionarProdutos(int produto)
        {

            quantidade += produto;
            Console.WriteLine($"Novos produtos adicionados ao estoque {this}");
        }
        public void RemoverProduto(int produto)
        {
            quantidade -= produto;
        }
    }
}
