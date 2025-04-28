using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Area.Entity.EnumProjeto;

namespace Area.Entity
{
    internal sealed class Retangulo : Modelo
    {

        public Retangulo(ColorM cor, double altura, double largura) : base(cor)
        {
            Altura = altura;
            Largura = largura;
        }
        public double Altura { get; private set; }
        public double Largura { get; private set; }
        public override double Area()
        {
            Console.WriteLine("Retangulo");
            return Altura * Largura;
        }
    }
}
