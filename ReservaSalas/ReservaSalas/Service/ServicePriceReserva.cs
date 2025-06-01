using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReservaSalas.Entities;
using ReservaSalas.Service.Interfaces;

namespace ReservaSalas.Service
{
    internal class ServicePriceReserva : IPriceCalcular
    {
        public double Calcular(Sala sala, DateTime inicio, DateTime fim)
        {
            double PriceDay = sala.PriceDays;
            TimeSpan tempo = inicio.Subtract(fim); 
            return Math.Abs( tempo.TotalDays * PriceDay);
        }
    }
}
