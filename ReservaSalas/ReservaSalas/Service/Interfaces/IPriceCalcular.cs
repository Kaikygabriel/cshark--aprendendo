using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReservaSalas.Entities;

namespace ReservaSalas.Service.Interfaces
{
    internal interface IPriceCalcular
    {
        public double Calcular(Sala sala, DateTime inicio, DateTime fim);
    }
}
