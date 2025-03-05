using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestandoAlogica
{
    internal class Program
    {
        static void Main()
        {
            
        }
        static void peça1()
        {
            Console.WriteLine("peça 1  numero");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("peça 1  quantidade");
            int quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine("peça 1  preço");
            float preco = float.Parse(Console.ReadLine());

            Console.WriteLine("peça 2  numero");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("peça 2  quantidade");
            int quantidade2 = int.Parse(Console.ReadLine());
            Console.WriteLine("peça 2  preço");
            float preco2 = float.Parse(Console.ReadLine());

            float total1 = quantidade * preco ;
            float total2 = quantidade2 * preco2;
            float resu = total1 + total2;
            Console.WriteLine(resu);
        }
        static void raio(float raio)
        {
            double pi = 3.14159;
            decimal area = ((decimal)raio * (decimal)raio)*(decimal)pi;
            Console.WriteLine(area);
        }
        static float Calcular(int id, int quantidade)
        {
            float resu = 0;
            switch (id) 
            {
                case 1:
                    resu = 4.00f * quantidade;
                    break;
                case 2:
                    resu = 4.50f * quantidade;
                    break;
                case 3:
                    resu = 5.00f * quantidade;
                    break;
            }
            return resu;
        }
    }
}
