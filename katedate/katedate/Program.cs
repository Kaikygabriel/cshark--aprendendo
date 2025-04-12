using System.Diagnostics;

namespace katedate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch tempo = new Stopwatch();
            tempo.Start();
            DateTime d = new DateTime(2020, 08, 16, 10, 10, 30, DateTimeKind.Local);//datetimekind indica que a data e local
            DateTime d2 = new DateTime(2020, 08, 16, 10, 10, 30, DateTimeKind.Utc);//indica que a data e global formato utc
            DateTime d3 = new DateTime(2020, 08, 16, 10, 10, 30);
            Console.WriteLine($"D1 {d} d1 kind {d.Kind} \nd1 local : {d.ToLocalTime()} \n d1 utc : {d.ToUniversalTime()}");
            Console.WriteLine($"D2 {d2} d2 kind {d2.Kind} \nd2 local : {d2.ToLocalTime()}\n d2 utc : {d2.ToUniversalTime()}");
            Console.WriteLine($"D3 {d3} d3 kind {d3.Kind} \nd3 local : {d3.ToLocalTime()} \nd3 utc : {d3.ToUniversalTime()}");
            tempo.Stop();
            Console.WriteLine(tempo);
        }
    }
}
