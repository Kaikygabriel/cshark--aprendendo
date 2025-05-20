using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReservaHotelOOPID.Entity;

namespace ReservaHotelOOPID.Service
{
    internal class QuartoService
    {
        public void CalcularTotal(Quarto quarto,double priceDay)
        {
            TimeSpan duracaoDay = quarto.Entregua.Subtract(quarto.Entrada);
            quarto.TotalPrice = Math.Ceiling(duracaoDay.TotalDays) * priceDay;    
        }
    }
}
