using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaReservaCancelamento.Entities
{
    internal class Reserva
    {
        public DateTime Inicio { get; set; }
        public DateTime Entregua{ get; set; }
        public SortedSet<Quarto> Quartos { get; private set; } = new SortedSet<Quarto>();
    }
}
