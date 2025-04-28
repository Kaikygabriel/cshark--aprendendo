using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Area.Entity.EnumProjeto;

namespace Area.Entity
{
    internal abstract class Modelo
    {
        public Modelo(ColorM cor)
        {
            Cor = cor;
        }

        public ColorM Cor { get;private protected set; }
        public abstract double Area();
    }
}
