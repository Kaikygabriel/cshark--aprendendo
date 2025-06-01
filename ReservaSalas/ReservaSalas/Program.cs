using ReservaSalas.Entities;
using ReservaSalas.Entities.EnumSala;
using ReservaSalas.Service;

namespace ReservaSalas
{
    internal class Program
    {
        static void Main()
        {
            Cliente kaiky = new Cliente("kaiky","11 9876-5656");
            Sala sala1 = new Sala(1, 13,70);
            Hotel hotel = new Hotel();
            ServiceReserva a = new ServiceReserva();
            DateTime datafim = DateTime.Now.AddDays(2);
            a.Reservar(kaiky, sala1,hotel,DateTime.Now,datafim);
            hotel.ReservasHotel.ForEach(x => Console.WriteLine(x));
        }
    }
}
