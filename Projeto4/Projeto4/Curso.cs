using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto4
{
    internal class Curso : PRoduto
    {
        public string autor;
        private int vagas;
        public Curso(string autor,string nome,float preco):base(nome,preco)
        {
            this.autor = autor;
            
        }
    }
}
