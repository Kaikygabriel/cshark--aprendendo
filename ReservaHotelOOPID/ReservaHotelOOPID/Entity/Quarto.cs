using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ReservaHotelOOPID.Entity
{
    internal class Quarto
    {
        public Quarto() { }
        public Quarto(int number, double valorBase)
        {
            Number = number;
            ValorBase = valorBase;
        }

        public DateTime Entrada { get; private set; }
        public DateTime Entregua { get; private set; }
        public int Number { get; private set; }
        public double ValorBase { get; private set; }
        public double TotalPrice { get;  set; }
    }
}
