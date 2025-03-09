using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeEstoquE
{
    [System.Serializable]

    internal class Ebook : Estoque

    {
        public string nome;
        public string autor;
        private float preco;
        public Ebook(string nome,string autor, float preco)
        {
            this.nome = nome;
            this.autor = autor; 
            this.preco = preco;
        }
        public void exibir()
        {
            Console.WriteLine($"O nome do Ebook é {nome}, autor do  é {autor}, eo preço é {preco}");
        }
    }
}
