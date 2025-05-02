using Reservation.Entity;

namespace Reservation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Numero do quarto");
                int numQuarto = int.Parse(Console.ReadLine());
                Console.WriteLine("data de entrada (dd/MM/yyyy)");
                DateTime entrada = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("data de saida (dd/MM/yyyy)");
                DateTime saida = DateTime.Parse(Console.ReadLine());
                Quarto quartoReservado = new Quarto(numQuarto, entrada, saida);
                quartoReservado.ToString();
                Console.WriteLine("Entre com os dados para atualizar a reserva");
                DateTime entrada2 = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("data de saida (dd/MM/yyyy)");
                DateTime saida2 = DateTime.Parse(Console.ReadLine());
                quartoReservado.UpadateDates(entrada2, saida2);
                Console.WriteLine("Dados atualizados");
                quartoReservado.ToString();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

}

