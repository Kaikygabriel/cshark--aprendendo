using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPDISistemaPagamento.Entities;

namespace OOPDISistemaPagamento.Service.Interfaces
{
    internal interface IMetodoPagamento
    {
        void ProcessarPagamento(double valor,Cliente Clientedestino,Cliente clienteInicio);
    }
}
