using System;
using OOPDISistemaPagamento.Entities;
using OOPDISistemaPagamento.Entities.EnumPagamento;
using OOPDISistemaPagamento.Service.Interfaces;

namespace OOPDISistemaPagamento.Service
{
    internal class PixPagamento : IMetodoPagamento
    {
        public void ProcessarPagamento(double valor, Cliente Clientedestino, Cliente clienteInicio)
        {
            if (valor <= 0)
                throw new Exception("Pagamento tem  que ser maior que 0");
            clienteInicio.ReceberPagamento(new Pagamento(valor, EStatus.Enviou));
            clienteInicio.Saldo -= valor;
            Clientedestino.ReceberPagamento(new Pagamento(valor, EStatus.Recebeu));
            Clientedestino.Saldo += valor;
        }
    }
}
