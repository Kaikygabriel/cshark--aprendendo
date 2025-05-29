using System;
using OOPDISistemaPagamento.Entities.EnumPagamento;

namespace OOPDISistemaPagamento.Entities
{
    internal class Pagamento
    {
        public Pagamento() { }

        public Pagamento(double valor, EStatus status)
        {
            Valor = valor;
            Status = status;
            Data = DateTime.Now;
        }

        public string Id { get; private set; } = Guid.NewGuid().ToString()[..8].ToUpper();
        public double Valor { get;private set; }
        public DateTime Data { get; private set; }
        public EStatus Status { get; private set; }

        public override string ToString()
        {
            return $"";
        }
    }
}
