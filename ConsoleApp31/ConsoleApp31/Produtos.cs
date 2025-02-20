using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    interface Ia
    {
        void exibir();
    }
    [System.Serializable]
    internal class Produtos : Ia
    {
        public string nome;
        public string marca;
        public float preco;

        public Produtos(string nome, string marca, float preco)
        {
            this.nome = nome;
            this.marca = marca;
            this.preco = preco;
        }
        public void exibir() 
        {
            Console.WriteLine($"Nome : {nome}Preço{preco}");
        }
    }
}
