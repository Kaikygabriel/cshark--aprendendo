using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enumeração.Entidade.Enums;

namespace Enumeração.Entidade
{
    internal class Order
    {
        public Order(int id, DateTime moment, OrderStatus status)
        {
            Id = id;
            Moment = moment;
            Status = status;
        }

        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public override string ToString()
        {
            return $"O pedido {Id} foi pedido no momento {Moment} e o status é {Status} ";
        }
    }
}
