using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alocacao2.Service
{
    internal class BrazilTaxa : ITaxService
    {
        public  double Tax(double valor  )
        {
            if(valor <= 100)
            {
                return valor*0.2;
            }
            else
            {
                return valor * 0.15;
            }
        }
    }
}
