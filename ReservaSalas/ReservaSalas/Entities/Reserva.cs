using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReservaSalas.Service.Interfaces;

namespace ReservaSalas.Entities
{
    internal class Reserva
    {
        public Reserva() { }

        public Reserva(Cliente cliente, Sala sala, DateTime inicio, DateTime fim,IPriceCalcular calc)
        {
            Cliente = cliente;
            Sala = sala;
            Inicio = inicio;
            Fim = fim;
            CalculoTotal = calc;
        }

        public Cliente Cliente { get; set; }
        public Sala Sala { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fim{ get; set; }
        public IPriceCalcular CalculoTotal { get; set; }
        
        public double TotalPrice()
        {
            return CalculoTotal.Calcular(Sala, Inicio, Fim);
        }
        public override string ToString()
        {
            return $"{Cliente}\n{Sala}\nR${TotalPrice().ToString("F2")}";
        }
    }
}
