using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeEstoquE
{
    [System.Serializable]

    internal class ProdutoFisico : Estoque
    {
        public string nome;
        private float preco;
        public float frete;

        public ProdutoFisico(string nome, float preco,float frete)
        {
            this.nome = nome;
            this.preco = preco;
            this.frete = frete;
        }

        public void exibir()
        {
            Console.WriteLine($"O Produto : {nome}, tem o preço de : R${preco}, eo frete de {frete} ");
        }
    }
}
