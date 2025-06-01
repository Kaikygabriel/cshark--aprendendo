using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaSalas.Entities
{
    internal class Hotel
    {
        public List<Reserva> ReservasHotel{ get; set;} = new List<Reserva>();

    }
}
