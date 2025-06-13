using System.Globalization;

namespace SistemaControleReservaSalas.Entities;

public class Reserva
{
     public Reserva(){}

     public Reserva(Usuario usuario, Sala sala, DateTime data)
     {
          _usuario = usuario;
          _sala = sala;
          _data = data;
     }

     private Usuario _usuario;
     private Sala _sala;
     private DateTime _data;

     public string GetInfo()
          => $"Reunião" +
             $"\n Horario : {_data.ToString("MM/dd/yyyyTHH/mm/ss",CultureInfo.CreateSpecificCulture("pt-Br"))}" +
             $"\n {_sala}" +
             $"\n {_usuario}";
}