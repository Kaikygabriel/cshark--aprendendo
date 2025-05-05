using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supemercado.EntityCliente
{
    internal sealed class Items
    {
        public Items() { }

        public Items(Produto produto, int quantidade)
        {
            Produto = produto;
            Quantidade = quantidade;
        }

        public Produto Produto{ get; private set; }
        public int Quantidade { get; set; }
    }
}
