using System;
using SistemaReservaCancelamento.Entities.EnumQuarto;

namespace SistemaReservaCancelamento.Entities
{
    internal class Quarto
    {
        public Quarto() { }

        public Quarto(int number, TypeQuarto tipo)
        {
            Number = number;
            Tipo = tipo;
        }

        public int Number { get;private set; }
        public TypeQuarto Tipo { get; private set; }
    }
}
