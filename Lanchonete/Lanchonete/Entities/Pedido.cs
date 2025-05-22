using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanchonete.Entities
{
    internal class Pedido
    {
        public Cliente Cliente { get; private set; }
        public List<Produto> Produtos { get; private set; } = new List<Produto>();
        public  double TotalPrice{ get; private set; }
    }
}
