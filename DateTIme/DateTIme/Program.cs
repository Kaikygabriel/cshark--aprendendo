
using System.Diagnostics;
using System.Globalization;
using System.Runtime.Serialization;

namespace DateTIme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime i = new DateTime(2015, 03, 22, 10, 20, 00); 
            DateTime j = i.AddHours(2);//pode adicionar horas (São TimeSpan que são adicionados)
            //Console.WriteLine(i.Date);//pega apenas a data
            //Console.WriteLine(i.Day); //pega so o dia
            //Console.WriteLine(i.ToLongDateString());//imprime a data de uma menira mais completa
            //Console.WriteLine(i.ToLongTimeString());//imprime a hora de uma menira mais completa
            //Console.WriteLine(i.ToShortDateString());//resume a data
            //Console.WriteLine(i.ToShortTimeString());//resume a hora
            //string data = i.ToString("yyyy-MM-dd");//o ToString contem sobrecarga
            //Console.WriteLine(data);
            DateTime agora = new DateTime(2025,03,1);
            DateTime depois = new DateTime(2025, 03, 5);
            TimeSpan t = agora.Subtract(depois);//subtrai os periodo para saber o tempo entre eles
            imprimir();
        }
        static void imprimir()
        {
            
            Stopwatch tempo = new Stopwatch();
            tempo.Start();
           
            DateTime t2 = new();
            do
            {
                DateTime t = DateTime.Parse(tempo.ToString());
                if (t.Second != t2.Second)
                {
                    Console.WriteLine(t.Second);
                }
                t2 = t;
            } while (tempo.Elapsed.TotalSeconds <= 10);
                tempo.Stop();
        }
    }
}
