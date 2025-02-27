using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto4
{
    internal class Ebook: PRoduto
    {
        public string autor;
        private int vendas;
        public Ebook(string autor, int vendas,string nome,float preco):base(nome,preco)
        {
            this.autor = autor;
            this.vendas = vendas;
        }
    }
}
