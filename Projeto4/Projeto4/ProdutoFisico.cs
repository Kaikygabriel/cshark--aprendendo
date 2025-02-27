using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto4
{
    internal class ProdutoFisico : PRoduto
    {
        private int estoque;
        public float frete;
        public ProdutoFisico(int estoque, float frete,string nome,float preco):base(nome,preco)
        {
            this.estoque = estoque;
            this.preco = preco;
        }
    }
}
