using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeração.Entidade.Enums
{
    //para poder ficar arrumado, e mais legivel, separamos as classes como usuario, cliente , pedidos e etc...
    //na pasta entidade, ja os enums criamos uma subpasta para poder
    enum OrderStatus
    {
        PagamentoPendente = 0,
        Preceso = 1,
        Saida = 2,
        Entregue = 3
    }
}
