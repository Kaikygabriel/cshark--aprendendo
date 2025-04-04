using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo
{
    internal class Triangulo
    {
        public double a;
        public double b;
        public double c;
        public float area;
        public Triangulo(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;

        }
        public void exibir()
        {
            double p = (a + b + c) / 2;
            double area1 = p * (p + a) * (p + b) * (p + c);
            area = (float)Math.Sqrt(area1);
            Console.WriteLine(area);
        }
        public static void VerMaior(Triangulo a, Triangulo b)
        {
            try
            {
                if (a.area > b.area)
                {
                    Console.WriteLine($"A Area do um {a.area} é maior");
                }
                else if (a.area < b.area)
                {
                    Console.WriteLine($"A Area do dois {b.area} é maior");

                }
                else
                {
                    Console.WriteLine("Empate");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR");

            }
        }
    }
}
