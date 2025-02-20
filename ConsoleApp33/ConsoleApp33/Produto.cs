using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    [System.Serializable]
    internal class Produto
    {
        public string nome;
        public string marca;
        public float preco;
        public Produto(string nome,string marca,float preco)
        {
            this.nome = nome;
            this.marca = marca;
            this.preco = preco;
        }
    }
}
