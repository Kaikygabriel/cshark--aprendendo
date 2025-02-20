using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loja
{
    [System.Serializable]
    internal class PRoduto
    {
        public string nome;
        public string marca;
        public float preco;
        public PRoduto(string nome, string marca, float preco)
        {
            this.nome = nome;
            this.marca = marca;
            this.preco = preco;
        }
    }
}
