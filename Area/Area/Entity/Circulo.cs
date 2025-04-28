using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Area.Entity.EnumProjeto;

namespace Area.Entity
{
    internal sealed class Circulo : Modelo
    {
        public Circulo(ColorM cor, double raio) : base(cor)
        {
            Raio = raio;
        }
        public double Raio { get; private set; }
        public override double Area()
        {
            Console.WriteLine("Circulo");
            return Math.Pow(Raio,2)* 3.141;
        }
    }
}
