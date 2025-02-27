using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto4
{
    abstract  class PRoduto
    {
        public string nome;
        public float preco;
        public PRoduto(string nome, float preco)
        {
            this.nome = nome;
            this.preco = preco;
        }
    }
}
