using System.ComponentModel;
using System.Globalization;

namespace ConsoleApp43
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calcular(2,2,2,3,3,3);
        }
         private static void Calcular(int a, int b, int c, int a1,int b1,int c1)
        {
            float p = (a + b + c)/ 2;  
            double areas = p * (p - a) * (p - b) * (p - c);
            float p1 = (a1 + b1 + c1)/ 2;
            double area1s = p1*(p1 - a1) * (p1 - b1) * (p1 - c1);
            decimal area = (decimal)Math.Sqrt(areas);
            decimal area1 = (decimal)Math.Sqrt(area1s);
            Console.WriteLine($"Area = {area}");
            Console.WriteLine($"Area 2 = {area1}");
            if (area > area1)
            {
                Console.WriteLine($"A area do triangulo um e maior");

            }
            else if(area < area1) 
            {
                Console.WriteLine($"A area do triangulo dois e maior");
            }
        }
    }
}
