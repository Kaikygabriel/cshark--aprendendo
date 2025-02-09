using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOja
{
    [System.Serializable]
    internal class Produto
    {
        public string nome;
        public string marca;
        public float preco;

        public Produto(string nome, string marca, float preco)
        {
            if (nome.Length > 1 && marca.Length > 1 && preco > 0) 
            {
                this.nome = nome;
                this.marca = marca;
                this.preco = preco;
            }
          
        }
    }
}
