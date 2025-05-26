using System;
using SistemaReservaCancelamento.Entities;

namespace SistemaReservaCancelamento.Service
{
    internal interface ICancelar
    {
        public void Cancelar(Reserva reserva);
    }
}
