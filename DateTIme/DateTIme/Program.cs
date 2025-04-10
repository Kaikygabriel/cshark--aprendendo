
using System.Globalization;

namespace DateTIme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Now;
            string data = "11/12/24";
            DateTime a = DateTime.Parse(data);
            //exibe o horario atual
            DateTime d4 = DateTime.Today;
            //exibe a data do dia atual porem com o horario zerado
            Console.WriteLine(d1);new 
            Console.WriteLine(d1.Ticks);
            //ticks são 100 nanosegundos, e são contados des da meia noite do dia 1 de janeiro do ano 1 da era comum
                                        //ano mes dia
            DateTime d2 = new DateTime(2025,03,16);
            Console.WriteLine(d2);     //ano mes dia hora minuto segundo
            DateTime d3 = new DateTime(2025, 03, 16, 10, 20, 00);
            Console.WriteLine(d3);
            DateTime a2 = DateTime.ParseExact("2000-03-16","yyyy-MM-dd",CultureInfo.InvariantCulture);  
        }
    }
}
