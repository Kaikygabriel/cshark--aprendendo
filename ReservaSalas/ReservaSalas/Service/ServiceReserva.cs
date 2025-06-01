using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReservaSalas.Entities;
using ReservaSalas.Service.Interfaces;

namespace ReservaSalas.Service
{
    internal class ServiceReserva : IReservaService
    {
        public void Reservar(Cliente cliente, Sala sala,Hotel hotel,DateTime inicio, DateTime fim)
        {
            if (inicio > fim)
                throw new Exception("Error reserva");

            Reserva reserva=  new Reserva(cliente,sala,inicio,fim, new ServicePriceReserva());
            hotel.ReservasHotel.Add(reserva);
        }
    }
}
