using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Pagamentok.Service
{
    internal class TaxaCartao : ITaxa
    {
        public double Taxa(double valor) 
        {
            return valor *0.05;
        }
    }
}
