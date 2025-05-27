using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaLojaVirtual.Entities;

namespace SistemaLojaVirtual.Service.Interface
{
    internal interface IDesconto
    {
        void Aplicar(double valor, Carrinho carrinho);
    }
}
