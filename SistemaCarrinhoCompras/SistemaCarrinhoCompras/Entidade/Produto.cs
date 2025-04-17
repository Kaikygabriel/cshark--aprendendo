using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCarrinhoCompras.Entidade
{
    internal class Produto : Item
    {
        public Produto(): base("Mouse", 200f){}
        public override string ToString()
        {
            return $"{Nome} R${Preco}";
        }
    }
}
