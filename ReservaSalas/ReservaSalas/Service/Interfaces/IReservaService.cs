using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReservaSalas.Entities;

namespace ReservaSalas.Service.Interfaces
{
    internal interface IReservaService
    {
        void Reservar(Cliente cliente, Sala sala, Hotel hotel, DateTime inicio, DateTime fim);
    }
}
