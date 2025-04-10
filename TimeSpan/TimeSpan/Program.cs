
using System.Diagnostics;
using System.Timers;

namespace Time
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            DateTime t = DateTime.Now;
            //hora minuto segundo
            TimeSpan d1 = new TimeSpan(0, 1, 30);
            TimeSpan d2 = new TimeSpan();
            TimeSpan d3 = new TimeSpan(900000000L) ; //passando  a hora em ticks
            Console.WriteLine(d1);
            Console.WriteLine(d3);

            //////////
            
            TimeSpan a = TimeSpan.FromDays(1.5);//timespan de um dia e meio
            Console.WriteLine(a);
            TimeSpan a1 = TimeSpan.FromHours(1.5);//duração de uma hora e meia, tambem e possivel fazre com segundos ou ticks
            DateTime t2 = DateTime.Now;
            TimeSpan exibir = t - t2;
            Console.WriteLine(exibir);
        }
    }
}
