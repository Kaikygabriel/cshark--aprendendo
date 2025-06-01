using System;
using ReservaSalas.Entities.EnumSala;

namespace ReservaSalas.Entities
{
    internal  class Sala
    {
        public Sala() { }

        public Sala(int number, int capacidade, double priceDays)
        {
            Number = number;
            Capacidade = capacidade;
            PriceDays = priceDays;
        }

        public int Number { get;protected set; }
        public int Capacidade{ get; protected set; }
        public double PriceDays { get;protected set; }

        public override string ToString()
        {
            return $"Quarto {Number}, tem a capacidade de {Capacidade}";
        }
    }
}
