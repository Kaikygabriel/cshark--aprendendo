
using System.Diagnostics;
using System.Timers;

namespace Time
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TimeSpan a = TimeSpan.MaxValue;//pega a duração maxima possivel de se amarzenar no TimeSpan
            TimeSpan a2 = TimeSpan.MinValue;//pega a duração minima possivel do TimeSpan
            TimeSpan a3 = TimeSpan.Zero;//duração zero 
            TimeSpan b = new TimeSpan(2,03,10);
            Console.WriteLine(b.Hours);//b.Minutes , Seconds,Hours,Days => TotalHours ,TotalDays etc tem o numero quebrado (,)
            TimeSpan t = a.Add(a2);//soma o a eo a2
        }
    }
}
