using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Area.Entity;
using Area.Entity.EnumProjeto;

namespace Area.Controler
{
    internal class Function
    {
        static List<Modelo> Modelos = new List<Modelo>();
        public static void Adicionar()
        {
            Console.WriteLine("Quantos modelos deseja acresentar");
            int numRepeticao = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numRepeticao; i++)
            {
                Console.WriteLine($"Objeto numero #{i}");
                Console.WriteLine("Retangulo ou circulo (R/C)");
                string escolha = Console.ReadLine().Trim();
                Console.WriteLine("Cor do objeto(Black/Blue/Red)");
                ColorM cor = Enum.Parse<ColorM>(Console.ReadLine().Trim());
                if (escolha.Equals("C", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Raio do circulo");
                    double raio = double.Parse(Console.ReadLine());
                    Modelos.Add(new Circulo(cor,raio));
                }
                else
                {
                    Console.WriteLine("Largura");
                    double largura = double.Parse(Console.ReadLine());
                    Console.WriteLine("Altura");
                    double altura = double.Parse(Console.ReadLine());
                    Modelos.Add(new Retangulo(cor,altura,largura)); 
                }
            }
        }
        public static void ListarArea()
        {
            foreach(Modelo m in Modelos)
            {
                Console.WriteLine(m.Area());
            }
        }
    }
}


