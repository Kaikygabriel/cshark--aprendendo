using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaLojaVirtual.Entities;
using SistemaLojaVirtual.Service.Interface;

namespace SistemaLojaVirtual.Service
{
    internal class ImpostoProdutoDigital : IImposto
    {
        public void Calcular(Carrinho carrinho)
        {
            if (carrinho.Total <= 0)
                throw new Exception("total tem que ser maior que zero");
            double total = carrinho.Total + (carrinho.Total * 0.18);
            carrinho.Total = total;
        }
    }
}
